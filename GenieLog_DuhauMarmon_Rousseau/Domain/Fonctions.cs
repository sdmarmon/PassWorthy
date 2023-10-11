using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Domain
{
    public static class Fonctions
    {
        public static int detForce(string mdp)
        {
            int longueur = mdp.Length;
            int nbChar = 0;
            if (mdp.Any(char.IsDigit))
            {
                nbChar += 10;
            }
            if (mdp.Any(char.IsLower))
            {
                nbChar += 26;
            }
            if (mdp.Any(char.IsUpper))
            {
                nbChar += 26;
            }
            if (mdp.Any(ch => !Char.IsLetterOrDigit(ch)))
            {
                nbChar += 33; //https://www.owasp.org/index.php/Password_special_characters //TODO (App) : Interdiction d'utiliser tous les autres caractères ASCII
            }
            double force = Math.Pow(nbChar, longueur);
            double tailleCle = Math.Log(force, 2);

            // https://www.ssi.gouv.fr/administration/precautions-elementaires/calculer-la-force-dun-mot-de-passe/
            if (tailleCle > 80)
            {
                return 3;
            }
            else if (tailleCle > 64)
            {
                return 2;
            }
            else return 1;
        }

        public static string genMdp(int nbCarac, int nbChiffres, int nbSymb)
        {
            char[] symb = new char[33];
            symb = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~".ToCharArray();
            char[] lettres = new char[52];
            lettres = ((Enumerable.Range(65, 26).Select(c => (Char)c)).Concat(Enumerable.Range(97, 26).Select(c => (Char)c))).ToArray();
            char[] num = new char[10];
            num = Enumerable.Range(48, 10).Select(c => (Char)c).ToArray();
            int[] nb = new int[nbCarac];
            nb = Enumerable.Range(0, nbCarac).ToArray();
            
            // Déterminer la postion des chiffres & des symboles
            List<int> posChiffres = new List<int>();
            while (posChiffres.Count < nbChiffres)
            {
                for (int i = 0; i < nbChiffres; i++)
                {
                    var bytesC = new byte[nbChiffres * 8];
                    new RNGCryptoServiceProvider().GetBytes(bytesC);
                    ulong valeur = BitConverter.ToUInt64(bytesC, i * 8);
                    if (!(posChiffres.Contains(nb[valeur % (uint)nb.Length])))
                    {
                        if (posChiffres.Count < nbChiffres)
                        {
                            posChiffres.Add(nb[valeur % (uint)nb.Length]);
                        }
                    }
                }
            }
            List<int> posSymb = new List<int>();
            while (posSymb.Count < nbSymb)
            {
                for (int i = 0; i < nbSymb; i++)
                {
                    var bytesS = new byte[nbSymb * 8];
                    new RNGCryptoServiceProvider().GetBytes(bytesS);
                    ulong valeur = BitConverter.ToUInt64(bytesS, i * 8);
                    if (!(posChiffres.Contains(nb[valeur % (uint)nb.Length])))
                    {
                        if (!(posSymb.Contains(nb[valeur % (uint)nb.Length])))
                        {
                            if (posSymb.Count < nbSymb)
                            {
                                posSymb.Add(nb[valeur % (uint)nb.Length]);
                            }
                        }
                    }
                }
            }

            // Déterminer les cacractères aux positions attribuées
            var bytes = new byte[nbCarac * 8];
            new RNGCryptoServiceProvider().GetBytes(bytes);
            string mdp = "";
            for (int i = 0; i < nbCarac; i++)
            {
                ulong valeur = BitConverter.ToUInt64(bytes, i * 8);
                if (posChiffres.Contains(i))
                {
                    mdp += num[valeur % (uint)num.Length];
                }
                else if (posSymb.Contains(i))
                {
                    mdp += symb[valeur % (uint)symb.Length];
                }
                else
                {
                    mdp += lettres[valeur % (uint)lettres.Length];
                }
            }
            return mdp;
        }

        public static string[] GetQuestions()
        {
            string[] questions = new string[]{"Quel est le nom de votre premier animal de compagnie ?", "Quel est le titre de votre livre préféré ?", "Kamehameha ?",
                "Qui est le meilleur professeur de l\'ENSC ?", "Ceci est une question !?"};
            return questions;
        }
    }
}
