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
using excel = Microsoft.Office.Interop.Excel;
using System.Threading;
namespace Sparrow_Stationary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }

        HouseOfConnections dessy = new HouseOfConnections();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.dateTimePicker2.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker2.CustomFormat = " ";
            // TODO: This line of code loads data into the 'sparrowDBDataSet3.invoice_add' table. You can move, or remove it, as needed.
            //this.invoice_addTableAdapter.Fill(this.sparrowDBDataSet3.invoice_add);
            // TODO: This line of code loads data into the 'sparrowDBDataSet3.invoice_add' table. You can move, or remove it, as needed.
            //this.invoice_addTableAdapter.Fill(this.sparrowDBDataSet3.invoice_add);
            //// TODO: This line of code loads data into the 'sparrowDBDataSet2.invoice_add' table. You can move, or remove it, as needed.
            //this.invoice_addTableAdapter1.Fill(this.sparrowDBDataSet2.invoice_add);
            ////makes picturebox13 round
            //System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            //gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            //Region rg = new Region(gp);
            //pictureBox1.Region = rg;

            panel8.Visible = false;
            panel9.Visible = false;
            ControlBox = false;

            Randomgenerator();

            progressBar1.Visible = false;
            button13.Enabled = false;
            textBox11.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //logout
            if (MessageBox.Show("ARE YOU SURE YOU WANT TO LOGOUT ??", "LOGOUT?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Dispose();
                var loginxx = new Login();
                loginxx.Show();
            }
            else
            {
                this.Show();
                var loginxx = new Login();
                
                loginxx.Hide();

            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            panel8.Hide();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel8.Hide();
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
                    textBox9.Text =  sum.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void ClearRecord()
        {
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ClearRecord();
            dataGridView1.Rows.Clear();
        }

        private void Randomgenerator()
        {
            //load id into textbox60
            Random generator = new Random();
            String r = generator.Next(0, 1000000).ToString("D7");
            textBox1.Text = r;
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
                else if (string.IsNullOrWhiteSpace(dateTimePicker2.Text))
                {
                    MessageBox.Show("Input Due Date", "Warning", 0, MessageBoxIcon.Error);
                    dateTimePicker2.Focus();
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
                    SqlCommand chk = new SqlCommand("SELECT * FROM invoice_add WHERE invoice_id='" + textBox1.Text + "'", dessy.returnCon());
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
                            SqlCommand cmd1 = new SqlCommand("INSERT INTO invoice_add(customerName,customerEmail,customerAddress,productDesc,prod_Qty,prod_price,total_price,invoice_price,invoice_id,invoice_Date,due_date) values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "','" + label15.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')", dessy.returnCon());
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

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if ((!string.IsNullOrWhiteSpace(textBox7.Text)) && (!string.IsNullOrEmpty(textBox6.Text)))
            //    {
            //        textBox8.Text = (Convert.ToInt32(textBox7.Text) * Convert.ToInt32(textBox6.Text)).ToString();
            //    }
            //    else
            //    {
            //        textBox8.Text = "";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("THE FOLLOWING ERROR OCCURED : " + ex.Message);
            //}
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

        private void button12_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            panel9.Hide();
        }

        private void panel9_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

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
            this.dateTimePicker2.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker2.CustomFormat = " ";

            //dataGridView1.Rows.Clear();
            label15.Text = "0.00";
            textBox9.Clear();
            Randomgenerator();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            // MessageBox.Show("INPUT ONLY INTEGER NUMBERS [NO LETTERS OR DECIMAL NUMBERS]","", 0, MessageBoxIcon.Error);
            return;
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

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
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
            textBox8.MaxLength = 4;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Please Wait Patiently For The Receipts", "Saved", 0, MessageBoxIcon.Information);

                var reports = new Invoice_report();
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
            }finally
            {
                Clear();
                Randomgenerator();
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow click = dataGridView2.Rows[e.RowIndex];
                textBox11.Text = click.Cells[9].Value.ToString();
                var receipt = new Invoice_report();
                receipt.textBox1.Text = this.textBox11.Text;
                receipt.Show();

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            progressBar1.Visible = true;
        }

        public void Excel()
        {
            //loading datagrid contents to excel worksheets
            Thread.Sleep(3000);
            excel.Application app = new excel.Application();
            excel.Workbook workbook = app.Workbooks.Add();
            excel.Worksheet Worksheet = null;
            app.Visible = true;
            Worksheet = workbook.Sheets["sheet1"];
            Worksheet = workbook.ActiveSheet;
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                Worksheet.Cells[1, i + 1] = dataGridView2.Columns[i].HeaderText;
            }

            for (int j = 0; j <= dataGridView2.Rows.Count - 1; j++)
            {

                for (int i = 0; i < dataGridView2.Columns.Count; i++)
                {

                    Worksheet.Cells[j + 2, i + 1] = dataGridView2.Rows[j].Cells[i].Value.ToString();
                }
            }
            Worksheet.Columns.AutoFit();
            //Worksheet.Columns.Text.Bold();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //indicating loading of data to excel when the export btn is triggerd
            progressBar1.Increment(1);
           // button8.Text = progressBar1.Value.ToString() + "%";
            //button8.ForeColor = Color.Red;
            this.progressBar1.Increment(10);
            if (progressBar1.Value == 100)
            {
                //timer1.Tick.Tostring() = label7.Text;
                Excel();
                progressBar1.Visible = false;
                timer1.Enabled = false;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string search = textBox10.Text;
                SqlCommand cmd = new SqlCommand("select * from invoice_add  where CONCAT(customerName,invoice_id) like '%" + textBox10.Text + "%' ", dessy.returnCon());
                //view records in datagrid
                SqlDataAdapter sda = new SqlDataAdapter("select * from invoice_add  where CONCAT(customerName,invoice_id) like '%" + textBox10.Text + "%' ", dessy.returnCon());
               dessy.opencon();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
                //end
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    if (string.IsNullOrWhiteSpace(textBox10.Text.ToString()))
                    {
                        //Clear();
                    }
                }
                else
                {
                    rd.Close();
                    MessageBox.Show("RECORD, '" + textBox10.Text + "' NOT FOUND", "ERROR", 0, MessageBoxIcon.Error);
                    textBox10.Clear();

                }
                rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dessy.closeCon();

            }




        }

        private void button14_Click(object sender, EventArgs e)
        {
            dessy.opencon();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM invoice_add ", dessy.returnCon());
            DataTable dt = new DataTable();

            dataGridView2.DataSource = dt;
            da.Fill(dt);
            button13.Enabled = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow click = dataGridView2.Rows[e.RowIndex];
                textBox11.Text = click.Cells[9].Value.ToString();
                var receipt = new Invoice_report();
                receipt.textBox1.Text = this.textBox11.Text;
                receipt.Show();

            }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, Color.Black);
        }

        private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePicker6.CustomFormat = "dd/mm/yyy hh:mm:ss";
            //dateTimePicker6.Format = DateTimePickerFormat.Long;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd/mm/yyy hh:mm:ss";
            dateTimePicker2.Format = DateTimePickerFormat.Long;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.ForeColor = Color.Black;
            var user = new USERS();
            user.Hide();
            Randomgenerator();
            panel8.Visible = true;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            var users = new ProformaMain();
            users.MdiParent = this;
            users.dataGridView1.ForeColor = Color.Black;

            Randomgenerator();
            users.Show();

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            var user = new USERS();
            user.Hide();
            panel8.Visible = true;
            panel9.Visible = true;
            dataGridView2.ForeColor = Color.Black;
            dataGridView2.Refresh();
            //this.invoice_addTableAdapter.Fill(this.sparrowDBDataSet3.invoice_add);
            //this.invoice_addTableAdapter.Fill(this.sparrowDBDataSet3.invoice_add);

            dessy.opencon();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 15 id,customerName,customerEmail,customerAddress,productDesc,prod_Qty,prod_price,total_price,invoice_price,invoice_id,invoice_Date,due_date   FROM invoice_add  ORDER BY id DESC", dessy.returnCon());
            DataTable dt = new DataTable();
            dataGridView2.DataSource = dt;
            da.Fill(dt);

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            var users = new USERS();
            users.MdiParent = this;
            users.Show();
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://mail.google.com");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
    }
}
