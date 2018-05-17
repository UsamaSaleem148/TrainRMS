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
    public partial class AdminLogIn : MetroFramework.Forms.MetroForm
    {
        Form1 f = new Form1();
        RMSController controller = new RMSController();
        public static int adminloginvalidator = 0;

        public AdminLogIn()
        {
            InitializeComponent();
        }

        private void AdminLogIn_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            RMS.AdminDashboardcs.checkingadmin = 0;
            controller.AdminLogin(metroTextBox1.Text,metroTextBox2.Text);
            if (adminloginvalidator == 100)
            {

                AdminDashboardcs ud = new AdminDashboardcs();
                this.Hide();
                ud.ShowDialog();
                this.Close();

            }
            else
            {
                DialogResult DDR = MessageBox.Show("Invalid Username or Password", "Railway Management System", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
