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
    public partial class ReserveSeats : MetroFramework.Forms.MetroForm
    {

        SqlConnection con;
        SqlDataReader dr;
        SqlDataAdapter da;
        SqlCommand cmd;
        

        public string status;

        int seats=1,location = 50,i,j;

        
        public string buttonText;
        public float amount;



        public ReserveSeats()
        {
            InitializeComponent();
        }


        public void noPassenger()
        {
           // string[] text = new string[noOfPassenger];

            Button[] btnPassenger = new Button[30];
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    var txt = new Button();
                    int name = seats;
                    //text[i] = name;
                    btnPassenger[i] = txt;
                    string nameofbutton = "btn" + i.ToString();
                    txt.Name = nameofbutton;
                    txt.Text = Convert.ToString(name);
                    txt.Location = new Point(location, 32 + (j * 28));
                    metroPanel1.Controls.Add(txt);
                    txt.Visible = true;
                    seats++;
                    txt.Click += new EventHandler(MyButtonClick);
                    
                }
                location += 100;
               


                
            }
        }

        private void ReserveSeats_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {





            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["DB"];
            string connectionString = conSettings.ConnectionString;


            
            try

            {
                con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                    con.Open();

                //Till Here}
                status = "false";
                cmd = new SqlCommand("insert into [Reservation](PassengerName,NIC,TrainName,ClassName,SeatNo,[From],[To],Amount,DepDate,DepTime,UserName,Status) values ('"+metroTextBox1.Text + "','" + metroTextBox2.Text + "','"+BookTrain.trainName+"','"+BookTrain.className+"','" + buttonText + "','"+ BookTrain.source + "','"+BookTrain.destination+"','1200','"+BookTrain.date+"','"+BookTrain.arrivaltime+"','"+RMSController.usname+"','False')", con);

                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult DDR = MessageBox.Show("Reservation Successfully!", "Railway Management System",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }






            metroPanel1.Enabled = true;
            metroPanel1.Visible = true;

            metroPanel2.Visible = false;
            metroPanel2.Enabled = false;


        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            
            metroPanel1.Enabled = true;
            metroPanel1.Visible = true;
            
            metroPanel2.Visible = false;
            metroPanel2.Enabled = false;
            metroPanel1.Controls.Clear();
            seats = 1;
            location = 50;
            noPassenger();
            
        }

        void MyButtonClick(object sender, EventArgs e)
        {
            buttonText = ((Button)sender).Text;
            ((Button)sender).Enabled = false;

            //MessageBox.Show(buttonText);
            metroPanel2.Visible = true;
            metroPanel2.Enabled = true;
            
            metroPanel1.Enabled = false;
            metroPanel1.Visible = false;
        }
    }
}
