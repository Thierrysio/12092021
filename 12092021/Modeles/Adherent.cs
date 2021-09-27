using System.Collections.Generic;

namespace _12092021.Modeles
{
    public class Adherent : Utilisateur
    {
        #region Attributs

        public static List<Adherent> CollClasse = new List<Adherent>();

        
        private string _adresse;
        private int _kms; //kilometres qui le separe de l'entreprise

        #endregion

        #region Constructeurs
        public Adherent(int id, string nom, string prenom, string adresse, int kms) : base(id,nom,prenom)
        {
            _adresse = adresse;
            _kms = kms;
            Adherent.CollClasse.Add(this);
        }


        #endregion

        #region Getters/Setters
        public string Adresse { get => _adresse; set => _adresse = value; }
        public int Kms { get => _kms; set => _kms = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
