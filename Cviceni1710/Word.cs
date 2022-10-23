using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni1710
{
    class Word
    {
        private string englishWord;
        private List<string> czechTranslate;

        public Word() 
        {
            this.EnglishWord = "";
            this.czechTranslate = new List<string>();
        }
        public Word(string eWord, List<string> czechWord)
        {
            this.EnglishWord = eWord;
            this.czechTranslate = czechWord;
        }

        public string EnglishWord { 
            get { return englishWord; }
            set { englishWord = value; }
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
        public override string? ToString()
        {
            return this.englishWord + ":\n" + this.DisplayCzechTranslateList();
        }
    }
}
