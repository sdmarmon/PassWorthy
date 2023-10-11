using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface ICompteRepository
    {
        /// <summary>
        /// Récupère la liste des comptes
        /// </summary>
        /// <returns></returns>
        IList<Compte> GetAll(string identifiant);

        IList<Compte> GetVieux(string identifiant);

        IList<Compte> GetFaible(string identifiant);

        IList<Compte> GetMemeMdp(string identifiant, Compte compte);

        void Save(Compte compte, bool changerDate);

        void Supprimer(Compte compte);

        IList<Compte> GetCate(string identifiant, string nomCate);

        IList<Compte> GetSansCate(string identifiant);

        IList<Compte> Recherche(string identifiant, string recherche);
    }
}
