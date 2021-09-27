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
        private TypePrestation _letypePrestation;
        private int _nbreActes;
        #endregion

        #region Constructeurs

        public Prestation(int nbreActes, TypePrestation letypePrestation)
        {
            Prestation.CollClasse.Add(this);
            _nbreActes = nbreActes;
            _letypePrestation = letypePrestation;
        }

        #endregion

        #region Getters/Setters
        public int NbreActes { get => _nbreActes; set => _nbreActes = value; }
        public TypePrestation LeTypePrestation { get => _letypePrestation; set => _letypePrestation = value; }

        #endregion

        #region Methodes
        public double GetTarifPrestation()
        {
            return this.NbreActes * this.LeTypePrestation.GetPrixForfaitaire();
        }
        #endregion
    }
}
