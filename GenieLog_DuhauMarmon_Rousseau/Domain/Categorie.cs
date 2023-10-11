using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Categorie
    {
        ///<summary>
        /// Id de la catégorie
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Nom de la catérgorie
        /// </summary>
        public virtual string Nom { get; set; }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Categorie() {}

        /// <summary>
        /// Constructeur
        /// </summary>
        public Categorie(string nom)
        {
            Nom = nom;

        }
        public override string ToString()
        {
            return Nom;
        }
    }
}
