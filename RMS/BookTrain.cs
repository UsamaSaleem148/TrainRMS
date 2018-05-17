using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace RMS
{
    public partial class BookTrain : MetroFramework.Forms.MetroForm
    {


        
        SqlConnection con;
        SqlDataReader dr;
        SqlDataAdapter da;
        SqlCommand cmd;
        RMSController controller = new RMSController();
        ReserveSeats passenegr = new ReserveSeats();
       public static string trainName, className, source, destination, date,arrivaltime,npassenger;

        private void metroTile2_Click(object sender, EventArgs e)
        {
            BookTrain bt = new BookTrain();
            this.Hide();
            bt.ShowDialog();
            this.Close();
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                //Till Here}

                cmd = new SqlCommand("SELECT * from TrainTimings where TrainName='" + metroComboBox1.Text + "' and StationName = '" + metroComboBox2.Text + "'", con);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                metroGrid1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public BookTrain()
        {
            InitializeComponent();
        }

        



        private void metroComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void metroTile1_Click(object sender, EventArgs e)
        {

            trainName = metroComboBox1.SelectedItem.ToString();
            className = metroComboBox4.SelectedItem.ToString();
            date = dateTimePicker1.Value.ToShortDateString();
            source = metroComboBox2.SelectedItem.ToString();
            destination = metroComboBox3.SelectedItem.ToString();
            arrivaltime = metroGrid1.Rows[0].Cells["ArrivalTime"].Value.ToString();
            npassenger = metroComboBox5.SelectedItem.ToString();


            passenegr.noPassenger();
            this.Hide();
            passenegr.ShowDialog();
            this.Close();
        }

        private void BookTrain_Load(object sender, EventArgs e)
        {

            dateTimePicker1.MinDate = DateTime.Today;


            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("SELECT StationName FROM Stations", con);

                try
                {
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        metroComboBox2.Items.Add(dr["StationName"].ToString());
                        metroComboBox3.Items.Add(dr["StationName"].ToString());
                    }
                    dr.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("SELECT ClassName FROM Classes", con);

                try
                {
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        metroComboBox4.Items.Add(dr["ClassName"].ToString());
                        
                    }
                    dr.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                //Till Here}

                cmd = new SqlCommand("SELECT * from TrainTimings where TrainName='"+metroComboBox1.Text+"'", con);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                metroGrid1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
