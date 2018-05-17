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


        Stations st = new Stations();

        public AdminDashboardcs()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            AdminDashboardcs ad = new AdminDashboardcs();
            Train train = new Train();
            ad.Hide();
            train.ShowDialog();
            ad.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            AdminDashboardcs ad = new AdminDashboardcs();
            AdminReservation ar = new AdminReservation();
            ad.Hide();
            ar.ShowDialog();
            ad.Close();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            AdminDashboardcs ad = new AdminDashboardcs();
            AddFreight af = new AddFreight();
            ad.Hide();
            af.ShowDialog();
            ad.Close();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {

        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            AdminDashboardcs ad = new AdminDashboardcs();
            AddRoutes ar = new AddRoutes();
            ad.Hide();
            ar.ShowDialog();
            ad.Close();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            AdminDashboardcs ad = new AdminDashboardcs();
            AdminPassenger ap = new AdminPassenger();
            ad.Hide();
            ap.ShowDialog();
            ad.Close();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Hide();
            st.ShowDialog();
            this.Close();
        }
    }
}
