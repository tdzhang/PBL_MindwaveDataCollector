using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;



namespace ThinkGearNETTest
{




    public partial class HistoryDataForm : Form
    {
        private HistoryDataReader dataReader = new HistoryDataReader();
        private HistoryDataReader dataReader2 = new HistoryDataReader();
        private HistoryDataReader dataReader3 = new HistoryDataReader();

        public HistoryDataForm()
        {
            InitializeComponent();
        }

        private void ChangOneChartToRealSimulate(Chart chartHistory)
        { 
            //set the range of the chart for the real time style.
            chartHistory.ChartAreas["ChartAreaRealData"].AxisX.Maximum = 30;
            chartHistory.ChartAreas["ChartAreaRealData"].AxisX.Minimum = 0;
             //customized the label of x axis
            CustomLabel label1 = new CustomLabel();
            label1.FromPosition = 28.0;
            label1.ToPosition = 32.0;
            label1.Text = "Now";
            label1.RowIndex = 0;
            CustomLabel label2 = new CustomLabel();
            label2.FromPosition = 11.0;
            label2.ToPosition = 19.0;
            label2.Text = "15s ago";
            label2.RowIndex = 0;
            CustomLabel label3 = new CustomLabel();
            label3.FromPosition = -4.0;
            label3.ToPosition = 4.0;
            label3.Text = "30s ago";
            label3.RowIndex = 0;

            chartHistory.ChartAreas["ChartAreaRealData"].AxisX.CustomLabels.Clear();
            chartHistory.ChartAreas["ChartAreaRealData"].AxisX.CustomLabels.Add(label1);
            chartHistory.ChartAreas["ChartAreaRealData"].AxisX.CustomLabels.Add(label2);
            chartHistory.ChartAreas["ChartAreaRealData"].AxisX.CustomLabels.Add(label3);

            //add the 0 data
            for (int i = 0; i < chartHistory.ChartAreas["ChartAreaRealData"].AxisX.Maximum; i++)
            {
                if (chartHistory.Series["Attention"].Points.Count > chartHistory.ChartAreas["ChartAreaRealData"].AxisX.Maximum)
                    chartHistory.Series["Attention"].Points.RemoveAt(0);
                chartHistory.Series["Attention"].Points.Add(0);
                if (chartHistory.Series["Meditation"].Points.Count > chartHistory.ChartAreas["ChartAreaRealData"].AxisX.Maximum)
                    chartHistory.Series["Meditation"].Points.RemoveAt(0);
                chartHistory.Series["Meditation"].Points.Add(0);
            }
        }

        //change the chart appearance into real-time style
        private void ChangeToRealSimulate()
        {
            ChangOneChartToRealSimulate(chartHistory1);
            ChangOneChartToRealSimulate(chartHistory2);
            ChangOneChartToRealSimulate(chartHistory3);
        }

