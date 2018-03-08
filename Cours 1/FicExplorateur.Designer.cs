namespace Cours_1
{
    partial class EcranExplorateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranExplorateur));
            this.tsCommande = new System.Windows.Forms.ToolStrip();
            this.ssMessage = new System.Windows.Forms.StatusStrip();
            this.tvRepertoire = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lvFichier = new System.Windows.Forms.ListView();
            this.ilVueArbre = new System.Windows.Forms.ImageList(this.components);
            this.ilVuePetit = new System.Windows.Forms.ImageList(this.components);
            this.ilVueGrand = new System.Windows.Forms.ImageList(this.components);
            this.tsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsQuitter = new System.Windows.Forms.ToolStripButton();
            this.tsApparence = new System.Windows.Forms.ToolStripSplitButton();
            this.tsPetitesIcones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGrandesIcones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsListe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.NOM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TAI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CREA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MOD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.slMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsCommande.SuspendLayout();
            this.ssMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsCommande
            // 
            this.tsCommande.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsQuitter,
            this.tsSeparator,
            this.tsApparence});
            this.tsCommande.Location = new System.Drawing.Point(0, 0);
            this.tsCommande.Name = "tsCommande";
            this.tsCommande.Size = new System.Drawing.Size(584, 25);
            this.tsCommande.TabIndex = 0;
            this.tsCommande.Text = "toolStrip1";
            // 
            // ssMessage
            // 
            this.ssMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slMessage});
            this.ssMessage.Location = new System.Drawing.Point(0, 339);
            this.ssMessage.Name = "ssMessage";
            this.ssMessage.Size = new System.Drawing.Size(584, 22);
            this.ssMessage.TabIndex = 1;
            this.ssMessage.Text = "statusStrip1";
            // 
            // tvRepertoire
            // 
            this.tvRepertoire.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvRepertoire.ImageIndex = 0;
            this.tvRepertoire.ImageList = this.ilVueArbre;
            this.tvRepertoire.Location = new System.Drawing.Point(0, 25);
            this.tvRepertoire.Name = "tvRepertoire";
            this.tvRepertoire.SelectedImageIndex = 0;
            this.tvRepertoire.Size = new System.Drawing.Size(200, 314);
            this.tvRepertoire.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 314);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // lvFichier
            // 
            this.lvFichier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NOM,
            this.TAI,
            this.CREA,
            this.MOD});
            this.lvFichier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFichier.FullRowSelect = true;
            this.lvFichier.LargeImageList = this.ilVueGrand;
            this.lvFichier.Location = new System.Drawing.Point(203, 25);
            this.lvFichier.Name = "lvFichier";
            this.lvFichier.Size = new System.Drawing.Size(381, 314);
            this.lvFichier.TabIndex = 4;
            this.lvFichier.UseCompatibleStateImageBehavior = false;
            // 
            // ilVueArbre
            // 
            this.ilVueArbre.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilVueArbre.ImageStream")));
            this.ilVueArbre.TransparentColor = System.Drawing.Color.Transparent;
            this.ilVueArbre.Images.SetKeyName(0, "WEOrdi.bmp");
            this.ilVueArbre.Images.SetKeyName(1, "WEFloppy.bmp");
            this.ilVueArbre.Images.SetKeyName(2, "WERepertoire.bmp");
            this.ilVueArbre.Images.SetKeyName(3, "WERepertoireActif.bmp");
            this.ilVueArbre.Images.SetKeyName(4, "WEPoubelle.bmp");
            // 
            // ilVuePetit
            // 
            this.ilVuePetit.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilVuePetit.ImageStream")));
            this.ilVuePetit.TransparentColor = System.Drawing.Color.Transparent;
            this.ilVuePetit.Images.SetKeyName(0, "WELVPetiteIcone.bmp");
            // 
            // ilVueGrand
            // 
            this.ilVueGrand.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilVueGrand.ImageStream")));
            this.ilVueGrand.TransparentColor = System.Drawing.Color.Transparent;
            this.ilVueGrand.Images.SetKeyName(0, "WELVGrandeIcone.bmp");
            // 
            // tsSeparator
            // 
            this.tsSeparator.Name = "tsSeparator";
            this.tsSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tsQuitter
            // 
            this.tsQuitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsQuitter.Image = global::Cours_1.Properties.Resources.doorshut;
            this.tsQuitter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsQuitter.Name = "tsQuitter";
            this.tsQuitter.Size = new System.Drawing.Size(23, 22);
            this.tsQuitter.Text = "toolStripButton1";
            this.tsQuitter.Click += new System.EventHandler(this.tsQuitter_Click);
            // 
            // tsApparence
            // 
            this.tsApparence.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsApparence.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPetitesIcones,
            this.tsGrandesIcones,
            this.tsListe,
            this.tsDetail});
            this.tsApparence.Image = global::Cours_1.Properties.Resources.WETBApparence;
            this.tsApparence.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsApparence.Name = "tsApparence";
            this.tsApparence.Size = new System.Drawing.Size(32, 22);
            this.tsApparence.Text = "toolStripSplitButton1";
            // 
            // tsPetitesIcones
            // 
            this.tsPetitesIcones.Name = "tsPetitesIcones";
            this.tsPetitesIcones.Size = new System.Drawing.Size(154, 22);
            this.tsPetitesIcones.Text = "Petites icônes";
            this.tsPetitesIcones.Click += new System.EventHandler(this.tsPetitesIcones_Click);
            // 
            // tsGrandesIcones
            // 
            this.tsGrandesIcones.Name = "tsGrandesIcones";
            this.tsGrandesIcones.Size = new System.Drawing.Size(154, 22);
            this.tsGrandesIcones.Text = "Grandes icônes";
            this.tsGrandesIcones.Click += new System.EventHandler(this.tsGrandesIcones_Click);
            // 
            // tsListe
            // 
            this.tsListe.Name = "tsListe";
            this.tsListe.Size = new System.Drawing.Size(154, 22);
            this.tsListe.Text = "Liste";
            this.tsListe.Click += new System.EventHandler(this.tsListe_Click);
            // 
            // tsDetail
            // 
            this.tsDetail.Name = "tsDetail";
            this.tsDetail.Size = new System.Drawing.Size(154, 22);
            this.tsDetail.Text = "Détail";
            this.tsDetail.Click += new System.EventHandler(this.tsDetail_Click);
            // 
            // NOM
            // 
            this.NOM.Text = "Nom";
            this.NOM.Width = 150;
            // 
            // TAI
            // 
            this.TAI.Text = "Taille";
            this.TAI.Width = 75;
            // 
            // CREA
            // 
            this.CREA.Text = "Création";
            this.CREA.Width = 75;
            // 
            // MOD
            // 
            this.MOD.Text = "Modification";
            this.MOD.Width = 75;
            // 
            // slMessage
            // 
            this.slMessage.Name = "slMessage";
            this.slMessage.Size = new System.Drawing.Size(42, 17);
            this.slMessage.Text = "#####";
            // 
            // EcranExplorateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lvFichier);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tvRepertoire);
            this.Controls.Add(this.ssMessage);
            this.Controls.Add(this.tsCommande);
            this.Name = "EcranExplorateur";
            this.Text = "Explorateur de fichiers";
            this.tsCommande.ResumeLayout(false);
            this.tsCommande.PerformLayout();
            this.ssMessage.ResumeLayout(false);
            this.ssMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsCommande;
        private System.Windows.Forms.StatusStrip ssMessage;
        private System.Windows.Forms.TreeView tvRepertoire;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView lvFichier;
        private System.Windows.Forms.ToolStripButton tsQuitter;
        private System.Windows.Forms.ToolStripSeparator tsSeparator;
        private System.Windows.Forms.ToolStripSplitButton tsApparence;
        private System.Windows.Forms.ToolStripMenuItem tsPetitesIcones;
        private System.Windows.Forms.ToolStripMenuItem tsGrandesIcones;
        private System.Windows.Forms.ToolStripMenuItem tsListe;
        private System.Windows.Forms.ToolStripMenuItem tsDetail;
        private System.Windows.Forms.ImageList ilVueArbre;
        private System.Windows.Forms.ImageList ilVuePetit;
        private System.Windows.Forms.ImageList ilVueGrand;
        private System.Windows.Forms.ToolStripStatusLabel slMessage;
        private System.Windows.Forms.ColumnHeader NOM;
        private System.Windows.Forms.ColumnHeader TAI;
        private System.Windows.Forms.ColumnHeader CREA;
        private System.Windows.Forms.ColumnHeader MOD;
    }
}