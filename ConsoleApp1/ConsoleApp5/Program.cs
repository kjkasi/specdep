using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    /*
     * На входе:
    args - массив чисел
    target - число, которое должно получится в результате суммы двух элементов args
    На выходе:
    boolean - true, если можно получить target из суммы 2 элементов args

    Временная сложность лучше чем O(n^2)

    Например: args = {2, 3, 5, 1, 0, 10} target = 13 - true, target = 25 - false

    public static bool GetResult(List<int> args, int target)
    {
        // Put your code here
    }
     */
    class Program
    {
        static void Main(string[] args)
        {
            var argss = new List<int> { 2, 3, 5, 1, 0, 10};
            GetResult(argss, 13);
        }

        public static bool GetResult(List<int> args, int target)
        {

           for (int i = 0; i < args.Count; i++)
           {
                for (int j = 0; j < args.Count; j++)
                {
                    Console.WriteLine($"({args[i]}, {args[j]})");
                    int sum = args[i] + args[j];
                    if (sum == target) return true;
                }
           }

           return false;
        }
    }
}
