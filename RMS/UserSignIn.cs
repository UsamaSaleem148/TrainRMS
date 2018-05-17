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
    public partial class UserSignIn : MetroFramework.Forms.MetroForm
    {
        

        RMSController controller = new RMSController();
        public static int loginvalidator = 0;

        public UserSignIn()
        {
            InitializeComponent();
        }

        private void UserSignIn_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            RMS.UserDashboard.checking = 0;
            controller.UserSignIn(metroTextBox1.Text,metroTextBox2.Text);
            if (loginvalidator == 100)
            {
                
                UserDashboard udash = new UserDashboard();
                this.Hide();
                udash.ShowDialog();
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
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
