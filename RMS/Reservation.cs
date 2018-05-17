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

        


        public Reservation()
        {
            InitializeComponent();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            UserDashboard ud = new UserDashboard();
            this.Hide();
            ud.ShowDialog();
            this.Close();
        }
    }
}
