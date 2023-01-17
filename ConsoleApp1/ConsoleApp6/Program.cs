using System;
using System.Linq;

namespace ConsoleApp6
{
    /*
     * [Задание 7][C#]Что выведется на экран?
int[] numeric = Enumerable.Range(1, 5).ToArray();
var resSum = numeric.Sum();
var resNum2 = numeric.Where(n => n < 4);

Console.WriteLine(resSum); // ?
Console.WriteLine(string.Join(",", resNum2)); // ?
numeric[2] = 0;
Console.WriteLine(resSum); // ?
Console.WriteLine(string.Join(",", resNum2)); // ?
    */
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeric = Enumerable.Range(1, 5).ToArray();
            var resSum = numeric.Sum();
            var resNum2 = numeric.Where(n => n < 4);

            Console.WriteLine(resSum); // 15
            Console.WriteLine(string.Join(",", resNum2)); // 1.2.3
            numeric[2] = 0;
            Console.WriteLine(resSum); // 15
            Console.WriteLine(string.Join(",", resNum2)); // 1.2.0
        }
    }
}
