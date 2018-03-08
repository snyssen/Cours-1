namespace Cours_1
{
    partial class Ecran_Clavier_Souris
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
            this.lblClavier = new System.Windows.Forms.Label();
            this.btnRAZ = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lbClavier = new System.Windows.Forms.ListBox();
            this.lblGauche = new System.Windows.Forms.Label();
            this.tbGauche = new System.Windows.Forms.TextBox();
            this.pPositionSouris = new System.Windows.Forms.Panel();
            this.tbOrdonnee = new System.Windows.Forms.TextBox();
            this.lblOrdonnee = new System.Windows.Forms.Label();
            this.tbAbscisse = new System.Windows.Forms.TextBox();
            this.lblAbscisse = new System.Windows.Forms.Label();
            this.tbDroite = new System.Windows.Forms.TextBox();
            this.lblDroite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClavier
            // 
            this.lblClavier.AutoSize = true;
            this.lblClavier.Location = new System.Drawing.Point(9, 7);
            this.lblClavier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClavier.Name = "lblClavier";
            this.lblClavier.Size = new System.Drawing.Size(80, 13);
            this.lblClavier.TabIndex = 0;
            this.lblClavier.Text = "Suivi du Clavier";
            // 
            // btnRAZ
            // 
            this.btnRAZ.Location = new System.Drawing.Point(9, 200);
            this.btnRAZ.Margin = new System.Windows.Forms.Padding(2);
            this.btnRAZ.Name = "btnRAZ";
            this.btnRAZ.Size = new System.Drawing.Size(79, 19);
            this.btnRAZ.TabIndex = 1;
            this.btnRAZ.Text = "Remis à Zéro";
            this.btnRAZ.UseVisualStyleBackColor = true;
            this.btnRAZ.Click += new System.EventHandler(this.Btn_RAZ_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(92, 200);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(79, 19);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.Btn_Quitter_Click);
            // 
            // lbClavier
            // 
            this.lbClavier.FormattingEnabled = true;
            this.lbClavier.Location = new System.Drawing.Point(9, 24);
            this.lbClavier.Margin = new System.Windows.Forms.Padding(2);
            this.lbClavier.Name = "lbClavier";
            this.lbClavier.Size = new System.Drawing.Size(163, 173);
            this.lbClavier.TabIndex = 3;
            // 
            // lblGauche
            // 
            this.lblGauche.AutoSize = true;
            this.lblGauche.Location = new System.Drawing.Point(173, 7);
            this.lblGauche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGauche.Name = "lblGauche";
            this.lblGauche.Size = new System.Drawing.Size(55, 13);
            this.lblGauche.TabIndex = 4;
            this.lblGauche.Text = "A Gauche";
            // 
            // tbGauche
            // 
            this.tbGauche.Location = new System.Drawing.Point(176, 24);
            this.tbGauche.Margin = new System.Windows.Forms.Padding(2);
            this.tbGauche.Name = "tbGauche";
            this.tbGauche.ReadOnly = true;
            this.tbGauche.Size = new System.Drawing.Size(73, 20);
            this.tbGauche.TabIndex = 5;
            this.tbGauche.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pPositionSouris
            // 
            this.pPositionSouris.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pPositionSouris.Location = new System.Drawing.Point(176, 46);
            this.pPositionSouris.Margin = new System.Windows.Forms.Padding(2);
            this.pPositionSouris.Name = "pPositionSouris";
            this.pPositionSouris.Size = new System.Drawing.Size(291, 173);
            this.pPositionSouris.TabIndex = 6;
            this.pPositionSouris.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pPositionSouris_MouseDown);
            this.pPositionSouris.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pPositionSouris_MouseMove);
            // 
            // tbOrdonnee
            // 
            this.tbOrdonnee.Location = new System.Drawing.Point(394, 24);
            this.tbOrdonnee.Margin = new System.Windows.Forms.Padding(2);
            this.tbOrdonnee.Name = "tbOrdonnee";
            this.tbOrdonnee.ReadOnly = true;
            this.tbOrdonnee.Size = new System.Drawing.Size(72, 20);
            this.tbOrdonnee.TabIndex = 8;
            this.tbOrdonnee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOrdonnee
            // 
            this.lblOrdonnee.AutoSize = true;
            this.lblOrdonnee.Location = new System.Drawing.Point(392, 7);
            this.lblOrdonnee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrdonnee.Name = "lblOrdonnee";
            this.lblOrdonnee.Size = new System.Drawing.Size(54, 13);
            this.lblOrdonnee.TabIndex = 7;
            this.lblOrdonnee.Text = "Ordonnée";
            // 
            // tbAbscisse
            // 
            this.tbAbscisse.Location = new System.Drawing.Point(324, 24);
            this.tbAbscisse.Margin = new System.Windows.Forms.Padding(2);
            this.tbAbscisse.Name = "tbAbscisse";
            this.tbAbscisse.ReadOnly = true;
            this.tbAbscisse.Size = new System.Drawing.Size(67, 20);
            this.tbAbscisse.TabIndex = 10;
            this.tbAbscisse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAbscisse
            // 
            this.lblAbscisse.AutoSize = true;
            this.lblAbscisse.Location = new System.Drawing.Point(322, 7);
            this.lblAbscisse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbscisse.Name = "lblAbscisse";
            this.lblAbscisse.Size = new System.Drawing.Size(49, 13);
            this.lblAbscisse.TabIndex = 9;
            this.lblAbscisse.Text = "Abscisse";
            // 
            // tbDroite
            // 
            this.tbDroite.Location = new System.Drawing.Point(252, 24);
            this.tbDroite.Margin = new System.Windows.Forms.Padding(2);
            this.tbDroite.Name = "tbDroite";
            this.tbDroite.ReadOnly = true;
            this.tbDroite.Size = new System.Drawing.Size(68, 20);
            this.tbDroite.TabIndex = 12;
            this.tbDroite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDroite
            // 
            this.lblDroite.AutoSize = true;
            this.lblDroite.Location = new System.Drawing.Point(250, 7);
            this.lblDroite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDroite.Name = "lblDroite";
            this.lblDroite.Size = new System.Drawing.Size(45, 13);
            this.lblDroite.TabIndex = 11;
            this.lblDroite.Text = "A Droite";
            // 
            // Ecran_Clavier_Souris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 228);
            this.Controls.Add(this.tbDroite);
            this.Controls.Add(this.lblDroite);
            this.Controls.Add(this.tbAbscisse);
            this.Controls.Add(this.lblAbscisse);
            this.Controls.Add(this.tbOrdonnee);
            this.Controls.Add(this.lblOrdonnee);
            this.Controls.Add(this.pPositionSouris);
            this.Controls.Add(this.tbGauche);
            this.Controls.Add(this.lblGauche);
            this.Controls.Add(this.lbClavier);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRAZ);
            this.Controls.Add(this.lblClavier);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ecran_Clavier_Souris";
            this.Text = "Suivi du Clavier et de la Souris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ecran_Clavier_Souris_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ecran_Clavier_Souris_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Ecran_Clavier_Souris_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClavier;
        private System.Windows.Forms.Button btnRAZ;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ListBox lbClavier;
        private System.Windows.Forms.Label lblGauche;
        private System.Windows.Forms.TextBox tbGauche;
        private System.Windows.Forms.Panel pPositionSouris;
        private System.Windows.Forms.TextBox tbOrdonnee;
        private System.Windows.Forms.Label lblOrdonnee;
        private System.Windows.Forms.TextBox tbAbscisse;
        private System.Windows.Forms.Label lblAbscisse;
        private System.Windows.Forms.TextBox tbDroite;
        private System.Windows.Forms.Label lblDroite;
    }
}