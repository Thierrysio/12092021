using System.Collections.Generic;

namespace _12092021.Modeles
{
    class Adherent
    {
        #region Attributs

        public static List<Adherent> CollClasse = new List<Adherent>();

        private int _id;
        private string _nom;
        private string _prenom;
        private string _adresse;

        
        #endregion

        #region Constructeurs
public Adherent(int id, string nom, string prenom, string adresse)
        {
            Adherent.CollClasse.Add(this);
            _id = id;
            _nom = nom;
            _prenom = prenom;
            _adresse = adresse;
        }

        #endregion

        #region Getters/Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        #endregion

        #region Methodes

        #endregion
    }
}
