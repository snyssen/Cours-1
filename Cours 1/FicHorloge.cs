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
    public partial class EcranHorloge : Form
    {

       
        public EcranHorloge()
        {
            InitializeComponent();
            Chronomètre.Start();
        }

        private void Chronomètre_Tick(object sender, EventArgs e)
        {
            Invalidate(); // Recharge l'ensemble de la fenêtre
            this.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }

        private void EcranHorloge_Paint(object sender, PaintEventArgs e)
        {
            int xcentre = ClientRectangle.Width / 2;
            int ycentre = ClientRectangle.Height / 2;

            int ax = 4 * xcentre / 5;
            int ay = 4 * ycentre / 5;


            int x, y;
            // Dessine le cadran
            for (int i = 0; i < 12; i++)
            {
                x = xcentre + (int)(ax * Math.Cos(i * Math.PI / 6));
                y = ycentre + (int)(ay * Math.Sin(i * Math.PI / 6));
                if (i % 3 == 0)
                {
                    e.Graphics.FillEllipse(new SolidBrush(Color.Red), x, y, 10, 10);
                }
                else
                {
                    e.Graphics.FillEllipse(new SolidBrush(Color.Blue), x, y, 10, 10);
                }
            }
            DateTime heure = DateTime.Now;
            this.Text = heure.Hour + ":" + heure.Minute + ":" + heure.Second;
            //affiche l'aiguille des secondes
            x = xcentre + (int)(0.9 * ax * Math.Cos(heure.Second * Math.PI / 30 - Math.PI / 2)); // Premier facteur détermine la taille de l'aiguille (=> arbitraire) | second facteur la distance par rapport au centre
            y = ycentre + (int)(0.9 * ay * Math.Sin(heure.Second * Math.PI / 30 - Math.PI / 2)); // Dernier facteur détermine l'angle de l'aiguille; on fait s * 2pi/60 (car 60 sec sur une boucle) - pi/2 (parce que ???)
            e.Graphics.DrawLine(new Pen(Color.Black), xcentre, ycentre, x, y); // On dessine alors l'aiguille en traçant une ligne entre le centre et le point dont on vient de déterminer les coordonnées
            //affiche l'aiguille des minutes
            x = xcentre + (int)(0.8 * ax * Math.Cos(heure.Minute * Math.PI / 30 + heure.Second * Math.PI / 1800 - Math.PI / 2));
            y = ycentre + (int)(0.8 * ay * Math.Sin(heure.Minute * Math.PI / 30 + heure.Second * Math.PI / 1800 - Math.PI / 2));
            e.Graphics.DrawLine(new Pen(Color.Black, 3), xcentre, ycentre, x, y);
            //affiche l'aiguille des heures
            x = xcentre + (int)(0.65 * ax * Math.Cos(heure.Hour * Math.PI / 6 + heure.Minute * Math.PI / 360 - Math.PI / 2));
            y = ycentre + (int)(0.65 * ay * Math.Sin(heure.Hour * Math.PI / 6 + heure.Minute * Math.PI / 360 - Math.PI / 2));
            e.Graphics.DrawLine(new Pen(Color.Black, 8), xcentre, ycentre, x, y);
        }
    }
}
