using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilitate
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.BackColor = Color.SeaGreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            bilantToolStripMenuItem.Text = "&Bilant";
            cppToolStripMenuItem.Text = "&CPP";
            infoToolStripMenuItem.Text = "&Info";
        }

        private void Bilant_Click(object sender, EventArgs e)
        {
            Bilant bilantForm = new Bilant();
            bilantForm.Show();
        }

        private void CPP_Click(object sender, EventArgs e)
        {
            CPP cppForm = new CPP();
            cppForm.Show();
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
