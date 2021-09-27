using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    public class Commercial : Utilisateur
    {
        #region Attributs

        public static List<Commercial> CollClasse = new List<Commercial>();

        
        private List<Tournee> _lesTournees;
        private List<Region> _lesRegions;



        #endregion

        #region Constructeurs

        public Commercial(int id, string nom, string prenom) : base(id, nom, prenom)
        {
            _lesTournees = new List<Tournee>();
            _lesRegions = new List<Region>();

            Commercial.CollClasse.Add(this);
        }



        #endregion

        #region Getters/Setters
        public List<Tournee> LesTournees { get => _lesTournees; set => _lesTournees = value; }
        public List<Region> LesRegions { get => _lesRegions; set => _lesRegions = value; }

        #endregion

        #region Methodes

        public int CalculKmsTourneeMoisCourant()
        {
            int resultat = 0;
            foreach(Tournee uneTournee in this.LesTournees)
            {
                if(uneTournee.LaDate.Month == DateTime.Now.Month)
                {
                    resultat += uneTournee.KmsRealises;
                }
            }
            return resultat;
        }


        #endregion
    }
}
