using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    public class Emplacement
    {
        #region Attributs

        public static List<Emplacement> CollClasse = new List<Emplacement>();
        private string _lieu;
        private int _tarif;
        #endregion

        #region Constructeurs

        public Emplacement(string lieu, int tarif)
        {
            Emplacement.CollClasse.Add(this);
            _lieu = lieu;
            _tarif = tarif;
        }

        #endregion

        #region Getters/Setters
        public string Lieu { get => _lieu; set => _lieu = value; }
        public int Tarif { get => _tarif; set => _tarif = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
