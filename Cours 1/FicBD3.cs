using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISET2018_CouClasses;
using ISET2018_CouGestion;

namespace Cours_1
{
    public partial class EcranBD3 : Form
    {
        private DataTable dtPersonne;
        private BindingSource bsPersonne;
        private string sChConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\picho\Nextcloud\Cours\Informatique\2e bac\POO\Q2\db\BD_Perso.mdf';Integrated Security=True;Connect Timeout=30";
            public EcranBD3()
        {
            InitializeComponent();
            RemplirDGV();
            if (dgvPersonnes.Rows.Count > 0)
            {
                Activer(true);
                dgvPersonnes.Rows[0].Selected = true;
            }
            else
                Activer(false);
        }

        private void Activer(bool lNavigation)
        {
            btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = lNavigation;
            btnAnnuler.Enabled = btnConfirmer.Enabled = !lNavigation;
            dtpNaissance.Enabled = tbNom.Enabled = tbPrenom.Enabled = !lNavigation;
            dgvPersonnes.Enabled = lNavigation;
            if (lNavigation)
                dgvPersonnes.Focus();
            else
                tbPrenom.Focus();
        }

        private void RemplirDGV()
        {
            dtPersonne = new DataTable();
            dtPersonne.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtPersonne.Columns.Add("Afficher");
            List<C_Personne> lTmp = new G_Personne(sChConn).Lire("Nom");
            foreach (C_Personne Tmp in lTmp)
                dtPersonne.Rows.Add(Tmp.ID, Tmp.PRE + " " + Tmp.NOM);
            bsPersonne = new BindingSource();
            bsPersonne.DataSource = dtPersonne;
            dgvPersonnes.DataSource = bsPersonne;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Activer(false);
            tbID.Text = tbPrenom.Text = tbNom.Text = "";
            dtpNaissance.Value = DateTime.Today;
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            if (dgvPersonnes.SelectedRows.Count > 0)
            {
                Activer(false);
                tbID.Text = dgvPersonnes.SelectedRows[0].Cells["ID"].Value.ToString();
                C_Personne Tmp = new G_Personne(sChConn).Lire_ID(int.Parse(tbID.Text));
                tbPrenom.Text = Tmp.PRE;
                tbNom.Text = Tmp.NOM;
                dtpNaissance.Value = (Tmp.NAI == null ? DateTime.Today : (DateTime)Tmp.NAI);

            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPersonnes.SelectedRows.Count > 0)
            {
                int nID = (int)dgvPersonnes.SelectedRows[0].Cells["ID"].Value;
                new G_Personne(sChConn).Supprimer(nID);
                bsPersonne.RemoveCurrent(); // Test
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (tbNom.Text.Length == 0)
                MessageBox.Show("Veuillez renseigner le nom");
            else
            {
                if (tbID.Text == "") // Mode ajout
                {
                    int nID = new G_Personne(sChConn).Ajouter(tbNom.Text, tbPrenom.Text, dtpNaissance.Value);
                    dtPersonne.Rows.Add(nID, tbPrenom.Text + " " + tbNom.Text);
                }
                else // Mode édition
                {
                    int nID = int.Parse(tbID.Text);
                    new G_Personne(sChConn).Modifier(nID, tbNom.Text, tbPrenom.Text, dtpNaissance.Value);
                    for (int i = 0; i < dtPersonne.Rows.Count; i++)
                    {
                        if ((int)dtPersonne.Rows[i]["ID"] == nID)
                        {
                            dtPersonne.Rows[i]["Afficher"] = tbPrenom.Text + " " + tbNom.Text;
                            break;
                        }
                    }
                }
                Activer(true);
            }
        }
    }
}
