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
            //this.bunifuDatePicker2.Format = DateTimePickerFormat.Custom;
            //this.bunifuDatePicker2.CustomFormat = " ";
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
            bunifuButton1.Cursor = Cursors.Hand;
            bunifuButton2.Cursor = Cursors.Hand;
            bunifuButton3.Cursor = Cursors.Hand;
            bunifuButton4.Cursor = Cursors.Hand;
            bunifuButton6.Cursor = Cursors.Hand;
            bunifuButton5.Cursor = Cursors.Hand;


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
            
        }

        public void ClearRecord()
        {
            bunifuTextBox6.Clear();
            bunifuTextBox7.Clear();
            bunifuTextBox8.Clear();
            bunifuTextBox9.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
                    }

        private void Randomgenerator()
        {
            //load id into textbox60
            Random generator = new Random();
            String r = generator.Next(0, 1000000).ToString("D7");
            bunifuTextBox2.Text = r;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            

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
                if ((!string.IsNullOrWhiteSpace(bunifuTextBox8.Text)) && (!string.IsNullOrEmpty(bunifuTextBox7.Text)))
                {
                    bunifuTextBox9.Text = (float.Parse(bunifuTextBox8.Text) * float.Parse(bunifuTextBox7.Text)).ToString();
                }
                else
                {
                    bunifuTextBox9.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("THE FOLLOWING ERROR OCCURED : " + ex.Message);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
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
            bunifuTextBox2.Clear();
            bunifuTextBox3.Clear();
            bunifuTextBox4.Clear();
            bunifuTextBox5.Clear();
            bunifuTextBox6.Clear();
            bunifuTextBox7.Clear();
            bunifuTextBox8.Clear();
            bunifuTextBox9.Clear();
            this.bunifuDatePicker2.Format = DateTimePickerFormat.Custom;
            this.bunifuDatePicker2.CustomFormat = " ";

            //dataGridView1.Rows.Clear();
            label15.Text = "0.00";
            textBox9.Clear();
            Randomgenerator();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
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
            bunifuTextBox8.MaxLength = 4;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
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
            for (int i = 0; i < bunifuDataGridView1.Columns.Count; i++)
            {
                Worksheet.Cells[1, i + 1] = bunifuDataGridView1.Columns[i].HeaderText;
            }

            for (int j = 0; j <= bunifuDataGridView1.Rows.Count - 1; j++)
            {

                for (int i = 0; i < bunifuDataGridView1.Columns.Count; i++)
                {

                    Worksheet.Cells[j + 2, i + 1] = bunifuDataGridView1.Rows[j].Cells[i].Value.ToString();
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



        }

        private void button14_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
            bunifuDatePicker2.CustomFormat = "dd/mm/yyy hh:mm:ss";
            bunifuDatePicker2.Format = DateTimePickerFormat.Long;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuDataGridView2.ForeColor = Color.Black;
            var user = new USERS();
            user.Hide();
            Randomgenerator();
            //this.bunifuDatePicker2.Format = DateTimePickerFormat.Custom;
            //this.bunifuDatePicker2.CustomFormat = " ";
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
            bunifuDataGridView1.ForeColor = Color.Black;
            bunifuDataGridView1.Refresh();
            //this.invoice_addTableAdapter.Fill(this.sparrowDBDataSet3.invoice_add);
            //this.invoice_addTableAdapter.Fill(this.sparrowDBDataSet3.invoice_add);

            dessy.opencon();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 15 id,customerName,customerEmail,customerAddress,productDesc,prod_Qty,prod_price,total_price,invoice_price,invoice_id,invoice_Date,due_date FROM invoice_add  ORDER BY id DESC ", dessy.returnCon());
            DataTable dt = new DataTable();
            bunifuDataGridView1.DataSource = dt;
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

        private void bunifuButton6_Click(object sender, EventArgs e)
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

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string search = bunifuTextBox1.Text;
                SqlCommand cmd = new SqlCommand("select * from invoice_add  where CONCAT(customerName,invoice_id) like '%" + bunifuTextBox1.Text + "%' ", dessy.returnCon());
                //view records in datagrid
                SqlDataAdapter sda = new SqlDataAdapter("select * from invoice_add  where CONCAT(customerName,invoice_id) like '%" + bunifuTextBox1.Text + "%' ", dessy.returnCon());
                dessy.opencon();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                bunifuDataGridView1.DataSource = dt;
                //end
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    if (string.IsNullOrWhiteSpace(bunifuTextBox1.Text.ToString()))
                    {
                        //Clear();
                    }
                }
                else
                {
                    rd.Close();
                    MessageBox.Show("RECORD, '" + bunifuTextBox1.Text + "' NOT FOUND", "ERROR", 0, MessageBoxIcon.Error);
                    bunifuTextBox1.Clear();

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

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow click = bunifuDataGridView1.Rows[e.RowIndex];
                textBox11.Text = click.Cells[9].Value.ToString();
                var receipt = new Invoice_report();
                receipt.textBox1.Text = this.textBox11.Text;
                receipt.Show();

            }
        }

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow click = bunifuDataGridView1.Rows[e.RowIndex];
                textBox11.Text = click.Cells[9].Value.ToString();
                var receipt = new Invoice_report();
                receipt.textBox1.Text = this.textBox11.Text;
                receipt.Show();

            }
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            dessy.opencon();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM invoice_add ", dessy.returnCon());
            DataTable dt = new DataTable();

            bunifuDataGridView1.DataSource = dt;
            da.Fill(dt);
            button13.Enabled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            // MessageBox.Show("INPUT ONLY INTEGER NUMBERS [NO LETTERS OR DECIMAL NUMBERS]","", 0, MessageBoxIcon.Error);
            return;

        }

        private void bunifuTextBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            // MessageBox.Show("INPUT ONLY INTEGER NUMBERS [NO LETTERS OR DECIMAL NUMBERS]","", 0, MessageBoxIcon.Error);
            return;
        }

        private void bunifuTextBox8_TextChange(object sender, EventArgs e)
        {
            try
            {
                if ((!string.IsNullOrWhiteSpace(bunifuTextBox8.Text)) && (!string.IsNullOrEmpty(bunifuTextBox7.Text)))
                {
                    bunifuTextBox9.Text = (Convert.ToInt32(bunifuTextBox8.Text) * Convert.ToInt32(bunifuTextBox7.Text)).ToString();
                }
                else
                {
                    bunifuTextBox9.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("THE FOLLOWING ERROR OCCURED : " + ex.Message);
            }
        }

        private void bunifuTextBox9_KeyPress(object sender, KeyPressEventArgs e)
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
            bunifuTextBox8.MaxLength = 4;
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            ClearRecord();
            bunifuDataGridView2.Rows.Clear();

        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(bunifuTextBox6.Text))
                {
                    MessageBox.Show("Input Product Description", "Warning", 0, MessageBoxIcon.Error);
                    bunifuTextBox6.Focus();
                    return;
                }
                else if (string.IsNullOrWhiteSpace(bunifuTextBox7.Text))
                {
                    MessageBox.Show("Input Quantity", "Warning", 0, MessageBoxIcon.Error);
                    bunifuTextBox7.Focus();
                    return;
                }
                else if (string.IsNullOrWhiteSpace(bunifuTextBox8.Text))
                {
                    MessageBox.Show("Input Unit Price", "Warning", 0, MessageBoxIcon.Error);
                    bunifuTextBox8.Focus();
                    return;
                }
                else if (string.IsNullOrWhiteSpace(bunifuTextBox9.Text))
                {
                    MessageBox.Show("Input Total Price", "Warning", 0, MessageBoxIcon.Error);
                    bunifuTextBox9.Focus();
                    return;
                }
                else
                {

                    string prod_description = bunifuTextBox6.Text;
                    string qty = bunifuTextBox7.Text;
                    string u_price = bunifuTextBox8.Text;
                    string t_price = bunifuTextBox9.Text;
                    string[] row = { prod_description, qty, u_price, t_price };
                    bunifuDataGridView2.Rows.Add(row);
                    //clear record
                    ClearRecord();
                    //calculating the sum of total prices
                    int sum = 0;
                    for (int i = 0; i < bunifuDataGridView2.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(bunifuDataGridView2.Rows[i].Cells[3].Value);
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

        private void bunifuTextBox7_TextChange(object sender, EventArgs e)
        {
            try
            {
                if ((!string.IsNullOrWhiteSpace(bunifuTextBox8.Text)) && (!string.IsNullOrEmpty(bunifuTextBox7.Text)))
                {
                    bunifuTextBox8.Text = (Convert.ToInt32(bunifuTextBox8.Text) * Convert.ToInt32(bunifuTextBox7.Text)).ToString();
                }
                else
                {
                    bunifuTextBox8.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("THE FOLLOWING ERROR OCCURED : " + ex.Message);
            }
        }

        private void bunifuButton10_Click(object sender, EventArgs e)
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
                if (string.IsNullOrWhiteSpace(bunifuTextBox3.Text))
                {
                    MessageBox.Show("Input Customer Name", "Warning", 0, MessageBoxIcon.Error);
                    bunifuTextBox3.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(bunifuTextBox4.Text))
                {
                    MessageBox.Show("Input Customer Email", "Warning", 0, MessageBoxIcon.Error);
                    bunifuTextBox4.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(bunifuTextBox4.Text))
                {
                    MessageBox.Show("Input Customer Address", "Warning", 0, MessageBoxIcon.Error);
                    bunifuTextBox4.Focus();
                    return;
                }
                else if (string.IsNullOrWhiteSpace(bunifuDatePicker2.Text))
                {
                    MessageBox.Show("Input Due Date", "Warning", 0, MessageBoxIcon.Error);
                    bunifuDatePicker2.Focus();
                    return;
                }

                if (bunifuDataGridView2.Rows.Count == 0)
                {
                    if (string.IsNullOrWhiteSpace(bunifuTextBox6.Text))
                    {
                        MessageBox.Show("Input Product Description", "Warning", 0, MessageBoxIcon.Error);
                        bunifuTextBox6.Focus();
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(bunifuTextBox7.Text))
                    {
                        MessageBox.Show("Input Quantity", "Warning", 0, MessageBoxIcon.Error);
                        bunifuTextBox7.Focus();
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(bunifuTextBox8.Text))
                    {
                        MessageBox.Show("Input Unit Price", "Warning", 0, MessageBoxIcon.Error);
                        bunifuTextBox8.Focus();
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(bunifuTextBox9.Text))
                    {
                        MessageBox.Show("Input Total Price", "Warning", 0, MessageBoxIcon.Error);
                        bunifuTextBox9.Focus();
                        return;
                    }
                }
                else
                {
                    //great.opencon();

                    //checking if student already exist
                    SqlCommand chk = new SqlCommand("SELECT * FROM invoice_add WHERE invoice_id='" + bunifuTextBox2.Text + "'", dessy.returnCon());
                    SqlDataReader dr = chk.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Customer With Invoice ID  '" + bunifuTextBox2.Text + "' IS ALREADY REGISTERED", "NOTICE", 0, MessageBoxIcon.Exclamation);
                        dessy.closeCon();
                        return;
                    }
                    else
                    {
                        dr.Close();

                        bool shown = false;
                        for (int i = 0; i < bunifuDataGridView2.Rows.Count; i++)
                        {

                            int count = bunifuDataGridView2.Rows.Count;
                            // MessageBox.Show(count.ToString());
                            SqlCommand cmd1 = new SqlCommand("INSERT INTO invoice_add(customerName,customerEmail,customerAddress,productDesc,prod_Qty,prod_price,total_price,invoice_price,invoice_id,invoice_Date,due_date) values('" + bunifuTextBox3.Text + "','" + bunifuTextBox4.Text + "','" + bunifuTextBox5.Text + "','" + bunifuDataGridView2.Rows[i].Cells[0].Value.ToString() + "','" + bunifuDataGridView2.Rows[i].Cells[1].Value.ToString() + "','" + bunifuDataGridView2.Rows[i].Cells[2].Value.ToString() + "','" + bunifuDataGridView2.Rows[i].Cells[3].Value.ToString() + "','" + label15.Text + "','" + bunifuTextBox2.Text + "','" + bunifuDatePicker1.Text + "','" + bunifuDatePicker2.Text + "')", dessy.returnCon());
                            //'" + dataGridView2.Rows[i].Cells[5].Value.ToString() + "')", dessy.returnCon());

                            dessy.opencon();

                            if (cmd1.ExecuteNonQuery() >= 1)
                            {

                                if (!shown)
                                {
                                    MessageBox.Show("Invoice Saved For Customer With Name '" + bunifuTextBox3.Text + "' Successfully", "Success!", 0, MessageBoxIcon.Information);
                                    bunifuButton11.Enabled = false;
                                    //button10.ForeColor = Color.Red;
                                    //button10.BackColor = Color.White;
                                    bunifuButton9.Enabled = false;
                                    bunifuTextBox9.Enabled = false;
                                    bunifuButton10.Enabled = false;

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

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Please Wait Patiently For The Receipts", "Saved", 0, MessageBoxIcon.Information);

                var reports = new Invoice_report();
                reports.textBox1.Text = this.bunifuTextBox2.Text;
                dessy.closeCon();
                bunifuDataGridView2.Rows.Clear();
                reports.Show();
                bunifuButton11.Enabled = true;
                bunifuButton9.Enabled = true;
                bunifuTextBox9.Enabled = true;
                bunifuButton10.Enabled = true;

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
    }
}
