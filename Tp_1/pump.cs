using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_1
{
    public partial class pump : UserControl
    {
        public pump()
        {
            InitializeComponent();
            
        }

        private void pump_Load(object sender, EventArgs e)
        {
            userActions f = new userActions();
            f.pistolClick += F_pistolClick;
        }

        private void F_pistolClick(bool btn)
        {
            if (btn)
            {
                label1.Text = "Raccrocher le pistolet une fois terminé";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
