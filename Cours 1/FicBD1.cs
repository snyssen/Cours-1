using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Cours_1
{
    public partial class EcranBD1 : Form
    {
        private string sChConn = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\picho\Nextcloud\Cours\Informatique\2e bac\POO\Q2\PROGRAMMES\Cours 1\Cours 1\perso.mdb";

        public EcranBD1()
        {
            InitializeComponent();
        }

        private void btnCharger_Click(object sender, EventArgs e)
        {
            lbContenu.Items.Clear();
            OleDbConnection Conn = new OleDbConnection(sChConn);
            Conn.Open();
            OleDbCommand Comm = new OleDbCommand();
            Comm.Connection = Conn;
            Comm.CommandText = "SELECT PRE,NOM FROM Client ORDER BY NOM";
            OleDbDataReader dr = Comm.ExecuteReader();
            while (dr.Read())
                lbContenu.Items.Add(dr["PRE"].ToString() + " " + dr["NOM"]);
            dr.Close();
            Conn.Close();
        }

        private void btnCompter_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(sChConn);
            Conn.Open();
            OleDbCommand Comm = new OleDbCommand();
            Comm.Connection = Conn;
            Comm.CommandText = "SELECT COUNT(NOM) FROM Client";
            int nb = (int)Comm.ExecuteScalar();
            MessageBox.Show(nb.ToString() + " enregistrements");
            Conn.Close();
        }

        private void btnSauver_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(sChConn);
            Conn.Open();
            OleDbCommand Comm = new OleDbCommand();
            Comm.Connection = Conn;
            Comm.CommandText = "INSERT INTO Client(NOM,PRE) VALUES('" + tbNom.Text + "','" + tbPrenom.Text + "')";
            int nb = (int)Comm.ExecuteNonQuery();
            MessageBox.Show(nb.ToString() + " enregistrement(s) effectué(s)");
            Conn.Close();
            btnCharger_Click(null, null);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(sChConn);
            Conn.Open();
            OleDbCommand Comm = new OleDbCommand();
            Comm.Connection = Conn;
            Comm.CommandText = "DELETE FROM Client WHERE NOM='" + tbSupprimer.Text + "'";
            int nb = (int)Comm.ExecuteNonQuery();
            MessageBox.Show(nb.ToString() + " suppression(s) effectuée(s)");
            Conn.Close();
            btnCharger_Click(null, null);
        }
    }
}
