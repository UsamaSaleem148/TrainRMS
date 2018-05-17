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
    public partial class AdminDashboardcs : MetroFramework.Forms.MetroForm
    {

        
        
        public static int checkingadmin = 0;

        public AdminDashboardcs()
        {
            AdminLogIn adml = new AdminLogIn();
            InitializeComponent();
            if (checkingadmin == 0)
            {
                checkingadmin = 100;
                adml.Close();
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Train train = new Train();
            this.Hide();
            train.ShowDialog();
            this.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            
            AdminReservation ar = new AdminReservation();
            this.Hide();
            ar.ShowDialog();
            this.Close();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            AddFreight af = new AddFreight();
            this.Hide();
            af.ShowDialog();
            this.Close();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {

        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            AddRoutes ar = new AddRoutes();
            this.Hide();
            ar.ShowDialog();
            this.Close();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            AdminPassenger ap = new AdminPassenger();
            this.Hide();
            ap.ShowDialog();
            this.Close();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Stations st = new Stations();
            this.Hide();
            st.ShowDialog();
            this.Close();
        }

        private void metroTile5_Click_1(object sender, EventArgs e)
        {
            AdminLogIn adml = new AdminLogIn();
            this.Hide();
            adml.ShowDialog();
            this.Close();
        }
    }
}
