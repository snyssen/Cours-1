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
            string[] Disques =  Environment.GetLogicalDrives(); // On récupère les disques
            foreach(string Disque in Disques)
            {
                TreeNode NoeudDisque = new TreeNode(Disque, 1, 1);
                NoeudRacine.Nodes.Add(NoeudDisque);
            }
            slMessage.Text = "";
            Cursor = Cursors.Arrow;
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
    }
}
