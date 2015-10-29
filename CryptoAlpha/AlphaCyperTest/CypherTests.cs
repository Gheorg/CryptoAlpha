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
            string decode = crypt.Decode(text, cypher);
            Assert.AreEqual(decode, ris);
        }
        [TestMethod]
        public void TestCaesarDecodeError()
        {
            string text = "ABBA";
            string cypher = "D";
            string ris = "DEED";
            Caesar crypt = new Caesar();
            string decode = crypt.Decode(text, cypher);
            Assert.AreEqual(decode, ris);
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
        public void TestVigenereDecodeOk()
        {
            string text = "ABBA";
            string cypher = "DFS";
            string ris = "XWJX";
            Vigenere crypt = new Vigenere();
            string decode = crypt.Decode(text, cypher);
            Assert.AreEqual(decode, ris);
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
        [TestMethod]
        public void TestVigenereDecodeError()
        {
            string text = "ABBA";
            string cypher = "DFS";
            string ris = "DGDT";
            Vigenere crypt = new Vigenere();
            string decode = crypt.Decode(text, cypher);
            Assert.AreEqual(decode, ris);
        }

        //Caesar32Test
        [TestMethod]
        public void TestCaesar32EncodeOk()
        {
            string text = "ABBA";
            string cypher = "D";
            string ris = "IRCUKRA=";
            Caesar32 crypt = new Caesar32();
            string encode = crypt.Encode(text, cypher);
            Assert.AreEqual(encode, ris);
        }
        [TestMethod]
        public void TestCaesar32EncodeError()
        {
            string text = "ABBA";
            string cypher = "D";
            string ris = "IRCAKRA=";
            Caesar32 crypt = new Caesar32();
            string encode = crypt.Encode(text, cypher);
            Assert.AreEqual(encode, ris);
        }
        [TestMethod]
        public void TestCaesar32DecodeOk()
        {
            string text = "IRCUKRA=";
            string cypher = "D";
            string ris = "ABBA";
            Caesar32 crypt = new Caesar32();
            string decode = crypt.Decode(text, cypher);
            Assert.AreEqual(decode, ris);
        }
        public void TestCaesar32DecodeError()
        {
            string text = "IRCAKRA=";
            string cypher = "D";
            string ris = "ABBA";
            Caesar32 crypt = new Caesar32();
            string decode = crypt.Decode(text, cypher);
            Assert.AreEqual(decode, ris);
        }

    }
}
