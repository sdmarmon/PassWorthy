using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    /// <summary>
    /// Interface d'accès aux catégories
    /// </summary>
    public interface ICategorieRepository
    {
        /// <summary>
        /// Récupère la liste des categories
        /// </summary>
        /// <returns></returns>
        IList<Categorie> GetAll(string identifiant);

        /// <summary>
        /// Sauvegarde une categorie
        /// </summary>
        /// <param name="categorie">la categorie</param>
        void Save(Categorie categorie);

        void Supprimer(Categorie categorie);

        Categorie GetCate(string nom);

        Categorie GetCate(string nom, string identifiant);
    }
}
