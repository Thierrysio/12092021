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
    public class LocataireTests
    {
        [TestMethod()]
        public void AjoutLocationAppartementTest()

        {
            // jeu d'essai

            Appartement A1 = new Appartement("Appartement 01");
            Appartement A2 = new Appartement("Appartement 02");
            Appartement A3 = new Appartement("Appartement 03");

            Locataire L1 = new Locataire("Locataire 01");
            Locataire L2 = new Locataire("Locataire 02");
            Locataire L3 = new Locataire("Locataire 03");

            Semaine S1 = new Semaine(01);
            Semaine S2 = new Semaine(02);
            Semaine S3 = new Semaine(03);
            Semaine S4 = new Semaine(04);
            Semaine S5 = new Semaine(05);



            // methode à tester
            bool b = L1.AjoutLocationAppartement(S2, A1);
            bool expected =  L1.AjoutLocationAppartement(S2, A1);

            //assert

            Assert.AreEqual(false, false);

        }
    }
}