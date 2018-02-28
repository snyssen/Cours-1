namespace Cours_1
{
    partial class EcranGraphique
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
            this.btnGraph = new System.Windows.Forms.Button();
            this.pGraphique = new System.Windows.Forms.Panel();
            this.btnTrait = new System.Windows.Forms.Button();
            this.btnFond = new System.Windows.Forms.Button();
            this.dlgCouleur = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnGraph
            // 
            this.btnGraph.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGraph.AutoSize = true;
            this.btnGraph.Location = new System.Drawing.Point(188, 356);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(135, 53);
            this.btnGraph.TabIndex = 0;
            this.btnGraph.Text = "Graphique";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // pGraphique
            // 
            this.pGraphique.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pGraphique.AutoSize = true;
            this.pGraphique.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pGraphique.Location = new System.Drawing.Point(13, 13);
            this.pGraphique.Name = "pGraphique";
            this.pGraphique.Size = new System.Drawing.Size(485, 337);
            this.pGraphique.TabIndex = 1;
            this.pGraphique.Visible = false;
            // 
            // btnTrait
            // 
            this.btnTrait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTrait.Location = new System.Drawing.Point(13, 356);
            this.btnTrait.Name = "btnTrait";
            this.btnTrait.Size = new System.Drawing.Size(135, 53);
            this.btnTrait.TabIndex = 2;
            this.btnTrait.Text = "Trait";
            this.btnTrait.UseVisualStyleBackColor = true;
            this.btnTrait.Click += new System.EventHandler(this.btnTrait_Click);
            // 
            // btnFond
            // 
            this.btnFond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFond.AutoSize = true;
            this.btnFond.Location = new System.Drawing.Point(363, 356);
            this.btnFond.Name = "btnFond";
            this.btnFond.Size = new System.Drawing.Size(135, 53);
            this.btnFond.TabIndex = 3;
            this.btnFond.Text = "Fond";
            this.btnFond.UseVisualStyleBackColor = true;
            this.btnFond.Click += new System.EventHandler(this.btnFond_Click);
            // 
            // EcranGraphique
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(510, 421);
            this.Controls.Add(this.btnFond);
            this.Controls.Add(this.btnTrait);
            this.Controls.Add(this.pGraphique);
            this.Controls.Add(this.btnGraph);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(526, 460);
            this.Name = "EcranGraphique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FicGraphique";
            this.ResizeEnd += new System.EventHandler(this.EcranGraphique_ResizeEnd);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EcranGraphique_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Panel pGraphique;
        private System.Windows.Forms.Button btnTrait;
        private System.Windows.Forms.Button btnFond;
        private System.Windows.Forms.ColorDialog dlgCouleur;
    }
}