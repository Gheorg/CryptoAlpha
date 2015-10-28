using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaCypher
{
    public abstract class CypherBase : ICypher
    {
        protected List<Char> _vettAlphabet;
        protected int _displacement;

        public CypherBase()
        {
            _vettAlphabet = new List<char>();
            AlphabetInitialization();
        }
        protected virtual void AlphabetInitialization()
        {
            for (int i = 0; i < 26; i++)
            {
                char tmp = (char)(i + 65);
                _vettAlphabet.Add(tmp);
            }
        }
        private int ResearchPosition(char tmp)
        {
            int resp = 0;
            for (int i = 0; i < _vettAlphabet.Count; i++)
            {
                if (tmp == _vettAlphabet[i])
                {
                    resp = i;
                }
            }
            return resp;
        }
        public string Encode(string text)
        {
            string resp = "";
            resp = Encode(text, _displacement);
            return resp;
        }
        public string Encode(char text, char cypher)
        {
            string resp = "";
            resp = this.Encode(text.ToString(), cypher.ToString());
            return resp;
        }

        public virtual string Encode(string text, int cypher)
        {
            string resp = "";
            char[] s = text.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                char tmp = s[i];
                int pos = ResearchPosition(tmp);
                int posCodificata = (pos + cypher) % 26;
                resp += _vettAlphabet[posCodificata];

            }
            return resp;
        }
        public virtual string Decode(string text, int cypher)
        {
            string resp = "";
            char[] s = text.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                char tmp = s[i];
                int pos = ResearchPosition(tmp);
                int posCodificata = (pos - cypher + 26) % 26;
                resp += _vettAlphabet[posCodificata];

            }
            return resp;
        }
        public virtual string Decode(string text, string cypher)
        {
            string resp = "";
            int spiazzamento = ResearchPosition(cypher.ToUpper()[0]);
            resp = Decode(text.ToUpper(), spiazzamento);
            return resp;
        }

        public virtual Task<string> DecodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }

        public virtual string Encode(string text, string cypher)
        {
            string resp = "";
            int spiazzamento = ResearchPosition(cypher.ToUpper()[0]);
            resp = Encode(text.ToUpper(), spiazzamento);
            return resp;
        }

        public virtual Task<string> EncodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }
    }
}
