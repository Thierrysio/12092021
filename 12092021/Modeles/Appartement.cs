using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    public class Appartement
    {
        #region Attributs

        public static List<Appartement> CollClasse = new List<Appartement>();
        private string _nom;
        #endregion

        #region Constructeurs

        public Appartement(string nom)
        {
            Appartement.CollClasse.Add(this);
            _nom = nom;
        }

        #endregion

        #region Getters/Setters
        public string Nom { get => _nom; set => _nom = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
