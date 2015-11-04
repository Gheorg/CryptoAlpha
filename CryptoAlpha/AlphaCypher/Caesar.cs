using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaCypher
{
    public class Caesar : Vigenere 
    {
        public Caesar() : base()
        {

        }
         protected override string Letters 
         { 
             get 
             { 
                return "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; 
             } 
         }

        public Caesar(int displacement) : base()
        {
            _displacement = displacement;
        }      
        public override string Decode(string text, string cypher)
        {
            string resp = "";
            for (int i = 0; i < text.Length; i++)
            {
                resp += base.Decode(text[i], cypher[0]);
            }
            return resp;
        }

        public override string Encode(string text, string cypher)
        {
            string resp = "";
            for (int i = 0; i < text.Length; i++)
            {
                resp += base.Encode(text[i], cypher[0]);         
            }
            return resp;
        }

        public override Task<string> DecodeAsync(string text, string cypher)
        {
            return Task.Factory.StartNew(() => Decode(text, cypher));
        }

        public override Task<string> EncodeAsync(string text, string cypher)
        {
            return Task.Factory.StartNew(() => Encode(text, cypher));
        }
    }
}
