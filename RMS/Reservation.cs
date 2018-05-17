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
    public partial class Reservation : MetroFramework.Forms.MetroForm
    {

        UserDashboard ud = new UserDashboard();


        public Reservation()
        {
            InitializeComponent();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ud.ShowDialog();
            this.Close();
        }
    }
}
