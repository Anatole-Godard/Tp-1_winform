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
    public partial class ticket : UserControl
    {
        public ticket()
        {
            InitializeComponent();
        }
        public delegate void DelegateTicketClick(bool btn);
        public event DelegateTicketClick ticketClick;

        private void ticket_click(object sender, EventArgs e)
        {
            if (ticketClick != null) 
            {
                if(((Button)sender).Text == "AVEC TICKET") { 
                    ticketClick(true);
                }
                else
                {
                    ticketClick(false);
                }
            }
        }
    }
}
