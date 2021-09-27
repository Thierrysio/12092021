using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    public class Utilisateur
    {
        #region Attributs

        public static List<Utilisateur> CollClasse = new List<Utilisateur>();
        private int _id;
        private string _nom;
        private string _prenom;
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
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
