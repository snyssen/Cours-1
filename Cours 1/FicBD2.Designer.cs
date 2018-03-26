namespace Cours_1
{
    partial class EcranBD2
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
            this.lblPrenom = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.persoDataSet = new Cours_1.persoDataSet();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblNaissance = new System.Windows.Forms.Label();
            this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.lblPos = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnConf = new System.Windows.Forms.Button();
            this.btnAnn = new System.Windows.Forms.Button();
            this.clientTableAdapter = new Cours_1.persoDataSetTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(13, 13);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 0;
            this.lblPrenom.Text = "Prénom";
            // 
            // tbPrenom
            // 
            this.tbPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "PRE", true));
            this.tbPrenom.Location = new System.Drawing.Point(13, 30);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(259, 20);
            this.tbPrenom.TabIndex = 1;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.persoDataSet;
            // 
            // persoDataSet
            // 
            this.persoDataSet.DataSetName = "persoDataSet";
            this.persoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbNom
            // 
            this.tbNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "NOM", true));
            this.tbNom.Location = new System.Drawing.Point(13, 70);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(259, 20);
            this.tbNom.TabIndex = 3;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(13, 53);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // lblNaissance
            // 
            this.lblNaissance.AutoSize = true;
            this.lblNaissance.Location = new System.Drawing.Point(16, 97);
            this.lblNaissance.Name = "lblNaissance";
            this.lblNaissance.Size = new System.Drawing.Size(96, 13);
            this.lblNaissance.TabIndex = 4;
            this.lblNaissance.Text = "Date de naissance";
            // 
            // dtpNaissance
            // 
            this.dtpNaissance.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientBindingSource, "NAI", true));
            this.dtpNaissance.Location = new System.Drawing.Point(13, 114);
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Size = new System.Drawing.Size(259, 20);
            this.dtpNaissance.TabIndex = 5;
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(13, 141);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(35, 35);
            this.btnPremier.TabIndex = 6;
            this.btnPremier.Text = "|<";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(196, 141);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(35, 35);
            this.btnSuivant.TabIndex = 7;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(237, 141);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(35, 35);
            this.btnDernier.TabIndex = 8;
            this.btnDernier.Text = ">|";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(54, 141);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(35, 35);
            this.btnPrecedent.TabIndex = 9;
            this.btnPrecedent.Text = "<";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // lblPos
            // 
            this.lblPos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPos.Location = new System.Drawing.Point(95, 141);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(95, 35);
            this.lblPos.TabIndex = 10;
            this.lblPos.Text = "p/n";
            this.lblPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(13, 183);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(76, 35);
            this.btnAjout.TabIndex = 11;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(95, 183);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(95, 35);
            this.btnModif.TabIndex = 12;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(196, 183);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(76, 35);
            this.btnSupp.TabIndex = 13;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnConf
            // 
            this.btnConf.Location = new System.Drawing.Point(13, 224);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(95, 35);
            this.btnConf.TabIndex = 14;
            this.btnConf.Text = "Confirmer";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // btnAnn
            // 
            this.btnAnn.Location = new System.Drawing.Point(177, 224);
            this.btnAnn.Name = "btnAnn";
            this.btnAnn.Size = new System.Drawing.Size(95, 35);
            this.btnAnn.TabIndex = 15;
            this.btnAnn.Text = "Annuler";
            this.btnAnn.UseVisualStyleBackColor = true;
            this.btnAnn.Click += new System.EventHandler(this.btnAnn_Click);
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // EcranBD2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.btnAnn);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnDernier);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.dtpNaissance);
            this.Controls.Add(this.lblNaissance);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.lblPrenom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EcranBD2";
            this.Text = "Gestion de base de données";
            this.Load += new System.EventHandler(this.EcranBD2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblNaissance;
        private System.Windows.Forms.DateTimePicker dtpNaissance;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Button btnAnn;
        private persoDataSet persoDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private persoDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
    }
}