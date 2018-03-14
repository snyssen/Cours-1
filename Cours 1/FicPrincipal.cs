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
    public partial class FicPrincipal : Form
    {
        public FicPrincipal()
        {
            InitializeComponent();
        }

        private void FicPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void mQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void mNonDefini_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité non implémentée");
        }

        private void FicPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Souhaitez-vous réellement fermer cette fenêtre ?", "Votre ultime bafouille", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void mAide_Click(object sender, EventArgs e)
        {
            A_propos aide = new A_propos();
            aide.ShowDialog();
        }

        private void mfProgression_Click(object sender, EventArgs e)
        {
            EcranProgression f = new EcranProgression();
            f.ShowDialog();
        }

        private void mfListe_Click(object sender, EventArgs e)
        {
            EcranListe f = new EcranListe();
            f.ShowDialog();
        }

        private void mfEditeur_Click(object sender, EventArgs e)
        {
            EcranEditeur f = new EcranEditeur();
            f.ShowDialog();
        }

        private void mfHorloge_Click(object sender, EventArgs e)
        {
            EcranHorloge f = new EcranHorloge();
            f.ShowDialog();
        }

        private void mefSpirographe_Click(object sender, EventArgs e)
        {
            EcranSpirographe f = new EcranSpirographe();
            f.ShowDialog();
        }

        private void mefGraphique_Click(object sender, EventArgs e)
        {
            EcranGraphique f = new EcranGraphique();
            f.ShowDialog();
        }

        private void mfCarnaval_Click(object sender, EventArgs e)
        {
            EcranCarnaval f = new EcranCarnaval();
            f.ShowDialog();
        }

        private void mfClavierSouris_Click(object sender, EventArgs e)
        {
            Ecran_Clavier_Souris f = new Ecran_Clavier_Souris();
            f.ShowDialog();
        }

        private void mfExplorateur_Click(object sender, EventArgs e)
        {
            EcranExplorateur f = new EcranExplorateur();
            f.ShowDialog();
        }

        private void mfBDD_Click(object sender, EventArgs e)
        {
            EcranBD1 f = new EcranBD1();
            f.ShowDialog();
        }
    }
}
