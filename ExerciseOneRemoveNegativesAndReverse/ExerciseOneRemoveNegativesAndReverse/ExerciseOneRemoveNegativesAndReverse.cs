using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ExerciseOneRemoveNegativesAndReverse
{
    static void Main(string[] args)
    {

        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        List<int> result = new List<int>();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] >= 0)
            {
                result.Add(input[i]);
            }
        }
        result.Reverse();
        Console.WriteLine(String.Join(" ", result));
    }
}

