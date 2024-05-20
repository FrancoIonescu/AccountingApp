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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ContProfitPierdere = new System.Windows.Forms.DataGridView();
            this.elemente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCont = new System.Windows.Forms.TextBox();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSalvare = new System.Windows.Forms.ComboBox();
            this.cbPreluare = new System.Windows.Forms.ComboBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnPreia = new System.Windows.Forms.Button();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.bilantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsModificaSuma = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ContProfitPierdere)).BeginInit();
            this.msMenu.SuspendLayout();
            this.cmsModificaSuma.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ContProfitPierdere.DefaultCellStyle = dataGridViewCellStyle1;
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
            this.label4.Location = new System.Drawing.Point(667, 369);
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
            "xml"});
            this.cbSalvare.Location = new System.Drawing.Point(777, 248);
            this.cbSalvare.Name = "cbSalvare";
            this.cbSalvare.Size = new System.Drawing.Size(141, 28);
            this.cbSalvare.TabIndex = 8;
            // 
            // cbPreluare
            // 
            this.cbPreluare.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPreluare.FormattingEnabled = true;
            this.cbPreluare.Items.AddRange(new object[] {
            "binar",
            "xml"});
            this.cbPreluare.Location = new System.Drawing.Point(777, 368);
            this.cbPreluare.Name = "cbPreluare";
            this.cbPreluare.Size = new System.Drawing.Size(141, 28);
            this.cbPreluare.TabIndex = 9;
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
            // btnPreia
            // 
            this.btnPreia.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.btnPreia.Location = new System.Drawing.Point(803, 419);
            this.btnPreia.Name = "btnPreia";
            this.btnPreia.Size = new System.Drawing.Size(93, 41);
            this.btnPreia.TabIndex = 11;
            this.btnPreia.Text = "Preia";
            this.btnPreia.UseVisualStyleBackColor = true;
            this.btnPreia.Click += new System.EventHandler(this.btnPreia_Click);
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
            // cmsModificaSuma
            // 
            this.cmsModificaSuma.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsModificaSuma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificaToolStripMenuItem});
            this.cmsModificaSuma.Name = "cmsModificaSuma";
            this.cmsModificaSuma.Size = new System.Drawing.Size(211, 56);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // CPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 737);
            this.Controls.Add(this.btnPreia);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.cbPreluare);
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
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.cmsModificaSuma.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cbPreluare;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnPreia;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem bilantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsModificaSuma;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
    }
}