using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    class Visite
    {
        #region Attributs

        public static List<Visite> CollClasse = new List<Visite>();

        private DateTime _heure;
        #endregion

        #region Constructeurs

        public Visite(DateTime heure)
        {
            Visite.CollClasse.Add(this);
            _heure = heure;
        }


        #endregion

        #region Getters/Setters
        public DateTime Heure { get => _heure; set => _heure = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
