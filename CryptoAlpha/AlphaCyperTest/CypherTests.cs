using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaCypher;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace AlphaCyperTest
{
    [TestClass]
    public class Cyphertests 
    {
        [TestMethod]
        public void TestCaesarError()
        {
            string testo = "ABBA";
            string codice = "A";
            string ris = "EFFE";
            Caesar crypt = new Caesar();
            string codifica = crypt.Encode(testo, codice);
            Assert.AreEqual(codifica,ris);
        }
        [TestMethod]
        public void TestCaesarOk()
        {
            string testo = "ABBA";
            string codice = "D";
            string ris = "DEED";
            Caesar crypt = new Caesar();
            string codifica = crypt.Encode(testo, codice);
            Assert.AreEqual(codifica, ris);
        }
    }
}
