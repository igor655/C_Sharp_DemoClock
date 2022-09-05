using System;

using System.Drawing;
using System.Drawing.Text;

using System.Windows.Forms;

namespace DemoClock
{
    

    public partial class MainForm : Form
    {
        char s = ':';

        PrivateFontCollection fontCollection = new PrivateFontCollection(); 
        public MainForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timeClock_Tick(object sender, EventArgs e)
        {
            //s = s == ':' ? ' ' : ':' ;
           
            labelClock.Text = DateTime.Now.ToString($"HH{s}mm{s}ss ");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            Show();
            
            

            LoginForm lf = new LoginForm();
            if(lf.ShowDialog() == DialogResult.OK && lf.CheckLogin())
            {
                fontCollection.AddFontFile("quartz.ttf");
                labelClock.Font = new Font(fontCollection.Families[0], 25);
                //timer1.Start();
            }
            else
            {
                this.Close();
            }





        }


    }
}
