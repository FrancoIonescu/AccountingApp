﻿namespace Contabilitate
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
            this.button1 = new System.Windows.Forms.Button();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Meniu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bilant
            // 
            this.Bilant.Font = new System.Drawing.Font("Rockwell", 10.2F);
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
            this.titlu.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Bold);
            this.titlu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titlu.Location = new System.Drawing.Point(239, 86);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(315, 42);
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
            this.cppToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.Meniu.Location = new System.Drawing.Point(0, 0);
            this.Meniu.Name = "Meniu";
            this.Meniu.Size = new System.Drawing.Size(800, 28);
            this.Meniu.TabIndex = 4;
            this.Meniu.Text = "menuStrip1";
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.button1.Location = new System.Drawing.Point(328, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Info";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

