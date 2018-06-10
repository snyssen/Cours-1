using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Cours_1
{
    public partial class EcranExpressionsRegulieres : Form
    {
        public EcranExpressionsRegulieres()
        {
            InitializeComponent();
        }

        private bool Validite(string sExpressionReguliere)
        {
            try
            {
                Regex test = new Regex(sExpressionReguliere);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Correspondance(string sExpressionReguliere, string sAVerifier, RegexOptions roParametres)
        {
            try
            {
                Regex exp = new Regex(sExpressionReguliere, roParametres);
                return exp.IsMatch(sAVerifier);
            }
            catch
            {
                return false;
            }
        }

        private Match TrouverOccurrence(string sExpressionReguliere, string sAVerifier, RegexOptions roParametres)
        {
            Regex test = new Regex(sExpressionReguliere, roParametres);
            return test.Match(sAVerifier);
        }

        private MatchCollection TrouverOccurrences(string sExpressionReguliere, string sAVerifier, RegexOptions roParametres)
        {
            Regex test = new Regex(sExpressionReguliere, roParametres);
            return test.Matches(sAVerifier);
        }

        private string RemplacerOccurrence(string sExpressionReguliere, string sTexteDepart, string sRemplacement, RegexOptions roParametres)
        {
            Regex test = new Regex(sExpressionReguliere, roParametres);
            return test.Replace(sTexteDepart, sRemplacement);
        }

        public string[] DecouperOccurrence(string sExpressionReguliere, string sATraiter, RegexOptions roParametres)
        {
            Regex exp = new Regex(sExpressionReguliere, roParametres);
            return exp.Split(sATraiter);
        }


        private void MettreEnEvidence(MatchCollection Occurences, RichTextBox Controle)
        {
            Controle.Select(0, Controle.Text.Length);
            Controle.SelectionBackColor = Color.Transparent;
            foreach (Match Occurence in Occurences)
            {
                Controle.Select(Occurence.Index, Occurence.Length);
                Controle.SelectionBackColor = Color.Silver;
            }
        }


        private void cbIsCaseSensitive_CheckedChanged(object sender, EventArgs e)
        {
            cbIsCorrespondance.Checked = Correspondance(tbExpressionReg.Text, rtbATraiter.Text, cbIsCaseSensitive.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);
            MettreEnEvidence(TrouverOccurrences(tbExpressionReg.Text, rtbATraiter.Text, cbIsCaseSensitive.Checked ? RegexOptions.None : RegexOptions.IgnoreCase), rtbATraiter);
        }

        private void cbRemplacer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRemplacer.Checked)
            {
                MessageBox.Show(RemplacerOccurrence(tbExpressionReg.Text, rtbATraiter.Text, tbRemplacement.Text, cbIsCaseSensitive.Checked ? RegexOptions.None : RegexOptions.IgnoreCase));
                cbRemplacer.Checked = false;
            }
        }

        private void cbSeparer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSeparer.Checked)
            {
                string[] tTmp = DecouperOccurrence(tbExpressionReg.Text, rtbATraiter.Text, cbIsCaseSensitive.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);
                foreach (string s in tTmp)
                    MessageBox.Show(s);
                cbSeparer.Checked = false;
            }
        }

        private void tbExpressionReg_TextChanged(object sender, EventArgs e)
        {
            if (cbIsValid.Checked = Validite(tbExpressionReg.Text))
            {
                cbIsCorrespondance.Checked = Correspondance(tbExpressionReg.Text, rtbATraiter.Text, cbIsCaseSensitive.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);
                MettreEnEvidence(TrouverOccurrences(tbExpressionReg.Text, rtbATraiter.Text, cbIsCaseSensitive.Checked ? RegexOptions.None : RegexOptions.IgnoreCase), rtbATraiter);
            }
        }

        private void tbRemplacement_TextChanged(object sender, EventArgs e)
        {
            cbIsCorrespondance.Checked = Correspondance(tbExpressionReg.Text, rtbATraiter.Text, cbIsCaseSensitive.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);
        }

        private void EcranExpressionsRegulieres_Load(object sender, EventArgs e)
        {
            tbExpressionReg_TextChanged(null, null);
        }
    }
}
