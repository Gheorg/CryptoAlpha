using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallF.BaseNEncodings;

namespace AlphaCypher
{
    public class Vigenere64: Vigenere
    {
        private Base64Encoding _b64;
        public Vigenere64():base()
        {
            _b64 = new Base64Encoding();
        }
        protected override string Letters
        {
            get
            {
                return "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
            }
        }
        public override string Decode(string text, string cypher)
        {
            string resp = "";
            string res = "";
            char[] vetChar = text.ToCharArray();
            byte[] ris = _b64.Decode(vetChar);
            resp = Encoding.UTF8.GetString(ris, 0, ris.Length);
            for (int i = 0; i < resp.Length; i++)
                res += base.Decode(resp[i], cypher[i % cypher.Length]);
            return res;
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
            char[] ris = _b64.Encode(vetBytes);
            resp = new string(ris);
            return resp;
        }

        public override Task<string> EncodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }
    }
}
