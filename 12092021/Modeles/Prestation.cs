using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    public class Prestation
    {
        #region Attributs

        public static List<Prestation> CollClasse = new List<Prestation>();

        private int _nbreActes;
        #endregion

        #region Constructeurs

        public Prestation(int nbreActes)
        {
            Prestation.CollClasse.Add(this);
            _nbreActes = nbreActes;
        }

        #endregion

        #region Getters/Setters
        public int NbreActes { get => _nbreActes; set => _nbreActes = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
