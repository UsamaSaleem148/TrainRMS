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
    public partial class Train : MetroFramework.Forms.MetroForm
    {
        RMSController controller = new RMSController();
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;
        public Train()
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

        private void Train_Load(object sender, EventArgs e)
        {
            //{Copy from here for Connection!
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                //Till Here}
                this.metroGrid1.Columns.Clear();
                cmd = new SqlCommand("SELECT * FROM Train", con);

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
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                //Till Here}
                this.metroGrid1.Columns.Clear();
                cmd = new SqlCommand("SELECT * FROM Classes", con);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                metroGrid2.DataSource = dt;
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

                    cmd = new SqlCommand("delete from Train where TrainID="+id+"", con);

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
                    cmd = new SqlCommand("SELECT * FROM Train", con);

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

        private void metroTile1_Click(object sender, EventArgs e)
        {
            controller.InsertTrain(metroTextBox1.Text,metroTextBox2.Text,metroTextBox3.Text);
            try
            {
                
                con.Open();

                //Till Here}
                this.metroGrid1.Columns.Clear();
                cmd = new SqlCommand("SELECT * FROM Train", con);

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

        private void metroTile2_Click(object sender, EventArgs e)
        {
            controller.AddClass(metroTextBox4.Text);
            try
            {
                
                con.Open();

                //Till Here}
                this.metroGrid1.Columns.Clear();
                cmd = new SqlCommand("SELECT * FROM Classes", con);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                metroGrid2.DataSource = dt;
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
