using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    public abstract class Utilisateur : ITest
    {
        #region Attributs

        public static List<Utilisateur> CollClasse = new List<Utilisateur>();
        protected int _id;
        protected string _nom;
        protected string _prenom;
        #endregion

        #region Constructeurs



         public Utilisateur(int id, string nom, string prenom)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;

            Utilisateur.CollClasse.Add(this);
        }


        #endregion

        #region Getters/Setters
        public abstract int Id { get; set; }
        public abstract string Nom { get; set; }
        public abstract string Prenom { get; set; }

        #endregion

        #region Methodes

        public string nager()
        {
            return "je nage";
        }

        public virtual string parler()
        {
           
            return "ok utilisateur";
        }
        
        public abstract string marcher();

        public int tester()
        {
            return 3;
        }


        #endregion
    }
}
