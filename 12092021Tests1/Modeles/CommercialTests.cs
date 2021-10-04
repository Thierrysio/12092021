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
        public void GetMontantRestaurantMoisTest()
        {
            //jeu d'essai
            TypeRepas TR1 = new TypeRepas("Dejeuner");
            Restaurant R1 = new Restaurant("Restaurant1", TR1);
            Restaurant R2 = new Restaurant("Restaurant2", TR1);
            Restaurant R3 = new Restaurant("Restaurant3", TR1);

            Commercial COM1 = new Commercial(1, "commercial1", "prenom1");

            COM1.AjoutAuDicoTypeResto(R1, 15);
            COM1.AjoutAuDicoTypeResto(R2, 15);
            COM1.AjoutAuDicoTypeResto(R3, 15);
            COM1.AjoutAuDicoTypeResto(R3, 15);

            // test methode
            int expected = COM1.GetMontantRestaurantMois();
            // Assert
            Assert.AreEqual(expected, 20);
        }
    }
}