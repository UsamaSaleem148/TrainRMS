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
    public partial class UserDashboard : MetroFramework.Forms.MetroForm
    {

        Form1 f = new Form1();
        BookTrain bookingTrain = new BookTrain();
        FreightRates freight = new FreightRates();
        public static int checking = 0;
        public UserDashboard()
        {
            InitializeComponent();
            if (checking == 0)
            {
                checking = 100;
                UserSignIn form = new UserSignIn();
                form.Close();
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            

            this.Hide();
            bookingTrain.ShowDialog();
            this.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Hide();
            freight.ShowDialog();
            this.Close();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
