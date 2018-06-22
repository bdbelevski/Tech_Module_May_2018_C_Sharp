using System;


class _05_Word_in_Plural
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();

        string pluralWord = "";

        if (word.EndsWith("y"))
        {
            string currentWord = word.Remove(word.Length - 1);
            pluralWord = currentWord + "ies";
        }
        else if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
        {
            pluralWord = word + "es";
        }
        else
        {
            pluralWord = word + "s";
        }
        Console.WriteLine($"{pluralWord}");
    }
}