﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallF.BaseNEncodings;

namespace AlphaCypher
{
    public class Caesar64: Caesar
    {
        private Base64Encoding _b64;

        public Caesar64()
        {
            _b64 = new Base64Encoding();
        }
        public override string Decode(string text, string cypher)
        {
            string resp = "";
            string res = "";
            char[] vetChar = text.ToCharArray();
            byte[] ris = _b64.Decode(vetChar);
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
            resp = base.Encode(text, cypher);
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
