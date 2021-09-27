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
        private Adherent _lAdherent;
        private DateTime _heure;
        private List<Prestation> _lesPrestations;
        #endregion

        #region Constructeurs

        public Visite(DateTime heure, Adherent lAdherent)
        {
            Visite.CollClasse.Add(this);
            _heure = heure;
            _lesPrestations = new List<Prestation>();
            _lAdherent =  lAdherent;
            this.AjoutTournee();
        }


        #endregion

        #region Getters/Setters
        public DateTime Heure { get => _heure; set => _heure = value; }
        public List<Prestation> LesPrestations { get => _lesPrestations; set => _lesPrestations = value; }
        public  Adherent LAdherent { get => _lAdherent; set => _lAdherent = value; }

        #endregion

        #region Methodes
        /// <summary>
        /// Cette methode doit permettre d'affecter la visite 
        /// courante à la tournée correspondante au jour indiqué
        /// dans l'attribut _heure.
        /// </summary>
        public void AjoutTournee()
        {
            bool param = false;
            if (Tournee.CollClasse.Count == 0) Tournee.CreerTournee(this.Heure);
            foreach (Tournee uneTournee in Tournee.CollClasse)
            {
                if (uneTournee.LaDate.Date == this.Heure.Date)
                {
                    //uneTournee.LesVisites.Add(this);
                    uneTournee.AjoutVisite(this);
                    break;
                }
                else
                {
                    param = true;
                }
            }

            if (param == true) Tournee.CreerTourneeGestionVisite(this.Heure, this);
        }

        public double montantAFacturer()
        {
            double resultat = 0;

            foreach(Prestation unePrestation in this.LesPrestations)
            {
                resultat += unePrestation.GetTarifPrestation();
            }

            return resultat;
        }
        #endregion
    }
}


