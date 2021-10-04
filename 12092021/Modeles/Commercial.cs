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
        private Dictionary<Restaurant, int> _typeResto;


        #endregion

        #region Constructeurs

        public Commercial(int id, string nom, string prenom) : base(id , nom, prenom)
        {
            _lesTournees = new List<Tournee>();
            _lesRegions = new List<Region>();
            _typeResto = new Dictionary<Restaurant, int>();
            Commercial.CollClasse.Add(this);
        }



        #endregion

        #region Getters/Setters
        public override int Id
        {
            get { return Id; }
            set { Id = value; }
        }
        public override string Nom
        {
            get { return Nom; }
            set { Nom = value; }
        }
        public override string Prenom
        {
            get { return Prenom; }
            set { Prenom = value; }
        }
        public List<Tournee> LesTournees { get => _lesTournees; set => _lesTournees = value; }
        public List<Region> LesRegions { get => _lesRegions; set => _lesRegions = value; }
        public Dictionary<Restaurant, int> TypeResto { get => _typeResto; set => _typeResto = value; }

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

        public override string parler()
        {

            return "ok commercial";
        }

        public override string marcher()
        {
            return "je marche lentement";
        }

        public int GetMontantRestaurantMois()
        {
            int resultat = 0;

            foreach (var pair in this.TypeResto)
            {
                resultat += pair.Value;
            }

            return resultat;
        }

        public void AjoutAuDicoTypeResto(Restaurant param1,int param2)
        {
            if (this.TypeResto.ContainsKey(param1))
            {
                this.TypeResto[param1] += param2;
            }
            else
            {
                this.TypeResto.Add(param1, param2);
            }
        }

        #endregion
    }
}
