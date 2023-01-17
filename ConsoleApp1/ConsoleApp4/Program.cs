using System;
using System.Linq;

namespace ConsoleApp4
{
    /*
    [Задание 5][C#]
Из последовательности notAllStrings выбрать только строковые элементы,
упорядочить слова по длине и затем в алфавитном порядке. Нужно использовать Linq.
Результат должен получиться следующим: One,Two,Five,Four,Three
object[] notAllStrings = { "One", "Two", "Three", "Four", "Five", 6 };
     */

    class Program
    {
        static void Main(string[] args)
        {
            object[] notAllStrings = { "One", "Two", "Three", "Four", "Five", 6 };

            Console.WriteLine();
            foreach (var item in notAllStrings)
            {
                Console.WriteLine(item);
            }

            var allStrings = notAllStrings.OfType<string>();

            Console.WriteLine();
            foreach (var item in allStrings)
            {
                Console.WriteLine(item);
            }

            var sortString = allStrings.OrderBy(e => e.Length).ThenBy(e => e);

            Console.WriteLine();
            foreach (var item in sortString)
            {
                Console.WriteLine(item);
            }
        }
    }
}
