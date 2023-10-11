using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IUtilisateurRepository utilisateurRepository = new UtilisateurRepository();
            ICategorieRepository categorieRepository = new CategorieRepository();
            ICompteRepository compteRepository = new CompteRepository();
            IAppartenanceRepository appartenanceRepository = new AppartenanceRepository();
            Application.Run(new Connexion_Form(utilisateurRepository, categorieRepository, compteRepository, appartenanceRepository));
        }
    }
}
