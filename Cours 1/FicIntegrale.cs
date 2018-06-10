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
    public partial class EcranIntegrale : Form
    {
        static private double fctPolynome(double x)
        { return x * x - 3 * x + 4; }
        static private double fctCosinus(double x)
        { return Math.Cos(x); }
        delegate double fctAIntegrer(double a);
        static double IntegrationRectangleGauche(fctAIntegrer f, double bg, double bd, int n)
        {
            double Aire = 0;
            double x = bg;
            double pas = (bd - bg) / n;
            for (int i = 0; i < n; i++)
            {
                Aire += pas * f(x);
                x += pas;
            }
            return Aire;
        }

        public EcranIntegrale()
        {
            InitializeComponent();
        }

        private void btnPolynome_Click(object sender, EventArgs e)
        {
            double a, b;
            int nbint;
            fctAIntegrer f = new fctAIntegrer(fctPolynome);
            if (double.TryParse(tbGauche.Text, out a) && double.TryParse(tbDroite.Text, out b) && int.TryParse(tbInterval.Text, out nbint))
            {
                lbResultat.Items.Clear();
                for (int i = 0; i < 5; i++)
                {
                    lbResultat.Items.Add("Nb int = " + nbint + " => " + IntegrationRectangleGauche(f, a, b, nbint));
                    nbint *= 2;
                }
            }
            else
                MessageBox.Show("Vérifiez vos entrées");
        }

        private void btnCosinus_Click(object sender, EventArgs e)
        {
            double a, b;
            int nbint;
            fctAIntegrer f = new fctAIntegrer(fctCosinus);
            if (double.TryParse(tbGauche.Text, out a) && double.TryParse(tbDroite.Text, out b) && int.TryParse(tbInterval.Text, out nbint))
            {
                lbResultat.Items.Clear();
                for (int i = 0; i < 5; i++)
                {
                    lbResultat.Items.Add("Nb int = " + nbint + " => " + IntegrationRectangleGauche(f, a, b, nbint));
                    nbint *= 2;
                }
            }
            else
                MessageBox.Show("Vérifiez vos entrées");
        }

        private void lblGauche_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbInterval_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
