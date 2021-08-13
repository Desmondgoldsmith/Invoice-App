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
    public partial class USERS : Form
    {
        public USERS()
        {
            InitializeComponent();
        }
        HouseOfConnections des = new HouseOfConnections();
        private void button3_Click(object sender, EventArgs e)
        {
            des.opencon();
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text.ToString()))
                {
                    MessageBox.Show("Input The User Name", "ERROR", 0, MessageBoxIcon.Asterisk);
                    textBox1.Focus();
                    return;

                }
                if (string.IsNullOrWhiteSpace(comboBox1.Text.ToString()))
                {
                    MessageBox.Show("Select The User Role", "ERROR", 0, MessageBoxIcon.Asterisk);
                    comboBox1.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBox2.Text.ToString()))
                {
                    MessageBox.Show("Input The Password", "ERROR", 0, MessageBoxIcon.Asterisk);
                    textBox2.Focus();
                    return;
                }
                if (textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("Passwords Do Not Match", "ERROR", 0, MessageBoxIcon.Asterisk);
                    textBox3.Focus();
                    return;
                }
                else
                {

                    //checking if student already exist
                    SqlCommand chk = new SqlCommand("SELECT * FROM SparrowUsers WHERE username='" + textBox1.Text + "'", des.returnCon());
                    SqlDataReader dr = chk.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("USER WITH NAME '" + textBox1.Text + "' IS ALREADY REGISTERED", "NOTICE", 0, MessageBoxIcon.Exclamation);
                        des.closeCon();
                        return;
                    }
                    else
                    {
                        dr.Close();
                        //converting image to binay format
                        des.opencon();
                        SqlCommand cmd = new SqlCommand("Reguser_sp", des.returnCon()) { CommandType = CommandType.StoredProcedure };
                        cmd.Parameters.AddWithValue("@uname", textBox1.Text);
                        cmd.Parameters.AddWithValue("@urole", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@upass", textBox2.Text);

                        if (cmd.ExecuteNonQuery() == 1)
                        {

                            //      Clear();
                            MessageBox.Show("User Saved Successfully.", "Saved", 0, MessageBoxIcon.Information);
                            this.sparrowUsersTableAdapter.Fill(this.sparrowDBDataSet4.SparrowUsers);

                        }
                        else
                        {
                            MessageBox.Show("Error in Saving Data.", "Error", 0, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                des.closeCon();
            }
            }

        private void USERS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sparrowDBDataSet4.SparrowUsers' table. You can move, or remove it, as needed.
            this.sparrowUsersTableAdapter.Fill(this.sparrowDBDataSet4.SparrowUsers);

        }
    }
    }


