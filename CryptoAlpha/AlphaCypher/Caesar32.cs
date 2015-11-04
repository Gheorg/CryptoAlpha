using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallF.BaseNEncodings;

namespace AlphaCypher
{
    public class Caesar32: Vigenere
    {
        private Base32Encoding _b32;
        
        public Caesar32()
        {
            _b32 = new Base32Encoding();
        }
        protected override string Letters 
         { 
             get 
             { 
                 return "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567="; 
             } 
         }

    public override string Decode(string text, string cypher)
        {
            string resp = "";
            string res = "";
            char[] vetChar = text.ToCharArray();
            byte[] ris = _b32.Decode(vetChar);          
            resp = Encoding.UTF8.GetString(ris, 0, ris.Length);           
            res = base.Decode(resp, cypher);
            
            return res;
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
            char[] charTxt = _b32.Encode(vetBytesTxt);
            char[] charCyp = _b32.Encode(vetBytesCyp);
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
