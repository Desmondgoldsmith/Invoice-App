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
    public partial class Proforma_reports : Form
    {
        public Proforma_reports()
        {
            InitializeComponent();
        }
        HouseOfConnections dessy = new HouseOfConnections();
        ReportDocument rd = new ReportDocument();

        private void Proforma_reports_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            try
            {

                dessy.opencon();
                string requery = "SELECT * FROM proforma_add WHERE prof_id = '" + textBox1.Text + "'";
                SqlDataAdapter reda = new SqlDataAdapter(requery, dessy.returnCon());
                DataSet remydata = new DataSet();
                reda.Fill(remydata, "proforma_add");
                proforma redatax = new proforma();
                redatax.SetDataSource(remydata);
                crystalReportViewer1.ReportSource = redatax;
                dessy.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
