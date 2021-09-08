﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles
{
    class Tournee
    {
        #region Attributs

        public static List<Tournee> CollClasse = new List<Tournee>();

        private DateTime _laDate;
        private int _kmsRealises;
        private Commercial _leCommercial;
        private List<Visite> _lesVisites;
        #endregion

        #region Constructeurs

        public Tournee(DateTime laDate, int kmsRealises)
        {
            Tournee.CollClasse.Add(this);
            _laDate = laDate;
            _kmsRealises = kmsRealises;
            _lesVisites = new List<Visite>();
        }


        #endregion

        #region Getters/Setters
        public DateTime LaDate { get => _laDate; set => _laDate = value; }
        public int KmsRealises { get => _kmsRealises; set => _kmsRealises = value; }
        public Commercial LeCommercial { get => _leCommercial; set => _leCommercial = value; }
        public List<Visite> LesVisites { get => _lesVisites; set => _lesVisites = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
