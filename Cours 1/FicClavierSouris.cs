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
    public partial class Ecran_Clavier_Souris : Form
    {
        int N_Gauche, N_Droit;
        public Ecran_Clavier_Souris()
        {
            InitializeComponent();
            Btn_RAZ_Click(null, null); // /!\ si on joue avec le sender ou le e, ne surtout pas mettre null
        }

        private void Btn_RAZ_Click(object sender, EventArgs e) //Sender = bouton
        {
            N_Gauche = N_Droit = 0;
            tbGauche.Text = tbDroite.Text = "0";
        }

        private void pPositionSouris_MouseMove(object sender, MouseEventArgs e)
        {
            tbAbscisse.Text = e.X.ToString();
            tbOrdonnee.Text = e.Y.ToString();
        }

        private void pPositionSouris_MouseDown(object sender, MouseEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Left:
                    N_Gauche++;
                    tbGauche.Text = N_Gauche.ToString();
                    break;
                case MouseButtons.Right:
                    N_Droit++;
                    tbDroite.Text = N_Droit.ToString();
                    break;
            }
        }

        private void Ecran_Clavier_Souris_KeyUp(object sender, KeyEventArgs e)
        {
            string s = "Touche relâchée : " + e.KeyCode + ", valeur : " + e.KeyValue;
            lbClavier.Items.Insert(0, s);
        }

        private void Ecran_Clavier_Souris_KeyDown(object sender, KeyEventArgs e)
        {
            string s = "Touche enfoncée : " + e.KeyCode + ", valeur : " + e.KeyValue;
            lbClavier.Items.Insert(0, s);
        }

        private void Ecran_Clavier_Souris_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = "Touche pressée : " + e.KeyChar;
            lbClavier.Items.Insert(0, s);
        }

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}