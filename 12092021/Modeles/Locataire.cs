using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    public class Locataire
    {
        #region Attributs

        public static List<Locataire> CollClasse = new List<Locataire>();
        private string _nom;
        private Dictionary<Semaine, Appartement> _dicoLocation;
        #endregion

        #region Constructeurs

        public Locataire(string nom)
        {
            Locataire.CollClasse.Add(this);
            _dicoLocation = new Dictionary<Semaine, Appartement>();
            _nom = nom;
        }
        #endregion

        #region Getters/Setters
        public string Nom { get => _nom; set => _nom = value; }
        public Dictionary<Semaine, Appartement> DicoLocation { get => _dicoLocation; set => _dicoLocation = value; }

        #endregion

        #region Methodes

        public bool AjoutLocationAppartement(Semaine param,Appartement param2)
        {
            bool resultat = false;
           // Est ce que l'appartement est libre cette semaine ?
            // Ajout de l'appartement dans le dico.

            foreach ( Locataire unLocataire in Locataire.CollClasse)
            {
                foreach(var pair in unLocataire.DicoLocation)
                {
                    if ((pair.Key == param) && (pair.Value == param2))
                        {
                        return true;
                    }
                }
                
            }
            if (resultat == false) this.DicoLocation.Add(param, param2);

            return resultat;
        }
        public bool AjoutLocationAppartement(Semaine param)
        {
            bool resultat = false;

            return resultat;
        }
        public bool AjoutLocationAppartement()
        {
            bool resultat = false;

            return resultat;
        }

        #endregion
    }
}
