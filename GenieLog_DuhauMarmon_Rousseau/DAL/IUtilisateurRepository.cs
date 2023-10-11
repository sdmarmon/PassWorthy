using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IUtilisateurRepository
    {
        /// <summary>
        /// Récupère la liste des utilisateurs
        /// </summary>
        /// <returns></returns>
        IList<Utilisateur> GetAll();

        void Save(Utilisateur utilisateur);

        IList<Utilisateur> Authentification(string identifiant, string mdp);

        IList<Utilisateur> MdpPerdu(string identifiant, int question, string reponse);

        IList<Utilisateur> GetUtil(string identifiant);
    }
}
