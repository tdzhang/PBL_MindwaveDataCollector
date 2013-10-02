using System;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using ThinkGearNET;

namespace ThinkGearNETTest
{
	public partial class FormMain : Form
	{
        //add a a new form
        private RealDataView formViewData = new RealDataView();
        private bool formViewDataVisible = false;
        //add a new form to view history data
        private HistoryDataForm formViewHistoryData = new HistoryDataForm();
        //the thinkGearWrapper private varible
		private ThinkGearWrapper _thinkGearWrapper = new ThinkGearWrapper();
        
        //whent the record Flag is true, the start recording
        private bool recordFlag = false;
        private StreamWriter _StreamWriter;
		
        public FormMain()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            //search over all the available port number
			foreach(string port in SerialPort.GetPortNames())
				cboPort.Items.Add(port);
            //choose the first one port as default port
			cboPort.SelectedIndex = 0;
            cboRate.SelectedIndex = 0;

            //show the real-data form
            formViewData.Show();
            formViewData.Visible = true;
            formViewDataVisible = true;
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			_thinkGearWrapper = new ThinkGearWrapper();

			// setup the event
			_thinkGearWrapper.ThinkGearChanged += _thinkGearWrapper_ThinkGearChanged;

			// connect to the device on the specified COM port at 57600 baud
            if (!_thinkGearWrapper.Connect(cboPort.SelectedItem.ToString(), Convert.ToInt32(cboRate.SelectedItem), true))
				MessageBox.Show("Could not connect to headset.");
            
            //enable the blink detection
            _thinkGearWrapper.EnableBlinkDetection(true);
            
		}

        private string checkingDuplicateString1 = "";
        private string checkingDuplicateString2 = "";
		void _thinkGearWrapper_ThinkGearChanged(object sender, ThinkGearChangedEventArgs e)
		{
            
			// update the textbox and sleep for a tiny bit
			BeginInvoke(new MethodInvoker(delegate 
				{
					lblAttention.Text = "Attention: " + e.ThinkGearState.Attention;
					lblMeditation.Text = "Meditation: " + e.ThinkGearState.Meditation;
					txtState.Text = e.ThinkGearState.ToString();
				}));

            //output the data of the nuerosky
            string s="";
            checkingDuplicateString2 = "";
            DateTime now=DateTime.Now;
            s += now.Year.ToString() + "/";
            s += now.Month.ToString() + "/";
            s += now.Day.ToString() + " ";
            s += now.Hour.ToString() + ":";
            s += now.Minute.ToString() + ":";
            s += now.Second.ToString() + ".";
            s += now.Millisecond.ToString() + " ";
            s += e.ThinkGearState.Error + " ";
            s += e.ThinkGearState.PacketsRead + " ";
            s += e.ThinkGearState.Battery + " ";
            s += e.ThinkGearState.PoorSignal + " ";
            s += e.ThinkGearState.Attention + " ";
            checkingDuplicateString2 += e.ThinkGearState.Attention + " ";
            s += e.ThinkGearState.Meditation + " ";
            checkingDuplicateString2 += e.ThinkGearState.Attention + " ";
            s += e.ThinkGearState.Raw + " ";
            s += e.ThinkGearState.Delta + " ";
            checkingDuplicateString2 += e.ThinkGearState.Delta + " ";
            s += e.ThinkGearState.Theta + " ";
            checkingDuplicateString2 += e.ThinkGearState.Theta + " ";
            s += e.ThinkGearState.Alpha1 + " ";
            s += e.ThinkGearState.Alpha2 + " ";
            s += e.ThinkGearState.Beta1 + " ";
            s += e.ThinkGearState.Beta2 + " ";
            s += e.ThinkGearState.Gamma1 + " ";
            s += e.ThinkGearState.Gamma2 + " ";
            s += e.ThinkGearState.BlinkStrength + " ";

            
            //System.Console.WriteLine(e.ThinkGearState.ToString());

            //see if the data is redundent
            if (checkingDuplicateString1 == checkingDuplicateString2)
            {
                Console.WriteLine("A data duplicate occured");
            }
            else 
            {
                //record data
                if (recordFlag)
                {
                    _StreamWriter.WriteLine(s);
                    _StreamWriter.Flush();
                }
                //use a new UI thread to update the real-time image showing
                if (formViewDataVisible)
                {
                    this.BeginInvoke((MethodInvoker)delegate() { formViewData.UpdateRealData(e); });
                }
            }
            //update the checking duplicate string 
            checkingDuplicateString1 = checkingDuplicateString2;
			Thread.Sleep(100);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			_thinkGearWrapper.Disconnect();
            if (recordFlag)
            {
                _StreamWriter.Close();
                recordFlag = false;
            }
            //closeing the View Data Form
            formViewData.Close();
           
		}

		private void btnDisconnect_Click(object sender, EventArgs e)
		{
			_thinkGearWrapper.Disconnect();
		}

		private void btnEnableBlink_Click(object sender, EventArgs e)
		{
			_thinkGearWrapper.EnableBlinkDetection(true);
		}

		private void btnDisableBlink_Click(object sender, EventArgs e)
		{
			_thinkGearWrapper.EnableBlinkDetection(false);
		}

        private void btnRecord_Click(object sender, EventArgs e)
        {
           
            saveFileDialog.Filter = "TEXT FILES|*.txt";
            saveFileDialog.Title = "Save to file";
            saveFileDialog.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog.FileName != "")
            {
                //start recording
                _StreamWriter = File.CreateText(saveFileDialog.FileName);
                recordFlag = true;
            }
            else
            {
                MessageBox.Show("The file name is null, try again.");
            }

        }

        private void btnStopRecord_Click(object sender, EventArgs e)
        {
            if (recordFlag)
            {
                _StreamWriter.Close();
                recordFlag = false;
            }
            else
            {
                MessageBox.Show("You havn't start a recording yet!");
            }
            
        }

        private void readTimeDataViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Checked)
            {
                //show the real-data form
                formViewData.Visible = true;
                formViewDataVisible = true;
            }
            else
            {
                //show the real-data form
                //formViewData.Close();
                formViewData.Visible = false;
                formViewDataVisible = false;
            }
        }

        //deal with the check state change of History data viewer
        private void historyDataVierwerToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Checked)
            {
                formViewHistoryData.Visible = true;
            }
            else
            {
                formViewHistoryData.Visible = false;
            }
        }
	}
}
