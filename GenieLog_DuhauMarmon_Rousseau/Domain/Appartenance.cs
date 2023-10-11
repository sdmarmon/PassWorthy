using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Appartenance
    {
        /// <summary>
        /// Id
        /// </summary>
        public virtual int Id { get; set; }

        ///<summary>
        /// Utilsateur
        /// </summary>
        public virtual Utilisateur Util { get; set; }

        /// <summary>
        /// Categorie
        /// </summary>
        public virtual Categorie Cate { get; set; }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Appartenance () { }

        /// <summary>
        /// Constructeur
        /// </summary>
        public Appartenance (Utilisateur util, Categorie cate)
        {
            Util = util;
            Cate = cate; 

        }
        public override string ToString()
        {
            return (Util + ", " + Cate);
        }
    }
}
