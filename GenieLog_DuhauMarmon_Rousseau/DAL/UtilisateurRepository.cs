using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate.Linq;

namespace DAL
{
    public class UtilisateurRepository : Repository, IUtilisateurRepository
    {
        public IList<Utilisateur> GetAll()
        {
            return Session.Query<Utilisateur>().ToList();
        }

        public void Save(Utilisateur utilisateur)
        {
            Session.SaveOrUpdate(utilisateur);
            Session.Flush();
        }

        public IList<Utilisateur> Authentification(string identifiant, string mdp) //authentification standard
        {
            string requete = "from Utilisateur util where (util.Identifiant=? and util.Mdp=?)";
            IList<Utilisateur> utilisateurs = Session.CreateQuery(requete).SetString(0, identifiant).SetString(1, mdp).List<Utilisateur>();
            return utilisateurs;
        }

        public IList<Utilisateur> MdpPerdu(string identifiant, int question, string reponse) //l'authentification quand le mot de passe est perdu
        {
            string requete = "from Utilisateur util where (util.Identifiant=? and util.Question=? and util.Reponse=?)";
            IList<Utilisateur> utilisateurs = Session.CreateQuery(requete).SetString(0, identifiant).SetInt32(1, question).SetString(2, reponse.ToLower()).List<Utilisateur>();
            return utilisateurs;
        }

        public IList<Utilisateur> GetUtil(string identifiant) //récupération d'un utilisateur
        {
            string requete = "from Utilisateur util where (util.Identifiant=?)";
            IList<Utilisateur> utilisateurs = Session.CreateQuery(requete).SetString(0, identifiant).List<Utilisateur>();
            return utilisateurs;
        }
    }   
}
