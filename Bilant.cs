using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Contabilitate
{
    public partial class Bilant : Form
    {
        ContBilant bilant = new ContBilant();
        public Bilant()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 580;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
            BilantContabil.Rows[0].Cells[1].Value = bilant.Active_imobilizate; 
            BilantContabil.Rows[1].Cells[1].Value = bilant.Imobilizari_corporale;
            BilantContabil.Rows[2].Cells[1].Value = bilant.Imobilizari_necorporale;
            BilantContabil.Rows[3].Cells[1].Value = bilant.Imobilizari_financiare;
            BilantContabil.Rows[4].Cells[1].Value = bilant.Active_circulante;
            BilantContabil.Rows[5].Cells[1].Value = bilant.Stocuri;
            BilantContabil.Rows[6].Cells[1].Value = bilant.Creante;
            BilantContabil.Rows[7].Cells[1].Value = bilant.Investitii_pe_termen_scurt;
            BilantContabil.Rows[8].Cells[1].Value = bilant.Casa_si_conturi_la_banci;
            BilantContabil.Rows[9].Cells[1].Value = bilant.Cheltuieli_in_avans;
            BilantContabil.Rows[10].Cells[1].Value = bilant.Datorii_termen_scurt;
            BilantContabil.Rows[11].Cells[1].Value = bilant.Active_circulante_nete;
            BilantContabil.Rows[12].Cells[1].Value = bilant.Active_minus_datorii;
            BilantContabil.Rows[13].Cells[1].Value = bilant.Datorii_termen_lung;
            BilantContabil.Rows[14].Cells[1].Value = bilant.Provizioane;
            BilantContabil.Rows[15].Cells[1].Value = bilant.Venituri_in_avans;
            BilantContabil.Rows[16].Cells[1].Value = bilant.Capital_si_rezerve;
            BilantContabil.Rows[17].Cells[1].Value = bilant.Capital;
            BilantContabil.Rows[18].Cells[1].Value = bilant.Prime_de_capital;
            BilantContabil.Rows[19].Cells[1].Value = bilant.Rezerve_din_reevaluare;
            BilantContabil.Rows[20].Cells[1].Value = bilant.Rezerve;
            BilantContabil.Rows[21].Cells[1].Value = bilant.Profit_pierdere_reportata;
            BilantContabil.Rows[22].Cells[1].Value = bilant.Profit_pierdere_curent;
            BilantContabil.Rows[22].Height = 50;

            bilantToolStripMenuItem.Text = "&Bilant";
            cppToolStripMenuItem.Text = "&CPP";
            infoToolStripMenuItem.Text = "&Info";
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
                        bilant.Active_imobilizate += suma;
                        bilant.Imobilizari_corporale += suma;
                        bilant.Active_minus_datorii += suma;
                        BilantContabil.Rows[0].Cells[1].Value = bilant.Active_imobilizate;
                        BilantContabil.Rows[1].Cells[1].Value = bilant.Imobilizari_corporale;
                        BilantContabil.Rows[12].Cells[1].Value = bilant.Active_minus_datorii;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;                    
                    }

                    else if (cont.Substring(0, 2) == "20")
                    {
                        bilant.Active_imobilizate += suma;
                        bilant.Imobilizari_necorporale += suma;
                        bilant.Active_minus_datorii += suma;
                        BilantContabil.Rows[0].Cells[1].Value = bilant.Active_imobilizate;
                        BilantContabil.Rows[2].Cells[1].Value = bilant.Imobilizari_necorporale;
                        BilantContabil.Rows[12].Cells[1].Value = bilant.Active_minus_datorii;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;                      
                    }

                    else if (cont.Substring(0, 2) == "26")
                    {          
                        bilant.Active_imobilizate += suma;
                        bilant.Imobilizari_financiare += suma;
                        bilant.Active_minus_datorii += suma;
                        BilantContabil.Rows[0].Cells[1].Value = bilant.Active_imobilizate;
                        BilantContabil.Rows[3].Cells[1].Value = bilant.Imobilizari_financiare;
                        BilantContabil.Rows[12].Cells[1].Value = bilant.Active_minus_datorii;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;                       
                    }

                    else if (cont.Substring(0, 1) == "3")
                    {
                        bilant.Stocuri += suma;
                        bilant.Active_circulante += suma;
                        bilant.Active_circulante_nete += suma;
                        bilant.Active_minus_datorii += suma;
                        BilantContabil.Rows[4].Cells[1].Value = bilant.Active_circulante;
                        BilantContabil.Rows[5].Cells[1].Value = bilant.Stocuri;
                        BilantContabil.Rows[11].Cells[1].Value = bilant.Active_circulante_nete;
                        BilantContabil.Rows[12].Cells[1].Value = bilant.Active_minus_datorii;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring (0, 2) == "41")
                    {
                        bilant.Creante += suma;
                        bilant.Active_circulante += suma;
                        bilant.Active_circulante_nete += suma;
                        bilant.Active_minus_datorii += suma;
                        BilantContabil.Rows[4].Cells[1].Value = bilant.Active_circulante;
                        BilantContabil.Rows[6].Cells[1].Value = bilant.Creante;
                        BilantContabil.Rows[11].Cells[1].Value = bilant.Active_circulante_nete;
                        BilantContabil.Rows[12].Cells[1].Value = bilant.Active_minus_datorii;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 2) == "50")
                    {
                        bilant.Investitii_pe_termen_scurt += suma;
                        bilant.Active_circulante += suma;
                        bilant.Active_circulante_nete += suma;
                        bilant.Active_minus_datorii += suma;
                        BilantContabil.Rows[4].Cells[1].Value = bilant.Active_circulante;
                        BilantContabil.Rows[7].Cells[1].Value = bilant.Investitii_pe_termen_scurt;
                        BilantContabil.Rows[11].Cells[1].Value = bilant.Active_circulante_nete;
                        BilantContabil.Rows[12].Cells[1].Value = bilant.Active_minus_datorii;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 2) == "51")
                    {
                        bilant.Casa_si_conturi_la_banci += suma;
                        bilant.Active_circulante += suma;
                        bilant.Active_circulante_nete += suma;
                        bilant.Active_minus_datorii += suma;
                        BilantContabil.Rows[4].Cells[1].Value = bilant.Active_circulante;
                        BilantContabil.Rows[8].Cells[1].Value = bilant.Casa_si_conturi_la_banci;
                        BilantContabil.Rows[11].Cells[1].Value = bilant.Active_circulante_nete;
                        BilantContabil.Rows[12].Cells[1].Value = bilant.Active_minus_datorii;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 3) == "471")
                    {
                        bilant.Cheltuieli_in_avans += suma;
                        bilant.Active_circulante_nete += suma;
                        bilant.Active_minus_datorii += suma;
                        BilantContabil.Rows[9].Cells[1].Value = bilant.Cheltuieli_in_avans;
                        BilantContabil.Rows[11].Cells[1].Value = bilant.Active_circulante_nete;
                        BilantContabil.Rows[12].Cells[1].Value = bilant.Active_minus_datorii;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 2) == "40" || cont.Substring(0, 2) == "44" || cont.Substring(0, 2) == "45" || cont.Substring(0, 2) == "46")
                    {
                        bilant.Datorii_termen_scurt += suma;
                        bilant.Active_circulante_nete -= suma;
                        bilant.Active_minus_datorii -= suma;
                        BilantContabil.Rows[10].Cells[1].Value = bilant.Datorii_termen_scurt;
                        BilantContabil.Rows[11].Cells[1].Value = bilant.Active_circulante_nete;
                        BilantContabil.Rows[12].Cells[1].Value = bilant.Active_minus_datorii;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 2) == "42" || cont.Substring(0, 2) == "43" || cont.Substring(0, 2) == "48" || cont.Substring(0, 2) == "49")
                    {
                        bilant.Datorii_termen_lung += suma;
                        BilantContabil.Rows[13].Cells[1].Value = bilant.Datorii_termen_lung;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 3) == "472")
                    {
                        bilant.Venituri_in_avans += suma;
                        BilantContabil.Rows[14].Cells[1].Value = bilant.Venituri_in_avans;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 3) == "101" || cont.Substring(0, 3) == "103")
                    {
                        bilant.Capital += suma;
                        bilant.Capital_si_rezerve += suma;
                        BilantContabil.Rows[16].Cells[1].Value = bilant.Capital_si_rezerve;
                        BilantContabil.Rows[17].Cells[1].Value = bilant.Capital;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 3) == "104")
                    {
                        bilant.Prime_de_capital += suma;
                        bilant.Capital_si_rezerve += suma;
                        BilantContabil.Rows[16].Cells[1].Value = bilant.Capital_si_rezerve;
                        BilantContabil.Rows[18].Cells[1].Value = bilant.Prime_de_capital;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 3) == "105")
                    {
                        bilant.Rezerve_din_reevaluare += suma;
                        bilant.Capital_si_rezerve += suma;
                        BilantContabil.Rows[16].Cells[1].Value = bilant.Capital_si_rezerve;
                        BilantContabil.Rows[19].Cells[1].Value = bilant.Rezerve_din_reevaluare;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 3) == "106")
                    {
                        bilant.Rezerve += suma;
                        bilant.Capital_si_rezerve += suma;
                        BilantContabil.Rows[16].Cells[1].Value = bilant.Capital_si_rezerve;
                        BilantContabil.Rows[20].Cells[1].Value = bilant.Rezerve;
                        tbCont.Clear();
                        cbTip.SelectedIndex = -1;
                        tbSuma.Clear();
                        suma = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Suma introdusa nu este valida.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                            
            }
            else
            {
                MessageBox.Show("Contul introdus nu este valid.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (cbSalvare.Text == "binar")
            {
                SaveFileDialog fisierBinar = new SaveFileDialog();
                fisierBinar.Filter = "Fisier binar (*.bin)|*.bin";
                fisierBinar.Title = "Bilant Contabil";
                if (fisierBinar.ShowDialog() == DialogResult.OK)
                {
                    List<object[]> dataToSave = new List<object[]>();
                    foreach (DataGridViewRow row in BilantContabil.Rows)
                    {

                        object[] rowData = new object[row.Cells.Count];
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            rowData[i] = row.Cells[i].Value;
                        }
                        dataToSave.Add(rowData);
                    }

                    using (FileStream fileStream = new FileStream(fisierBinar.FileName, FileMode.Create))
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        binaryFormatter.Serialize(fileStream, dataToSave);
                    }
                }
            }
        }

        private void btnPreia_Click(object sender, EventArgs e)
        {
            if (cbPreluare.Text == "binar")
            {
                OpenFileDialog fisierBinar = new OpenFileDialog();
                fisierBinar.Filter = "Fisier binar (*.bin)|*.bin";
                fisierBinar.Title = "Bilant Contabil";
                if (fisierBinar.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fileStream = new FileStream(fisierBinar.FileName, FileMode.Open))
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        List<object[]> loadedData = (List<object[]>)binaryFormatter.Deserialize(fileStream);

                        BilantContabil.Rows.Clear();

                        foreach (object[] rowData in loadedData)
                        {
                            BilantContabil.Rows.Add(rowData);
                        }
                        BilantContabil.Rows[7].Height = 50;
                        BilantContabil.Rows[10].Height = 50;
                        BilantContabil.Rows[13].Height = 50;
                        BilantContabil.Rows[22].Height = 50;
                    }
                }
            }
        }

        private void cmsModificaSuma_MouseClick(object sender, MouseEventArgs e)
        {
            if (BilantContabil.SelectedCells.Count > 0)
            {
                DataGridViewCell celulaSelectata = BilantContabil.SelectedCells[0];

                if (celulaSelectata.ColumnIndex == 1)
                {
                    Rectangle dreptunghiCelula = BilantContabil.GetCellDisplayRectangle(celulaSelectata.ColumnIndex, celulaSelectata.RowIndex, true);

                    using (Form modificaForm = new Form())
                    {
                        modificaForm.Size = new Size(200, 100);
                        modificaForm.StartPosition = FormStartPosition.Manual;
                        modificaForm.Location = BilantContabil.PointToScreen(new Point(dreptunghiCelula.X, dreptunghiCelula.Y));

                        TextBox textBox = new TextBox
                        {
                            Location = new Point(10, 10),
                            Width = 160,
                            Text = celulaSelectata.Value?.ToString()
                        };

                        textBox.KeyDown += (s, args) =>
                        {
                            if (args.KeyCode == Keys.Enter)
                            {
                                ConfirmValue();
                                args.Handled = true;                          
                            }
                        };

                        Button btnConfirmare = new Button
                        {
                            Text = "Confirma",
                            Location = new Point(10, 40),
                            Width = 160
                        };

                        btnConfirmare.Click += (s, args) =>
                        {
                            ConfirmValue();
                        };

                        void ConfirmValue()
                        {
                            if (double.TryParse(textBox.Text, out double newValue))
                            {
                                celulaSelectata.Value = newValue;
                                modificaForm.Close();
                            }
                            else
                            {
                                MessageBox.Show("Introduceti o valoare numerica valida.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }


                        modificaForm.Controls.Add(textBox);
                        modificaForm.Controls.Add(btnConfirmare);
                        modificaForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                        modificaForm.MaximizeBox = false;
                        modificaForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Modificarile sunt permise doar pentru coloana cu valori.", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bilantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bilant bilantContabilNou = new Bilant();
            bilantContabilNou.Show();
        }

        private void cppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPP contProfitPierdereNou = new CPP();
            contProfitPierdereNou.Show();
        }
    }
}
