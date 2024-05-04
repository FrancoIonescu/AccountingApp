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
                float suma;
                if (float.TryParse(tbSuma.Text, out suma))
                {
                    string cont = tbCont.Text;

                    if (cont.Substring(0, 2) == "21")
                    {
                        elemente.Active_imobilizate += suma;
                        elemente.Imobilizari_corporale += suma;
                        elemente.Active_minus_datorii += suma;
                        BilantContabil.Rows[0].Cells[1].Value = elemente.Active_imobilizate;
                        BilantContabil.Rows[1].Cells[1].Value = elemente.Imobilizari_corporale;
                        BilantContabil.Rows[12].Cells[1].Value = elemente.Active_minus_datorii;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;                    
                    }

                    else if (cont.Substring(0, 2) == "20")
                    {
                        elemente.Active_imobilizate += suma;
                        elemente.Imobilizari_necorporale += suma;
                        elemente.Active_minus_datorii += suma;
                        BilantContabil.Rows[0].Cells[1].Value = elemente.Active_imobilizate;
                        BilantContabil.Rows[2].Cells[1].Value = elemente.Imobilizari_necorporale;
                        BilantContabil.Rows[12].Cells[1].Value = elemente.Active_minus_datorii;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;                      
                    }

                    else if (cont.Substring(0, 2) == "26")
                    {          
                        elemente.Active_imobilizate += suma;
                        elemente.Imobilizari_financiare += suma;
                        elemente.Active_minus_datorii += suma;
                        BilantContabil.Rows[0].Cells[1].Value = elemente.Active_imobilizate;
                        BilantContabil.Rows[3].Cells[1].Value = elemente.Imobilizari_financiare;
                        BilantContabil.Rows[12].Cells[1].Value = elemente.Active_minus_datorii;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;                       
                    }

                    else if (cont.Substring(0, 1) == "3")
                    {
                        elemente.Stocuri += suma;
                        elemente.Active_circulante += suma;
                        elemente.Active_circulante_nete += suma;
                        elemente.Active_minus_datorii += suma;
                        BilantContabil.Rows[4].Cells[1].Value = elemente.Active_circulante;
                        BilantContabil.Rows[5].Cells[1].Value = elemente.Stocuri;
                        BilantContabil.Rows[11].Cells[1].Value = elemente.Active_circulante_nete;
                        BilantContabil.Rows[12].Cells[1].Value = elemente.Active_minus_datorii;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring (0, 2) == "41")
                    {
                        elemente.Creante += suma;
                        elemente.Active_circulante += suma;
                        elemente.Active_circulante_nete += suma;
                        elemente.Active_minus_datorii += suma;
                        BilantContabil.Rows[4].Cells[1].Value = elemente.Active_circulante;
                        BilantContabil.Rows[6].Cells[1].Value = elemente.Creante;
                        BilantContabil.Rows[11].Cells[1].Value = elemente.Active_circulante_nete;
                        BilantContabil.Rows[12].Cells[1].Value = elemente.Active_minus_datorii;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 2) == "50")
                    {
                        elemente.Investitii_pe_termen_scurt += suma;
                        elemente.Active_circulante += suma;
                        elemente.Active_circulante_nete += suma;
                        elemente.Active_minus_datorii += suma;
                        BilantContabil.Rows[4].Cells[1].Value = elemente.Active_circulante;
                        BilantContabil.Rows[7].Cells[1].Value = elemente.Investitii_pe_termen_scurt;
                        BilantContabil.Rows[11].Cells[1].Value = elemente.Active_circulante_nete;
                        BilantContabil.Rows[12].Cells[1].Value = elemente.Active_minus_datorii;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 2) == "51")
                    {
                        elemente.Casa_si_conturi_la_banci += suma;
                        elemente.Active_circulante += suma;
                        elemente.Active_circulante_nete += suma;
                        elemente.Active_minus_datorii += suma;
                        BilantContabil.Rows[4].Cells[1].Value = elemente.Active_circulante;
                        BilantContabil.Rows[8].Cells[1].Value = elemente.Casa_si_conturi_la_banci;
                        BilantContabil.Rows[11].Cells[1].Value = elemente.Active_circulante_nete;
                        BilantContabil.Rows[12].Cells[1].Value = elemente.Active_minus_datorii;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 3) == "471")
                    {
                        elemente.Cheltuieli_in_avans += suma;
                        elemente.Active_circulante_nete += suma;
                        elemente.Active_minus_datorii += suma;
                        BilantContabil.Rows[9].Cells[1].Value = elemente.Cheltuieli_in_avans;
                        BilantContabil.Rows[11].Cells[1].Value = elemente.Active_circulante_nete;
                        BilantContabil.Rows[12].Cells[1].Value = elemente.Active_minus_datorii;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 2) == "40" || cont.Substring(0, 2) == "44" || cont.Substring(0, 2) == "45" || cont.Substring(0, 2) == "46")
                    {
                        elemente.Datorii_termen_scurt += suma;
                        elemente.Active_circulante_nete -= suma;
                        elemente.Active_minus_datorii -= suma;
                        BilantContabil.Rows[10].Cells[1].Value = elemente.Datorii_termen_scurt;
                        BilantContabil.Rows[11].Cells[1].Value = elemente.Active_circulante_nete;
                        BilantContabil.Rows[12].Cells[1].Value = elemente.Active_minus_datorii;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 2) == "42" || cont.Substring(0, 2) == "43" || cont.Substring(0, 2) == "48" || cont.Substring(0, 2) == "49")
                    {
                        elemente.Datorii_termen_lung += suma;
                        BilantContabil.Rows[13].Cells[1].Value = elemente.Datorii_termen_lung;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 3) == "472")
                    {
                        elemente.Venituri_in_avans += suma;
                        BilantContabil.Rows[14].Cells[1].Value = elemente.Venituri_in_avans;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 3) == "101" || cont.Substring(0, 3) == "103")
                    {
                        elemente.Capital += suma;
                        elemente.Capital_si_rezerve += suma;
                        BilantContabil.Rows[16].Cells[1].Value = elemente.Capital_si_rezerve;
                        BilantContabil.Rows[17].Cells[1].Value = elemente.Capital;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 3) == "104")
                    {
                        elemente.Prime_de_capital += suma;
                        elemente.Capital_si_rezerve += suma;
                        BilantContabil.Rows[16].Cells[1].Value = elemente.Capital_si_rezerve;
                        BilantContabil.Rows[18].Cells[1].Value = elemente.Prime_de_capital;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 3) == "105")
                    {
                        elemente.Rezerve_din_reevaluare += suma;
                        elemente.Capital_si_rezerve += suma;
                        BilantContabil.Rows[16].Cells[1].Value = elemente.Capital_si_rezerve;
                        BilantContabil.Rows[19].Cells[1].Value = elemente.Rezerve_din_reevaluare;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 3) == "106")
                    {
                        elemente.Rezerve += suma;
                        elemente.Capital_si_rezerve += suma;
                        BilantContabil.Rows[16].Cells[1].Value = elemente.Capital_si_rezerve;
                        BilantContabil.Rows[20].Cells[1].Value = elemente.Rezerve;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Suma introdusa nu este un numar valid.");
                }
                            
            }
            else
            {
                MessageBox.Show("Contul introdus nu este unul valid.");
            }
        }
    }
}
