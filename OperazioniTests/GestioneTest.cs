using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operazioni;
namespace OperazioniTests
{
    [TestClass]
    public class GestioneTest
    {
        
        
        
            [TestMethod]
            public void TestCalcoloMisterioso()
            {
                int n = 5;
                long valore_aspettato = 240;
                long resp = Gestione.CalcoloMisterioso(n);
                Assert.AreEqual(valore_aspettato , resp);
            }
        [TestMethod]
        public void TestCalcoloMisterioso2()
        {
            int n = 6;
            long valore_aspettato = 1440;
            long resp = Gestione.CalcoloMisterioso(n);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public void TestCalcoloMisterioso3()
        {
            int n = 7;
            long valore_aspettato = 10080;
            long resp = Gestione.CalcoloMisterioso(n);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public void TestCalcoloMisterioso4()
        {
            int n = 8;
            long valore_aspettato = 80640;
            long resp = Gestione.CalcoloMisterioso(n);
            Assert.AreEqual(valore_aspettato, resp);
        }
    }
}

