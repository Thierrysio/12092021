using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    public class Region
    {
        #region Attributs

        public static List<Region> CollClasse = new List<Region>();

        private string _libelle;
        #endregion

        #region Constructeurs

        public Region(string libelle)
        {
            Region.CollClasse.Add(this);
            _libelle = libelle;
        }

        #endregion

        #region Getters/Setters
        public string Libelle { get => _libelle; set => _libelle = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
