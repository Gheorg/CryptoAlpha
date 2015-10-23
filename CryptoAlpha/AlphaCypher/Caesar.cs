using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaCypher
{
    public class Caesar : CypherBase 
    {
        public Caesar() : base()
        {

        }
        public Caesar(int displacement) : base()
        {
            _displacement = displacement;
        }
        public override string Encode(string testo, int spiazzamento)
        {
            string resp = "";
            resp = base.Encode(testo, spiazzamento);
            return resp;
        }
        public override string Decode(string text, string cypher)
        {
            throw new NotImplementedException();
        }

        public override string Encode(string text, string cypher)
        {
            string resp = "";
            resp = base.Encode(text, cypher);
            return resp;
        }

        public override Task<string> DecodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }

        public override Task<string> EncodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }
    }
}
