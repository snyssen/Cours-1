﻿namespace Cours_1
{
    partial class EcranIntegrale
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
            this.lbResultat = new System.Windows.Forms.ListBox();
            this.btnPolynome = new System.Windows.Forms.Button();
            this.btnCosinus = new System.Windows.Forms.Button();
            this.lblGauche = new System.Windows.Forms.Label();
            this.tbGauche = new System.Windows.Forms.TextBox();
            this.tbDroite = new System.Windows.Forms.TextBox();
            this.lblDroite = new System.Windows.Forms.Label();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbResultat
            // 
            this.lbResultat.FormattingEnabled = true;
            this.lbResultat.Location = new System.Drawing.Point(13, 65);
            this.lbResultat.Name = "lbResultat";
            this.lbResultat.Size = new System.Drawing.Size(341, 186);
            this.lbResultat.TabIndex = 0;
            // 
            // btnPolynome
            // 
            this.btnPolynome.Location = new System.Drawing.Point(12, 257);
            this.btnPolynome.Name = "btnPolynome";
            this.btnPolynome.Size = new System.Drawing.Size(341, 23);
            this.btnPolynome.TabIndex = 1;
            this.btnPolynome.Text = "Polynome \" x * x - 3 * x + 4 \"";
            this.btnPolynome.UseVisualStyleBackColor = true;
            this.btnPolynome.Click += new System.EventHandler(this.btnPolynome_Click);
            // 
            // btnCosinus
            // 
            this.btnCosinus.Location = new System.Drawing.Point(13, 286);
            this.btnCosinus.Name = "btnCosinus";
            this.btnCosinus.Size = new System.Drawing.Size(341, 23);
            this.btnCosinus.TabIndex = 2;
            this.btnCosinus.Text = "Cosinus";
            this.btnCosinus.UseVisualStyleBackColor = true;
            this.btnCosinus.Click += new System.EventHandler(this.btnCosinus_Click);
            // 
            // lblGauche
            // 
            this.lblGauche.AutoSize = true;
            this.lblGauche.Location = new System.Drawing.Point(13, 13);
            this.lblGauche.Name = "lblGauche";
            this.lblGauche.Size = new System.Drawing.Size(45, 13);
            this.lblGauche.TabIndex = 3;
            this.lblGauche.Text = "Gauche";
            this.lblGauche.Click += new System.EventHandler(this.lblGauche_Click);
            // 
            // tbGauche
            // 
            this.tbGauche.Location = new System.Drawing.Point(16, 30);
            this.tbGauche.Name = "tbGauche";
            this.tbGauche.Size = new System.Drawing.Size(42, 20);
            this.tbGauche.TabIndex = 4;
            this.tbGauche.Text = "0";
            // 
            // tbDroite
            // 
            this.tbDroite.Location = new System.Drawing.Point(312, 30);
            this.tbDroite.Name = "tbDroite";
            this.tbDroite.Size = new System.Drawing.Size(42, 20);
            this.tbDroite.TabIndex = 6;
            this.tbDroite.Text = "2";
            this.tbDroite.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblDroite
            // 
            this.lblDroite.AutoSize = true;
            this.lblDroite.Location = new System.Drawing.Point(309, 13);
            this.lblDroite.Name = "lblDroite";
            this.lblDroite.Size = new System.Drawing.Size(35, 13);
            this.lblDroite.TabIndex = 5;
            this.lblDroite.Text = "Droite";
            this.lblDroite.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(161, 30);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(32, 20);
            this.tbInterval.TabIndex = 8;
            this.tbInterval.Text = "2";
            this.tbInterval.TextChanged += new System.EventHandler(this.tbInterval_TextChanged);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(158, 13);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(42, 13);
            this.lblInterval.TabIndex = 7;
            this.lblInterval.Text = "Interval";
            // 
            // EcranIntegrale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 323);
            this.Controls.Add(this.tbInterval);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.tbDroite);
            this.Controls.Add(this.lblDroite);
            this.Controls.Add(this.tbGauche);
            this.Controls.Add(this.lblGauche);
            this.Controls.Add(this.btnCosinus);
            this.Controls.Add(this.btnPolynome);
            this.Controls.Add(this.lbResultat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranIntegrale";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intégrale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbResultat;
        private System.Windows.Forms.Button btnPolynome;
        private System.Windows.Forms.Button btnCosinus;
        private System.Windows.Forms.Label lblGauche;
        private System.Windows.Forms.TextBox tbGauche;
        private System.Windows.Forms.TextBox tbDroite;
        private System.Windows.Forms.Label lblDroite;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.Label lblInterval;
    }
}