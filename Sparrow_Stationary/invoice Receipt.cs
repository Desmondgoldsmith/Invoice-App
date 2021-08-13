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
    public partial class invoice_Receipt : Form
    {
        public invoice_Receipt()
        {
            InitializeComponent();
        }
        HouseOfConnections dessy = new HouseOfConnections();
        ReportDocument rd = new ReportDocument();

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void invoice_Receipt_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            try
            {
                if (textBox1.Text != "")
                {
                    dessy.opencon();
                    string requery = "SELECT * FROM invoice_add WHERE invoice_id = '" + textBox1.Text + "'";
                    SqlDataAdapter reda = new SqlDataAdapter(requery, dessy.returnCon());
                    DataSet remydata = new DataSet();
                    reda.Fill(remydata, "invoice_add");
                    RealInvoice_reports redatax = new RealInvoice_reports();
                    redatax.SetDataSource(remydata);
                    crystalReportViewer1.ReportSource = redatax;
                    dessy.closeCon();
                }
                //else
                //{
                //    dessy.opencon();
                //    string query = "SELECT * FROM ALLFEES ORDER BY id DESC";
                //    SqlDataAdapter da = new SqlDataAdapter(query, dessy.returnCon());
                //    DataSet mydata = new DataSet();
                //    da.Fill(mydata, "ALLFEES");
                //    feesReceiptsx datax = new feesReceiptsx();
                //    datax.SetDataSource(mydata);
                //    crystalReportViewer1.ReportSource = datax;
                //    dessy.closeCon();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
