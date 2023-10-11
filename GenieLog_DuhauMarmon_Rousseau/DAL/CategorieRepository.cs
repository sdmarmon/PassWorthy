using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate.Linq;

namespace DAL
{
    public class CategorieRepository : Repository, ICategorieRepository
    {
        public void Save(Categorie categorie)
        {
            Session.SaveOrUpdate(categorie);
            Session.Flush();
        }

        public Categorie GetCate(string nom)//récupération d'une catégorie en fonction de son nom
        {
            string requete = "select distinct c from Categorie c WHERE c.Nom=?";
            IList<Categorie> categories = Session.CreateQuery(requete).SetString(0, nom).List<Categorie>();
            if (categories.Count == 1)
            {
                return categories[0];
            }
            return null;
        }

        public Categorie GetCate(string nom, string identifiant)//vérification qu'une catégorie existe ou non pour un utilisateur donné
        {
            IList<Categorie> categories = GetAll(identifiant);
            Categorie categorie = GetCate(nom);
            if (categories.Contains(categorie))
            {
                return categorie;
            }
            return null;
        }

        public IList<Categorie> GetAll(string identifiant)//récupération de toutes les catégories d'un utilisateur
        {
            string requete = "select distinct c from Categorie c, Appartenance app, Utilisateur util WHERE util.Identifiant=? AND util.Id=app.Util.Id AND app.Cate.Id=c.Id order by c.Nom";
            IList<Categorie> categories = Session.CreateQuery(requete).SetString(0, identifiant).List<Categorie>();
            return categories;
        }

        public void Supprimer(Categorie categorie)//supprimer une catégorie
        {
            Session.Delete(categorie);
            Session.Flush();
        }
    }
}
