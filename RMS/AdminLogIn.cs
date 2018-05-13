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

        RMSController controller = new RMSController();

        public AdminLogIn()
        {
            InitializeComponent();
        }

        private void AdminLogIn_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            controller.AdminLogin(metroTextBox1.Text,metroTextBox2.Text);
        }
    }
}
