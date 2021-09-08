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
        private List<Region> _lesRegions;

        #endregion

        #region Constructeurs

        public Commercial(int id, string nom, string prenom)
        {
            Commercial.CollClasse.Add(this);
            _id = id;
            _nom = nom;
            _prenom = prenom;
            _lesRegions = new List<Region>();

        }

        #endregion

        #region Getters/Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public List<Region> LesRegions { get => _lesRegions; set => _lesRegions = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
