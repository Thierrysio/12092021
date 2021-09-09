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
    public class CommercialTests
    {
        
        [TestMethod()]
        public void GetRegionNonAffectéeTest()
        {
            Commercial C1 = new Commercial(1, "nom1", "prenom1");

            Region R1 = new Region("Region 1");
            Region R2 = new Region("Region 2");
            Region R3 = new Region("Region 3");
            Region R4 = new Region("Region 4");
            Region R5 = new Region("Region 5");

            C1.LesRegions.Add(R1);
            C1.LesRegions.Add(R4);

            List<Region> resultatReel = C1.GetRegionNonAffectée();
            

            Assert.AreEqual(resultatReel.Count,3);
        }
    }
}