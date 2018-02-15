namespace Cours_1
{
    partial class EcranAccueil
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
            this.btnPousser = new System.Windows.Forms.Button();
            this.btnEntrez = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pbImageDepart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageDepart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPousser
            // 
            this.btnPousser.Font = new System.Drawing.Font("Mistral", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPousser.Location = new System.Drawing.Point(12, 208);
            this.btnPousser.Name = "btnPousser";
            this.btnPousser.Size = new System.Drawing.Size(120, 40);
            this.btnPousser.TabIndex = 0;
            this.btnPousser.Text = "P o u s s e z";
            this.btnPousser.UseVisualStyleBackColor = true;
            this.btnPousser.Click += new System.EventHandler(this.btnPousser_Click);
            // 
            // btnEntrez
            // 
            this.btnEntrez.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrez.Location = new System.Drawing.Point(152, 208);
            this.btnEntrez.Name = "btnEntrez";
            this.btnEntrez.Size = new System.Drawing.Size(120, 40);
            this.btnEntrez.TabIndex = 1;
            this.btnEntrez.Text = "E n t r e z";
            this.btnEntrez.UseVisualStyleBackColor = true;
            this.btnEntrez.Click += new System.EventHandler(this.btnEntrez_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(40, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(204, 42);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Découverte de C#";
            // 
            // pbImageDepart
            // 
            this.pbImageDepart.Image = global::Cours_1.Properties.Resources.cat_logo;
            this.pbImageDepart.Location = new System.Drawing.Point(84, 77);
            this.pbImageDepart.Name = "pbImageDepart";
            this.pbImageDepart.Size = new System.Drawing.Size(111, 86);
            this.pbImageDepart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageDepart.TabIndex = 3;
            this.pbImageDepart.TabStop = false;
            // 
            // EcranAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.pbImageDepart);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnEntrez);
            this.Controls.Add(this.btnPousser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranAccueil";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenue, welcome...";
            ((System.ComponentModel.ISupportInitialize)(this.pbImageDepart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPousser;
        private System.Windows.Forms.Button btnEntrez;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox pbImageDepart;
    }
}

