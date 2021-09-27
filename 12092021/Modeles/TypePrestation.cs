using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    public class TypePrestation
    {
        #region Attributs

        public static List<TypePrestation> CollClasse = new List<TypePrestation>();

        private string _libelle;
        private double _prixForfaitaire;
        #endregion

        #region Constructeurs

        public TypePrestation(string libelle, double prixForfaitaire)
        {
            TypePrestation.CollClasse.Add(this);
            _libelle = libelle;
            _prixForfaitaire = prixForfaitaire;
        }

        #endregion

        #region Getters/Setters
        public string Libelle { get => _libelle; set => _libelle = value; }
        public double PrixForfaitaire { get => _prixForfaitaire; set => _prixForfaitaire = value; }

        #endregion

        #region Methodes
        public double GetPrixForfaitaire()
        {
            return this.PrixForfaitaire;
        }
        #endregion
    }
}
