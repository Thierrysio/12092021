using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    public class Prestation
    {
        #region Attributs

        public static List<Prestation> CollClasse = new List<Prestation>();
        private TypePrestation _letypePrestation;
        private int _nbreActes;
        private Dictionary<Activite, int> _dicoNbreActivites;

        #endregion

        #region Constructeurs

        public Prestation(int nbreActes, TypePrestation letypePrestation)
        {
            Prestation.CollClasse.Add(this);
            _nbreActes = nbreActes;
            _letypePrestation = letypePrestation;
            _dicoNbreActivites = new Dictionary<Activite, int>();
        }

        #endregion

        #region Getters/Setters
        public int NbreActes { get => _nbreActes; set => _nbreActes = value; }
        public TypePrestation LeTypePrestation { get => _letypePrestation; set => _letypePrestation = value; }
        public  Dictionary<Activite, int> DicoNbreActivites { get => _dicoNbreActivites; set => _dicoNbreActivites = value; }

        #endregion

        #region Methodes
        public double GetTarifPrestation()
        {
            return this.NbreActes * this.LeTypePrestation.GetPrixForfaitaire();
        }

        public void AjoutAuDicoNbreActivites(Activite param1, int param2)
        {
            if (this.DicoNbreActivites.ContainsKey(param1))
            {
                this.DicoNbreActivites[param1] += param2;
            }
            else
            {
                this.DicoNbreActivites.Add(param1, param2);
            }
        }

        public Dictionary<MicroTache,int> GetListeMicroTaches()
        {
            Dictionary<MicroTache, int> resultat = new Dictionary<MicroTache, int>();

            foreach( var pair0 in this.DicoNbreActivites)
            {
                foreach(var pair1 in pair0.Key.DicoNbreTaches)
                {
                    foreach(var pair2 in pair1.Key.DicoNbreMicroTaches)
                    {
                        if (resultat.ContainsKey(pair2.Key))
                        {
                            resultat[pair2.Key] += pair2.Value *pair1.Value * pair0.Value;
                        }
                        else
                        {
                            resultat.Add(pair2.Key, pair2.Value * pair1.Value * pair0.Value);
                        }
                    }
                }
            }

            return resultat;
        }
        #endregion
    }
}
