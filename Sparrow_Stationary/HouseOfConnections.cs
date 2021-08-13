using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Sparrow_Stationary
{
    class HouseOfConnections
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B22ALD5;Initial Catalog=SparrowDB;Integrated Security=True");

        public void opencon()
        {

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }


        public void closeCon()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }


        public SqlConnection returnCon()
        {
            return con;
        }

    }
}
