using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Contabilitate
{
    public partial class Bilant : Form
    {
        Elemente elemente = new Elemente();
        public Bilant()
        {
            InitializeComponent();
            this.Width = 800; // Setează lățimea formei la 800 de pixeli
            this.Height = 800;
            Font font = new Font("Arial", 13, FontStyle.Regular);
            BilantContabil.Font = font;
            BilantContabil.Rows.Add("A. Active Imobilizate");
            BilantContabil.Rows.Add("I. Imobilizari corporale");
            BilantContabil.Rows.Add("II. Imobilizari necorporale");
            BilantContabil.Rows.Add("III. Imobilizari financiare");
            BilantContabil.Rows.Add("B. Active circulante");
            BilantContabil.Rows.Add("I. Stocuri");
            BilantContabil.Rows.Add("II. Creante");
            BilantContabil.Rows.Add("III. Investitii financiare pe termen scurt");
            BilantContabil.Rows[7].Height = 50;
            BilantContabil.Rows.Add("IV. Casa si conturi la banci");
            BilantContabil.Rows.Add("C. Cheltuieli in avans");
            BilantContabil.Rows.Add("D. Datorii: Sumele care trebuie platite intr-o perioada de pana la un an");
            BilantContabil.Rows[10].Height = 50;
            BilantContabil.Rows.Add("E. Active circulante nete");
            BilantContabil.Rows.Add("F. Active minus datorii curente");
            BilantContabil.Rows.Add("G. Datorii: Sumele care trebuie platite intr-o perioada mai mare de un an");
            BilantContabil.Rows[13].Height = 50;
            BilantContabil.Rows.Add("H. Provizioane");
            BilantContabil.Rows.Add("I. Venituri in avans");
            BilantContabil.Rows.Add("J. Capital si rezerve");
            BilantContabil.Rows.Add("I. Capital");
            BilantContabil.Rows.Add("II. Prime de capital");
            BilantContabil.Rows.Add("III. Rezerve din reevaluare");
            BilantContabil.Rows.Add("IV. Rezerve");
            BilantContabil.Rows.Add("V. Profitul sau pierderea reportat/a");
            BilantContabil.Rows.Add("VI. Profitul sau pierderea exercitiului financiar");
            BilantContabil.Rows[22].Height = 50;
            BilantContabil.Rows[0].Cells[1].Value = elemente.Active_imobilizate; 
            BilantContabil.Rows[1].Cells[1].Value = elemente.Imobilizari_corporale;
            BilantContabil.Rows[2].Cells[1].Value = elemente.Imobilizari_necorporale;
            BilantContabil.Rows[3].Cells[1].Value = elemente.Imobilizari_financiare;
            BilantContabil.Rows[4].Cells[1].Value = elemente.Active_circulante;
            BilantContabil.Rows[5].Cells[1].Value = elemente.Stocuri;
            BilantContabil.Rows[6].Cells[1].Value = elemente.Creante;
            BilantContabil.Rows[7].Cells[1].Value = elemente.Investitii_pe_termen_scurt;
            BilantContabil.Rows[8].Cells[1].Value = elemente.Casa_si_conturi_la_banci;
            BilantContabil.Rows[9].Cells[1].Value = elemente.Cheltuieli_in_avans;
            BilantContabil.Rows[10].Cells[1].Value = elemente.Datorii_termen_scurt;
            BilantContabil.Rows[11].Cells[1].Value = elemente.Active_circulante_nete;
            BilantContabil.Rows[12].Cells[1].Value = elemente.Active_minus_datorii;
            BilantContabil.Rows[13].Cells[1].Value = elemente.Datorii_termen_lung;
            BilantContabil.Rows[14].Cells[1].Value = elemente.Provizioane;
            BilantContabil.Rows[15].Cells[1].Value = elemente.Venituri_in_avans;
            BilantContabil.Rows[16].Cells[1].Value = elemente.Capital_si_rezerve;
            BilantContabil.Rows[17].Cells[1].Value = elemente.Capital;
            BilantContabil.Rows[18].Cells[1].Value = elemente.Prime_de_capital;
            BilantContabil.Rows[19].Cells[1].Value = elemente.Rezerve_din_reevaluare;
            BilantContabil.Rows[20].Cells[1].Value = elemente.Rezerve;
            BilantContabil.Rows[21].Cells[1].Value = elemente.Profit_pierdere_reportata;
            BilantContabil.Rows[22].Cells[1].Value = elemente.Profit_pierdere_curent;
        }

        private void adauga_Click(object sender, EventArgs e)
        {
            if (tbCont.Text.All(char.IsDigit) && (tbCont.Text.Length == 3 || tbCont.Text.Length == 4))
            {
                string cont = tbCont.Text;

                switch (cont.Substring(0, 2))
                {
                    case "21":
                        {
                            float sumaImobilizariCorporale;
                            if (float.TryParse(tbSuma.Text, out sumaImobilizariCorporale))
                            {
                                elemente.Active_imobilizate += sumaImobilizariCorporale;
                                elemente.Imobilizari_corporale += sumaImobilizariCorporale;
                                BilantContabil.Rows[0].Cells[1].Value = elemente.Active_imobilizate;
                                BilantContabil.Rows[1].Cells[1].Value = elemente.Imobilizari_corporale;
                                tbCont.Clear();
                                cbTip.SelectedIndex = -1;
                                tbSuma.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Suma introdusa nu este un numar valid.");
                            }
                            break;
                        }
                    case "20":
                        {
                            float sumaImobilizariNecorporale;
                            if (float.TryParse(tbSuma.Text, out sumaImobilizariNecorporale))
                            {
                                elemente.Active_imobilizate += sumaImobilizariNecorporale;
                                elemente.Imobilizari_necorporale += sumaImobilizariNecorporale;
                                BilantContabil.Rows[0].Cells[1].Value = elemente.Active_imobilizate;
                                BilantContabil.Rows[2].Cells[1].Value = elemente.Imobilizari_necorporale;
                                tbCont.Clear();
                                cbTip.SelectedIndex = -1;
                                tbSuma.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Suma introdusa nu este un numar valid.");
                            }
                            break;
                        }
                    case "26":
                        {
                            float sumaImobilizariFinanciare;
                            if (float.TryParse(tbSuma.Text, out sumaImobilizariFinanciare))
                            {
                                elemente.Active_imobilizate += sumaImobilizariFinanciare;
                                elemente.Imobilizari_financiare += sumaImobilizariFinanciare;
                                BilantContabil.Rows[0].Cells[1].Value = elemente.Active_imobilizate;
                                BilantContabil.Rows[3].Cells[1].Value = elemente.Imobilizari_financiare;
                                tbCont.Clear();
                                cbTip.SelectedIndex = -1;
                                tbSuma.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Suma introdusa nu este un numar valid.");
                            }
                            break;
                        }
                    default:
                        MessageBox.Show("Contul introdus nu este unul valid.");
                        break;
                }

            }
            else
            {
                MessageBox.Show("Contul introdus nu este unul valid.");
            }
        }
    }
}
