
using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sparrow_Stationary
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }
        int valuex = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar1_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuProgressBar.ProgressChangedEventArgs e)
        {
            
        }

        private void bunifuCircleProgress1_ProgressChanged(object sender, BunifuCircleProgress.ProgressChangedEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            valuex += 1;
            bunifuCircleProgress1.Value = valuex;
            if (bunifuCircleProgress1.Value == 100)
            {
                //bunifuCircleProgress1.Value = 0;
                timer1.Stop();
                var opt = new Login();
                opt.Show();
                this.Hide();
            }


            //timer1.Stop();

            

        }
    }
}
