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
    public partial class UserSignUp : MetroFramework.Forms.MetroForm
    {

        

        RMSController controller = new RMSController();

        public UserSignUp()
        {
            InitializeComponent();
        }

        private void UserSignUp_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            controller.UserSignup(metroTextBox1.Text, metroTextBox2.Text, metroTextBox3.Text, metroTextBox4.Text, metroTextBox5.Text, metroTextBox6.Text, richTextBox1.Text);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            UserSignIn login = new UserSignIn();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
