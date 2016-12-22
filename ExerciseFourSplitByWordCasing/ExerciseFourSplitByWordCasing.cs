using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExerciseFourSplitByWordCasing
{
    static void Main(string[] args)
    {
        char[] separators = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
        List<string> wordsSequence = Console.ReadLine().
            Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
        List<string> lowerCase = new List<string>();
        List<string> upperCase = new List<string>();
        List<string> mixCase = new List<string>();
        foreach (var word in wordsSequence)
        {
            int upper = 0;
            int lower = 0;
            foreach (var letter in word)
            {
                if (char.IsUpper(letter))
                {
                    upper++;
                }
                else if (char.IsLower(letter))
                {
                    lower++;
                }
            }
            if (lower == word.Length)
            {
                lowerCase.Add(word);
            }
            else if (upper == word.Length)
            {
                upperCase.Add(word);
            }
            else
            {
                mixCase.Add(word);
            }
        }
        Console.WriteLine($"Lower-case: {String.Join(", ", lowerCase)}");
        Console.WriteLine($"Mixed-case: {String.Join(", ", mixCase)}");
        Console.WriteLine($"Upper-case: {String.Join(", ", upperCase)}");
    }
}
