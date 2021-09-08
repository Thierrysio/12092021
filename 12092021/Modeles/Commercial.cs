using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    class Commercial
    {
        #region Attributs

        public static List<Commercial> CollClasse = new List<Commercial>();

        private int _id;
        private string _nom;
        private string _prenom;

        #endregion

        #region Constructeurs

        public Commercial(int id, string nom, string prenom)
        {
            Commercial.CollClasse.Add(this);
            _id = id;
            _nom = nom;
            _prenom = prenom;
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
