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
    public partial class EcranProgression : Form
    {
        public EcranProgression()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExecuter_Click(object sender, EventArgs e)
        {
            int i, j, pas;
            Cursor Curseur = this.Cursor; //Stocke le curseur
            Random delai = new Random();
            Cursor = Cursors.WaitCursor; // Affiche un curseur d'attente
            btnExecuter.Enabled = btnQuitter.Enabled = false;

            // Simulation de copie d'un fichier
            for (i=1;i<=8;i++)
            {
                pbPrincipale.Value = 0;
                pas = 5 + 9 * delai.Next(20);
                for(j=1;j<=20;j++)
                {
                    pbSecondaire.Value = j * 5;
                    System.Threading.Thread.Sleep(pas);
                }
                pbPrincipale.Value = i * 100 / 8;
            }

            btnExecuter.Enabled = btnQuitter.Enabled = true;
            Cursor = Curseur;
        }
    }
}
