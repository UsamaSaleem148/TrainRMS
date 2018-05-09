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
    public partial class BookTrain : MetroFramework.Forms.MetroForm
    {

        ReserveSeats passenegr = new ReserveSeats();

        public BookTrain()
        {
            InitializeComponent();
        }

        



        private void metroComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void metroTile1_Click(object sender, EventArgs e)
        {
            passenegr.noPassenger(Convert.ToInt32(metroComboBox5.SelectedItem.ToString()));
            this.Hide();
            passenegr.ShowDialog();
            this.Close();
        }
    }
}
