using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    public class Louer
    {
        #region Attributs

        public static List<Louer> CollClasse = new List<Louer>();
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private Appartement _lAppartement;
        private Periode _laPeriode;


        #endregion

        #region Constructeurs

        public Louer(DateTime dateDebut, DateTime dateFin, Appartement lAppartement, Periode laPeriode)
        {
            Louer.CollClasse.Add(this);
            _dateDebut = dateDebut;
            _dateFin = dateFin;
            _lAppartement = lAppartement;
            _laPeriode = laPeriode;
        }

        #endregion

        #region Getters/Setters
        public DateTime DateDebut { get => _dateDebut; set => _dateDebut = value; }
        public DateTime DateFin { get => _dateFin; set => _dateFin = value; }
        public Appartement LAppartement { get => _lAppartement; set => _lAppartement = value; }
        internal Periode LaPeriode { get => _laPeriode; set => _laPeriode = value; }

        #endregion

        #region Methodes

        public int GetLePrixParSemaine()
        {
            int resultat = 0;

            return resultat;
        }

        #endregion
    }
}
