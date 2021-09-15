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
    public partial class ProformaMain : Form
    {
        public ProformaMain()
        {
            InitializeComponent();
        }

        HouseOfConnections dessy = new HouseOfConnections();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, Color.Black);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    MessageBox.Show("Input Product Description", "Warning", 0, MessageBoxIcon.Error);
                    textBox5.Focus();
                    return;
                }
                else if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    MessageBox.Show("Input Quantity", "Warning", 0, MessageBoxIcon.Error);
                    textBox6.Focus();
                    return;
                }
                else if (string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    MessageBox.Show("Input Unit Price", "Warning", 0, MessageBoxIcon.Error);
                    textBox7.Focus();
                    return;
                }
                else if (string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    MessageBox.Show("Input Total Price", "Warning", 0, MessageBoxIcon.Error);
                    textBox8.Focus();
                    return;
                }
                else
                {

                    string prod_description = textBox5.Text;
                    string qty = textBox6.Text;
                    string u_price = textBox7.Text;
                    string t_price = textBox8.Text;
                    string[] row = { prod_description, qty, u_price, t_price };
                    dataGridView1.Rows.Add(row);
                    //clear record
                    ClearRecord();
                    //calculating the sum of total prices
                    int sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    }
                    label15.Text = sum.ToString();
                    textBox9.Text = sum.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ClearRecord();
            dataGridView1.Rows.Clear();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            dessy.opencon();
            //SqlCommand cmd = new SqlCommand("insertInvoice_sp", dessy.returnCon()) { CommandType = CommandType.StoredProcedure };
            //cmd.Parameters.AddWithValue("@cname", textBox2.Text);
            //cmd.Parameters.AddWithValue("@cemail", textBox3.Text);
            //cmd.Parameters.AddWithValue("@cadd", textBox4.Text);
            //cmd.Parameters.AddWithValue("@proddesc", textBox5.Text);
            //cmd.Parameters.AddWithValue("@prodqty", textBox6.Text);
            //cmd.Parameters.AddWithValue("@prodprice", textBox7.Text);
            //cmd.Parameters.AddWithValue("@totprice", textBox8.Text);
            //cmd.Parameters.AddWithValue("@invid", textBox1.Text);
            //cmd.Parameters.AddWithValue("@invdate", textBox2.Text);
            //cmd.Parameters.AddWithValue("@duedate", textBox3.Text);


            //string StrQuery;
            try
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Input Customer Name", "Warning", 0, MessageBoxIcon.Error);
                    textBox2.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Input Customer Email", "Warning", 0, MessageBoxIcon.Error);
                    textBox3.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Input Customer Address", "Warning", 0, MessageBoxIcon.Error);
                    textBox3.Focus();
                    return;
                }
                
                if (dataGridView1.Rows.Count == 0)
                {
                    if (string.IsNullOrWhiteSpace(textBox5.Text))
                    {
                        MessageBox.Show("Input Product Description", "Warning", 0, MessageBoxIcon.Error);
                        textBox5.Focus();
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(textBox6.Text))
                    {
                        MessageBox.Show("Input Quantity", "Warning", 0, MessageBoxIcon.Error);
                        textBox6.Focus();
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(textBox7.Text))
                    {
                        MessageBox.Show("Input Unit Price", "Warning", 0, MessageBoxIcon.Error);
                        textBox7.Focus();
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(textBox8.Text))
                    {
                        MessageBox.Show("Input Total Price", "Warning", 0, MessageBoxIcon.Error);
                        textBox8.Focus();
                        return;
                    }
                }
                else
                {
                    //great.opencon();

                    //checking if student already exist
                    SqlCommand chk = new SqlCommand("SELECT * FROM proforma_add WHERE prof_id='" + textBox1.Text + "'", dessy.returnCon());
                    SqlDataReader dr = chk.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Customer With Invoice ID  '" + textBox1.Text + "' IS ALREADY REGISTERED", "NOTICE", 0, MessageBoxIcon.Exclamation);
                        dessy.closeCon();
                        return;
                    }
                    else
                    {
                        dr.Close();

                        bool shown = false;
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {

                            int count = dataGridView1.Rows.Count;
                            // MessageBox.Show(count.ToString());
                            SqlCommand cmd1 = new SqlCommand("INSERT INTO proforma_add(customerName,customerEmail,customerAddress,productDesc,prod_Qty,prod_price,total_price,prof_price,prof_id,prof_Date) values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "','" + label15.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "')", dessy.returnCon());
                            //'" + dataGridView2.Rows[i].Cells[5].Value.ToString() + "')", dessy.returnCon());

                            dessy.opencon();

                            if (cmd1.ExecuteNonQuery() >= 1)
                            {

                                if (!shown)
                                {
                                    MessageBox.Show("Invoice Saved For Customer With Name '" + textBox2.Text + "' Successfully", "Success!", 0, MessageBoxIcon.Information);
                                    button10.Enabled = false;
                                    //button10.ForeColor = Color.Red;
                                    //button10.BackColor = Color.White;
                                    button7.Enabled = false;
                                    button8.Enabled = false;
                                    button9.Enabled = false;

                                    shown = true;
                                }


                            }
                            else
                            {
                                MessageBox.Show("Error In Saving Invoice ", "Error!", 0, MessageBoxIcon.Error);

                            }
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
                //dataGridView1.Rows.Clear();
                //Clear();
                //Randomgenerator();
                dessy.closeCon();
                //textBox2.Clear();
                //textBox3.Clear();
                //textBox4.Clear();
                //textBox9.Clear();
                //label15.Text = "0.00";
            }

        }

        private void Randomgenerator()
        {
            //load id into textbox60
            Random generator = new Random();
            String r = generator.Next(0, 1000000).ToString("D7");
            textBox1.Text = r;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
  //          this.dateTimePicker2.Format = DateTimePickerFormat.Custom;
//            this.dateTimePicker2.CustomFormat = " ";

            //dataGridView1.Rows.Clear();
            label15.Text = "0.00";
            textBox9.Clear();
            Randomgenerator();
        }


        public void ClearRecord()
        {
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }


        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Please Wait Patiently For The Receipts", "Saved", 0, MessageBoxIcon.Information);

                var reports = new Proforma_reports();
                reports.textBox1.Text = this.textBox1.Text;
                dessy.closeCon();
                dataGridView1.Rows.Clear();
                reports.Show();
                button10.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Clear();
                Randomgenerator();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((!string.IsNullOrWhiteSpace(textBox7.Text)) && (!string.IsNullOrEmpty(textBox6.Text)))
                {
                    textBox8.Text = (float.Parse(textBox7.Text) * float.Parse(textBox6.Text)).ToString();
                }
                else
                {
                    textBox8.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("THE FOLLOWING ERROR OCCURED : " + ex.Message);
            }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((!string.IsNullOrWhiteSpace(textBox7.Text)) && (!string.IsNullOrEmpty(textBox6.Text)))
                {
                    textBox8.Text = (float.Parse(textBox7.Text) * float.Parse(textBox6.Text)).ToString();
                }
                else
                {
                    textBox8.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("THE FOLLOWING ERROR OCCURED : " + ex.Message);
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //Only Allows IOne Decimal Point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            textBox7.MaxLength = 4;

        }

        private void ProformaMain_Load(object sender, EventArgs e)
        {
            Randomgenerator();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
