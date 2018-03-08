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
    public partial class EcranCarnaval : Form
    {
        public EcranCarnaval()
        {
            InitializeComponent();
        }

        private void btnGeometrique_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bien vu l'aveugle !");
        }

        private void btnTexte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rien de plus l'aveugle");
        }

        private void DefinirZone()
        {
            GraphicsPath dessin = new GraphicsPath();
            Point[] points = new Point[] // On définit les points du masque
            {
                new Point(0, 0),
                new Point(0, Size.Height),
                new Point(Size.Width / 4, 4 * Size.Height / 5),
                new Point(Size.Width / 2, Size.Height),
                new Point(3 * Size.Width / 4, 4 * Size.Height / 5),
                new Point(Size.Width, Size.Height),
                new Point(Size.Width, 0)
            };
            dessin.AddClosedCurve(points); // On dessine le contour du masque
            Region = new Region(dessin);
        }

        private void EcranCarnaval_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void EcranCarnaval_Paint(object sender, PaintEventArgs e)
        {
            DefinirZone();
            btnTexte.Size = new Size(ClientSize.Width - 20, btnTexte.Size.Height);
            DessinerBoutonTexte();
            btnGeometrique.Size = new Size(ClientSize.Width - 20, ClientSize.Height / 4 - 20);
            DessinerBoutonGeometrique();
        }

        private void DessinerBoutonTexte()
        {
            GraphicsPath gp = new GraphicsPath();
            StringFormat sf = new StringFormat(StringFormat.GenericDefault);
            sf.Alignment = StringAlignment.Center;
            gp.AddString("! Cliquons ensemble !", new FontFamily("Courier New"), (int)FontStyle.Bold, 24, new Point(ClientSize.Width / 2, 0), sf);
            btnTexte.Region = new Region(gp);
        }

        private void DessinerBoutonGeometrique()
        {
            int w = btnGeometrique.Size.Width;
            int h = btnGeometrique.Size.Height;
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(new Rectangle(0, 0, w / 2, h));
            gp.AddEllipse(new Rectangle(w / 4, h / 2, w / 6, h / 3));
            gp.AddEllipse(new Rectangle(w / 2, 0, w / 2, h));
            gp.AddEllipse(new Rectangle(3 * w / 4 - w / 6, h / 2, w / 6,  h / 3));
            btnGeometrique.Region = new Region(gp);
        }
    }
}
