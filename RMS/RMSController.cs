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
        string User_Name;

        public void InsertTrain(string TrainName,string Source,string Destination)
        {
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;
            try
            {
                con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
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
                if (con.State == ConnectionState.Closed)
                    con.Open();

                //Till Here}

                cmd = new SqlCommand("insert into [User]([Name],Username,Password,Email,Phone,NIC,Address) values ('"+name+"','"+username+"','"+password+"','"+email+"','"+phone+"','"+nic+"','"+address+"')", con);

                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult DDR = MessageBox.Show("User Added Successfully!", "Railway Management System", MessageBoxButtons.OK,
MessageBoxIcon.Information);


                UserSignUp usu = new UserSignUp();
                UserDashboard ud = new UserDashboard();
                usu.Hide();
                ud.ShowDialog();
                usu.Close();


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
                if (con.State == ConnectionState.Closed)
                    con.Open();

                da = new SqlDataAdapter("SELECT * from [User] where [Username]='" + username + "' and [Password]='" + password + "'", con);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    User_Name = dtbl.Rows[0][1].ToString();

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


        public void AddFreight(string fName, string perKG)
        {
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;
            try
            {
                con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                    con.Open();

                //Till Here}

                cmd = new SqlCommand("insert into [FreightRates]([ItemName],PerKgRate) values ('" + fName + "','" + perKG + "')", con);

                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult DDR = MessageBox.Show("Item Added Successfully!", "Railway Management System", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void AdminLogin(string username, string password)
        {
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;
            try
            {
                con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                    con.Open();

                da = new SqlDataAdapter("SELECT * from [Administrator] where [Username]='" + username + "' and [Password]='" + password + "'", con);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {


                    AdminLogIn adl = new AdminLogIn();
                    AdminDashboardcs ad = new AdminDashboardcs();
                    adl.Hide();
                    ad.ShowDialog();
                    adl.Close();


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
        public void AddStations(string stationname)
        {
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;
            try
            {
                con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                    con.Open();

                //Till Here}

                cmd = new SqlCommand("insert into [Stations](StationName) values ('" + stationname + "')", con);

                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult DDR = MessageBox.Show("Station Added Successfully!", "Railway Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void AddRoutes(string TrainName,string StationName,string arrivaltime,string departuretime)
        {
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;
            try
            {
                con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                    con.Open();

                //Till Here}

                cmd = new SqlCommand("insert into [TrainTimings](StationName,TrainName,ArrivalTime,DepartureTime) values ('" + StationName + "','"+TrainName+"','"+arrivaltime+"','"+departuretime+"')", con);

                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult DDR = MessageBox.Show("Route Added Successfully!", "Railway Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddClass(string className)
        {
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;
            try
            {
                con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                    con.Open();

                //Till Here}

                cmd = new SqlCommand("insert into [Classes](ClassName) values ('" + className + "')", con);

                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult DDR = MessageBox.Show("Class Added Successfully!", "Railway Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BookSeats(string passengerName,string NIC, string TrainName, string Class, string seatNo, string From, string to, string depdate)
        {
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;
            try
            {
                con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                    con.Open();

                //Till Here}
                string status = "false";
                cmd = new SqlCommand("insert into [Reservation](PassengerName,NIC,TrainName,ClassName,SeatNo,[From],[To],Amount,DepDate,DepTime,UserName,Status) values ('" + passengerName + "','" + NIC + "','" + TrainName + "','" + Class + "','" + seatNo + "','" + From + "','" + to + "',1200,'" + depdate + "','05:00','" + User_Name + "','" + status + "')", con);

                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult DDR = MessageBox.Show("Reservation Successfully!", "Railway Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
