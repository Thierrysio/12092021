using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    public class Appartement
    {
        #region Attributs

        public static List<Appartement> CollClasse = new List<Appartement>();
        private string _nom;
        private Dictionary<Semaine, Locataire> _dicoLocation;
        #endregion

        #region Constructeurs

        public Appartement(string nom)
        {
            Appartement.CollClasse.Add(this);
            _nom = nom;
            _dicoLocation = new Dictionary<Semaine, Locataire>();
        }

        #endregion

        #region Getters/Setters
        public string Nom { get => _nom; set => _nom = value; }
        public Dictionary<Semaine, Locataire> DicoLocation { get => _dicoLocation; set => _dicoLocation = value; }

        #endregion

        #region Methodes

        public Locataire QuiALoue(Semaine param)
        {
            Locataire resultat = null;

            foreach(var pair in this.DicoLocation)
            {
                if (pair.Key == param)
                {
                    return pair.Value;
                }
            }

            return resultat;
        }

        public bool AjoutLocationAppartement(Semaine param, Locataire param2)
        {
            bool resultat = false;
            // Est ce que l'appartement est libre cette semaine ?
            // Ajout de l'appartement dans le dico.

            if (this.QuiALoue(param) == null)
            {
                this.DicoLocation.Add(param, param2);
            }
            else
            {
                resultat = true;
            }

            return resultat;
        }
        public bool AjoutLocationAppartement(Locataire param)
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
