using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace RMS
{
    class RMSController
    {
        
        SqlConnection con;
        SqlDataReader dr;
        SqlDataAdapter da;
        SqlCommand cmd;

        public void InsertTrain(string TrainName,string Source,string Destination)
        {
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                //Till Here}

                cmd = new SqlCommand("insert into Train(TrainName,Source,Destination) values ('"+TrainName+"','"+Source+"','"+Destination+"')", con);

                cmd.ExecuteNonQuery();
                con.Close();
                DialogResult DDR = MessageBox.Show("Train Added Successfully!", "Railway Management System", MessageBoxButtons.OK,
MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UserSignup(string name,string username,string email,string password,string phone,string nic,string address)
        {
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                //Till Here}

                cmd = new SqlCommand("insert into [User]([Name],Username,Password,Email,Phone,NIC,Address) values ('"+name+"','"+username+"','"+password+"','"+email+"','"+phone+"','"+nic+"','"+address+"')", con);

                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult DDR = MessageBox.Show("User Added Successfully!", "Railway Management System", MessageBoxButtons.OK,
MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

        public void UserSignIn(string username, string password)
        {
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                da = new SqlDataAdapter("SELECT * from [User] where [Username]='" + username + "' and [Password]='" + password + "'", con);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {


                    UserSignIn usd = new UserSignIn();
                    UserDashboard ud = new UserDashboard();
                    usd.Hide();
                    ud.ShowDialog();
                    usd.Close();


                }
                else
                {
                    DialogResult DDR = MessageBox.Show("Invalid Username or Password", "Railway Management System", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
