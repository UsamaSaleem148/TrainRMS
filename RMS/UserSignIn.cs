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

        public UserSignIn()
        {
            InitializeComponent();
        }

        private void UserSignIn_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            controller.UserSignIn(metroTextBox1.Text,metroTextBox2.Text);
        }
    }
}
