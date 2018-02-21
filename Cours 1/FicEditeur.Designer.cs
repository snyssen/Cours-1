﻿namespace Cours_1
{
    partial class EcranEditeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranEditeur));
            this.mEditeur = new System.Windows.Forms.MenuStrip();
            this.dlgOuvrirFichier = new System.Windows.Forms.OpenFileDialog();
            this.dlgSauverFichier = new System.Windows.Forms.SaveFileDialog();
            this.dlgPolice = new System.Windows.Forms.FontDialog();
            this.pBarreBouton = new System.Windows.Forms.Panel();
            this.rtbTexte = new System.Windows.Forms.RichTextBox();
            this.meFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.meEditer = new System.Windows.Forms.ToolStripMenuItem();
            this.meFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mefNouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.mefOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mefSauver = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mefQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.meeColler = new System.Windows.Forms.ToolStripMenuItem();
            this.mefJustifier = new System.Windows.Forms.ToolStripMenuItem();
            this.mefPolice = new System.Windows.Forms.ToolStripMenuItem();
            this.mefCaractère = new System.Windows.Forms.ToolStripMenuItem();
            this.mefjGauche = new System.Windows.Forms.ToolStripMenuItem();
            this.mefjDroite = new System.Windows.Forms.ToolStripMenuItem();
            this.mefjCentre = new System.Windows.Forms.ToolStripMenuItem();
            this.mefcGras = new System.Windows.Forms.ToolStripMenuItem();
            this.mefcItalique = new System.Windows.Forms.ToolStripMenuItem();
            this.mefcSouligne = new System.Windows.Forms.ToolStripMenuItem();
            this.mefcBarre = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.meeCouper = new System.Windows.Forms.ToolStripMenuItem();
            this.meeCopier = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditeur.SuspendLayout();
            this.pBarreBouton.SuspendLayout();
            this.SuspendLayout();
            // 
            // mEditeur
            // 
            this.mEditeur.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meFichier,
            this.meEditer,
            this.meFormat});
            this.mEditeur.Location = new System.Drawing.Point(0, 0);
            this.mEditeur.Name = "mEditeur";
            this.mEditeur.Size = new System.Drawing.Size(651, 24);
            this.mEditeur.TabIndex = 0;
            this.mEditeur.Text = "menuStrip1";
            // 
            // dlgOuvrirFichier
            // 
            this.dlgOuvrirFichier.FileName = "openFileDialog1";
            this.dlgOuvrirFichier.Filter = "Nos fichiers (*.mesdocs)|*.mesdocs|Tous fichiers (*.*)|*.*";
            // 
            // dlgSauverFichier
            // 
            this.dlgSauverFichier.Filter = "Nos fichiers (*.mesdocs)|*.mesdocs|Tous fichiers (*.*)|*.*";
            // 
            // pBarreBouton
            // 
            this.pBarreBouton.Controls.Add(this.btnQuitter);
            this.pBarreBouton.Controls.Add(this.btnEnregistrer);
            this.pBarreBouton.Controls.Add(this.btnOuvrir);
            this.pBarreBouton.Controls.Add(this.btnNouveau);
            this.pBarreBouton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBarreBouton.Location = new System.Drawing.Point(0, 24);
            this.pBarreBouton.Name = "pBarreBouton";
            this.pBarreBouton.Size = new System.Drawing.Size(651, 36);
            this.pBarreBouton.TabIndex = 1;
            // 
            // rtbTexte
            // 
            this.rtbTexte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTexte.Location = new System.Drawing.Point(0, 60);
            this.rtbTexte.Name = "rtbTexte";
            this.rtbTexte.Size = new System.Drawing.Size(651, 382);
            this.rtbTexte.TabIndex = 2;
            this.rtbTexte.Text = "";
            this.rtbTexte.TextChanged += new System.EventHandler(this.rtbTexte_TextChanged);
            // 
            // meFichier
            // 
            this.meFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mefNouveau,
            this.mefOuvrir,
            this.mefSauver,
            this.toolStripMenuItem1,
            this.mefQuitter});
            this.meFichier.Name = "meFichier";
            this.meFichier.Size = new System.Drawing.Size(54, 20);
            this.meFichier.Text = "Fichier";
            // 
            // meEditer
            // 
            this.meEditer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meeCouper,
            this.meeCopier,
            this.meeColler});
            this.meEditer.Name = "meEditer";
            this.meEditer.Size = new System.Drawing.Size(49, 20);
            this.meEditer.Text = "Editer";
            // 
            // meFormat
            // 
            this.meFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mefJustifier,
            this.mefPolice,
            this.mefCaractère});
            this.meFormat.Name = "meFormat";
            this.meFormat.Size = new System.Drawing.Size(57, 20);
            this.meFormat.Text = "Format";
            // 
            // mefNouveau
            // 
            this.mefNouveau.Name = "mefNouveau";
            this.mefNouveau.Size = new System.Drawing.Size(152, 22);
            this.mefNouveau.Text = "Nouveau";
            this.mefNouveau.Click += new System.EventHandler(this.mefNouveau_Click);
            // 
            // mefOuvrir
            // 
            this.mefOuvrir.Name = "mefOuvrir";
            this.mefOuvrir.Size = new System.Drawing.Size(152, 22);
            this.mefOuvrir.Text = "Ouvrir";
            this.mefOuvrir.Click += new System.EventHandler(this.mefOuvrir_Click);
            // 
            // mefSauver
            // 
            this.mefSauver.Name = "mefSauver";
            this.mefSauver.Size = new System.Drawing.Size(152, 22);
            this.mefSauver.Text = "Sauver";
            this.mefSauver.Click += new System.EventHandler(this.mefSauver_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mefQuitter
            // 
            this.mefQuitter.Name = "mefQuitter";
            this.mefQuitter.Size = new System.Drawing.Size(152, 22);
            this.mefQuitter.Text = "Quitter";
            this.mefQuitter.Click += new System.EventHandler(this.mefQuitter_Click);
            // 
            // meeColler
            // 
            this.meeColler.Name = "meeColler";
            this.meeColler.Size = new System.Drawing.Size(152, 22);
            this.meeColler.Text = "Coller";
            this.meeColler.Click += new System.EventHandler(this.meeColler_Click);
            // 
            // mefJustifier
            // 
            this.mefJustifier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mefjGauche,
            this.mefjDroite,
            this.mefjCentre});
            this.mefJustifier.Name = "mefJustifier";
            this.mefJustifier.Size = new System.Drawing.Size(152, 22);
            this.mefJustifier.Text = "Justifier";
            // 
            // mefPolice
            // 
            this.mefPolice.Name = "mefPolice";
            this.mefPolice.Size = new System.Drawing.Size(152, 22);
            this.mefPolice.Text = "Police";
            this.mefPolice.Click += new System.EventHandler(this.mefPolice_Click);
            // 
            // mefCaractère
            // 
            this.mefCaractère.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mefcGras,
            this.mefcItalique,
            this.mefcSouligne,
            this.mefcBarre});
            this.mefCaractère.Name = "mefCaractère";
            this.mefCaractère.Size = new System.Drawing.Size(152, 22);
            this.mefCaractère.Text = "Caractère";
            // 
            // mefjGauche
            // 
            this.mefjGauche.Name = "mefjGauche";
            this.mefjGauche.Size = new System.Drawing.Size(152, 22);
            this.mefjGauche.Text = "Gauche";
            this.mefjGauche.Click += new System.EventHandler(this.mefjGauche_Click);
            // 
            // mefjDroite
            // 
            this.mefjDroite.Name = "mefjDroite";
            this.mefjDroite.Size = new System.Drawing.Size(152, 22);
            this.mefjDroite.Text = "Droite";
            this.mefjDroite.Click += new System.EventHandler(this.mefjDroite_Click);
            // 
            // mefjCentre
            // 
            this.mefjCentre.Name = "mefjCentre";
            this.mefjCentre.Size = new System.Drawing.Size(152, 22);
            this.mefjCentre.Text = "Centré";
            this.mefjCentre.Click += new System.EventHandler(this.mefjCentre_Click);
            // 
            // mefcGras
            // 
            this.mefcGras.Name = "mefcGras";
            this.mefcGras.Size = new System.Drawing.Size(152, 22);
            this.mefcGras.Text = "Gras";
            this.mefcGras.Click += new System.EventHandler(this.mefcGras_Click);
            // 
            // mefcItalique
            // 
            this.mefcItalique.Name = "mefcItalique";
            this.mefcItalique.Size = new System.Drawing.Size(152, 22);
            this.mefcItalique.Text = "Italique";
            this.mefcItalique.Click += new System.EventHandler(this.mefcItalique_Click);
            // 
            // mefcSouligne
            // 
            this.mefcSouligne.Name = "mefcSouligne";
            this.mefcSouligne.Size = new System.Drawing.Size(152, 22);
            this.mefcSouligne.Text = "Souligné";
            this.mefcSouligne.Click += new System.EventHandler(this.mefcSouligne_Click);
            // 
            // mefcBarre
            // 
            this.mefcBarre.Name = "mefcBarre";
            this.mefcBarre.Size = new System.Drawing.Size(152, 22);
            this.mefcBarre.Text = "Barré";
            this.mefcBarre.Click += new System.EventHandler(this.mefcBarre_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitter.Image")));
            this.btnQuitter.Location = new System.Drawing.Point(100, 4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(26, 26);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.mefQuitter_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Image = ((System.Drawing.Image)(resources.GetObject("btnEnregistrer.Image")));
            this.btnEnregistrer.Location = new System.Drawing.Point(68, 4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(26, 26);
            this.btnEnregistrer.TabIndex = 2;
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.mefSauver_Click);
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Image = ((System.Drawing.Image)(resources.GetObject("btnOuvrir.Image")));
            this.btnOuvrir.Location = new System.Drawing.Point(36, 4);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(26, 26);
            this.btnOuvrir.TabIndex = 1;
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.mefOuvrir_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Image = ((System.Drawing.Image)(resources.GetObject("btnNouveau.Image")));
            this.btnNouveau.Location = new System.Drawing.Point(4, 4);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(26, 26);
            this.btnNouveau.TabIndex = 0;
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.mefNouveau_Click);
            // 
            // meeCouper
            // 
            this.meeCouper.Name = "meeCouper";
            this.meeCouper.Size = new System.Drawing.Size(152, 22);
            this.meeCouper.Text = "Couper";
            this.meeCouper.Click += new System.EventHandler(this.meeCouper_Click);
            // 
            // meeCopier
            // 
            this.meeCopier.Name = "meeCopier";
            this.meeCopier.Size = new System.Drawing.Size(152, 22);
            this.meeCopier.Text = "Copier";
            this.meeCopier.Click += new System.EventHandler(this.meeCopier_Click);
            // 
            // EcranEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 442);
            this.Controls.Add(this.rtbTexte);
            this.Controls.Add(this.pBarreBouton);
            this.Controls.Add(this.mEditeur);
            this.MainMenuStrip = this.mEditeur;
            this.Name = "EcranEditeur";
            this.Text = "Traitement de texte ... en toute modestie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EcranEditeur_FormClosing);
            this.Shown += new System.EventHandler(this.EcranEditeur_Shown);
            this.mEditeur.ResumeLayout(false);
            this.mEditeur.PerformLayout();
            this.pBarreBouton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mEditeur;
        private System.Windows.Forms.OpenFileDialog dlgOuvrirFichier;
        private System.Windows.Forms.SaveFileDialog dlgSauverFichier;
        private System.Windows.Forms.FontDialog dlgPolice;
        private System.Windows.Forms.Panel pBarreBouton;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.RichTextBox rtbTexte;
        private System.Windows.Forms.ToolStripMenuItem meFichier;
        private System.Windows.Forms.ToolStripMenuItem mefNouveau;
        private System.Windows.Forms.ToolStripMenuItem mefOuvrir;
        private System.Windows.Forms.ToolStripMenuItem mefSauver;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mefQuitter;
        private System.Windows.Forms.ToolStripMenuItem meEditer;
        private System.Windows.Forms.ToolStripMenuItem meeCouper;
        private System.Windows.Forms.ToolStripMenuItem meeCopier;
        private System.Windows.Forms.ToolStripMenuItem meeColler;
        private System.Windows.Forms.ToolStripMenuItem meFormat;
        private System.Windows.Forms.ToolStripMenuItem mefJustifier;
        private System.Windows.Forms.ToolStripMenuItem mefjGauche;
        private System.Windows.Forms.ToolStripMenuItem mefjDroite;
        private System.Windows.Forms.ToolStripMenuItem mefjCentre;
        private System.Windows.Forms.ToolStripMenuItem mefPolice;
        private System.Windows.Forms.ToolStripMenuItem mefCaractère;
        private System.Windows.Forms.ToolStripMenuItem mefcGras;
        private System.Windows.Forms.ToolStripMenuItem mefcItalique;
        private System.Windows.Forms.ToolStripMenuItem mefcSouligne;
        private System.Windows.Forms.ToolStripMenuItem mefcBarre;
    }
}