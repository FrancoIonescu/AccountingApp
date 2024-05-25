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

namespace Contabilitate
{
    public partial class CPP : Form
    {
        ContCPP cpp = new ContCPP();
        public CPP()
        {
            InitializeComponent();
            this.Width = 750;
            this.Height = 465;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            Font font = new Font("Arial", 13, FontStyle.Regular);
            ContProfitPierdere.Font = font;
            ContProfitPierdere.Rows.Add("Venituri din exploatare");
            ContProfitPierdere.Rows.Add("Cheltuieli din exploatare");
            ContProfitPierdere.Rows.Add("Profitul sau pierderea din exploatare");
            ContProfitPierdere.Rows.Add("Venituri financiare");
            ContProfitPierdere.Rows.Add("Cheltuieli financiare");
            ContProfitPierdere.Rows.Add("Profitul sau pierderea financiar/a");
            ContProfitPierdere.Rows.Add("Venituri totale");
            ContProfitPierdere.Rows.Add("Cheltuieli totale");
            ContProfitPierdere.Rows.Add("Profitul sau pierderea brut/a");
            ContProfitPierdere.Rows.Add("Cheltuieli cu impozitul pe profit");
            ContProfitPierdere.Rows.Add("Profitul sau pierderea net/a");
            ContProfitPierdere.Rows[2].Height = 50;
            ContProfitPierdere.Rows[5].Height = 50;
            ContProfitPierdere.Rows[9].Height = 50;
            ContProfitPierdere.Rows[10].Height = 50;
            ContProfitPierdere.Rows[0].Cells[1].Value = cpp.Venituri_din_exploatare;
            ContProfitPierdere.Rows[1].Cells[1].Value = cpp.Cheltuieli_din_exploatare;
            ContProfitPierdere.Rows[2].Cells[1].Value = cpp.Profit_pierdere_exploatare;
            ContProfitPierdere.Rows[3].Cells[1].Value = cpp.Venituri_financiare;
            ContProfitPierdere.Rows[4].Cells[1].Value = cpp.Cheltuieli_financiare;
            ContProfitPierdere.Rows[5].Cells[1].Value = cpp.Profit_pierdere_financiar;
            ContProfitPierdere.Rows[6].Cells[1].Value = cpp.Venituri_totale;
            ContProfitPierdere.Rows[7].Cells[1].Value = cpp.Cheltuieli_totale;
            ContProfitPierdere.Rows[8].Cells[1].Value = cpp.Profit_pierdere_brut;
            ContProfitPierdere.Rows[9].Cells[1].Value = cpp.Cheltuieli_impozit_profit;
            ContProfitPierdere.Rows[10].Cells[1].Value = cpp.Profit_pierdere_net;

            bilantToolStripMenuItem.Text = "&Bilant";
            cppToolStripMenuItem.Text = "&CPP";
            infoToolStripMenuItem.Text = "&Info";
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (tbCont.Text.All(char.IsDigit) && (tbCont.Text.Length == 3 || tbCont.Text.Length == 4))
            {
                float suma;
                if (float.TryParse(tbSuma.Text, out suma))
                {
                    string cont = tbCont.Text;

                    if (cont.Substring(0, 1) == "7" && cont.Substring(0, 2) != "76")
                    {
                        cpp.Venituri_din_exploatare += suma;
                        cpp.Profit_pierdere_exploatare += suma;
                        cpp.Venituri_totale += suma;
                        ContProfitPierdere.Rows[0].Cells[1].Value = cpp.Venituri_din_exploatare;
                        ContProfitPierdere.Rows[2].Cells[1].Value = cpp.Venituri_din_exploatare;
                        ContProfitPierdere.Rows[6].Cells[1].Value = cpp.Venituri_totale;
                        tbCont.Clear();
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 2) == "76")
                    {
                        cpp.Venituri_financiare += suma;
                        cpp.Profit_pierdere_financiar += suma;
                        cpp.Venituri_totale += suma;
                        ContProfitPierdere.Rows[3].Cells[1].Value = cpp.Venituri_financiare;
                        ContProfitPierdere.Rows[5].Cells[1].Value = cpp.Profit_pierdere_financiar;
                        ContProfitPierdere.Rows[6].Cells[1].Value = cpp.Venituri_totale;
                        tbCont.Clear();
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 1) == "6" && cont.Substring(0, 2) != "66" && cont.Substring(0, 3) != "691") 
                    {
                        cpp.Cheltuieli_din_exploatare += suma;
                        cpp.Profit_pierdere_exploatare -= suma;
                        cpp.Cheltuieli_totale += suma;
                        ContProfitPierdere.Rows[1].Cells[1].Value = cpp.Cheltuieli_din_exploatare;
                        ContProfitPierdere.Rows[2].Cells[1].Value = cpp.Profit_pierdere_exploatare;
                        ContProfitPierdere.Rows[7].Cells[1].Value = cpp.Cheltuieli_totale;
                        tbCont.Clear();
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 2) == "66")
                    {
                        cpp.Cheltuieli_financiare += suma;
                        cpp.Profit_pierdere_financiar -= suma;
                        cpp.Cheltuieli_totale += suma;
                        ContProfitPierdere.Rows[4].Cells[1].Value = cpp.Cheltuieli_financiare;
                        ContProfitPierdere.Rows[5].Cells[1].Value = cpp.Profit_pierdere_financiar;
                        ContProfitPierdere.Rows[7].Cells[1].Value = cpp.Cheltuieli_totale;
                        tbCont.Clear();
                        tbSuma.Clear();
                        suma = 0;
                    }

