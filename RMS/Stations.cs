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
    public partial class Stations : MetroFramework.Forms.MetroForm
    {
        RMSController controller = new RMSController();
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;
        public Stations()
        {
            InitializeComponent();
        }
        public void deletebuttons()
        {
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            this.metroGrid1.Columns.Add(deleteButton);

        }
        private void metroTile1_Click(object sender, EventArgs e)
        {
            controller.AddStations(metroTextBox1.Text);
            
            try
            {
                
                con.Open();

                //Till Here}
                this.metroGrid1.Columns.Clear();
                cmd = new SqlCommand("SELECT * FROM Stations", con);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                metroGrid1.DataSource = dt;
                con.Close();
                deletebuttons();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Stations_Load(object sender, EventArgs e)
        {
            try
            {
                ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
                string connectionString = conSettings.ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();

                
                this.metroGrid1.Columns.Clear();
                cmd = new SqlCommand("SELECT * FROM Stations", con);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                metroGrid1.DataSource = dt;
                con.Close();
                deletebuttons();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string id = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
                try
                {

                    con.Open();

                    //Till Here}

                    cmd = new SqlCommand("delete from Stations where StationID=" + id + "", con);

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
                try
                {

                    con.Open();

                    //Till Here}
                    this.metroGrid1.Columns.Clear();
                    cmd = new SqlCommand("SELECT * FROM Stations", con);

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    metroGrid1.DataSource = dt;
                    con.Close();
                    deletebuttons();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            }
    }
}