        private void ChangOneChartToStaticSimulate(Chart chartHistory)
        {
            //set the range of the chart for the real time style.
            chartHistory.ChartAreas["ChartAreaRealData"].AxisX.Maximum = dataReader.length;
            chartHistory.ChartAreas["ChartAreaRealData"].AxisX.Minimum = 0;
            //customized the label of x axis
            CustomLabel label1 = new CustomLabel();
            label1.FromPosition = dataReader.length - dataReader.length / 15;
            label1.ToPosition = dataReader.length + dataReader.length / 15;
            label1.Text = "Last";
            label1.RowIndex = 0;
            CustomLabel label2 = new CustomLabel();
            label2.FromPosition = dataReader.length / 2 - dataReader.length / 15;
            label2.ToPosition = dataReader.length / 2 + dataReader.length / 15;
            label2.Text = "Middle";
            label2.RowIndex = 0;
            CustomLabel label3 = new CustomLabel();
            label3.FromPosition = -dataReader.length / 15;
            label3.ToPosition = dataReader.length / 15;
            label3.Text = "Begin";
            label3.RowIndex = 0;

            chartHistory.ChartAreas["ChartAreaRealData"].AxisX.CustomLabels.Clear();
            chartHistory.ChartAreas["ChartAreaRealData"].AxisX.CustomLabels.Add(label1);
            chartHistory.ChartAreas["ChartAreaRealData"].AxisX.CustomLabels.Add(label2);
            chartHistory.ChartAreas["ChartAreaRealData"].AxisX.CustomLabels.Add(label3);

            //add the 0 data
            for (int i = 0; i < dataReader.length; i++)
            {
                if (chartHistory.Series["Attention"].Points.Count > chartHistory.ChartAreas["ChartAreaRealData"].AxisX.Maximum)
                    chartHistory.Series["Attention"].Points.RemoveAt(0);
                chartHistory.Series["Attention"].Points.Add(dataReader.intention[i]);
                if (chartHistory.Series["Meditation"].Points.Count > chartHistory.ChartAreas["ChartAreaRealData"].AxisX.Maximum)
                    chartHistory.Series["Meditation"].Points.RemoveAt(0);
                chartHistory.Series["Meditation"].Points.Add(dataReader.meditation[i]);
            }
        }
        //change the chart appearance into static style
        private void ChangeToStaticSimulate()
        {
            ChangOneChartToStaticSimulate(chartHistory1);
            ChangOneChartToStaticSimulate(chartHistory2);
            ChangOneChartToStaticSimulate(chartHistory3);
        }


        private void upDateOneChartStaticSimulate(Chart chartHistory, HistoryDataReader dataReader)
        {
            //calculate the range od the array.
            double low_index = (dataReader.PageIndex > 0) ? dataReader.PageIndex - 0.5 : 0;
            int low = 0;
            int high = 0;
            low = (int)(low_index * dataReader.interval);
            high = low + dataReader.interval;
            if (high > dataReader.length)
            {
                high = dataReader.length;
            }

            //set the range of the chart for the real time style.
            chartHistory.ChartAreas["ChartAreaRealData"].AxisX.Maximum = (high - low);
            chartHistory.ChartAreas["ChartAreaRealData"].AxisX.Minimum = 0;

            //customized the label of x axis
            CustomLabel label1 = new CustomLabel();
            label1.FromPosition = (high - low) - (high - low) / 15;
            label1.ToPosition = (high - low) + (high - low) / 15;
            label1.Text = high.ToString();
            label1.RowIndex = 0;
            CustomLabel label2 = new CustomLabel();
            label2.FromPosition = (high - low) / 2 - (high - low) / 15;
            label2.ToPosition = (high - low) / 2 + (high - low) / 15;
            label2.Text = "Middle";
            label2.RowIndex = 0;
            CustomLabel label3 = new CustomLabel();
            label3.FromPosition = -(high - low) / 15;
            label3.ToPosition = (high - low) / 15;
            label3.Text = low.ToString();
            label3.RowIndex = 0;

            chartHistory.ChartAreas["ChartAreaRealData"].AxisX.CustomLabels.Clear();
            chartHistory.ChartAreas["ChartAreaRealData"].AxisX.CustomLabels.Add(label1);
            chartHistory.ChartAreas["ChartAreaRealData"].AxisX.CustomLabels.Add(label2);
            chartHistory.ChartAreas["ChartAreaRealData"].AxisX.CustomLabels.Add(label3);

            //add the 0 data
            for (int i = low; i < high; i++)
            {
                if (chartHistory.Series["Attention"].Points.Count > chartHistory.ChartAreas["ChartAreaRealData"].AxisX.Maximum)
                    chartHistory.Series["Attention"].Points.RemoveAt(0);
                chartHistory.Series["Attention"].Points.Add(dataReader.intention[i]);
                if (chartHistory.Series["Meditation"].Points.Count > chartHistory.ChartAreas["ChartAreaRealData"].AxisX.Maximum)
                    chartHistory.Series["Meditation"].Points.RemoveAt(0);
                chartHistory.Series["Meditation"].Points.Add(dataReader.meditation[i]);
            }
        }
        //change the chart appearance into static style
        private void upDateStaticSimulate()
        {
            upDateOneChartStaticSimulate(chartHistory1, dataReader);
            upDateOneChartStaticSimulate(chartHistory2, dataReader2);
            upDateOneChartStaticSimulate(chartHistory3, dataReader3);
        }

