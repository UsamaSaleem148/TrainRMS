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
    public partial class Reservation : MetroFramework.Forms.MetroForm
    {

        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;


        public Reservation()
        {
            InitializeComponent();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            UserDashboard ud = new UserDashboard();
            this.Hide();
            ud.ShowDialog();
            this.Close();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            metroTile3.Enabled = false;
            // TODO: This line of code loads data into the 'rMSDataSet.Reservation' table. You can move, or remove it, as needed.
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;



            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                //Till Here}
                this.dataGridView1.Columns.Clear();
                cmd = new SqlCommand("SELECT * FROM Reservation", con);

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

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;



            try
            {

                con.Open();

                //Till Here}

                cmd = new SqlCommand("SELECT * from Reservation where ReservationID=" + metroTextBox1.Text + "", con);

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

        private void metroTile3_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;
            string id = dataGridView1.Rows[0].Cells[0].Value.ToString();
            try
            {

                con.Open();

                //Till Here}

                cmd = new SqlCommand("delete from Reservation where ReservationID=" + id + "", con);

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
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                //Till Here}
                this.dataGridView1.Columns.Clear();
                cmd = new SqlCommand("SELECT * FROM Reservation", con);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            metroTile3.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metroTile3.Enabled = true;
        }
    }
}
