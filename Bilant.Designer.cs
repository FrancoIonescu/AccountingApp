namespace Contabilitate
{
    partial class Bilant
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
            this.BilantContabil = new System.Windows.Forms.DataGridView();
            this.denumire_element = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsModificaSuma = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCont = new System.Windows.Forms.TextBox();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.adauga = new System.Windows.Forms.Button();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.cbSalvare = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.msMeniu = new System.Windows.Forms.MenuStrip();
            this.bilantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPreluare = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BilantContabil)).BeginInit();
            this.cmsModificaSuma.SuspendLayout();
            this.msMeniu.SuspendLayout();
            this.panelPreluare.SuspendLayout();
            this.SuspendLayout();
            // 
            // BilantContabil
            // 
            this.BilantContabil.AllowDrop = true;
            this.BilantContabil.AllowUserToAddRows = false;
            this.BilantContabil.AllowUserToDeleteRows = false;
            this.BilantContabil.ColumnHeadersHeight = 29;
            this.BilantContabil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumire_element,
            this.sold});
            this.BilantContabil.ContextMenuStrip = this.cmsModificaSuma;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BilantContabil.DefaultCellStyle = dataGridViewCellStyle2;
            this.BilantContabil.Location = new System.Drawing.Point(0, 31);
            this.BilantContabil.Name = "BilantContabil";
            this.BilantContabil.ReadOnly = true;
            this.BilantContabil.RowHeadersWidth = 51;
            this.BilantContabil.RowTemplate.Height = 24;
            this.BilantContabil.Size = new System.Drawing.Size(710, 671);
            this.BilantContabil.TabIndex = 0;
            // 
            // denumire_element
            // 
            this.denumire_element.Frozen = true;
            this.denumire_element.HeaderText = "Denumirea Elementului";
            this.denumire_element.MinimumWidth = 6;
            this.denumire_element.Name = "denumire_element";
            this.denumire_element.ReadOnly = true;
            this.denumire_element.Width = 320;
            // 
            // sold
            // 
            this.sold.Frozen = true;
            this.sold.HeaderText = "Sume";
            this.sold.MinimumWidth = 6;
            this.sold.Name = "sold";
            this.sold.ReadOnly = true;
            this.sold.Width = 170;
            // 
            // cmsModificaSuma
            // 
            this.cmsModificaSuma.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsModificaSuma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificaToolStripMenuItem});
            this.cmsModificaSuma.Name = "cmsModificaSuma";
            this.cmsModificaSuma.Size = new System.Drawing.Size(138, 28);
            this.cmsModificaSuma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmsModificaSuma_MouseClick);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.modificaToolStripMenuItem.Text = "Modifica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(735, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cont";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(735, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Suma";
            // 
            // tbCont
            // 
            this.tbCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbCont.Location = new System.Drawing.Point(836, 54);
            this.tbCont.Name = "tbCont";
            this.tbCont.Size = new System.Drawing.Size(141, 26);
            this.tbCont.TabIndex = 4;
            // 
            // tbSuma
            // 
            this.tbSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSuma.Location = new System.Drawing.Point(836, 114);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(141, 26);
            this.tbSuma.TabIndex = 6;
            // 
            // adauga
            // 
            this.adauga.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adauga.Location = new System.Drawing.Point(854, 172);
            this.adauga.Name = "adauga";
            this.adauga.Size = new System.Drawing.Size(100, 40);
            this.adauga.TabIndex = 7;
            this.adauga.Text = "Adauga";
            this.adauga.UseVisualStyleBackColor = true;
            this.adauga.Click += new System.EventHandler(this.adauga_Click);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.btnSalveaza.Location = new System.Drawing.Point(861, 351);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(93, 36);
            this.btnSalveaza.TabIndex = 16;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // cbSalvare
            // 
            this.cbSalvare.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalvare.FormattingEnabled = true;
            this.cbSalvare.Items.AddRange(new object[] {
            "binar",
            "csv"});
            this.cbSalvare.Location = new System.Drawing.Point(839, 300);
            this.cbSalvare.Name = "cbSalvare";
            this.cbSalvare.Size = new System.Drawing.Size(141, 28);
            this.cbSalvare.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F);
            this.label4.Location = new System.Drawing.Point(726, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Preluare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F);
            this.label5.Location = new System.Drawing.Point(726, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Salvare";
            // 
            // msMeniu
            // 
            this.msMeniu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMeniu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilantToolStripMenuItem,
            this.cppToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.msMeniu.Location = new System.Drawing.Point(0, 0);
            this.msMeniu.Name = "msMeniu";
            this.msMeniu.ShowItemToolTips = true;
            this.msMeniu.Size = new System.Drawing.Size(1012, 28);
            this.msMeniu.TabIndex = 18;
            this.msMeniu.Text = "menuStrip1";
            // 
            // bilantToolStripMenuItem
            // 
            this.bilantToolStripMenuItem.Name = "bilantToolStripMenuItem";
            this.bilantToolStripMenuItem.ShortcutKeyDisplayString = "Keys.B";
            this.bilantToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.bilantToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.bilantToolStripMenuItem.Text = "Bilant";
            this.bilantToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bilantToolStripMenuItem.Click += new System.EventHandler(this.bilantToolStripMenuItem_Click);
            // 
            // cppToolStripMenuItem
            // 
            this.cppToolStripMenuItem.Name = "cppToolStripMenuItem";
            this.cppToolStripMenuItem.ShortcutKeyDisplayString = "";
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
            // panelPreluare
            // 
            this.panelPreluare.AllowDrop = true;
            this.panelPreluare.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelPreluare.Controls.Add(this.label2);
            this.panelPreluare.Location = new System.Drawing.Point(836, 469);
            this.panelPreluare.Name = "panelPreluare";
            this.panelPreluare.Size = new System.Drawing.Size(144, 91);
            this.panelPreluare.TabIndex = 20;
            this.panelPreluare.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPreluare_DragDrop);
            this.panelPreluare.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPreluare_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label2.Location = new System.Drawing.Point(11, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "DRAG HERE";
            // 
            // Bilant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 676);
            this.Controls.Add(this.panelPreluare);
            this.Controls.Add(this.msMeniu);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.cbSalvare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adauga);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.tbCont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BilantContabil);
            this.MainMenuStrip = this.msMeniu;
            this.Name = "Bilant";
            this.Text = "Bilant";
            ((System.ComponentModel.ISupportInitialize)(this.BilantContabil)).EndInit();
            this.cmsModificaSuma.ResumeLayout(false);
            this.msMeniu.ResumeLayout(false);
            this.msMeniu.PerformLayout();
            this.panelPreluare.ResumeLayout(false);
            this.panelPreluare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BilantContabil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCont;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.Button adauga;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumire_element;
        private System.Windows.Forms.DataGridViewTextBoxColumn sold;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.ComboBox cbSalvare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip cmsModificaSuma;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msMeniu;
        private System.Windows.Forms.ToolStripMenuItem bilantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Panel panelPreluare;
        private System.Windows.Forms.Label label2;
    }
}