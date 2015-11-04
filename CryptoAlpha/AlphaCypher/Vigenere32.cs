using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallF.BaseNEncodings;

namespace AlphaCypher
{
    public class Vigenere32: Vigenere
    {
        private Base32Encoding _b32;
        public Vigenere32():base()
        {
            _b32 = new Base32Encoding();
        }
        protected override string Letters 
        { 
             get 
             { 
                 return "ABCDEFGHIJKLMNOPQRSTUVWXYZ23567="; 
             } 
         }

    public override string Decode(string text, string cypher)
        {
            string resp = "";
            string tmpTxt = "";
            string tmpCyp = "";
            string tmp = "";
            byte[] vetBytesCyp32 = Encoding.UTF8.GetBytes(cypher);
            char[] charCyp32 = _b32.Encode(vetBytesCyp32);
            tmp = new string(charCyp32);
            resp = base.Decode(text, tmp);
            char[] charTxt = resp.ToCharArray();
            char[] charCyp = cypher.ToCharArray();
            byte[] vetBytesTxt = _b32.Decode(charTxt);
            tmpTxt = Encoding.UTF8.GetString(vetBytesTxt, 0, vetBytesTxt.Length);
            return tmpTxt;
        }

        public override Task<string> DecodeAsync(string text, string cypher)
        {
            return Task.Factory.StartNew(() => Decode(text, cypher));
        }

        public override string Encode(string text, string cypher)
        {
            string resp = "";
            string tmpTxt = "";
            string tmpCyp = "";
            byte[] vetBytesTxt = Encoding.UTF8.GetBytes(text);
            byte[] vetBytesCyp = Encoding.UTF8.GetBytes(cypher);
            char[] charTxt = _b32.Encode(vetBytesTxt);
            char[] charCyp = _b32.Encode(vetBytesCyp);
            tmpTxt = new string(charTxt);
            tmpCyp = new string(charCyp);           
            resp = base.Encode(tmpTxt, tmpCyp);
            return resp;
        }

        public override Task<string> EncodeAsync(string text, string cypher)
        {
            return Task.Factory.StartNew(() => Encode(text, cypher));
        }
    }
}
