namespace Cours_1
{
    partial class EcranBD1
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
            this.lbContenu = new System.Windows.Forms.ListBox();
            this.btnCharger = new System.Windows.Forms.Button();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.btnSauver = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.tbSupprimer = new System.Windows.Forms.TextBox();
            this.btnCompter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbContenu
            // 
            this.lbContenu.FormattingEnabled = true;
            this.lbContenu.Location = new System.Drawing.Point(13, 13);
            this.lbContenu.Name = "lbContenu";
            this.lbContenu.Size = new System.Drawing.Size(775, 121);
            this.lbContenu.TabIndex = 0;
            // 
            // btnCharger
            // 
            this.btnCharger.Location = new System.Drawing.Point(13, 140);
            this.btnCharger.Name = "btnCharger";
            this.btnCharger.Size = new System.Drawing.Size(775, 23);
            this.btnCharger.TabIndex = 1;
            this.btnCharger.Text = "Charger";
            this.btnCharger.UseVisualStyleBackColor = true;
            this.btnCharger.Click += new System.EventHandler(this.btnCharger_Click);
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(13, 170);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(599, 20);
            this.tbPrenom.TabIndex = 2;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(12, 202);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(599, 20);
            this.tbNom.TabIndex = 3;
            // 
            // btnSauver
            // 
            this.btnSauver.Location = new System.Drawing.Point(618, 170);
            this.btnSauver.Name = "btnSauver";
            this.btnSauver.Size = new System.Drawing.Size(170, 52);
            this.btnSauver.TabIndex = 4;
            this.btnSauver.Text = "Sauver";
            this.btnSauver.UseVisualStyleBackColor = true;
            this.btnSauver.Click += new System.EventHandler(this.btnSauver_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(618, 251);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(170, 23);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // tbSupprimer
            // 
            this.tbSupprimer.Location = new System.Drawing.Point(12, 254);
            this.tbSupprimer.Name = "tbSupprimer";
            this.tbSupprimer.Size = new System.Drawing.Size(599, 20);
            this.tbSupprimer.TabIndex = 6;
            // 
            // btnCompter
            // 
            this.btnCompter.Location = new System.Drawing.Point(13, 280);
            this.btnCompter.Name = "btnCompter";
            this.btnCompter.Size = new System.Drawing.Size(775, 23);
            this.btnCompter.TabIndex = 7;
            this.btnCompter.Text = "Compter";
            this.btnCompter.UseVisualStyleBackColor = true;
            this.btnCompter.Click += new System.EventHandler(this.btnCompter_Click);
            // 
            // EcranBD1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 315);
            this.Controls.Add(this.btnCompter);
            this.Controls.Add(this.tbSupprimer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnSauver);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.btnCharger);
            this.Controls.Add(this.lbContenu);
            this.Name = "EcranBD1";
            this.Text = "Base de données \"CONSOLE\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbContenu;
        private System.Windows.Forms.Button btnCharger;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button btnSauver;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TextBox tbSupprimer;
        private System.Windows.Forms.Button btnCompter;
    }
}