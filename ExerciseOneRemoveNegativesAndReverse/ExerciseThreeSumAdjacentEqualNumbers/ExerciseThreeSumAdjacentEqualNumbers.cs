using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExerciseThreeSumAdjacentEqualNumbers

{
    static void Main(string[] args)
    {
        
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        for (int i = 1; i < input.Count; i++)
        {
            if (input[i - 1] == input[i])
            {
                input[i-1] +=input[i];
                input.RemoveAt(i);
                i=i-2;
                if (i<0)
                {
                    i = 0;
                }
            }
           
        }
        Console.WriteLine(String.Join(" ",input));
    }
}

