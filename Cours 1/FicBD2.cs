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
    public partial class EcranBD2 : Form
    {
        public EcranBD2()
        {
            InitializeComponent();
            clientBindingSource.PositionChanged += new EventHandler(BougerClient);
            ActiverNav(true);
        }

        private void BougerClient(object sender, EventArgs e)
        {
            Bouger();
        }

        private void ActiverNav(bool lActif)
        {
            btnPremier.Enabled = btnPrecedent.Enabled = btnSuivant.Enabled = btnDernier.Enabled = lActif;
            btnAjout.Enabled = btnModif.Enabled = btnSupp.Enabled = lActif;
            tbPrenom.Enabled = tbNom.Enabled = dtpNaissance.Enabled = !lActif;
            btnConf.Enabled = btnAnn.Enabled = !lActif;
        }

        private void Bouger()
        {
            btnPremier.Enabled = btnPrecedent.Enabled = btnSuivant.Enabled = btnDernier.Enabled = true;
            if (clientBindingSource.Position == 0)
                btnPremier.Enabled = btnPrecedent.Enabled = false;
            if (clientBindingSource.Position == clientBindingSource.Count - 1)
                btnSuivant.Enabled = btnDernier.Enabled = false;
            lblPos.Text = (1 + clientBindingSource.Position).ToString() + "/" + clientBindingSource.Count.ToString();
            btnSupp.Enabled = btnModif.Enabled = (clientBindingSource.Count > 0);
        }

        private void EcranBD2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'persoDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.persoDataSet.Client);
            //string s = Program.PA.ChConnDB;µ
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            clientBindingSource.Position = 0;
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            clientBindingSource.Position--;
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            clientBindingSource.Position++;
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            clientBindingSource.Position = clientBindingSource.Count - 1;
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            clientBindingSource.AddNew();
            ActiverNav(false);
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            ActiverNav(false);
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Souhaitez-vous supprimer cet enregistrement ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clientBindingSource.RemoveAt(clientBindingSource.Position);
                ValiderModif();
            }
            Bouger();
        }

        private void btnAnn_Click(object sender, EventArgs e)
        {
            clientBindingSource.CancelEdit();
            ActiverNav(true);
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            clientBindingSource.EndEdit();
            if (persoDataSet.HasChanges())
                ValiderModif();
            else
                MessageBox.Show("Aucune modification");
            ActiverNav(true);
        }

        private void ValiderModif()
        {
            try
            {
                MessageBox.Show(clientTableAdapter.Update(persoDataSet.Client).ToString() + "Mise(s) à jour effectuée(s)");
            }
            catch
            {
                MessageBox.Show("Echec de la mise à jour");
            }
        }
    }
}
