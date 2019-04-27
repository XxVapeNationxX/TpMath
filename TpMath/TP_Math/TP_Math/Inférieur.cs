using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Text.RegularExpressions;

namespace TP_Math
{
    public partial class Inférieur : Form
    {
        public Inférieur()
        {
            InitializeComponent();
        }

        private void BTN_Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        //Vérification que les champs sont correctes

        private void TBX_Moyenne_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            Error_Moyenne.Visible = false;
        }

        //Vérification que les champs sont correctes

        private void TBX_ET_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            Error_Ecart.Visible = false;
        }

        private void BTN_Calculer_Click(object sender, EventArgs e)
        {
            bool bon = true;
            //Vérification que les champs sont correctes
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
            if (textBox1.Text.IndexOf('-') > 0 || textBox1.Text.IndexOf('.') == 0 || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                ERror_A.Visible = true;
                bon = false;
            }
            if (bon == true)
            {
                //Trouver la cote z
                double CoteZ = (double.Parse(textBox1.Text) - double.Parse(TBX_Moyenne.Text)) / double.Parse(TBX_ET.Text);
                double Prob;
                //inférieur
                if (CoteZ > 0 && CoteZ < 4)
                    Prob = (TrouverProb(CoteZ) + 0.5);
                else if (CoteZ > 4)
                    Prob = 1;
                else
                    Prob = (0.5 - TrouverProb(CoteZ * -1));
                //Vérifie la réponse et met en pourcentage
                TBX_Reponse.Text = FinaliserProb(Prob);
            }
        }

        //Vérification que les champs sont correctes

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            ERror_A.Visible = false;
        }

        public string FinaliserProb(double prob)
        {
            string probFini = (prob * 100).ToString();
            if (prob == 0)
                probFini += "%";
            else if (prob == 1)
                probFini += "%";
            else
            {
                if (probFini.IndexOf('.') != -1)
                    probFini = probFini.Substring(0, (probFini.IndexOf('.') + 3)) + "%"; // Sur une version anglaise de windows, les . restent des .
                else
                    probFini = probFini.Substring(0, (probFini.IndexOf(',') + 3)) + "%"; // Sur une version française de windows, les . sont transformées en , FOR SOME REASON!!!!!!!!!!!
            }

            return probFini;
        }

        //Cette fonction créée le tableau de loi normal
        //à partir du tableau donnée par le prof
        //

        public void ImportTable()
        {
            System.Data.DataTable dt = new System.Data.DataTable("dataTable");
            DataSet dsSource = new DataSet("dataSet");
            dt.Reset();

            Excel.Workbook ExWorkbook;
            Excel.Worksheet ExWorksheet;
            Excel.Range ExRange;
            Excel.Application ExObj = new Excel.Application();


            ExWorkbook = ExObj.Workbooks.Open(System.IO.Directory.GetCurrentDirectory() + "\\table_normale.xlsx", Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            ExWorksheet = (Excel.Worksheet)ExWorkbook.Sheets.get_Item(1);
            ExRange = ExWorksheet.UsedRange;

            for (int Cnum = 1; Cnum <= ExRange.Columns.Count; Cnum++)
            {
                dt.Columns.Add(new DataColumn((ExRange.Cells[1, Cnum] as Excel.Range).Value2.ToString()));
            }
            dt.AcceptChanges();

            for (int Rnum = 1; Rnum <= ExRange.Rows.Count; Rnum++)
            {
                DataRow dr = dt.NewRow();
                for (int Cnum = 1; Cnum <= ExRange.Columns.Count; Cnum++)
                {
                    if ((ExRange.Cells[Rnum, Cnum] as Excel.Range).Value2 != null)
                    {
                        dr[Cnum - 1] = (ExRange.Cells[Rnum, Cnum] as Excel.Range).Value2.ToString();
                    }
                }
                dt.Rows.Add(dr);
                dt.AcceptChanges();
            }
            ExWorkbook.Close(true, Missing.Value, Missing.Value);
            ExObj.Quit();

            DGV_Table.DataSource = dt;
        }

        //Cette fonction cherche la probabilité avec la cote Z
        //dans le tableau créée avec excel plutôt puis la renvoie
        //pour le mettre en pourcentage

        public double TrouverProb(double coteZ)
        {
            int resA = 0, resB = 0;
            for (int i = 1; i < DGV_Table.RowCount; i++)
            {
                if (Convert.ToDouble(DGV_Table.Rows[i].Cells[0].Value) != 0)
                {
                    if (coteZ.ToString().Length >= 3)
                    {
                        if (Convert.ToDouble(DGV_Table.Rows[i].Cells[0].Value) == Convert.ToDouble(coteZ.ToString().Substring(0, 3)))
                            resA = i;
                    }
                    else
                    {
                        if (Convert.ToDouble(DGV_Table.Rows[i].Cells[0].Value) == Convert.ToDouble(coteZ.ToString().Substring(0, coteZ.ToString().Length)))
                            resA = i;
                    }
                }
                else
                {
                    if (coteZ.ToString().Length >= 3)
                    {
                        if (Convert.ToDouble(DGV_Table.Rows[i].Cells[0].Value) == Convert.ToDouble(coteZ.ToString().Substring(0, 3)))
                            resA = 1;
                    }
                    else
                    {
                        if (Convert.ToDouble(DGV_Table.Rows[i].Cells[0].Value) == Convert.ToDouble(coteZ.ToString().Substring(0, coteZ.ToString().Length)))
                            resA = 1;
                    }
                }
            }
            for (int j = 1; j < DGV_Table.ColumnCount; j++)
            {
                if (Convert.ToDouble(DGV_Table.Rows[0].Cells[j].Value) != 0)
                {
                    if (coteZ.ToString().Length > 3)
                    {
                        if (Convert.ToDouble(coteZ.ToString().Substring(3, 1)) == Convert.ToDouble((DGV_Table.Rows[0].Cells[j].Value).ToString().Substring(3, 1)))
                            resB = j;
                    }
                    else
                    {
                        resB = 1;
                    }
                }
            }
            return Convert.ToDouble(DGV_Table.Rows[resA].Cells[resB].Value);
        }
    }
}