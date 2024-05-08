﻿using System;
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
        Elemente cpp = new Elemente();
        public CPP()
        {
            InitializeComponent();
            this.Width = 750;
            this.Height = 435;
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
        }

        private void btnPreia_Click(object sender, EventArgs e)
        {
            if (cbPreluare.Text == "binar")
            {
                OpenFileDialog fisierBinar = new OpenFileDialog();
                fisierBinar.Filter = "Fisier binar (*.bin)|*.bin";
                fisierBinar.Title = "CPP";
                if (fisierBinar.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fileStream = new FileStream(fisierBinar.FileName, FileMode.Open))
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        List<object[]> loadedData = (List<object[]>)binaryFormatter.Deserialize(fileStream);

                        ContProfitPierdere.Rows.Clear();

                        foreach (object[] rowData in loadedData)
                        {
                            ContProfitPierdere.Rows.Add(rowData);
                        }
                        ContProfitPierdere.Rows[2].Height = 50;
                        ContProfitPierdere.Rows[5].Height = 50;
                        ContProfitPierdere.Rows[9].Height = 50;
                        ContProfitPierdere.Rows[10].Height = 50;
                    }
                }
            }
        }
    }
}
