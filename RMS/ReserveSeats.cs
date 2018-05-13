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
        public ReserveSeats()
        {
            InitializeComponent();
        }


        public void noPassenger(int noOfPassenger)
        {
          
            TextBox[] txtPassenger = new TextBox[noOfPassenger];
            Label[] lblPassenger = new Label[noOfPassenger];
            for (int i = 0; i < txtPassenger.Length; i++)
            {
                var lbl = new Label();
                string name = "label" + i.ToString();
                lblPassenger[i] = lbl;
                lbl.Name = name;
                lbl.Text = "Passenger Name:";
                lbl.Location = new Point(50, 32 + (i * 28));
                metroPanel1.Controls.Add(lbl);
                lbl.Visible = true;


                var txt = new TextBox();
                name = "textbox" + i.ToString();
                txtPassenger[i] = txt;
                txt.Name = name;
                txt.Text = "";
                txt.Location = new Point(172, 32 + (i * 28));
                metroPanel1.Controls.Add(txt);
                txt.Visible = true;
            }
        }

        private void ReserveSeats_Load(object sender, EventArgs e)
        {

        }
    }
}
