using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Modélise un utilisateur
    /// </summary>
    /// 

    public class Utilisateur
    {
        ///<summary>
        /// Id de l'utilisateur
        /// </summary>
        public virtual int Id { get; set; } //à voir si cet id est vraiment utile, car normalement l'identifiant est unique (sinon pour le reste genre retrouvé le mdp, c'est la loose)

        /// <summary>
        /// Identifiant de l'utilisateur
        /// </summary>
        public virtual string Identifiant { get; set; }

        /// <summary>
        /// Mot de passe de l'utilisateur
        /// </summary>
        public virtual string Mdp { get; set; }

        /// <summary>
        /// Question de l'utilisateur
        /// </summary>
        public virtual int Question { get; set; }

        /// <summary>
        /// Réponse à la question de l'utilisateur
        /// </summary>
        public virtual string Reponse { get; set; }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Utilisateur() { }

        /// <summary>
        /// Constructeur
        /// </summary>
        public Utilisateur(string identifiant, string mdp, int question, string reponse)
            {
            Identifiant = identifiant;
            Mdp = mdp;
            Question = question;
            Reponse = reponse;
            }

            public override string ToString()
            {
            return "Identifiant : " + Identifiant + "\nMot de passe : " + Mdp;
            }
        }
}
