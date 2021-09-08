using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    class Prestation
    {
        #region Attributs

        public static List<Prestation> CollClasse = new List<Prestation>();

        private int _nbreActes;
        private TypePrestation _leTypePrestation;
        #endregion

        #region Constructeurs

        public Prestation(int nbreActes, TypePrestation leTypePrestation)
        {
            Prestation.CollClasse.Add(this);
            _nbreActes = nbreActes;
            _leTypePrestation = leTypePrestation;
        }

        #endregion

        #region Getters/Setters
        public int NbreActes { get => _nbreActes; set => _nbreActes = value; }
        public TypePrestation LeTypePrestation { get => _leTypePrestation; set => _leTypePrestation = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
