using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallF.BaseNEncodings;

namespace AlphaCypher
{
    public class Caesar32: Caesar
    {
        private Base32Encoding _b32;
        
        public Caesar32()
        {
            _b32 = new Base32Encoding();
        }
        public virtual string Decode(string text, string cypher)
        {
            string resp = "";
            string res = "";
            char[] vetChar = text.ToCharArray();
            byte[] ris = _b32.Decode(vetChar);          
            resp = Encoding.UTF8.GetString(ris, 0, ris.Length);           
            res = base.Decode(resp, cypher);
            
            return res;
        }

        public virtual Task<string> DecodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }

        public virtual string Encode(string text, string cypher)
        {
            string resp = "";
            resp=  base.Encode(text, cypher);          
            byte[] vetBytes = Encoding.UTF8.GetBytes(resp);
            char[]ris=_b32.Encode(vetBytes);
            resp = new string(ris);    
            return resp;
        }

        public virtual Task<string> EncodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }
    }
}
