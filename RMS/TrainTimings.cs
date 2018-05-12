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

namespace RMS
{
    public partial class TrainTimings : MetroFramework.Forms.MetroForm
    {
        

        
        SqlCommand com;

        
        public TrainTimings()
        {
            InitializeComponent();
        }

        private void TrainTimings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rMSDataSet.Train' table. You can move, or remove it, as needed.
            this.trainTableAdapter.Fill(this.rMSDataSet.Train);
            // TODO: This line of code loads data into the 'rMSDataSet.TrainTimings' table. You can move, or remove it, as needed.
            this.trainTimingsTableAdapter.Fill(this.rMSDataSet.TrainTimings);
           

            try
            {
                connn.ConnectDb();







                com.CommandText = "SELECT TrainTimings.TimingsID, Train.TrainName, TrainTimings.ArrivalTime, TrainTimings.DepartureTime FROM TrainTimings INNER JOIN Train ON TrainTimings.TrainID = Train.TrainID";



                SqlDataReader reader = com.ExecuteReader();

                if (reader.HasRows)

                {

                    DataTable dt = new DataTable();

                    dt.Load(reader);

                    dataGridView1.DataSource = dt;

                }

            }

            finally

            {

                

            }

        }
    }
}
