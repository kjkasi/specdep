using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    /*
     [Задание 8][C#]
Что будет выведено на экран?
Что будет выведено на экран, если заменить await Task.Delay(5) на Thread.Sleep(5)?
class Program
{
    private static string result;

    static void Main()
    {
        SaySomething();
        Console.WriteLine(result);
    }

    static async Task<string> SaySomething()
    {
        await Task.Delay(5);
        result = "Hello world!";
        return “Something”;
    }
}*/
    class Program
    {
        private static string result;
        static void Main(string[] args)
        {
            SaySomething();
            Console.WriteLine(result);
        }

        static async Task<string> SaySomething()
        {
            await Task.Delay(5);
            //Thread.Sleep(5);
            result = "Hello world!";
            return "Something";
        }
    }
}
