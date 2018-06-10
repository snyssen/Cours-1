using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cours_1
{
    public partial class EcranExplorateur : Form
    {
        private TreeNode NoeudRacine;
        public EcranExplorateur()
        {
            InitializeComponent();
            slMessage.Text = "";
            LireDisque();
        }

        private void LireDisque()
        {
            Cursor = Cursors.WaitCursor;
            slMessage.Text = "Lecture de l'arborescence";
            NoeudRacine = new TreeNode("Poste de travail", 0, 0); // On se place dans le poste de travail, arguments derrière = images
            tvRepertoire.Nodes.Clear();
            tvRepertoire.Nodes.Add(NoeudRacine);
            string[] Disques =  Environment.GetLogicalDrives(); // On récupère les noms des disques
            foreach(string Disque in Disques)
            {
                TreeNode NoeudDisque = new TreeNode(Disque, 1, 1);
                NoeudRacine.Nodes.Add(NoeudDisque);
                LireRepertoires(Disque, NoeudDisque.Nodes);
            }
            slMessage.Text = "";
            Cursor = Cursors.Arrow;
        }

        private void LireRepertoires(string nd, TreeNodeCollection tnc)
        {
            if (Directory.Exists(nd))
            {
                try
                {
                    string[] sReps = Directory.GetDirectories(nd);
                    foreach(string sRep in sReps)
                    {
                        string s1 = "";
                        string s2 = "";
                        s1 = NomFichier(sRep);
                        s2 = s1.ToUpper();
                        TreeNode NoeudCourant;
                        if (s2 == "RECYCLED" || s2 == "RECYCLER" || s2 == "$RECYCLE.BIN")
                            NoeudCourant = new TreeNode(s1, 4, 4);
                        else
                            NoeudCourant = new TreeNode(s1, 2, 3);
                        tnc.Add(NoeudCourant);
                        //LireRepertoires(sRep, NoeudCourant.Nodes);
                    }
                }

                catch { }
            }
        }

        private void LireFichiers(string sRep)
        {
            lvFichier.Items.Clear();
            slMessage.Text = "Rafraîchiessement de " + sRep + " en cours.";
            Cursor = Cursors.WaitCursor;
            try
            {
                string[] sFics = Directory.GetFiles(sRep);
                string[] lvCol = new string[4];
                // lvCol[0] <- Nom du fichier
                // lvCol[1] <- Taille du fichier
                // lvCol[2] <- Date de création du fichier
                // lvCol[3] <- Date de dernière modification du fichier

                slMessage.Text = "Parcours de " + sRep;
                foreach (string sFic in sFics)
                {
                    if (sFic.ToUpper() != "PAGEFILE.SYS")
                    {
                        FileInfo fi = new FileInfo(sFic);
                        lvCol[0] = NomFichier(sFic);
                        if (fi.Length > 1024 * 1024)
                            lvCol[1] = (fi.Length / 1024 * 1024).ToString() + " MB";
                        else if (fi.Length > 1024)
                            lvCol[1] = (fi.Length / 1024).ToString() + " KB";
                        else
                            lvCol[1] = (fi.Length / 1024).ToString() + " B";
                        lvCol[2] = fi.CreationTime.ToString("dd/MM/yyyy");
                        lvCol[3] = fi.LastWriteTime.ToString("dd/MM/yyyy");

                        ListViewItem lvi = new ListViewItem(lvCol, 0);
                        lvFichier.Items.Add(lvi);
                    }
                }
            }
            catch(IOException Fot)
            {
                MessageBox.Show("Erreur d'accès à " + sRep + " (" + Fot.Message + ")");
            }
            catch
            {
                MessageBox.Show("Erreur d'accès à " + sRep);
            }
            finally
            {
                slMessage.Text = "";
                Cursor = Cursors.Arrow;
            }
        }

        private string NomFichier(string nf)
        {
            return nf.Substring(1 + nf.LastIndexOf('\\'));
        }

        private void tsQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsPetitesIcones_Click(object sender, EventArgs e)
        {
            lvFichier.View = View.SmallIcon;
        }

        private void tsGrandesIcones_Click(object sender, EventArgs e)
        {
            lvFichier.View = View.LargeIcon;
        }

        private void tsListe_Click(object sender, EventArgs e)
        {
            lvFichier.View = View.List;
        }

        private void tsDetail_Click(object sender, EventArgs e)
        {
            lvFichier.View = View.Details;
        }

        private void tvRepertoire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode NoeudCourant = e.Node;
            if (NoeudCourant == NoeudRacine)
            {
                string[] sTmp = { "Poste de travail", "", "", "" };
                ListViewItem lvi = new ListViewItem(sTmp, 0);
                lvFichier.Items.Add(lvi);
            }
            else
            {
                string sRep = NoeudCourant.FullPath;
                sRep = sRep.Substring(1 + sRep.IndexOf('\\'));
                try
                {
                    lvFichier.Items.Clear();
                    if (!Directory.Exists(sRep))
                    {
                        string[] sTmp = { "Non Opérationnel", "", "", "" };
                        ListViewItem lvi = new ListViewItem(sTmp, 0);
                        lvFichier.Items.Add(lvi);
                        Cursor = Cursors.Arrow;
                        slMessage.Text = "";
                        tvRepertoire.Focus();
                    }
                    else
                        LireFichiers(sRep);

                }
                catch (IOException Fote)
                {
                    MessageBox.Show("Erreur d'accès à " + sRep + " (" + Fote.Message + ").");
                    Cursor = Cursors.Arrow;
                    slMessage.Text = "";
                    tvRepertoire.Focus();
                }
            }
        }
    }
}
