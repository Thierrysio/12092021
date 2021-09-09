using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    public class Visite
    {
        #region Attributs

        public static List<Visite> CollClasse = new List<Visite>();

        private DateTime _heure;
        private List<Prestation> _lesPrestations;
        #endregion

        #region Constructeurs

        public Visite(DateTime heure)
        {
            Visite.CollClasse.Add(this);
            _heure = heure;
            _lesPrestations = new List<Prestation>();

            // A coder
        }


        #endregion

        #region Getters/Setters
        public DateTime Heure { get => _heure; set => _heure = value; }
        public List<Prestation> LesPrestations { get => _lesPrestations; set => _lesPrestations = value; }

        #endregion

        #region Methodes
        /// <summary>
        /// Cette methode doit permettre d'affecter la visite 
        /// courante à la tournée correspondante au jour indiqué
        /// dans l'attribut _heure.
        /// </summary>
        public void AjoutTournee()
        {
            // Acoder
        }
        #endregion
    }
}
