using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    public class Periode
    {
        #region Attributs

        public static List<Periode> CollClasse = new List<Periode>();
        private string _nom;
        #endregion

        #region Constructeurs

        public Periode(string nom)
        {
            Periode.CollClasse.Add(this);
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
