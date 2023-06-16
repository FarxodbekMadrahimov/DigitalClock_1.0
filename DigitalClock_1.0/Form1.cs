using System;
using System.Windows.Forms;

namespace DigitalClock_1._0
{
    public partial class Form1 : Form
    {
        bool formateAm_PM;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (formateAm_PM == true)
            { lbl24Time.Text = DateTime.Now.ToString("hh:mm"); }
            else
            {
                lbl24Time.Text = DateTime.Now.ToString("HH:mm");
            }

            lblsec.Text = DateTime.Now.ToString("ss");


        }

        private void lblsec_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }




    }
}
