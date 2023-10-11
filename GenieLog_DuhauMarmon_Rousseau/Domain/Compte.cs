using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Modélise un compte
    /// </summary>
    public class Compte
    {
        ///<summary>
        /// Id du compte
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Nom du compte
        /// </summary>
        public virtual string Titre { get; set; }

        /// <summary>
        /// Identifiant de l'utilisateur sur ce compte
        /// </summary>
        public virtual string Identifiant { get; set; }

        /// <summary>
        /// Site (lien) pour le compte
        /// </summary>
        public virtual string Site { get; set; }

        /// <summary>
        /// Mot de passe de l'utilisateur sur ce compte
        /// </summary>
        public virtual string Mdp { get; set; }

        /// <summary>
        /// Force du mot de passe
        /// </summary>
        public virtual int Force { get; set; }

        /// <summary>
        /// Date de la création du compte
        /// </summary>
        public virtual DateTime Date { get; set; }

        /// <summary>
        ///Catégorie du compte
        /// </summary>
        public virtual Categorie Cate { get; set; }

        /// <summary>
        ///Utilisateur du compte
        /// </summary>
        public virtual Utilisateur Util { get; set; }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Compte() { }

        /// <summary>
        /// Constructeur
        /// </summary>
        public Compte(string identifiant, string mdp, string titre, string site, Categorie categorie, Utilisateur util)
        {
            Identifiant = identifiant;
            Mdp = mdp;
            Titre = titre;
            Force = Fonctions.detForce(mdp);
            Site = site;
            Date = DateTime.Now;
            Util = util;
            Cate = categorie;
        }

        public override string ToString()
        {
            string message;
            if (Identifiant != null)
            {
                message = "Titre : " + Titre + "\nIdentifiant : " + Identifiant + "\nMot de Passe : " + Mdp;

            }
            else
            {
                message = "SSID : " + Titre + "\nMot de Passe : " + Mdp;
            }
            return message;
        }
    }
}
