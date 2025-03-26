using Microsoft.VisualStudio.TestTools.UnitTesting;
using Formes.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formes.modele.Tests
{
    [TestClass()]
    public class CarreTests
    {
        [TestMethod()]
        public void CarreTest()
        {

        }

        [TestMethod()]
        public void PerimetreTest()
        {
            Carre c = new Carre(5);
            double perimetre = c.Perimetre();
            Assert.AreEqual(20, perimetre);
        }

        [TestMethod()]
        public void AireTest()
        {

        }
    }
}