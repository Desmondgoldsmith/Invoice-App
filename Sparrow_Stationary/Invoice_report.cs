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
using CrystalDecisions.CrystalReports.Engine;

namespace Sparrow_Stationary
{
    public partial class Invoice_report : Form
    {
        public Invoice_report()
        {
            InitializeComponent();
        }
        HouseOfConnections dessy = new HouseOfConnections();
        ReportDocument rd = new ReportDocument();
        private void Invoice_report_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            try
            {

                dessy.opencon();
                string requery = "SELECT * FROM invoice_add WHERE invoice_id = '" + textBox1.Text + "'";
                SqlDataAdapter reda = new SqlDataAdapter(requery, dessy.returnCon());
                DataSet remydata = new DataSet();
                reda.Fill(remydata, "invoice_add");
                invoicereport redatax = new invoicereport();
                redatax.SetDataSource(remydata);
                crystalReportViewer1.ReportSource = redatax;
                dessy.closeCon();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
