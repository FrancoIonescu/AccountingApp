using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilitate
{
    public class ContCPP
    {
        private float venituri_din_exploatare;
        private float cheltuieli_din_exploatare;
        private float profit_pierdere_exploatare;
        private float venituri_financiare;
        private float cheltuieli_financiare;
        private float profit_pierdere_financiar;
        private float venituri_totale;
        private float cheltuieli_totale;
        private float profit_pierdere_brut;
        private float cheltuieli_impozit_profit;
        private float profit_pierdere_net;

        public ContCPP() { }

        public ContCPP(float venituri_din_exploatare, float cheltuieli_din_exploatare, float profit_pierdere_exploatare, float venituri_financiare, float cheltuieli_financiare, float profit_pierdere_financiar, float venituri_totale, float cheltuieli_totale, float profit_pierdere_brut, float cheltuieli_impozit_profit, float profit_pierdere_net)
        {
            this.venituri_din_exploatare = venituri_din_exploatare;
            this.cheltuieli_din_exploatare = cheltuieli_din_exploatare;
            this.profit_pierdere_exploatare = profit_pierdere_exploatare;
            this.venituri_financiare = venituri_financiare;
            this.cheltuieli_financiare = cheltuieli_financiare;
            this.profit_pierdere_financiar = profit_pierdere_financiar;
            this.venituri_totale = venituri_totale;
            this.cheltuieli_totale = cheltuieli_totale;
            this.profit_pierdere_brut = profit_pierdere_brut;
            this.cheltuieli_impozit_profit = cheltuieli_impozit_profit;
            this.profit_pierdere_net = profit_pierdere_net;
        }

        public float Venituri_din_exploatare
        {
            get { return venituri_din_exploatare; }
            set { venituri_din_exploatare = value; }
        }
        public float Cheltuieli_din_exploatare
        {
            get { return cheltuieli_din_exploatare; }
            set { cheltuieli_din_exploatare = value; }
        }
        public float Profit_pierdere_exploatare
        {
            get { return profit_pierdere_exploatare; }
            set { profit_pierdere_exploatare = value; }
        }
        public float Venituri_financiare
        {
            get { return venituri_financiare; }
            set { venituri_financiare = value; }
        }
        public float Cheltuieli_financiare
        {
            get { return cheltuieli_financiare; }
            set { cheltuieli_financiare = value; }
        }
        public float Profit_pierdere_financiar
        {
            get { return profit_pierdere_financiar; }
            set { profit_pierdere_financiar = value; }
        }
        public float Venituri_totale
        {
            get { return venituri_totale; }
            set { venituri_totale = value; }
        }
        public float Cheltuieli_totale
        {
            get { return cheltuieli_totale; }
            set { cheltuieli_totale = value; }
        }
        public float Profit_pierdere_brut
        {
            get { return profit_pierdere_brut; }
            set { profit_pierdere_brut = value; }
        }
        public float Cheltuieli_impozit_profit
        {
            get { return cheltuieli_impozit_profit; }
            set { cheltuieli_impozit_profit = value; }
        }
        public float Profit_pierdere_net
        {
            get { return profit_pierdere_net; }
            set { profit_pierdere_net = value; }
        }
    }
}
