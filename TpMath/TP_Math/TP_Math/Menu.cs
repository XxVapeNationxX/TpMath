using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BTN_Intérieur_Click(object sender, EventArgs e)
        {
            this.Hide();
            Intérieur intérieur = new Intérieur();
            intérieur.ShowDialog();
        }

        private void BTN_Inférieur_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inférieur inférieur = new Inférieur();
            inférieur.ShowDialog();
        }

        private void BTN_Supérieur_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supérieur supérieur = new Supérieur();
            supérieur.ShowDialog();
        }
    }
}
