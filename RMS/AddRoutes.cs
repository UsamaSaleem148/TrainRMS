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
    public partial class AddRoutes : MetroFramework.Forms.MetroForm
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlDataAdapter da;
        SqlCommand cmd;
        RMSController controller = new RMSController();
        

        public AddRoutes()
        {
            InitializeComponent();
        }

        private void AddRoutes_Load(object sender, EventArgs e)
        {

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "hh:mm:ss";




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
                        comboBox2.Items.Add(dr["StationName"].ToString());
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
                        comboBox1.Items.Add(dr["TrainName"].ToString());
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
            
            try
            {
            
                con.Open();

                //Till Here}

                cmd = new SqlCommand("SELECT * from TrainTimings", con);

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

        private void metroTile1_Click(object sender, EventArgs e)
        {
           
            controller.AddRoutes(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), metroTextBox1.Text, metroTextBox2.Text);

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                //Till Here}

                cmd = new SqlCommand("SELECT * from TrainTimings", con);

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
