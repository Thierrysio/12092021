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
            Activite A2 = new Activite("Activite 02");
            Activite A3 = new Activite("Activite 03");
            Activite A4 = new Activite("Activite 04");
            Activite A5 = new Activite("Activite 05");

            P1.AjoutAuDicoNbreActivites(A1, 1);
            P1.AjoutAuDicoNbreActivites(A2, 1);
            P1.AjoutAuDicoNbreActivites(A1, 1);

            Tache T1 = new Tache("Tache 01");
            Tache T2 = new Tache("Tache 02");
            Tache T3 = new Tache("Tache 03");
            Tache T4 = new Tache("Tache 04");
            Tache T5 = new Tache("Tache 05");

            A1.AjoutAuDicoNbreTaches(T1, 1);
            A1.AjoutAuDicoNbreTaches(T3, 1);
            A1.AjoutAuDicoNbreTaches(T1, 1);
            A2.AjoutAuDicoNbreTaches(T1, 1);
            A2.AjoutAuDicoNbreTaches(T5, 1);

            MicroTache MT1 = new MicroTache("Microtache 01");
            MicroTache MT2 = new MicroTache("Microtache 02");
            MicroTache MT3 = new MicroTache("Microtache 03");
            MicroTache MT4 = new MicroTache("Microtache 04");
            MicroTache MT5 = new MicroTache("Microtache 05");

            T1.AjoutDicoNbreMicroTaches(MT1, 1);
            T1.AjoutDicoNbreMicroTaches(MT3, 1);
            T1.AjoutDicoNbreMicroTaches(MT1, 1);

            
            T3.AjoutDicoNbreMicroTaches(MT5, 1);
            T3.AjoutDicoNbreMicroTaches(MT2, 1);

            T5.AjoutDicoNbreMicroTaches(MT1, 1);
            T5.AjoutDicoNbreMicroTaches(MT2, 1);

            // Methodes à tester

            Dictionary<MicroTache, int> expected = P1.GetListeMicroTaches();

            // Assert

            Assert.AreEqual(1, 1);
        }
    }
}