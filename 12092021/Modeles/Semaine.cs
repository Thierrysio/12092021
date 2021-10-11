using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    public class Semaine
    {
        #region Attributs

        public static List<Semaine> CollClasse = new List<Semaine>();
        private int _numero;
        #endregion

        #region Constructeurs

        public Semaine(int numero)
        {
            Semaine.CollClasse.Add(this);
            _numero = numero;
        }

        #endregion

        #region Getters/Setters
        public int Numero { get => _numero; set => _numero = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
