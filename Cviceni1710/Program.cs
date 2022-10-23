namespace Cviceni1710
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();

            List<string> listSayHi = new List<string>();
                listSayHi.Add("Hello");
                listSayHi.Add("Hi");
            Word w = dictionary.CreateWord(listSayHi, "ahoj", "cau", "nazdar");
            dictionary.AddWord(w);

            List<string> listCat = new List<string>();
                listCat.Add("Cat");
                listCat.Add("Kitty");
            Word w2 = dictionary.CreateWord(listCat, "kocour", "kocka");
            dictionary.AddWord(w2);

            Console.WriteLine(dictionary.TranslateToCzech("Hello"));
            Console.WriteLine(dictionary.TranslateToEnglish("cau"));
            Console.WriteLine(dictionary.TranslateToCzech("Kitty"));
            Console.WriteLine(dictionary.TranslateToCzech("sth thats not in dictionary"));



        }
    }
}