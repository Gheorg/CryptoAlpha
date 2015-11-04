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
            string ris = "QVADDPH7";
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
            string text = "QVADDPH7";
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

        //Vigenere32 Test
        [TestMethod]
        public void TestVigenere32EncodeOk()
        {
            string text = "ABBA";
            string cypher = "DFS";
            string ris = "IRDVIRA=";
            Vigenere32 crypt = new Vigenere32();
            string encode = crypt.Encode(text, cypher);
            Assert.AreEqual(encode, ris);
        }
        public void TestVigenere32DecodeOk()
        {
            string text = "IRDVIRA=";
            string cypher = "DFS";
            string ris = "ABBA";
            Vigenere32 crypt = new Vigenere32();
            string decode = crypt.Decode(text, cypher);
            Assert.AreEqual(decode, ris);
        }
        [TestMethod]
        public void TestVigenere32EncodeError()
        {
            string text = "ABBA";
            string cypher = "DFS";
            string ris = "IRDVIRB=";
            Vigenere crypt = new Vigenere();
            string encode = crypt.Encode(text, cypher);
            Assert.AreEqual(encode, ris);
        }
        [TestMethod]
        public void TestVigenere32DecodeError()
        {
            string text = "IRDVIRA=";
            string cypher = "DFS";
            string ris = "DGDT";
            Vigenere crypt = new Vigenere();
            string decode = crypt.Decode(text, cypher);
            Assert.AreEqual(decode, ris);
        }

        //Caesar64 test
        [TestMethod]
        public void TestCaesar64EncodeOk()
        {
            string text = "ABBA";
            string cypher = "D";
            string ris = "hUIBhQ//";
            Caesar64 crypt = new Caesar64();
            string encode = crypt.Encode(text, cypher);
            Assert.AreEqual(encode, ris);
        }
        [TestMethod]
        public void TestCaesar64EncodeError()
        {
            string text = "ABBA";
            string cypher = "D";
            string ris = "IRCAKRA=";
            Caesar64 crypt = new Caesar64();
            string encode = crypt.Encode(text, cypher);
            Assert.AreEqual(encode, ris);
        }
        [TestMethod]
        public void TestCaesar64DecodeOk()
        {
            string text = "hUIBhQ//";
            string cypher = "D";
            string ris = "ABBA";
            Caesar64 crypt = new Caesar64();
            string decode = crypt.Decode(text, cypher);
            Assert.AreEqual(decode, ris);
        }
        [TestMethod]
        public void TestCaesar64DecodeError()
        {
            string text = "IRCAKRA=";
            string cypher = "D";
            string ris = "ABBA";
            Caesar64 crypt = new Caesar64();
            string decode = crypt.Decode(text, cypher);
            Assert.AreEqual(decode, ris);
        }

        //Vigenere64 test
        [TestMethod]
        public void TestVigenere64EncodeOk()
        {
            string text = "ABBA";
            string cypher = "DFS";
            string ris = "REdURA==";
            Vigenere64 crypt = new Vigenere64();
            string encode = crypt.Encode(text, cypher);
            Assert.AreEqual(encode, ris);
        }
        [TestMethod]
        public void TestVigenere64EncodeError()
        {
            string text = "ABBA";
            string cypher = "DFS";
            string ris = "REDURA==";
            Vigenere64 crypt = new Vigenere64();
            string encode = crypt.Encode(text, cypher);
            Assert.AreEqual(encode, ris);
        }
        [TestMethod]
        public void TestVigenere64DecodeOk()
        {
            string text = "REdURA==";
            string cypher = "DFS";
            string ris = "ABBA";
            Vigenere64 crypt = new Vigenere64();
            string decode = crypt.Decode(text, cypher);
            Assert.AreEqual(decode, ris);
        }
        [TestMethod]
        public void TestVigenere64DecodeError()
        {
            string text = "REdURA==";
            string cypher = "DFS";
            string ris = "ABBB";
            Vigenere64 crypt = new Vigenere64();
            string decode = crypt.Decode(text, cypher);
            Assert.AreEqual(decode, ris);
        }
    }
}
