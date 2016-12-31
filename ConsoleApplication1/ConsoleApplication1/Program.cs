using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class test
{
    static void Main(string[] args)
    {
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        input.Sort();
        int counter = 1;
        int previousNum = input[0];
        for (int i = 1; i < input.Count; i++)
        {
            if (previousNum == input[i])
            {
                counter++;
            }
            else
            {
                Console.WriteLine($"{previousNum}->{counter}");

                previousNum = input[i];
                counter = 1;
            }
        }
        //Console.WriteLine($"{previousNum}->{counter}");
    }
}
