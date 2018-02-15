namespace Cours_1
{
    partial class A_propos
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
            this.pInfos = new System.Windows.Forms.Panel();
            this.Confirmer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pInfos
            // 
            this.pInfos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pInfos.Controls.Add(this.label4);
            this.pInfos.Controls.Add(this.label3);
            this.pInfos.Controls.Add(this.label2);
            this.pInfos.Controls.Add(this.pictureBox1);
            this.pInfos.Controls.Add(this.label1);
            this.pInfos.Location = new System.Drawing.Point(13, 13);
            this.pInfos.Name = "pInfos";
            this.pInfos.Size = new System.Drawing.Size(259, 200);
            this.pInfos.TabIndex = 0;
            // 
            // Confirmer
            // 
            this.Confirmer.Location = new System.Drawing.Point(98, 219);
            this.Confirmer.Name = "Confirmer";
            this.Confirmer.Size = new System.Drawing.Size(89, 30);
            this.Confirmer.TabIndex = 1;
            this.Confirmer.Text = "Confirmer";
            this.Confirmer.UseVisualStyleBackColor = true;
            this.Confirmer.Click += new System.EventHandler(this.Confirmer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Premières manipulations";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cours_1.Properties.Resources.cat_logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version sous alpha 1.0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Office Symbol Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "CopyRight Simon Nyssen";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 43);
            this.label4.TabIndex = 4;
            this.label4.Text = "Et l\'application se dit qu\'un jour elle deviendra aussi grande que .NET";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // A_propos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Confirmer);
            this.Controls.Add(this.pInfos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "A_propos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "A propos";
            this.pInfos.ResumeLayout(false);
            this.pInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Confirmer;
        private System.Windows.Forms.Panel pInfos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}