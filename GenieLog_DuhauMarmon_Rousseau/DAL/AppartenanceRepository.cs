using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate.Linq;

namespace DAL
{
    public class AppartenanceRepository : Repository , IAppartenanceRepository
    {
        public void Save(Appartenance appartenance)
        {
            Session.SaveOrUpdate(appartenance);
            Session.Flush();
        }

        public void SaveCateBase(ICategorieRepository categorieRepository, Utilisateur utilisateur)//association des catégories de bases à un utilisateur (nouveau)
        {
            List<string> cateBase = new List<string> {"Administratif", "Réseaux sociaux", "Scolarité", "Wifi"};
            // Sérialiser les outputs de la commande ?
            // netsh wlan show profiles
            // netsh wlan show profile name="SSID" key=clear
            foreach (string cate in cateBase)
            {
                Categorie categorie = categorieRepository.GetCate(cate);
                if (categorie==null)
                {
                    categorie = new Categorie(cate);
                    categorieRepository.Save(categorie);
                    this.Save(new Appartenance(utilisateur, categorie));
                }
                else
                {
                    this.Save(new Appartenance(utilisateur, categorie));
                }
            }
        }

        public void Supprimer(Appartenance appartenance)//supprimer une appartenance (catégorie-utilisateur)
        {
            Session.Delete(appartenance);
            Session.Flush();
        }

        public Appartenance GetApp(Utilisateur utilisateur, Categorie categorie)//vérifier qu'une catégorie existe déjà pour un utilisateur donné
        {
            string requete = "select distinct a from Appartenance a where a.Util.Id=? and a.Cate.Id=?";
            IList<Appartenance> appartenances = Session.CreateQuery(requete).SetInt32(0, utilisateur.Id).SetInt32(1, categorie.Id).List<Appartenance>();
            if (appartenances.Count == 1)
            {
                return appartenances[0];
            }
            return null;
        }

        public IList<Appartenance> GetAll(Categorie categorie)//récupérer toutes les catégories d'un utilisateur
        {
            string requete = "select distinct a from Appartenance a where a.Cate.Id=?";
            IList<Appartenance> appartenances = Session.CreateQuery(requete).SetInt32(0, categorie.Id).List<Appartenance>();
            return appartenances;
        }
    }
}
