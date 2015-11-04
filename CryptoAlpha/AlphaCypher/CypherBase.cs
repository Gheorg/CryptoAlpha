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
        protected virtual string Letters 
         { 
            get 
            { 
                return "";
            } 
        }
    public CypherBase()
        {
            _vettAlphabet = new List<char>();
            AlphabetInitialization();
        }
        protected virtual void AlphabetInitialization()
        {
            for (int i = 0; i < Letters.Length; i++)
            {
                //char tmp = (char)(i + 65);
                _vettAlphabet.Add(Letters[i]);
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
        public abstract string Encode(string text, string cypher);
        protected char Encode(char text, char cypher)
         { 
            char resp; 
            int pos = ResearchPosition(text); 
            int posCypher = ResearchPosition(cypher); 
            int posCodificata = (pos + posCypher) % _vettAlphabet.Count; 
            resp = _vettAlphabet[posCodificata]; 
             return resp; 
         }
        public abstract string Decode(string text, string cypher);
        protected char Decode(char text, char cypher)
         { 
            char resp; 
            int pos = ResearchPosition(text); 
            int posCypher = ResearchPosition(cypher); 
            int posCodificata = (pos - posCypher + _vettAlphabet.Count) % _vettAlphabet.Count; 
            resp = _vettAlphabet[posCodificata]; 
            return resp; 

 
        }

        public virtual Task<string> DecodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }

        public virtual Task<string> EncodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }
    }
}
