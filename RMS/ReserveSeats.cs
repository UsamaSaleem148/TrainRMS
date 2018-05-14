using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS
{
    public partial class ReserveSeats : MetroFramework.Forms.MetroForm
    {
        int seats=1,location = 50;
        
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

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }
        void MyButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string buttonText = ((Button)sender).Text;
            ((Button)sender).Enabled = false;
            MessageBox.Show(buttonText);
        }
    }
}
