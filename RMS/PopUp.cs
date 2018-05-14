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
    public partial class PopUp : MetroFramework.Forms.MetroForm
    {
        public PopUp()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ReserveSeats rsv = new ReserveSeats();
           
            

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ReserveSeats rsv = new ReserveSeats();
            rsv.Enabled = true;
            
        }
    }
}
