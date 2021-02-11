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
    public partial class numPad : UserControl
    {
        public numPad()
        {
            InitializeComponent();
        
        }
        private string cardCode ="";
            
        public delegate void DelegatePadClick(String btn);
        public event DelegatePadClick padClick;

        public delegate void DelegateDelClick(String btn);
        public event DelegateDelClick delClick;
        
        public delegate void DelegateValidClick(String btn);
        public event DelegateValidClick validClick;

        private void padNum_click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
            if (padClick != null)
            {
                cardCode += ((Button)sender).Text;
            }
        }

        private void del_click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);

            if (delClick!= null)
            {
                cardCode = cardCode.Remove(cardCode.Length - 1);
            }
        }

        private void valid_click(object sender, EventArgs e)
        {
            if (validClick != null) {
                validClick(cardCode);
                cardCode = "";
            }
        }
    }
}
