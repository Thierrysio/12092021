using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    public class Restaurant
    {
        #region Attributs

        public static List<Restaurant> CollClasse = new List<Restaurant>();

        private string _nom;
        private TypeRepas _leTypeRepas;
        
        #endregion

        #region Constructeurs

        public Restaurant(string nom, TypeRepas leTypeRepas)
        {
            Restaurant.CollClasse.Add(this);
            _nom = nom;
            _leTypeRepas = leTypeRepas;

        }

        #endregion

        #region Getters/Setters

        public string Nom { get => _nom; set => _nom = value; }
        public TypeRepas LeTypeRepas { get => _leTypeRepas; set => _leTypeRepas = value; }



        #endregion

        #region Methodes

        #endregion
    }
}
