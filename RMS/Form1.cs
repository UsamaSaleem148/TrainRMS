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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        UserSignIn ud = new UserSignIn();
        AdminDashboardcs ad = new AdminDashboardcs();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
            UserSignIn usi = new UserSignIn();
            this.Hide();
            usi.ShowDialog();
            this.Close();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            
            AdminLogIn al = new AdminLogIn();
            this.Hide();
            al.ShowDialog();
            this.Close();
        }
    }
}
//Console.WriteLine("Hello World!");
//            TextBox[] txtPassenger = new TextBox[Convert.ToInt32(metroComboBox6.SelectedItem.ToString())];
//Label[] lblPassenger = new Label[Convert.ToInt32(metroComboBox6.SelectedItem.ToString())];
//            for (int i = 0; i<txtPassenger.Length; i++)
//            {
//                var lbl = new Label();
//string name = "label" + i.ToString();
//lblPassenger[i] = lbl;
//                lbl.Name = name;
//                lbl.Text = name;
//                lbl.Location = new Point(50, 32 + (i* 28));
//                metroPanel2.Controls.Add(lbl);
//                lbl.Visible = true;


//                var txt = new TextBox();
//name = "textbox" + i.ToString();
//                txtPassenger[i] = txt;
//                txt.Name = name;
//                txt.Text = name;
//                txt.Location = new Point(172, 32 + (i* 28));
//                metroPanel2.Controls.Add(txt);
//                txt.Visible = true;
//            }