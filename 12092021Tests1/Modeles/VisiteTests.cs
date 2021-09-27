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
    public class VisiteTests
    {
        [TestMethod()]
        public void montantAFacturerTest()
        {
            // jeu d'essai

            Adherent A1 = new Adherent(1, "disney", "riri", "adrersse1", 50);

            Visite V1 = new Visite(DateTime.Now,A1);

            TypePrestation T1 = new TypePrestation("Type Prestation 1", 50);
            TypePrestation T2 = new TypePrestation("Type Prestation 2", 40);
            TypePrestation T3 = new TypePrestation("Type Prestation 3", 30);
            TypePrestation T4 = new TypePrestation("Type Prestation 4", 20);

            Prestation P1 = new Prestation(5, T1);
            Prestation P2 = new Prestation(5, T2);

            V1.LesPrestations.Add(P1);
            V1.LesPrestations.Add(P2);



            // Methode
            double actuel = V1.montantAFacturer();
            // Assert
            Assert.AreEqual(actuel, 450);
        }
    }
}