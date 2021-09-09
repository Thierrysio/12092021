using Microsoft.VisualStudio.TestTools.UnitTesting;
using _12092021.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092021.Modeles.Tests
{
    [TestClass()]
    public class TourneeTests
    {
        [TestMethod()]
        public void GetNbreDeVisitesTest()
        {
            Tournee T1 = new Tournee(new DateTime(2021, 09, 12),0);

            Visite V1 = new Visite(new DateTime(2021, 09, 12, 11, 00, 00));
            Visite V2 = new Visite(new DateTime(2021, 09, 12, 12, 00, 00));
            Visite V3 = new Visite(new DateTime(2021, 09, 13, 13, 00, 00));
            Visite V4 = new Visite(new DateTime(2021, 09, 12, 11, 00, 00));

            T1.LesVisites.Add(V1);
            T1.LesVisites.Add(V3);
            T1.LesVisites.Add(V2);

            int resultat = T1.GetNbreDeVisites();

            Assert.AreEqual(resultat,3);
        }
    }
}