        private void btnRealTime_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "TEXT FILES|*.txt";
            openFileDialog1.Title = "Choose Data File";
            openFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (openFileDialog1.FileName != "")
            {
                dataReader.fileName = openFileDialog1.FileName;
                if (dataReader.OpenDataFile())
                {
                    ChangeToRealSimulate();
                    //timer1.Enabled=true;
                    ((Button)sender).BackColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("File open error, try again.");
                }
            }
            else
            {
                MessageBox.Show("File open error, try again.");
            }
        }

        //using the data to calculate the state of users
        private void CalculateUserState(DataPointCollection attention, DataPointCollection meditation, Chart chartReal, Button btnRelax, Button btnEngagement, Button btnProductivity)
        {
            int length = attention.Count;
            int Max = Convert.ToInt32(chartReal.ChartAreas["ChartAreaRealData"].AxisX.Maximum);

            double[] num_attention;
            double[] num_meditation;
            double[] med_m_att;
            num_attention = new double[50];
            num_meditation = new double[50];
            med_m_att = new double[50];

            double[] dif_attention;
            double[] dif_meditation;
            dif_attention = new double[50];
            dif_meditation = new double[50];

            bool[] flag_attention;
            bool[] flag_meditation;
            flag_attention = new bool[50];
            flag_meditation = new bool[50];

            for (int i = 0; i < length; i++)
            {
                //MessageBox.Show(length.ToString());
                //Console.WriteLine(length.ToString());
                num_attention[i] = attention[i].YValues[0];
                num_meditation[i] = meditation[i].YValues[0];
                med_m_att[i] = num_meditation[i] - num_attention[i];
            }

            for (int i = 0; i < length - 1; i++)
            {
                dif_attention[i] = num_attention[i + 1] - num_attention[i];
                dif_meditation[i] = num_meditation[i + 1] - num_meditation[i];
            }

            for (int i = 0; i < length - 1; i++)
            {
                flag_attention[i] = dif_attention[i] > 0;
                flag_meditation[i] = dif_meditation[i] > 0;
            }

            //find the relax level
            double relax_level = 0;
            double avg_relax = 0;
            for (int i = length - 8; i < length; i++)
            {
                relax_level += med_m_att[i];
                avg_relax += num_meditation[i];
            }
            relax_level = relax_level / 8;
            avg_relax = avg_relax / 8;

            if (relax_level > 40 && avg_relax > 50)
            {
                btnRelax.Text = "Total Relaxed";
                btnRelax.BackColor = Color.Red;
            }
            else if (relax_level > 25 && avg_relax > 40)
            {
                btnRelax.Text = "Relaxed";
                btnRelax.BackColor = Color.Purple;
            }
            else if (relax_level > 10 && avg_relax > 30)
            {
                btnRelax.Text = "Little Relaxed";
                btnRelax.BackColor = Color.Yellow;
            }
            else if (relax_level > -20)
            {
                btnRelax.Text = "Normal";
                btnRelax.BackColor = Color.Green;
            }
            else if (relax_level > -40)
            {
                btnRelax.Text = "Tired";
                btnRelax.BackColor = Color.Blue;
            }
            //synchronize level
            int agree_num = 0;
            for (int i = 0; i < length; i++)
            {
                if (flag_attention[i] == flag_meditation[i])
                {
                    agree_num++;
                }
            }
            Console.WriteLine(agree_num.ToString());
            if (agree_num > 21)
            {
                btnEngagement.Text = "Total Focused";
                btnEngagement.BackColor = Color.Green;
            }
            else if (agree_num > 16)
            {
                btnEngagement.Text = "Focused";
                btnEngagement.BackColor = Color.Yellow;
            }
            else if (agree_num > 10)
            {
                btnEngagement.Text = "Little Distracted";
                btnEngagement.BackColor = Color.Purple;
            }
            else if (agree_num > 0)
            {
                btnEngagement.Text = "Distracted";
                btnEngagement.BackColor = Color.Red;
            }
            //productivity level
            double productivity = 0;
            double prod_med_m_att = 0;
            for (int i = length - 10; i < length; i++)
            {
                productivity += (num_attention[i] * num_meditation[i]);
                prod_med_m_att += med_m_att[i];
            }
            productivity = productivity / 10;
            prod_med_m_att = prod_med_m_att / 10;
            //Console.WriteLine(productivity.ToString());
            if (productivity > 2500 && prod_med_m_att < 40)
            {
                btnProductivity.Text = "High";
                btnProductivity.BackColor = Color.Green;
            }
            else if (productivity > 1400 && prod_med_m_att < 40)
            {
                btnProductivity.Text = "Medium";
                btnProductivity.BackColor = Color.Yellow;
            }
            else if (productivity > 800)
            {
                btnProductivity.Text = "Low";
                btnProductivity.BackColor = Color.Purple;
            }
            else if (productivity > 0)
            {
                btnProductivity.Text = "Extrmely Low";
                btnProductivity.BackColor = Color.Red;
            }
        }
        private void timer1_Tick_OneChart(Chart chartHistory, HistoryDataReader dataReader,Label label,int ButtonIndex)
        {
            string line;
            if ((line = dataReader.sReader.ReadLine()) != null)
            {
                //using label to show the orginal data
                label.Text = line;
                string[] words = line.Split(' ');
                // System.Console.WriteLine("1");
                if (chartHistory.Series["Attention"].Points.Count > chartHistory.ChartAreas["ChartAreaRealData"].AxisX.Maximum)
                    chartHistory.Series["Attention"].Points.RemoveAt(0);

                chartHistory.Series["Attention"].Points.Add(Convert.ToInt32(words[6]));
                //System.Console.WriteLine(e.ThinkGearState.Attention);

                if (chartHistory.Series["Meditation"].Points.Count > chartHistory.ChartAreas["ChartAreaRealData"].AxisX.Maximum)
                    chartHistory.Series["Meditation"].Points.RemoveAt(0);
                chartHistory.Series["Meditation"].Points.Add(Convert.ToInt32(words[7]));
                //System.Console.WriteLine(e.ThinkGearState.Meditation);
                switch (ButtonIndex)
	            {
                    case 1: CalculateUserState(chartHistory.Series["Attention"].Points, chartHistory.Series["Meditation"].Points, chartHistory, btnRelax1, btnEngagement1, btnProductivity1);
                        break;
                    case 2: CalculateUserState(chartHistory.Series["Attention"].Points, chartHistory.Series["Meditation"].Points, chartHistory, btnRelax2, btnEngagement2, btnProductivity2);
                        break;
                    case 3: CalculateUserState(chartHistory.Series["Attention"].Points, chartHistory.Series["Meditation"].Points, chartHistory, btnRelax3, btnEngagement3, btnProductivity3);
                        break;
		            default:
                        break;
	            }
                
            }
            else
            {
                label.Text = "Unchanged";
                timer1.Enabled = false;
            }
        }
        //real-time simulate
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1_Tick_OneChart(chartHistory1, dataReader, label1,1);
            if (dataReader2.opened)
	        {
		         timer1_Tick_OneChart(chartHistory2, dataReader2, label2,2);
	        }
            if (dataReader3.opened)
	        {
		         timer1_Tick_OneChart(chartHistory3, dataReader3, label3,3);
	        }
            
        }

        //clean up before the form close
        private void HistoryDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
            }
            if (dataReader.sReader!=null)
            {
                dataReader.CloseDataFile();
            }
            if (dataReader2.sReader != null)
            {
                dataReader2.CloseDataFile();
            }
            if (dataReader3.sReader != null)
            {
                dataReader3.CloseDataFile();
            }
        }

        private void butPauseResume_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        //change the regenerate rate
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //change the time into the timer's interval
            string Str = textBox1.Text.Trim();
            int Num;
            bool isNum = int.TryParse(Str, out Num);
            if (isNum)
                timer1.Interval = Num;
            else
                MessageBox.Show("Invalid number, that shoule be a int number");
        }

        //************************************************************************>>>>>>>>>
        private void btnStaticData_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "TEXT FILES|*.txt";
            openFileDialog1.Title = "Choose Data File";
            openFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (openFileDialog1.FileName != "")
            {
                dataReader.fileName = openFileDialog1.FileName;
                if (dataReader.OpenDataFile())
                {
                    dataReader.extractWholeData();
                    ChangeToStaticSimulate();
                    label1.Text = "Total Line:" + dataReader.length.ToString();
                    timer1.Enabled = false;
                    textBox2.Text = dataReader.interval.ToString();
                }
                else
                {
                    MessageBox.Show("File open error, try again.");
                }
            }
            else
            {
                MessageBox.Show("File open error, try again.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //change the time into the timer's interval
            string Str = textBox2.Text.Trim();
            int Num;
            bool isNum = int.TryParse(Str, out Num);
            if (isNum)
            {
                if (Num>dataReader.length)
                {
                    MessageBox.Show("Interval is too big.");
                }
                else
                {
                    dataReader.interval = Num;
                    dataReader.PageIndex = 0;
                    upDateStaticSimulate();
                }
            }
            else
                MessageBox.Show("Invalid number, that shoule be a int number");
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (dataReader.length>0)
            {
                int i = dataReader.PageIndex;
                if (i>0)
                {
                    i--;
                    dataReader.PageIndex = i;
                    upDateStaticSimulate();
                }
            }
        }

        private void bntRight_Click(object sender, EventArgs e)
        {
            if (dataReader.length > 0)
            {
                int i = dataReader.PageIndex;
                i++;
                int indexT = (int)(dataReader.PageIndex - 0.5);
                if (indexT*dataReader.interval<dataReader.length)
	            {
                    dataReader.PageIndex = i;
                    upDateStaticSimulate();
	            }
            }
        }
        //************************************************************************<<<<<<<<<


        //add the second data reader
        private void btnRealTime2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "TEXT FILES|*.txt";
            openFileDialog1.Title = "Choose Data File";
            openFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (openFileDialog1.FileName != "")
            {
                dataReader2.fileName = openFileDialog1.FileName;
                if (dataReader2.OpenDataFile())
                {
                    ChangeToRealSimulate();
                    ((Button)sender).BackColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("File open error, try again.");
                }
            }
            else
            {
                MessageBox.Show("File open error, try again.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataReader.opened)
            timer1.Enabled = true;
        }

        private void btnRealTime3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "TEXT FILES|*.txt";
            openFileDialog1.Title = "Choose Data File";
            openFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (openFileDialog1.FileName != "")
            {
                dataReader3.fileName = openFileDialog1.FileName;
                if (dataReader3.OpenDataFile())
                {
                    ChangeToRealSimulate();
                    ((Button)sender).BackColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("File open error, try again.");
                }
            }
            else
            {
                MessageBox.Show("File open error, try again.");
            }
        }

    }

    public class HistoryDataReader
    {
        public string fileName;
        public StreamReader sReader;
        public int[] intention;
        public int[] meditation;
        public int length = 0;
        public int PageIndex = 0;
        public int interval = 0;
        public bool opened=false;

        public bool OpenDataFile()
        {
            //if alread opened a file, close it first
            if (opened)
            {
                CloseDataFile();
            }

            sReader= new StreamReader(fileName,Encoding.Default);
            opened = (sReader != null);
            return (sReader!=null);
        }

        public void extractWholeData()
        {
            intention = new int[50000];
            meditation = new int[50000];
            length=0;
            string line;
            int i=0;
            while ((line = sReader.ReadLine()) != null)
            {
                string[] words = line.Split(' ');
                // System.Console.WriteLine("1");
                intention[i]=Convert.ToInt32(words[6]);
                meditation[i]=Convert.ToInt32(words[7]);
                i++;
                length++;
                if (length > 49990)
                {
                    break;
                    MessageBox.Show("The dataset is too big, need to adjust the Constant.");
                }
            }
            interval = length;
      
        }

        public void CloseDataFile()
        {
            sReader.Close();
            opened = false;
        }
    }

}
