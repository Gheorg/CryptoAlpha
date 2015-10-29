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
        public override string Decode(string text, string cypher)
        {
            string resp = "";            
            char[] vetChar = text.ToCharArray();
            byte[] ris = _b32.Decode(vetChar);
            resp = Encoding.UTF8.GetString(ris, 0, ris.Length);
            for (int i = 0; i < text.Length; i++)
                resp += base.Decode(text[i], cypher[i % cypher.Length]);
            return resp;
        }

        public override Task<string> DecodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }

        public override string Encode(string text, string cypher)
        {
            string resp = "";
            for (int i = 0; i < text.Length; i++)
            {
                resp += base.Encode(text[i], cypher[i % cypher.Length]);
            }
            byte[] vetBytes = Encoding.UTF8.GetBytes(resp);
            char[] ris = _b32.Encode(vetBytes);
            resp = new string(ris);
            return resp;
        }

        public override Task<string> EncodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }
    }
}
