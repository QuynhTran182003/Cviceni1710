using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni1710
{
    class Dictionary
    {
        Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

        public Word CreateWord(string english, params string[] czechWord)
        {
            Word word = new Word();
            foreach (string c in czechWord)
            {
                word.CzechTranslate.Add(c);
            }
            return word = new Word(english, word.CzechTranslate);
        }

        public void AddWord (Word w)
        {
            dictionary.Add(w.EnglishWord, w.CzechTranslate);
        }



        public override string? ToString()
        {
            string dict = "";
            foreach(KeyValuePair<string, List<string>> kvp in dictionary)
            {
                dict += ("English: {0}, Czech: {1}", kvp.Key, kvp.Value) +"\n";
            }
            return dict;
        }
    }
}
