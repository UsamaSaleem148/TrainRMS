using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RMS
{
    class RMSController
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;

        public void InsertTrain(string TrainName,string Source,string Destination)
        {
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                //Till Here}

                cmd = new SqlCommand("insert into Train(TrainName,Source,Destination) values ('"+TrainName+"','"+Source+"','"+Destination+"')", con);

                cmd.ExecuteNonQuery();
                con.Close();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
    }
}
