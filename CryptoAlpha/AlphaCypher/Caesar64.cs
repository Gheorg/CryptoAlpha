using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallF.BaseNEncodings;

namespace AlphaCypher
{
    public class Caesar64: Vigenere
    {
        private Base64Encoding _b64;

        public Caesar64()
        {
            _b64 = new Base64Encoding();
        }
        protected override string Letters 
         { 
             get 
             { 
                 return "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/="; 
             } 
         }

    public override string Decode(string text, string cypher)
        {
            string resp = "";
            string tmpTxt = "";
            string tmpCyp = "";
            string tmp = "";
            byte[] vetBytesCyp32 = Encoding.UTF8.GetBytes(cypher);
            char[] charCyp32 = _b64.Encode(vetBytesCyp32);
            tmp = new string(charCyp32);
            resp = base.Decode(text, tmp);
            char[] charTxt = resp.ToCharArray();
            char[] charCyp = cypher.ToCharArray();
            byte[] vetBytesTxt = _b64.Decode(charTxt);
            tmpTxt = Encoding.UTF8.GetString(vetBytesTxt, 0, vetBytesTxt.Length);
            return tmpTxt;
        }

        public override Task<string> DecodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }

        public override string Encode(string text, string cypher)
        {
            string resp = "";
            string tmpTxt = "";
            string tmpCyp = "";
            byte[] vetBytesTxt = Encoding.UTF8.GetBytes(text);
            byte[] vetBytesCyp = Encoding.UTF8.GetBytes(cypher);
            char[] charTxt = _b64.Encode(vetBytesTxt);
            char[] charCyp = _b64.Encode(vetBytesCyp);
            tmpTxt = new string(charTxt);
            tmpCyp = new string(charCyp);
            resp = base.Encode(tmpTxt, tmpCyp);
            return resp;
        }

        public override Task<string> EncodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }
    }
}
