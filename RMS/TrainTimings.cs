using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace RMS
{
    public partial class TrainTimings : MetroFramework.Forms.MetroForm
    {



        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;


        
        public TrainTimings()
        {
            InitializeComponent();
        }

        private void TrainTimings_Load(object sender, EventArgs e)
        {
            
           

            //Copy from here for Connection!
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                //cmd.CommandText = "SELECT TrainTimings.TimingsID, Train.TrainName, TrainTimings.ArrivalTime, TrainTimings.DepartureTime FROM TrainTimings INNER JOIN Train ON TrainTimings.TrainID = Train.TrainID";

                cmd=new SqlCommand("SELECT TrainTimings.TimingsID, Train.TrainName, TrainTimings.ArrivalTime, TrainTimings.DepartureTime FROM TrainTimings INNER JOIN Train ON TrainTimings.TrainID = Train.TrainID", con);

                SqlDataReader reader = cmd.ExecuteReader();

                

                    DataTable dt = new DataTable();

                    dt.Load(reader);

                    dataGridView1.DataSource = dt;
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
