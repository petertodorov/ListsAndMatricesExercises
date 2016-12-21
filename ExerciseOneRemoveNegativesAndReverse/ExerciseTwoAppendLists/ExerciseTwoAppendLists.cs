using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ExerciseTwoAppendLists
{
    static void Main(string[] args)
    {
        List<string> input = Console.ReadLine().Split('|').ToList();
        input.Reverse();
        List<string> result = new List<string>();
        foreach (var item in input)
        {
           List<string> nums = item.
                Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            result.AddRange(nums);
        }
        Console.WriteLine(String.Join(" ", result));
    }
}

