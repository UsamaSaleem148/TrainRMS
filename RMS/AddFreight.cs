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
    public partial class AddFreight : MetroFramework.Forms.MetroForm
    {

        RMSController controller = new RMSController();

        public AddFreight()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            controller.AddFreight(metroTextBox1.Text, metroTextBox2.Text);
        }
    }
}
