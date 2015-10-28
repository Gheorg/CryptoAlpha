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
        //CaesarTest
        [TestMethod]
        public void TestCaesarEncodeError()
        {
            string text = "ABBA";
            string cypher = "A";
            string ris = "EFFE";
            Caesar crypt = new Caesar();
            string codifica = crypt.Encode(text, cypher);
            Assert.AreEqual(codifica, ris);
        }
        [TestMethod]
        public void TestCaesarEncodeOk()
        {
            string text = "ABBA";
            string cypher = "D";
            string ris = "DEED";
            Caesar crypt = new Caesar();
            string codifica = crypt.Encode(text, cypher);
            Assert.AreEqual(codifica, ris);
        }
        [TestMethod]
        public void TestCaesarDecodeOk()
        {
            string text = "ABBA";
            string cypher = "D";
            string ris = "XYYX";
            Caesar crypt = new Caesar();
            string codifica = crypt.Decode(text, cypher);
            Assert.AreEqual(codifica, ris);
        }
        [TestMethod]
        public void TestCaesarDecodeError()
        {
            string text = "ABBA";
            string cypher = "D";
            string ris = "DEED";
            Caesar crypt = new Caesar();
            string codifica = crypt.Decode(text, cypher);
            Assert.AreEqual(codifica, ris);
        }
        //VigenereTest
        [TestMethod]
        public void TestVigenereEncodeOk()
        {
            string text = "ABBA";
            string cypher = "DFS";
            string ris = "DGTD";
            Vigenere crypt = new Vigenere();
            string encode = crypt.Encode(text, cypher);
            Assert.AreEqual(encode, ris);
        }
        [TestMethod]
        public void TestVigenereEncodeError()
        {
            string text = "ABBA";
            string cypher = "DFS";
            string ris = "DGDT";
            Vigenere crypt = new Vigenere();
            string encode = crypt.Encode(text, cypher);
            Assert.AreEqual(encode, ris);
        }
    }
}
