using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Cours_1
{
    sealed class ParamApplication : ApplicationSettingsBase
    {
        [UserScopedSetting()]

        public string ChConnDB
        {
            get { return (string)this["csPerso"]; }
            set { this["csPerso"] = value; }
        }
    }
    static class Program
    {
        public static ParamApplication PA = new ParamApplication();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EcranAccueil());
            Application.Run(new FicPrincipal());
        }
    }
}
