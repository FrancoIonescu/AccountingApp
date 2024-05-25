namespace Contabilitate
{
    partial class CPP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ContProfitPierdere = new System.Windows.Forms.DataGridView();
            this.elemente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsModificaSuma = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCont = new System.Windows.Forms.TextBox();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSalvare = new System.Windows.Forms.ComboBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.bilantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelPreluare = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ContProfitPierdere)).BeginInit();
            this.cmsModificaSuma.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.panelPreluare.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContProfitPierdere
            // 
            this.ContProfitPierdere.AllowDrop = true;
            this.ContProfitPierdere.AllowUserToAddRows = false;
            this.ContProfitPierdere.AllowUserToDeleteRows = false;
            this.ContProfitPierdere.ColumnHeadersHeight = 29;
            this.ContProfitPierdere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.elemente,
            this.sume});
            this.ContProfitPierdere.ContextMenuStrip = this.cmsModificaSuma;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ContProfitPierdere.DefaultCellStyle = dataGridViewCellStyle2;
            this.ContProfitPierdere.Location = new System.Drawing.Point(0, 31);
            this.ContProfitPierdere.Name = "ContProfitPierdere";
            this.ContProfitPierdere.ReadOnly = true;
            this.ContProfitPierdere.RowHeadersWidth = 51;
            this.ContProfitPierdere.RowTemplate.Height = 24;
            this.ContProfitPierdere.Size = new System.Drawing.Size(645, 492);
            this.ContProfitPierdere.TabIndex = 0;
            // 
            // elemente
            // 
            this.elemente.Frozen = true;
            this.elemente.HeaderText = "Elemente";
            this.elemente.MinimumWidth = 6;
            this.elemente.Name = "elemente";
            this.elemente.ReadOnly = true;
            this.elemente.Width = 250;
            // 
            // sume
            // 
            this.sume.HeaderText = "Sume";
            this.sume.MinimumWidth = 6;
            this.sume.Name = "sume";
            this.sume.ReadOnly = true;
            this.sume.Width = 181;
            // 
            // cmsModificaSuma
            // 
            this.cmsModificaSuma.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsModificaSuma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificaToolStripMenuItem});
            this.cmsModificaSuma.Name = "cmsModificaSuma";
            this.cmsModificaSuma.Size = new System.Drawing.Size(138, 28);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // tbCont
            // 
            this.tbCont.Location = new System.Drawing.Point(777, 45);
            this.tbCont.Name = "tbCont";
            this.tbCont.Size = new System.Drawing.Size(150, 22);
            this.tbCont.TabIndex = 1;
            // 
            // tbSuma
            // 
            this.tbSuma.Location = new System.Drawing.Point(777, 103);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(150, 22);
            this.tbSuma.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(664, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cont";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(667, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suma";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(803, 155);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(93, 45);
            this.btnAdauga.TabIndex = 5;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F);
            this.label3.Location = new System.Drawing.Point(664, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salvare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F);
            this.label4.Location = new System.Drawing.Point(667, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preluare";
            // 
            // cbSalvare
            // 
            this.cbSalvare.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalvare.FormattingEnabled = true;
            this.cbSalvare.Items.AddRange(new object[] {
            "binar",
            "csv"});
            this.cbSalvare.Location = new System.Drawing.Point(777, 248);
            this.cbSalvare.Name = "cbSalvare";
            this.cbSalvare.Size = new System.Drawing.Size(150, 28);
            this.cbSalvare.TabIndex = 8;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.btnSalveaza.Location = new System.Drawing.Point(803, 300);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(93, 36);
            this.btnSalveaza.TabIndex = 10;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // msMenu
            // 
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilantToolStripMenuItem,
            this.cppToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(995, 28);
            this.msMenu.TabIndex = 12;
            this.msMenu.Text = "menuStrip1";
            // 
            // bilantToolStripMenuItem
            // 
            this.bilantToolStripMenuItem.Name = "bilantToolStripMenuItem";
            this.bilantToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.bilantToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.bilantToolStripMenuItem.Text = "Bilant";
            this.bilantToolStripMenuItem.Click += new System.EventHandler(this.bilantToolStripMenuItem_Click);
            // 
            // cppToolStripMenuItem
            // 
            this.cppToolStripMenuItem.Name = "cppToolStripMenuItem";
            this.cppToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.cppToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.cppToolStripMenuItem.Text = "CPP";
            this.cppToolStripMenuItem.Click += new System.EventHandler(this.cppToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label6.Location = new System.Drawing.Point(14, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "DRAG HERE";
            // 
            // panelPreluare
            // 
            this.panelPreluare.AllowDrop = true;
            this.panelPreluare.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelPreluare.Controls.Add(this.label6);
            this.panelPreluare.Location = new System.Drawing.Point(777, 389);
            this.panelPreluare.Name = "panelPreluare";
            this.panelPreluare.Size = new System.Drawing.Size(150, 94);
            this.panelPreluare.TabIndex = 15;
            this.panelPreluare.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPreluare_DragDrop);
            this.panelPreluare.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPreluare_DragEnter);
            // 
            // CPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 737);
            this.Controls.Add(this.panelPreluare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.cbSalvare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.tbCont);
            this.Controls.Add(this.ContProfitPierdere);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "CPP";
            this.Text = "CPP";
            ((System.ComponentModel.ISupportInitialize)(this.ContProfitPierdere)).EndInit();
            this.cmsModificaSuma.ResumeLayout(false);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.panelPreluare.ResumeLayout(false);
            this.panelPreluare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ContProfitPierdere;
        private System.Windows.Forms.DataGridViewTextBoxColumn elemente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sume;
        private System.Windows.Forms.TextBox tbCont;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSalvare;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem bilantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsModificaSuma;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelPreluare;
    }
}