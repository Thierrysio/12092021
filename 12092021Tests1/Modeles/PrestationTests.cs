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
    public class PrestationTests
    {
        [TestMethod()]
        public void GetListeMicroTachesTest()
        {
            // Jeu d'essai

            TypePrestation TP1 = new TypePrestation("TypePrestation1", 20);
            
            Prestation P1 = new Prestation(5, TP1);

            Activite A1 = new Activite("Activite 01");
            Activite A1 = new Activite("Activite 01");
            Activite A1 = new Activite("Activite 01");
            Activite A1 = new Activite("Activite 01");
            Activite A1 = new Activite("Activite 01");


            // Methodes à tester

            // Assert
        }
    }
}