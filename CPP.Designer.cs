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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ContProfitPierdere = new System.Windows.Forms.DataGridView();
            this.elemente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCont = new System.Windows.Forms.TextBox();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ContProfitPierdere)).BeginInit();
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ContProfitPierdere.DefaultCellStyle = dataGridViewCellStyle2;
            this.ContProfitPierdere.Location = new System.Drawing.Point(2, -1);
            this.ContProfitPierdere.Name = "ContProfitPierdere";
            this.ContProfitPierdere.ReadOnly = true;
            this.ContProfitPierdere.RowHeadersWidth = 51;
            this.ContProfitPierdere.RowTemplate.Height = 24;
            this.ContProfitPierdere.Size = new System.Drawing.Size(645, 715);
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
            // CPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 926);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.tbCont);
            this.Controls.Add(this.ContProfitPierdere);
            this.Name = "CPP";
            this.Text = "CPP";
            ((System.ComponentModel.ISupportInitialize)(this.ContProfitPierdere)).EndInit();
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
    }
}