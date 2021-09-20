using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    public class Tournee
    {
        #region Attributs

        public static List<Tournee> CollClasse = new List<Tournee>();

        private DateTime _laDate;
        private int _kmsRealises;
        private Commercial _leCommercial;
        private List<Visite> _lesVisites;
        #endregion

        #region Constructeurs

        public Tournee(DateTime laDate)
        {
            Tournee.CollClasse.Add(this);
            _laDate = laDate;
            _kmsRealises = 0;
            _lesVisites = new List<Visite>();
        }


        #endregion

        #region Getters/Setters
        public DateTime LaDate { get => _laDate; set => _laDate = value; }
        public int KmsRealises { get => _kmsRealises; set => _kmsRealises = value; }
        public Commercial LeCommercial { get => _leCommercial; set => _leCommercial = value; }
        public List<Visite> LesVisites { get => _lesVisites; set => _lesVisites = value; }

        #endregion

        #region Methodes
        public int GetNbreDeVisites()
        {
            return this.LesVisites.Count;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"> correspond à la visite à ajouter</param>
        public void AjoutVisite(Visite param)
        {
            
            this.LesVisites.Add(param);
            this.CalculKmsRealises();
                
        }

        private int CalculKmsRealises()
        {
            int resultat = 0;
            foreach(Visite uneVisite in this.LesVisites)
            {
                resultat += uneVisite.LAdherent.Kms;
            }
            return resultat;
        }
    

    public static void CreerTournee(DateTime param)
        {
            new Tournee(param);
        }

        public static void CreerTourneeGestionVisite(DateTime param,  Visite param3)
        {
            new Tournee(param).AjoutVisite(param3);
        }



        public bool GetVerificationExistenceTournee(DateTime param)
        {
            bool resultat = false;
            // A coder
            return resultat;
        }
        public void AffecterLaTournee()
        {
            //mettre dans un dictionnaire les kilometres réalises
            //par tous les commerciaux. Methode AjoutDictionnaireKmsRealises()
            Dictionary<Commercial,int> monDictionnaire = this.AjoutDictionnaireKmsRealises();
        }

        private Dictionary<Commercial,int> AjoutDictionnaireKmsRealises()
        {
            Dictionary<Commercial, int> resultat = new Dictionary<Commercial, int>();
            foreach (Commercial unCommercial in Commercial.CollClasse)
            {
                resultat.Add(unCommercial, unCommercial.CalculKmsTourneeMoisCourant());
            }
            return resultat;
        }

        private Commercial QuiQuenAFaitLeMoinsCeMoisCi(Dictionary<Commercial, int> param)
        {
            Commercial resultat = null;
            int val = int.MaxValue;
            foreach (KeyValuePair<Commercial, int> pair in param)
            {
                if (pair.Value <val)
                {
                    resultat = pair.Key;
                }
            }

            return resultat;
        }


        #endregion
    }
}

