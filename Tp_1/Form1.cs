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
    public partial class Form1 : Form
    {
        private bool isCard;

        private string choice;
        
        public Form1()
        {
            InitializeComponent();
            userActions f = new userActions();
            f.Show();
            f.cardClick += cardClick;
            choices1.Visible = false;
            ticket1.Visible = false;
            numPad1.Visible = false;
            pump1.Visible = false;
            f.pistolClick += F_pistolClick;
            
        }

        private void F_pistolClick(bool btn)
        {
           if (!btn)
            {
                pump1.Visible = false;
                choices1.Visible = false;
                ticket1.Visible = false;
                numPad1.Visible = false;
                pump1.Visible = false;
                choice = "";
                isCard = false;
                label1.Visible = true;
            }
            else
            {
                pump1.label1.Text = "Raccrocher le pistolet une fois terminé"; ;
            }
        }

        private void cardClick(bool btn)
        {
            isCard = btn;
            if (btn)
            {
                if (choice == null) { 
                    choices1.Visible = true;
                    label1.Visible = false;
                    ticket1.Visible = false;
                    numPad1.Visible = false;
                }
                else
                {
                    choice = null;
                    choices1.Visible = false;
                    label1.Visible = true;
                    ticket1.Visible = false;
                    numPad1.Visible = false;
                }
            }
        }

        private void numPad1_Load(object sender, EventArgs e)
        {
            numPad1.validClick += NumPad1_validClick;
        }

        private void NumPad1_validClick(string btn)
        {
            numPad1.Visible = false;
            ticket1.Visible = true;   
        }

        private void ticket1_Load(object sender, EventArgs e)
        {
            ticket1.ticketClick += Ticket1_ticketClick;
        }

        private void Ticket1_ticketClick(bool btn)
        {
            pump1.label2.Text = choice;
            pump1.Visible = true;
            ticket1.Visible = false;
        }

        private void choices1_Load(object sender, EventArgs e)
        {
            choices1.choiceClick += Choices1_choiceClick;
        }

        private void Choices1_choiceClick(string btn)
        {
            choice = btn;
            choices1.Visible = false;
            numPad1.Visible = true;
        }

        private void pump1_Load(object sender, EventArgs e)
        {

        }
    }
}
