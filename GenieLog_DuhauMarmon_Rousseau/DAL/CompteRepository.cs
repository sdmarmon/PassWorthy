using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate.Linq;

namespace DAL
{
    public class CompteRepository : Repository, ICompteRepository
    {
        public IList<Compte> GetAll(string identifiant)
        {
            string requete = "select distinct c from Compte c where c.Util.Id in (from Utilisateur util where util.Identifiant=?) order by c.Titre";
            IList<Compte> comptes = Session.CreateQuery(requete).SetString(0, identifiant).List<Compte>();
            return comptes;
        }

        public IList<Compte> GetFaible(string identifiant)
        {
            string requete = "select distinct c from Compte c where (c.Util.Id in (from Utilisateur util where util.Identifiant=?) and c.Force=1) order by c.Titre";
            IList<Compte> comptes = Session.CreateQuery(requete).SetString(0, identifiant).List<Compte>();
            return comptes;
        }

        public IList<Compte> GetVieux(string identifiant)
        {
            DateTime dateLimite = DateTime.Now.AddDays(-180);
            string requete = "select distinct c from Compte c where (c.Util.Id in (from Utilisateur util where util.Identifiant=?) and c.Date < ?) order by c.Titre";
            IList<Compte> comptes = Session.CreateQuery(requete).SetString(0, identifiant).SetDateTime(1, dateLimite).List<Compte>(); 
            return comptes;
        }

        public IList<Compte> GetMemeMdp(string identifiant, Compte compte)
        {
            string requete = "select distinct c from Compte c where (c.Util.Id in (from Utilisateur util where util.Identifiant=?) and c.Id!=? and c.Mdp=?) order by c.Titre";
            IList<Compte> comptes = Session.CreateQuery(requete).SetString(0, identifiant).SetInt32(1, compte.Id).SetString(2, compte.Mdp).List<Compte>();
            return comptes;
        }

        public void Save(Compte compte, bool changerDate)
        {
            if (changerDate ==true)
            {
                compte.Date = DateTime.Now; // quand le mot de passe est modifié où que le compte est nouvellement crée, la date est mise à jour
            }
            Session.SaveOrUpdate(compte);
            Session.Flush();
        }

        public void Supprimer(Compte compte)
        {
            Session.Delete(compte);
            Session.Flush();
        }

        public IList<Compte> GetCate(string identifiant, string nomCate)//récupération des comptes dans une catégorie par ordre alphabétique
        {
            string requete = "select distinct c from Compte c where ((c.Cate.Id in (from Categorie cate where cate.Nom=?)) and (c.Util.Id in (from Utilisateur util where util.Identifiant=?))) order by c.Titre";
            IList<Compte> comptes = Session.CreateQuery(requete).SetString(0, nomCate).SetString(1, identifiant).List<Compte>();
            return comptes;
        }

        public IList<Compte> GetSansCate(string identifiant)//récupération des comptes sans catégories par ordre alphabétique
        {
            string requete = "select distinct c from Compte c where (c.Cate.Id is null) and (c.Util.Id in (from Utilisateur util where util.Identifiant=?)) order by c.Titre";
            IList<Compte> categories = Session.CreateQuery(requete).SetString(0, identifiant).List<Compte>();
            return categories;
        }

        public IList<Compte> Recherche(string identifiant, string recherche)//récupération des comptes correspondants à la recherche
        {
            string requete = "select distinct c from Compte c where ((c.Titre like ? or c.Site like ?) and (c.Util.Id in (from Utilisateur util where util.Identifiant=?))) order by c.Titre";
            IList<Compte> comptes = Session.CreateQuery(requete).SetString(0, "%"+recherche+"%").SetString(1, "%" + recherche + "%").SetString(2, identifiant).List<Compte>();
            return comptes;
        }
    }
}