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

        UserDashboard ud = new UserDashboard();

        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;


        
        public TrainTimings()
        {
            InitializeComponent();
        }

        private void TrainTimings_Load(object sender, EventArgs e)
        {

            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;



            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("SELECT TrainName FROM Train", con);

                try
                {
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        metroComboBox1.Items.Add(dr["TrainName"].ToString());
                    }
                    dr.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            //{Copy from here for Connection!

            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                //Till Here}

                cmd = new SqlCommand("SELECT TrainTimings.TimingsID, Train.TrainName,TrainTimings.StationName , TrainTimings.ArrivalTime, TrainTimings.DepartureTime FROM TrainTimings INNER JOIN Train ON TrainTimings.TrainName = Train.TrainName", con);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
            

            con.Close(); }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                //Till Here}

                cmd = new SqlCommand("SELECT * from TrainTimings where TrainName='" + metroComboBox1.Text + "'", con);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ud.ShowDialog();
            this.Close();
        }
    }
}
