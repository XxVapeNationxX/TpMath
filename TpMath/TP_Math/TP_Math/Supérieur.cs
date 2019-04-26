﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Math
{
    public partial class Supérieur : Form
    {
        
        public Supérieur()
        {
            InitializeComponent();
        }

        private void BTN_Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void TBX_Moyenne_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            Error_Moyenne.Visible = false;
        }

        private void TBX_ET_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            Error_Ecart.Visible = false;
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            ERror_A.Visible = false;
        }

        private void TBX_Reponse_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_Calculer_Click_1(object sender, EventArgs e)
        {
            bool bon = true;

            if (TBX_Moyenne.Text.IndexOf('-') > 0 || TBX_Moyenne.Text.IndexOf('.') == 0 || string.IsNullOrWhiteSpace(TBX_Moyenne.Text))
            {
                Error_Moyenne.Visible = true;
                bon = false;
            }
            if (TBX_ET.Text.IndexOf('-') > 0 || TBX_ET.Text.IndexOf('.') == 0 || string.IsNullOrWhiteSpace(TBX_ET.Text))
            {
                Error_Ecart.Visible = true;
                bon = false;
            }
            if (TBX_A.Text.IndexOf('-') > 0 || TBX_A.Text.IndexOf('.') == 0 || string.IsNullOrWhiteSpace(TBX_A.Text))
            {
                ERror_A.Visible = true;
                bon = false;
            }

            if (bon == true) 
            {
                double Rep;
                Rep = Probabilité.getTableData((double.Parse(TBX_A.Text) - double.Parse(TBX_Moyenne.Text)) / double.Parse(TBX_ET.Text), 2);
                Rep = Rep * 100;
                TBX_Reponse.Text = Rep.ToString() + " %";            
            }
        }
    }
}
