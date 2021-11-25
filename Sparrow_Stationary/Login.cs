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
           
        }

        //function that handles login
        public void vallogin()
        {
            //Validating textboxes
            if (string.IsNullOrWhiteSpace(bunifuTextBox1.Text.ToString()))
            {

                MessageBox.Show("Please Input Your UserName", "UserName Required", 0, MessageBoxIcon.Information);
                bunifuTextBox1.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(bunifuTextBox2.Text.ToString()))
            {

                MessageBox.Show("Please Input Your Password", "Password Required", 0, MessageBoxIcon.Information);
                bunifuTextBox2.Focus();
                return;
            }
            else
            {

                try
                {
                    //selecting from the table and comparing values in textboxes to values in table
                    des.opencon();
                    query = "SELECT * FROM SparrowUsers WHERE username = '" + bunifuTextBox1.Text + "'and  passworduser ='" + bunifuTextBox2.Text + "'  ";
                    cmd = new SqlCommand(query, des.returnCon());
                    dr = cmd.ExecuteReader();
                    //if a row in the table exist with same values in texbox,
                    if (dr.HasRows == true)
                    {

                        if (dr.Read())
                        {
                            //state = dr.GetValue(8).ToString();
                            //assigning values of the role column to a variable name role
                            role = dr.GetValue(2).ToString();
                            //string Date = dr.GetValue(4).ToString();
                            //if role is equal to admin and the password is equal to the password in the textbox, 
                            if (bunifuTextBox1.Text == dr.GetValue(1).ToString() && role == "Admin" && bunifuTextBox2.Text == dr.GetValue(3).ToString())
                            {
                                MessageBox.Show(" '" + bunifuTextBox2.Text + "' Logged In Successfully", "Login Successful", 0, MessageBoxIcon.Information);
                                var main = new Form1();
                                main.Show();
                                main.label1.Text = bunifuTextBox1.Text;
                                main.label2.Text = role;
                                // main.ShowInTaskbar = false;
                                main.FormBorderStyle = FormBorderStyle.FixedToolWindow;


                                this.Hide();
                            }
                            else if (bunifuTextBox1.Text == dr.GetValue(1).ToString() && role == "Admin" && bunifuTextBox2.Text == dr.GetValue(3).ToString())
                            {

                                MessageBox.Show(" '" + bunifuTextBox2.Text + "' Logged In Successfully", "Login Successful", 0, MessageBoxIcon.Information);
                                var main = new Form1();
                                main.Show();
                                 //bunifuButton1.Enabled = false;
                                //button2.Enabled = false;
                                main.label1.Text = bunifuTextBox1.Text;
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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            vallogin();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            vallogin();
        }
    }
}
