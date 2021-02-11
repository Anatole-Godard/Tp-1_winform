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
    public partial class userActions : Form
    {
        public userActions()
        {
            InitializeComponent();
        }

        public delegate void DelegateCardClick(bool card);
        public event DelegateCardClick cardClick;
        
        public delegate void DelegatePistolClick(bool btn);
        public event DelegatePistolClick pistolClick;
        
        public delegate void DelegateTiquetClick(String btn);
        public event DelegateTiquetClick tiquetClick;

   

        private void card_click(object sender, EventArgs e)
        {
            if (cardClick != null)
            {
                if (((Button)sender).Text == "inserer carte")
                {
                    cardClick(true);
                }
                else
                {
                    cardClick(false);
                }
                
            }
        }

        private void pistol_click(object sender, EventArgs e)
        {
            if (pistolClick != null)
            {
                if (((Button)sender).Text == "prendre pistolet")
                {
                    pistolClick(true);
                }
                else
                {
                    pistolClick(false);
                }
            }
        }

        private void tiquet_click(object sender, EventArgs e)
        {
            if (tiquetClick != null)
            {
                tiquetClick(((Button)sender).Text);
            }
        }
    }
}
