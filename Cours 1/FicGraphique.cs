using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Cours_1
{
    public partial class EcranGraphique : Form
    {
        private GraphicsPath GraphEnr = null; // Enregistre l'image
        private GraphicsPath GraphEnr2 = null;
        private Color Fond, Trait;
        List<MonPoint> lPoints = new List<MonPoint>();

        public EcranGraphique()
        {
            InitializeComponent();
            Trait = Color.Red;
            Fond = Color.Salmon;
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            lPoints.Clear();
            lPoints = RandGen(); // On génère la liste de points

            Dessine(lPoints); // On génère le graphique
        }

        private void EcranGraphique_Paint(object sender, PaintEventArgs e)
        {
            if (GraphEnr != null)
            {
                Rectangle zone = new Rectangle(pGraphique.Location, pGraphique.Size);
                e.Graphics.FillRectangle(new SolidBrush(Fond), zone);
                e.Graphics.DrawPath(new Pen(Trait), GraphEnr);
                e.Graphics.DrawPath(new Pen(Color.FromArgb(Trait.ToArgb() ^ 0xffffff)), GraphEnr2);
            }
        }

        private void btnTrait_Click(object sender, EventArgs e)
        {
            dlgCouleur.Color = Trait;
            if (dlgCouleur.ShowDialog() == DialogResult.OK)
            {
                Trait = dlgCouleur.Color;
                Invalidate();
            }
        }

        private void btnFond_Click(object sender, EventArgs e)
        {
            dlgCouleur.Color = Fond;
            if (dlgCouleur.ShowDialog() == DialogResult.OK)
            {
                Fond = dlgCouleur.Color;
                Invalidate();
            }
        }

        private int DeltaY(List<MonPoint> list)
        {
            int max = 0;
            int min = 0;

            foreach (MonPoint pt in list)
            {
                if (pt.y > max)
                    max = pt.y;
                if (pt.y < min)
                    min = pt.y;
            }

            return max + Math.Abs(min);
        }

        private List<MonPoint> RandGen()
        {
            List<MonPoint> ListPoints = new List<MonPoint>();
            Random Rand = new Random();
            int x = 0, y;
            int Max = Rand.Next(10, 26);

            // Génère la liste de points
            for (int i = 0; i < Max; i++)
            {
                x = x + Rand.Next(5, 21);
                y = Rand.Next(1, 202);
                if (y <= 101)
                {
                    if (y == 101)
                        y = 0;
                    else
                        y = -y;
                }
                else
                    y -= 101;

                ListPoints.Add(new MonPoint(x, y));
            }

            return ListPoints;
        }

        private void EcranGraphique_ResizeEnd(object sender, EventArgs e)
        {
            //Invalidate();
            if (lPoints.Count != 0)
                Dessine(lPoints);
        }

        private void Dessine(List<MonPoint> ListPoints)
        {
            // Ajustement à la fenêtre
            int EcartX = pGraphique.Width / ListPoints[ListPoints.Count - 1].x;
            int EcartY = pGraphique.Height / DeltaY(ListPoints);

            // Fond
            GraphEnr = new GraphicsPath();
            GraphEnr2 = new GraphicsPath();
            Rectangle zone = new Rectangle(pGraphique.Location, pGraphique.Size);
            Graphics gr = CreateGraphics();
            gr.FillRectangle(new SolidBrush(Fond), zone);
            int yc = pGraphique.Height / 2;
            int xd = pGraphique.Location.X;
            gr.DrawLine(new Pen(Color.FromArgb(Trait.ToArgb() ^ 0xffffff)), new Point(ListPoints[0].x * EcartX + xd, yc), new Point(ListPoints[ListPoints.Count - 1].x * EcartX + xd, yc)); // Pen([..]) définit la couleur inverse du trait choisit.
            GraphEnr2.AddLine(new Point(ListPoints[0].x * EcartX + xd, yc), new Point(ListPoints[ListPoints.Count - 1].x * EcartX + xd, yc));

            // Lignes
            // On trace les lignes
            for (int i = 1; i < ListPoints.Count; i++)
            {
                gr.DrawLine(new Pen(Trait), new Point(ListPoints[i - 1].x * EcartX + xd, ListPoints[i - 1].y * EcartY + yc), new Point(ListPoints[i].x * EcartX + xd, ListPoints[i - 1].y * EcartY + yc));
                gr.DrawLine(new Pen(Trait), new Point(ListPoints[i].x * EcartX + xd, ListPoints[i - 1].y * EcartY + yc), new Point(ListPoints[i].x * EcartX + xd, ListPoints[i].y * EcartY + yc));
                Application.DoEvents();
                GraphEnr.AddLine(new Point(ListPoints[i - 1].x * EcartX + xd, ListPoints[i - 1].y * EcartY + yc), new Point(ListPoints[i].x * EcartX + xd, ListPoints[i - 1].y * EcartY + yc));
                GraphEnr.AddLine(new Point(ListPoints[i].x * EcartX + xd, ListPoints[i - 1].y * EcartY + yc), new Point(ListPoints[i].x * EcartX + xd, ListPoints[i].y * EcartY + yc));
            }
        }
    }
}