namespace Cours_1
{
    partial class FicPrincipal
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
            this.mMenu = new System.Windows.Forms.MenuStrip();
            this.mFenetres = new System.Windows.Forms.ToolStripMenuItem();
            this.mfProgression = new System.Windows.Forms.ToolStripMenuItem();
            this.mfListe = new System.Windows.Forms.ToolStripMenuItem();
            this.mfEditeur = new System.Windows.Forms.ToolStripMenuItem();
            this.mfHorloge = new System.Windows.Forms.ToolStripMenuItem();
            this.mefSpirographe = new System.Windows.Forms.ToolStripMenuItem();
            this.mAide = new System.Windows.Forms.ToolStripMenuItem();
            this.mQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mefGraphique = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mMenu
            // 
            this.mMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFenetres,
            this.mAide,
            this.mQuitter});
            this.mMenu.Location = new System.Drawing.Point(0, 0);
            this.mMenu.Name = "mMenu";
            this.mMenu.Size = new System.Drawing.Size(284, 24);
            this.mMenu.TabIndex = 0;
            this.mMenu.Text = "menuStrip1";
            // 
            // mFenetres
            // 
            this.mFenetres.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mfProgression,
            this.mfListe,
            this.mfEditeur,
            this.mfHorloge,
            this.mefSpirographe,
            this.mefGraphique});
            this.mFenetres.Name = "mFenetres";
            this.mFenetres.Size = new System.Drawing.Size(63, 20);
            this.mFenetres.Text = "Fenêtres";
            // 
            // mfProgression
            // 
            this.mfProgression.Name = "mfProgression";
            this.mfProgression.Size = new System.Drawing.Size(187, 22);
            this.mfProgression.Text = "Barres de progression";
            this.mfProgression.Click += new System.EventHandler(this.mfProgression_Click);
            // 
            // mfListe
            // 
            this.mfListe.Name = "mfListe";
            this.mfListe.Size = new System.Drawing.Size(187, 22);
            this.mfListe.Text = "Liste";
            this.mfListe.Click += new System.EventHandler(this.mfListe_Click);
            // 
            // mfEditeur
            // 
            this.mfEditeur.Name = "mfEditeur";
            this.mfEditeur.Size = new System.Drawing.Size(187, 22);
            this.mfEditeur.Text = "Editeur";
            this.mfEditeur.Click += new System.EventHandler(this.mfEditeur_Click);
            // 
            // mfHorloge
            // 
            this.mfHorloge.Name = "mfHorloge";
            this.mfHorloge.Size = new System.Drawing.Size(187, 22);
            this.mfHorloge.Text = "Horloge";
            this.mfHorloge.Click += new System.EventHandler(this.mfHorloge_Click);
            // 
            // mefSpirographe
            // 
            this.mefSpirographe.Name = "mefSpirographe";
            this.mefSpirographe.Size = new System.Drawing.Size(187, 22);
            this.mefSpirographe.Text = "Spirographe";
            this.mefSpirographe.Click += new System.EventHandler(this.mefSpirographe_Click);
            // 
            // mAide
            // 
            this.mAide.Name = "mAide";
            this.mAide.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mAide.Size = new System.Drawing.Size(43, 20);
            this.mAide.Text = "Aide";
            this.mAide.Click += new System.EventHandler(this.mAide_Click);
            // 
            // mQuitter
            // 
            this.mQuitter.Name = "mQuitter";
            this.mQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mQuitter.Size = new System.Drawing.Size(56, 20);
            this.mQuitter.Text = "Quitter";
            this.mQuitter.Click += new System.EventHandler(this.mQuitter_Click);
            // 
            // mefGraphique
            // 
            this.mefGraphique.Name = "mefGraphique";
            this.mefGraphique.Size = new System.Drawing.Size(187, 22);
            this.mefGraphique.Text = "Graphique";
            this.mefGraphique.Click += new System.EventHandler(this.mefGraphique_Click);
            // 
            // FicPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.mMenu);
            this.MainMenuStrip = this.mMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FicPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ecran principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FicPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FicPrincipal_Load);
            this.mMenu.ResumeLayout(false);
            this.mMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mMenu;
        private System.Windows.Forms.ToolStripMenuItem mFenetres;
        private System.Windows.Forms.ToolStripMenuItem mfProgression;
        private System.Windows.Forms.ToolStripMenuItem mfListe;
        private System.Windows.Forms.ToolStripMenuItem mfEditeur;
        private System.Windows.Forms.ToolStripMenuItem mAide;
        private System.Windows.Forms.ToolStripMenuItem mQuitter;
        private System.Windows.Forms.ToolStripMenuItem mfHorloge;
        private System.Windows.Forms.ToolStripMenuItem mefSpirographe;
        private System.Windows.Forms.ToolStripMenuItem mefGraphique;
    }
}