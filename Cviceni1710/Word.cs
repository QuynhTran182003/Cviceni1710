using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni1710
{
    class Word
    {
        private List<string> englishWord;
        private List<string> czechTranslate;

        public Word() 
        {
            this.englishWord = new List<string>();
            this.czechTranslate = new List<string>();
        }
        public Word(List<string> eWord, List<string> czechWord)
        {
            this.englishWord = eWord;
            this.czechTranslate = czechWord;
        }

        public List<string> EnglishWord { 
            get { return englishWord; }
        }

        public List<string> CzechTranslate { get { return czechTranslate; } }

        public string DisplayCzechTranslateList()
        {
            string st = "";
            foreach(string s in czechTranslate)
            {
                st += s + ", ";
            }
            return st;
        }
        
    }
}
