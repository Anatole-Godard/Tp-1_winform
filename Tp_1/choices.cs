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
    public partial class choices : UserControl
    {
        public choices()
        {
            InitializeComponent();
        }

        public delegate void DelegateChoiceClick(String btn);
        public event DelegateChoiceClick choiceClick;

        private void choice_click(object sender, EventArgs e)
        {
            if (choiceClick != null)
            {
                choiceClick(((Button)sender).Text);
            }
        }
    }
}
