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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BilantContabil = new System.Windows.Forms.DataGridView();
            this.denumire_element = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCont = new System.Windows.Forms.TextBox();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.adauga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BilantContabil)).BeginInit();
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BilantContabil.DefaultCellStyle = dataGridViewCellStyle2;
            this.BilantContabil.Location = new System.Drawing.Point(-1, 0);
            this.BilantContabil.Name = "BilantContabil";
            this.BilantContabil.RowHeadersWidth = 51;
            this.BilantContabil.RowTemplate.Height = 24;
            this.BilantContabil.Size = new System.Drawing.Size(710, 677);
            this.BilantContabil.TabIndex = 0;
            // 
            // denumire_element
            // 
            this.denumire_element.Frozen = true;
            this.denumire_element.HeaderText = "Denumirea Elementului";
            this.denumire_element.MinimumWidth = 6;
            this.denumire_element.Name = "denumire_element";
            this.denumire_element.Width = 320;
            // 
            // sold
            // 
            this.sold.Frozen = true;
            this.sold.HeaderText = "Sold ";
            this.sold.MinimumWidth = 6;
            this.sold.Name = "sold";
            this.sold.Width = 170;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(735, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cont";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(736, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(736, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
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
            // cbTip
            // 
            this.cbTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "Activ",
            "Datorie",
            "Capital Propriu"});
            this.cbTip.Location = new System.Drawing.Point(836, 117);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(141, 28);
            this.cbTip.TabIndex = 5;
            // 
            // tbSuma
            // 
            this.tbSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSuma.Location = new System.Drawing.Point(854, 182);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(100, 26);
            this.tbSuma.TabIndex = 6;
            // 
            // adauga
            // 
            this.adauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.adauga.Location = new System.Drawing.Point(854, 236);
            this.adauga.Name = "adauga";
            this.adauga.Size = new System.Drawing.Size(100, 40);
            this.adauga.TabIndex = 7;
            this.adauga.Text = "Adauga";
            this.adauga.UseVisualStyleBackColor = true;
            this.adauga.Click += new System.EventHandler(this.adauga_Click);
            // 
            // Bilant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 784);
            this.Controls.Add(this.adauga);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.tbCont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BilantContabil);
            this.Name = "Bilant";
            this.Text = "Bilant";
            ((System.ComponentModel.ISupportInitialize)(this.BilantContabil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BilantContabil;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumire_element;
        private System.Windows.Forms.DataGridViewTextBoxColumn sold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCont;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.Button adauga;
    }
}