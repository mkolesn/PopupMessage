using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopupMessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();
            int delay = 6000;
            string message = "Pass Delay in Milliseconds and Message Text in command-line arguments";

            if (args.Length >= 3)
            {
                try
                {
                    delay = int.Parse(args[1]);
                }
                catch (Exception)
                {
                }
                message = args[2];
            }

            label1.Text = message;
            timer1.Interval = delay;
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
