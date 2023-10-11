using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IAppartenanceRepository
    {
        void Save(Appartenance appartenance);

        void SaveCateBase(ICategorieRepository categorieRepository, Utilisateur utilisateur);

        void Supprimer(Appartenance appartenance);

        Appartenance GetApp(Utilisateur utilisateur, Categorie categorie);

        IList<Appartenance> GetAll(Categorie categorie);
    }
}
