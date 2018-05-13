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
    public partial class FreightRates : MetroFramework.Forms.MetroForm
    {

        SqlConnection con;
        SqlDataReader dr;
        SqlDataAdapter da;
        SqlCommand cmd;


        public FreightRates()
        {
            InitializeComponent();
        }

        private void FreightRates_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("SELECT ItemName FROM FreightRates", con);

                try
                {
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        metroComboBox1.Items.Add(dr["ItemName"].ToString());
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

                //Till Here}
                this.metroGrid1.Columns.Clear();
                cmd = new SqlCommand("SELECT * FROM FreightRates", con);

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

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("SELECT * FROM FreightRates where ItemName = '" + metroComboBox1.Text + "'", con);


                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                metroGrid1.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
