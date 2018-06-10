namespace Cours_1
{
    partial class EcranExpressionsRegulieres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranExpressionsRegulieres));
            this.lblExpressionReg = new System.Windows.Forms.Label();
            this.tbExpressionReg = new System.Windows.Forms.TextBox();
            this.cbIsValid = new System.Windows.Forms.CheckBox();
            this.cbIsCorrespondance = new System.Windows.Forms.CheckBox();
            this.cbIsCaseSensitive = new System.Windows.Forms.CheckBox();
            this.cbSeparer = new System.Windows.Forms.CheckBox();
            this.cbRemplacer = new System.Windows.Forms.CheckBox();
            this.tbRemplacement = new System.Windows.Forms.TextBox();
            this.lblRemplacement = new System.Windows.Forms.Label();
            this.lblATraiter = new System.Windows.Forms.Label();
            this.rtbATraiter = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblExpressionReg
            // 
            this.lblExpressionReg.AutoSize = true;
            this.lblExpressionReg.Location = new System.Drawing.Point(13, 13);
            this.lblExpressionReg.Name = "lblExpressionReg";
            this.lblExpressionReg.Size = new System.Drawing.Size(101, 13);
            this.lblExpressionReg.TabIndex = 0;
            this.lblExpressionReg.Text = "Expression régulière";
            // 
            // tbExpressionReg
            // 
            this.tbExpressionReg.Location = new System.Drawing.Point(16, 30);
            this.tbExpressionReg.Name = "tbExpressionReg";
            this.tbExpressionReg.Size = new System.Drawing.Size(772, 20);
            this.tbExpressionReg.TabIndex = 1;
            this.tbExpressionReg.TextChanged += new System.EventHandler(this.tbExpressionReg_TextChanged);
            // 
            // cbIsValid
            // 
            this.cbIsValid.AutoSize = true;
            this.cbIsValid.Enabled = false;
            this.cbIsValid.Location = new System.Drawing.Point(16, 57);
            this.cbIsValid.Name = "cbIsValid";
            this.cbIsValid.Size = new System.Drawing.Size(55, 17);
            this.cbIsValid.TabIndex = 2;
            this.cbIsValid.Text = "Valide";
            this.cbIsValid.UseVisualStyleBackColor = true;
            // 
            // cbIsCorrespondance
            // 
            this.cbIsCorrespondance.AutoSize = true;
            this.cbIsCorrespondance.Enabled = false;
            this.cbIsCorrespondance.Location = new System.Drawing.Point(16, 80);
            this.cbIsCorrespondance.Name = "cbIsCorrespondance";
            this.cbIsCorrespondance.Size = new System.Drawing.Size(104, 17);
            this.cbIsCorrespondance.TabIndex = 3;
            this.cbIsCorrespondance.Text = "Correspondance";
            this.cbIsCorrespondance.UseVisualStyleBackColor = true;
            // 
            // cbIsCaseSensitive
            // 
            this.cbIsCaseSensitive.AutoSize = true;
            this.cbIsCaseSensitive.Location = new System.Drawing.Point(582, 57);
            this.cbIsCaseSensitive.Name = "cbIsCaseSensitive";
            this.cbIsCaseSensitive.Size = new System.Drawing.Size(123, 17);
            this.cbIsCaseSensitive.TabIndex = 4;
            this.cbIsCaseSensitive.Text = "Respect de la casse";
            this.cbIsCaseSensitive.UseVisualStyleBackColor = true;
            this.cbIsCaseSensitive.CheckedChanged += new System.EventHandler(this.cbIsCaseSensitive_CheckedChanged);
            // 
            // cbSeparer
            // 
            this.cbSeparer.AutoSize = true;
            this.cbSeparer.Location = new System.Drawing.Point(711, 80);
            this.cbSeparer.Name = "cbSeparer";
            this.cbSeparer.Size = new System.Drawing.Size(63, 17);
            this.cbSeparer.TabIndex = 5;
            this.cbSeparer.Text = "Séparer";
            this.cbSeparer.UseVisualStyleBackColor = true;
            this.cbSeparer.CheckedChanged += new System.EventHandler(this.cbSeparer_CheckedChanged);
            // 
            // cbRemplacer
            // 
            this.cbRemplacer.AutoSize = true;
            this.cbRemplacer.Location = new System.Drawing.Point(711, 57);
            this.cbRemplacer.Name = "cbRemplacer";
            this.cbRemplacer.Size = new System.Drawing.Size(77, 17);
            this.cbRemplacer.TabIndex = 6;
            this.cbRemplacer.Text = "Remplacer";
            this.cbRemplacer.UseVisualStyleBackColor = true;
            this.cbRemplacer.CheckedChanged += new System.EventHandler(this.cbRemplacer_CheckedChanged);
            // 
            // tbRemplacement
            // 
            this.tbRemplacement.Location = new System.Drawing.Point(16, 117);
            this.tbRemplacement.Name = "tbRemplacement";
            this.tbRemplacement.Size = new System.Drawing.Size(772, 20);
            this.tbRemplacement.TabIndex = 8;
            this.tbRemplacement.TextChanged += new System.EventHandler(this.tbRemplacement_TextChanged);
            // 
            // lblRemplacement
            // 
            this.lblRemplacement.AutoSize = true;
            this.lblRemplacement.Location = new System.Drawing.Point(13, 100);
            this.lblRemplacement.Name = "lblRemplacement";
            this.lblRemplacement.Size = new System.Drawing.Size(118, 13);
            this.lblRemplacement.TabIndex = 7;
            this.lblRemplacement.Text = "Texte de remplacement";
            // 
            // lblATraiter
            // 
            this.lblATraiter.AutoSize = true;
            this.lblATraiter.Location = new System.Drawing.Point(13, 140);
            this.lblATraiter.Name = "lblATraiter";
            this.lblATraiter.Size = new System.Drawing.Size(72, 13);
            this.lblATraiter.TabIndex = 9;
            this.lblATraiter.Text = "Texte à traiter";
            // 
            // rtbATraiter
            // 
            this.rtbATraiter.Location = new System.Drawing.Point(16, 157);
            this.rtbATraiter.Name = "rtbATraiter";
            this.rtbATraiter.Size = new System.Drawing.Size(772, 281);
            this.rtbATraiter.TabIndex = 10;
            this.rtbATraiter.Text = resources.GetString("rtbATraiter.Text");
            // 
            // EcranExpressionsRegulieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbATraiter);
            this.Controls.Add(this.lblATraiter);
            this.Controls.Add(this.tbRemplacement);
            this.Controls.Add(this.lblRemplacement);
            this.Controls.Add(this.cbRemplacer);
            this.Controls.Add(this.cbSeparer);
            this.Controls.Add(this.cbIsCaseSensitive);
            this.Controls.Add(this.cbIsCorrespondance);
            this.Controls.Add(this.cbIsValid);
            this.Controls.Add(this.tbExpressionReg);
            this.Controls.Add(this.lblExpressionReg);
            this.Name = "EcranExpressionsRegulieres";
            this.Text = "Expression régulière";
            this.Load += new System.EventHandler(this.EcranExpressionsRegulieres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExpressionReg;
        private System.Windows.Forms.TextBox tbExpressionReg;
        private System.Windows.Forms.CheckBox cbIsValid;
        private System.Windows.Forms.CheckBox cbIsCorrespondance;
        private System.Windows.Forms.CheckBox cbIsCaseSensitive;
        private System.Windows.Forms.CheckBox cbSeparer;
        private System.Windows.Forms.CheckBox cbRemplacer;
        private System.Windows.Forms.TextBox tbRemplacement;
        private System.Windows.Forms.Label lblRemplacement;
        private System.Windows.Forms.Label lblATraiter;
        private System.Windows.Forms.RichTextBox rtbATraiter;
    }
}