                    else if (cont.Substring(0, 3) == "691")
                    {
                        cpp.Cheltuieli_impozit_profit += suma;
                        ContProfitPierdere.Rows[9].Cells[1].Value = cpp.Cheltuieli_impozit_profit;
                        tbCont.Clear();
                        tbSuma.Clear();
                        suma = 0;
                    }  

                    else
                    {
                        MessageBox.Show("Contul nu este recunoscut");
                    }

                    ContProfitPierdere.Rows[8].Cells[1].Value = cpp.Venituri_totale - cpp.Cheltuieli_totale;
                    cpp.Profit_pierdere_brut = cpp.Profit_pierdere_brut = float.Parse(ContProfitPierdere.Rows[8].Cells[1].Value.ToString());

                    if (cpp.Cheltuieli_impozit_profit > 0)
                    {
                        ContProfitPierdere.Rows[10].Cells[1].Value = cpp.Profit_pierdere_brut - cpp.Cheltuieli_impozit_profit;
                    }
                }

                else
                {
                    MessageBox.Show("Suma introdusa nu este valida!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Contul introdus nu este corect!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (cbSalvare.Text == "binar")
            {
                SaveFileDialog fisierBinar = new SaveFileDialog();
                fisierBinar.Filter = "Fisier binar (*.bin)|*.bin";
                fisierBinar.Title = "CPP";
                if (fisierBinar.ShowDialog() == DialogResult.OK)
                {
                    List<object[]> dataToSave = new List<object[]>();
                    foreach (DataGridViewRow row in ContProfitPierdere.Rows)
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
            if (cbSalvare.Text == "csv")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Fișier CSV (*.csv)|*.csv";
                saveFileDialog.Title = "Salvează contul de profit si pierdere ca CSV";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder csvData = new StringBuilder();

                    // Adaugă antetul coloanelor
                    for (int i = 0; i < ContProfitPierdere.Columns.Count; i++)
                    {
                        csvData.Append(ContProfitPierdere.Columns[i].HeaderText);
                        if (i < ContProfitPierdere.Columns.Count - 1)
                        {
                            csvData.Append(",");
                        }
                    }
                    csvData.AppendLine();

                    foreach (DataGridViewRow row in ContProfitPierdere.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            csvData.Append(row.Cells[i].Value.ToString().Replace(",", ";"));
                            if (i < row.Cells.Count - 1)
                            {
                                csvData.Append(",");
                            }
                        }
                        csvData.AppendLine();
                    }

                    File.WriteAllText(saveFileDialog.FileName, csvData.ToString());
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

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContProfitPierdere.SelectedCells.Count > 0)
            {
                DataGridViewCell celulaSelectata = ContProfitPierdere.SelectedCells[0];

                if (celulaSelectata.ColumnIndex == 1)
                {
                    Rectangle dreptunghiCelula = ContProfitPierdere.GetCellDisplayRectangle(celulaSelectata.ColumnIndex, celulaSelectata.RowIndex, true);

                    using (Form modificaForm = new Form())
                    {
                        modificaForm.Size = new Size(200, 100);
                        modificaForm.StartPosition = FormStartPosition.Manual;
                        modificaForm.Location = ContProfitPierdere.PointToScreen(new Point(dreptunghiCelula.X, dreptunghiCelula.Y));

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

        private void incarcaDateDinFisierBinar(string filePath)
        {
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    List<object[]> dateIncarcate = (List<object[]>)binaryFormatter.Deserialize(fileStream);

                    ContProfitPierdere.Rows.Clear();

                    foreach (object[] rowData in dateIncarcate)
                    {
                        ContProfitPierdere.Rows.Add(rowData);
                    }

                    ContProfitPierdere.Rows[2].Height = 50;
                    ContProfitPierdere.Rows[5].Height = 50;
                    ContProfitPierdere.Rows[9].Height = 50;
                    ContProfitPierdere.Rows[10].Height = 50;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la incarcarea datelor: {ex.Message}");
            }
        }

        private void incarcaDateDinFisierCSV(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    ContProfitPierdere.Rows.Clear();
                    string[] header = reader.ReadLine().Split(',');
                    foreach (string column in header)
                    {
                        if (!ContProfitPierdere.Columns.Contains(column))
                        {
                            ContProfitPierdere.Columns.Add(column, column);
                        }
                    }

                    while (!reader.EndOfStream)
                    {
                        string[] row = reader.ReadLine().Split(',');
                        for (int i = 0; i < row.Length; i++)
                        {
                            row[i] = row[i].Replace(";", ",");
                        }
                        ContProfitPierdere.Rows.Add(row);
                    }

                    ContProfitPierdere.Rows[2].Height = 50;
                    ContProfitPierdere.Rows[5].Height = 50;
                    ContProfitPierdere.Rows[9].Height = 50;
                    ContProfitPierdere.Rows[10].Height = 50;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la incarcarea datelor din CSV: {ex.Message}");
            }
        }

        private void panelPreluare_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length > 0)
            {
                string filePath = files[0];
                string extension = Path.GetExtension(filePath).ToLower();

                if (extension == ".bin")
                {
                    incarcaDateDinFisierBinar(filePath);
                }
                else if (extension == ".csv")
                {
                    incarcaDateDinFisierCSV(filePath);
                }
                else
                {
                    MessageBox.Show("Fisierul nu este acceptat!");
                }
            }
        }

        private void panelPreluare_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files != null && files.Length > 0)
                {
                    string filePath = files[0];
                    string extension = Path.GetExtension(filePath).ToLower();
                    if (extension == ".bin" || extension == ".csv")
                    {
                        e.Effect = DragDropEffects.Copy;
                    }
                    else
                    {
                        e.Effect = DragDropEffects.None;
                    }
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


    }
}
