using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Sparrow_Stationary
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        HouseOfConnections des = new HouseOfConnections();
        string role = "";
        string query = "";
        SqlDataReader dr;
        SqlCommand cmd;
        //string state;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(165, Color.Black);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vallogin();
        }


        public void vallogin()
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text.ToString()))
            {

                MessageBox.Show("Please Input Your UserName", "UserName Required", 0, MessageBoxIcon.Information);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text.ToString()))
            {

                MessageBox.Show("Please Input Your Password", "Password Required", 0, MessageBoxIcon.Information);
                textBox2.Focus();
                return;
            }
            else
            {

                try
                {

                    des.opencon();
                    query = "SELECT * FROM SparrowUsers WHERE username = '" + textBox1.Text + "'and  passworduser ='" + textBox2.Text + "'  ";
                    cmd = new SqlCommand(query, des.returnCon());
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {

                        if (dr.Read())
                        {
                            //state = dr.GetValue(8).ToString();
                            role = dr.GetValue(2).ToString();
                            //string Date = dr.GetValue(4).ToString();

                            if (textBox1.Text == dr.GetValue(1).ToString() && role == "Admin" && textBox2.Text == dr.GetValue(3).ToString())
                            {
                                MessageBox.Show(" '" + textBox1.Text + "' Logged In Successfully", "Login Successful", 0, MessageBoxIcon.Information);
                                var main = new Form1();
                                main.Show();
                                main.label1.Text = textBox1.Text;
                                main.label2.Text = role;
                                // main.ShowInTaskbar = false;
                                main.FormBorderStyle = FormBorderStyle.FixedToolWindow;


                                this.Hide();
                            }
                            else if (textBox1.Text == dr.GetValue(1).ToString() && role == "Admin" && textBox2.Text == dr.GetValue(3).ToString())
                            {

                                MessageBox.Show(" '" + textBox1.Text + "' Logged In Successfully", "Login Successful", 0, MessageBoxIcon.Information);
                                var main = new Form1();
                                main.Show();
                                button1.Enabled = false;
                                button2.Enabled = false;
                                main.label1.Text = textBox1.Text;
                                main.label2.Text = role;
                                // main.ShowInTaskbar = false;
                                main.FormBorderStyle = FormBorderStyle.FixedToolWindow;


                                this.Hide();

                            }
                        }
                    }else
                    {
                        MessageBox.Show("Wrong Username Or Password","Failed To Login",0,MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("THE FOLLOWING ERROR OCCURED " + ex.Message);
                }
                finally
                {
                    des.closeCon();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure You Want To Exit This App ?", "Close Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }

        }
    }
}
