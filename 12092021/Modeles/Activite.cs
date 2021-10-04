using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    public class Activite
    {
        #region Attributs

        public static List<Activite> CollClasse = new List<Activite>();
        private string _nom;
        private Dictionary<Tache, int> _dicoNbreTaches;

        #endregion

        #region Constructeurs

        public Activite(string nom)
        {
            Activite.CollClasse.Add(this);
            _nom = nom;
            _dicoNbreTaches = new Dictionary<Tache, int>();
        }


        #endregion

        #region Getters/Setters

        public string Nom { get => _nom; set => _nom = value; }
        public Dictionary<Tache, int> DicoNbreTaches { get => _dicoNbreTaches; set => _dicoNbreTaches = value; }


        #endregion

        #region Methodes
        public void AjoutAuDicoNbreTaches(Tache param1, int param2)
        {
            if (this.DicoNbreTaches.ContainsKey(param1))
            {
                this.DicoNbreTaches[param1] += param2;
            }
            else
            {
                this.DicoNbreTaches.Add(param1, param2);
            }
        }
        #endregion
    }
}
