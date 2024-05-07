namespace Contabilitate
{
    partial class Menu
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
            this.Bilant = new System.Windows.Forms.Button();
            this.titlu = new System.Windows.Forms.Label();
            this.CPP = new System.Windows.Forms.Button();
            this.Meniu = new System.Windows.Forms.MenuStrip();
            this.bilantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Meniu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bilant
            // 
            this.Bilant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bilant.Location = new System.Drawing.Point(326, 165);
            this.Bilant.Name = "Bilant";
            this.Bilant.Size = new System.Drawing.Size(116, 54);
            this.Bilant.TabIndex = 0;
            this.Bilant.Text = "Bilant";
            this.Bilant.UseVisualStyleBackColor = true;
            this.Bilant.Click += new System.EventHandler(this.Bilant_Click);
            // 
            // titlu
            // 
            this.titlu.AutoSize = true;
            this.titlu.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titlu.Location = new System.Drawing.Point(257, 90);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(276, 38);
            this.titlu.TabIndex = 2;
            this.titlu.Text = "CONTABILITATE";
            // 
            // CPP
            // 
            this.CPP.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPP.Location = new System.Drawing.Point(328, 243);
            this.CPP.Name = "CPP";
            this.CPP.Size = new System.Drawing.Size(114, 54);
            this.CPP.TabIndex = 3;
            this.CPP.Text = "CPP";
            this.CPP.UseVisualStyleBackColor = true;
            this.CPP.Click += new System.EventHandler(this.CPP_Click);
            // 
            // Meniu
            // 
            this.Meniu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Meniu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilantToolStripMenuItem,
            this.cppToolStripMenuItem});
            this.Meniu.Location = new System.Drawing.Point(0, 0);
            this.Meniu.Name = "Meniu";
            this.Meniu.Size = new System.Drawing.Size(800, 30);
            this.Meniu.TabIndex = 4;
            this.Meniu.Text = "menuStrip1";
            // 
            // bilantToolStripMenuItem
            // 
            this.bilantToolStripMenuItem.Name = "bilantToolStripMenuItem";
            this.bilantToolStripMenuItem.Size = new System.Drawing.Size(61, 26);
            this.bilantToolStripMenuItem.Text = "Bilant";
            // 
            // cppToolStripMenuItem
            // 
            this.cppToolStripMenuItem.Name = "cppToolStripMenuItem";
            this.cppToolStripMenuItem.Size = new System.Drawing.Size(48, 26);
            this.cppToolStripMenuItem.Text = "CPP";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CPP);
            this.Controls.Add(this.titlu);
            this.Controls.Add(this.Bilant);
            this.Controls.Add(this.Meniu);
            this.MainMenuStrip = this.Meniu;
            this.Name = "Menu";
            this.Text = "Form1";
            this.Meniu.ResumeLayout(false);
            this.Meniu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bilant;
        private System.Windows.Forms.Label titlu;
        private System.Windows.Forms.Button CPP;
        private System.Windows.Forms.MenuStrip Meniu;
        private System.Windows.Forms.ToolStripMenuItem bilantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cppToolStripMenuItem;
    }
}

