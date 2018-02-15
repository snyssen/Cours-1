using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cours_1
{
    public partial class EcranAccueil : Form
    {
        bool clicPousser = false;

        public EcranAccueil()
        {
            InitializeComponent();
        }

        private void btnEntrez_Click(object sender, EventArgs e)
        {
            /*
            FicPrincipal f = new FicPrincipal();
            f.Show();
            this.Hide();
            f.FormClosing += this.f_FormClosing;
            */

            this.Close();
        }

        private void f_FormClosing(object send, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void btnPousser_Click(object sender, EventArgs e)
        {
            if (!clicPousser)
            {
                lblTitre.Text = "Bienvenue";
                pbImageDepart.Image = Properties.Resources.cat_logo_2;
                clicPousser = true;
            }
            else
            {
                lblTitre.Text = "Découverte de C#";
                pbImageDepart.Image = Properties.Resources.cat_logo;
                clicPousser = false;
            }
        }
    }
}
