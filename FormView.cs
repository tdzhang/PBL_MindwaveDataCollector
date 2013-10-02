using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThinkGearNET;
using System.Windows.Forms.DataVisualization.Charting;

namespace ThinkGearNETTest
{
    public partial class RealDataView : Form
    {
        public bool close = false;
        public RealDataView()
        {
            InitializeComponent();
        }

        //update new data into the form
        public void UpdateRealData(ThinkGearChangedEventArgs e)
        {
            Random rnd = new Random();
            // System.Console.WriteLine("1");
            if (chartReal.Series["Attention"].Points.Count > chartReal.ChartAreas["ChartAreaRealData"].AxisX.Maximum)
                chartReal.Series["Attention"].Points.RemoveAt(0);

            chartReal.Series["Attention"].Points.Add(Convert.ToInt32(e.ThinkGearState.Attention));
            //System.Console.WriteLine(e.ThinkGearState.Attention);

            

            if (chartReal.Series["Meditation"].Points.Count > chartReal.ChartAreas["ChartAreaRealData"].AxisX.Maximum)
                chartReal.Series["Meditation"].Points.RemoveAt(0);
            chartReal.Series["Meditation"].Points.Add(Convert.ToInt32(e.ThinkGearState.Meditation));
            //System.Console.WriteLine(e.ThinkGearState.Meditation);

            CalculateUserState(chartReal.Series["Attention"].Points, chartReal.Series["Meditation"].Points);
        }

        //using the data to calculate the state of users
        private void CalculateUserState(DataPointCollection attention, DataPointCollection meditation)
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
            flag_attention=new bool[50];
            flag_meditation=new bool[50];

            for (int i = 0; i < length; i++)
            {
                //MessageBox.Show(length.ToString());
                //Console.WriteLine(length.ToString());
                num_attention[i]=attention[i].YValues[0];
                num_meditation[i] = meditation[i].YValues[0];
                med_m_att[i]=num_meditation[i]-num_attention[i];
            }

            for (int i = 0; i < length-1; i++)
            {
                dif_attention[i]=num_attention[i+1]-num_attention[i];
                dif_meditation[i] =num_meditation[i+1]-num_meditation[i] ;
            }

            for (int i = 0; i < length-1; i++)
            {
                flag_attention[i] = dif_attention[i] > 0;
                flag_meditation[i] = dif_meditation[i] > 0;
            }

            //find the relax level
            double relax_level = 0;
            double avg_relax = 0;
            for (int i = length-8; i < length; i++)
            {
                relax_level+=med_m_att[i];
                avg_relax += num_meditation[i];
            }
            relax_level = relax_level / 8;
            avg_relax = avg_relax / 8;

            if (relax_level > 40 && avg_relax>50)
            {
                btnRelax.Text = "Total Relaxed";
                btnRelax.BackColor = Color.Red;
            }
            else if (relax_level > 25 && avg_relax>40)
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
            for (int i = length-10; i < length; i++)
            {
                productivity += (num_attention[i] * num_meditation[i]);
                prod_med_m_att += med_m_att[i];
            }
            productivity=productivity/10;
            prod_med_m_att = prod_med_m_att / 10;
            //Console.WriteLine(productivity.ToString());
            if (productivity > 2500 && prod_med_m_att<40)
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

        private void FormView_FormClosing(object sender, FormClosingEventArgs e)
        {
            close = true;
        }

        private void FormView_Load(object sender, EventArgs e)
        {
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

            chartReal.ChartAreas["ChartAreaRealData"].AxisX.CustomLabels.Clear();
            chartReal.ChartAreas["ChartAreaRealData"].AxisX.CustomLabels.Add(label1);
            chartReal.ChartAreas["ChartAreaRealData"].AxisX.CustomLabels.Add(label2);
            chartReal.ChartAreas["ChartAreaRealData"].AxisX.CustomLabels.Add(label3);

            //add the 0 data
            for (int i = 0; i < chartReal.ChartAreas["ChartAreaRealData"].AxisX.Maximum; i++)
            {
                if (chartReal.Series["Attention"].Points.Count > chartReal.ChartAreas["ChartAreaRealData"].AxisX.Maximum)
                    chartReal.Series["Attention"].Points.RemoveAt(0);
                chartReal.Series["Attention"].Points.Add(0);
                if (chartReal.Series["Meditation"].Points.Count > chartReal.ChartAreas["ChartAreaRealData"].AxisX.Maximum)
                    chartReal.Series["Meditation"].Points.RemoveAt(0);
                chartReal.Series["Meditation"].Points.Add(0);
            }
               
        }
    }
}
