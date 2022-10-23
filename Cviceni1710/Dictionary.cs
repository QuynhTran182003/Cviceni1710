using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Cviceni1710
{
    class Dictionary
    {
        Dictionary<List<string>, List<string>> dictionary = new Dictionary<List<string>, List<string>>();

        public Word CreateWord(List<string> english, params string[] czechWord)
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

        public string TranslateToCzech(string w)
        {
            string result = w + ": ";
            bool appear = false;
            //get list of all keys in dictionary (called listKeys)
            List<List<string>> listKeys = new List<List<string>>(dictionary.Keys);
            //for each key in that listKeys (called keys because it has many synonyms)
            foreach (List<string> keys in listKeys)
            {
                //for each value in the key (that has many synonyms)
                foreach (string key in keys)
                {
                    //if the word appears in the key
                    if(w == key)
                    {
                        appear = true;
                        foreach(string s in dictionary[keys])
                        {
                            result += s + ", ";
                        }
                    }
                }
            }
            if (!appear)
            {
                result = "Cannot found word";
            }
            return result;
        }

        public string TranslateToEnglish(string slovo)
        {
            string result = slovo + ": ";
            bool appear = false;

            foreach (var pair in dictionary)
            {
                foreach(var value in pair.Value)
                {
                    if (value.Contains(slovo))
                    {
                        appear = true;
                        foreach(string s in pair.Key)
                        {
                            result += s + ", ";
                        }

                    }
                }
            }
            if (!appear)
            {
                result = "Cannot found word";
            }
            return result;
        }
        /*public override string? ToString()
        {
            string dict = "";
            foreach(KeyValuePair<List<string>, List<string>> kvp in dictionary)
            {
                dict += ("English: {0}, Czech: {1}", kvp.Key, kvp.Value) +"\n";
            }
            return dict;
        }*/
    }
}
