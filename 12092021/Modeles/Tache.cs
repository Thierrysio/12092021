using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    public class Tache
    {
        #region Attributs

        public static List<Tache> CollClasse = new List<Tache>();
        private string _nom;
        private Dictionary<MicroTache, int> _dicoNbreMicroTaches;

        #endregion

        #region Constructeurs

        public Tache(string nom)
        {
            Tache.CollClasse.Add(this);
            _nom = nom;
            _dicoNbreMicroTaches = new Dictionary<MicroTache, int>();
        }

        #endregion

        #region Getters/Setters
        public string Nom { get => _nom; set => _nom = value; }
        public Dictionary<MicroTache, int> DicoNbreMicroTaches { get => _dicoNbreMicroTaches; set => _dicoNbreMicroTaches = value; }


        #endregion

        #region Methodes
        public void AjoutDicoNbreMicroTaches(MicroTache param1, int param2)
        {
            if (this.DicoNbreMicroTaches.ContainsKey(param1))
            {
                this.DicoNbreMicroTaches[param1] += param2;
            }
            else
            {
                this.DicoNbreMicroTaches.Add(param1, param2);
            }
        }
        #endregion
    }
}
