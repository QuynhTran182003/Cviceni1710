namespace Cviceni1710
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();
            Word w = dictionary.CreateWord("Hello", "ahoj", "cau", "nazdar");
            dictionary.AddWord(w);

            Word w2 = dictionary.CreateWord("cat", "kocour", "kocka");
            dictionary.AddWord(w2);

            Console.WriteLine(dictionary);
        }
    }
}