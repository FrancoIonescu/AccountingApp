using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilitate
{
    public class Elemente
    {
        private float active_imobilizate;
        private float imobilizari_corporale;
        private float imobilizari_necorporale;
        private float imobilizari_financiare;
        private float active_circulante;
        private float stocuri;
        private float creante;
        private float investitii_pe_termen_scurt;
        private float casa_si_conturi_la_banci;
        private float cheltuieli_in_avans;
        private float datorii_termen_scurt;
        private float active_circulante_nete;
        private float active_minus_datorii;
        private float datorii_termen_lung;
        private float provizioane;
        private float venituri_in_avans;
        private float capital_si_rezerve;
        private float capital;
        private float prime_de_capital;
        private float rezerve_din_reevaluare;
        private float rezerve;
        private float profit_pierdere_reportata;
        private float profit_pierdere_curent;

        public Elemente() {}

        public Elemente(float active_imobilizate, float imobilizari_corporale, float imobilizari_necorporale, float imobilizari_financiare, float active_circulante, float stocuri, float creante, float investitii_pe_termen_scurt, float casa_si_conturi_la_banci, float cheltuieli_in_avans, float datorii_termen_scurt, float active_circulante_nete, float active_minus_datorii, float datorii_termen_lung, float provizioane, float venituri_in_avans, float capital_si_rezerve, float capital, float prime_de_capital, float rezerve_din_reevaluare, float rezerve, float profit_pierdere_reportata, float profit_pierdere_curent)
        {
            this.active_imobilizate = active_imobilizate;
            this.imobilizari_corporale = imobilizari_corporale;
            this.imobilizari_necorporale = imobilizari_necorporale;
            this.imobilizari_financiare = imobilizari_financiare;
            this.active_circulante = active_circulante;
            this.stocuri = stocuri;
            this.creante = creante;
            this.investitii_pe_termen_scurt = investitii_pe_termen_scurt;
            this.casa_si_conturi_la_banci = casa_si_conturi_la_banci;
            this.cheltuieli_in_avans = cheltuieli_in_avans;
            this.datorii_termen_scurt = datorii_termen_scurt;
            this.active_circulante_nete = active_circulante_nete;
            this.active_minus_datorii = active_minus_datorii;
            this.datorii_termen_lung = datorii_termen_lung;
            this.provizioane = provizioane;
            this.venituri_in_avans = venituri_in_avans;
            this.capital_si_rezerve = capital_si_rezerve;
            this.capital = capital;
            this.prime_de_capital = prime_de_capital;
            this.rezerve_din_reevaluare = rezerve_din_reevaluare;
            this.rezerve = rezerve;
            this.profit_pierdere_reportata = profit_pierdere_reportata;
            this.profit_pierdere_curent = profit_pierdere_curent;
        }

        public float Active_imobilizate
        { 
            get { return active_imobilizate; } 
            set { active_imobilizate = value; } 
        }

        public float Imobilizari_corporale 
        {
            get { return imobilizari_corporale; }
            set { imobilizari_corporale = value; } 
        }

        public float Imobilizari_necorporale
        {
            get { return imobilizari_necorporale; }
            set { imobilizari_necorporale = value; }
        }

        public float Imobilizari_financiare
        {
            get { return imobilizari_financiare; }
            set { imobilizari_financiare = value; }
        }

        public float Active_circulante
        {
            get { return active_circulante; }
            set { active_circulante = value; }
        }

        public float Stocuri
        {
            get { return stocuri; }
            set { stocuri = value; }
        }

        public float Creante
        {
            get { return creante; }
            set { creante = value; }
        }

        public float Investitii_pe_termen_scurt
        {
            get { return investitii_pe_termen_scurt; }
            set { investitii_pe_termen_scurt = value; }
        }

        public float Casa_si_conturi_la_banci
        {
            get { return casa_si_conturi_la_banci; }
            set { casa_si_conturi_la_banci = value; }
        }

        public float Cheltuieli_in_avans
        {
            get { return cheltuieli_in_avans; }
            set { cheltuieli_in_avans = value; }
        }

        public float Datorii_termen_scurt
        {
            get { return datorii_termen_scurt; }
            set { datorii_termen_scurt = value; }
        }

        public float Active_circulante_nete
        {
            get { return active_circulante_nete; }
            set { active_circulante_nete = value; }
        }

        public float Active_minus_datorii
        {
            get { return active_minus_datorii; }
            set { active_minus_datorii = value; }
        }

        public float Datorii_termen_lung
        {
            get { return datorii_termen_lung; }
            set { datorii_termen_lung = value; }
        }

        public float Provizioane
        {
            get { return provizioane; }
            set { provizioane = value; }
        }

        public float Venituri_in_avans
        {
            get { return venituri_in_avans; }
            set { venituri_in_avans = value; }
        }

        public float Capital_si_rezerve
        {
            get { return capital_si_rezerve; }
            set { capital_si_rezerve = value; }
        }

        public float Capital
        {
            get { return capital; }
            set { capital = value; }
        }

        public float Prime_de_capital
        {
            get { return prime_de_capital; }
            set { prime_de_capital = value; }
        }

        public float Rezerve_din_reevaluare
        {
            get { return rezerve_din_reevaluare; }
            set { rezerve_din_reevaluare = value; }
        }
        public float Rezerve
        {
            get { return rezerve; }
            set { rezerve = value; }
        }

        public float Profit_pierdere_reportata
        {
            get { return profit_pierdere_reportata; }
            set { profit_pierdere_reportata = value; }
        }

        public float Profit_pierdere_curent
        {
            get { return profit_pierdere_curent; }
            set { profit_pierdere_curent = value; }
        }

    }
}
