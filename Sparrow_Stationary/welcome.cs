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

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            var opt = new Login();
            opt.Show();
            this.Hide();
        }

        private void welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
