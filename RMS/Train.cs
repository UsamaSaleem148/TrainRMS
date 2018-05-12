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
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;
        public Train()
        {
            InitializeComponent();
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

                cmd = new SqlCommand("SELECT * FROM Train", con);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                metroGrid1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
