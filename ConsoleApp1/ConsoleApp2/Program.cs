using System;
using System.Collections.Generic;

/*
 [Задание 3][C#]

public class Car
{
    public string Model { get; set; }
    public int Wheels { get; set; }
}

private static void RefreshValue(int value)
{
    value = 0;
}

private static void RefreshValue(ref int value)
{
    value = 0;
}

private static void RefreshValue(string value)
{
    value = null;
}

private static void RefreshValue(List<string> value)
{
    value = new List<string>();
    value.Add("I'm empty");
}

Чему равно значение переменной, передаваемой в качестве входного параметра, после вызова метода RefreshValue?
1.
int i = 8;
RefreshValue(i);
Console.WriteLine(i);// ?
2.
var car = new Car();
car.Wheels = 4;
RefreshValue(car.Wheels);
Console.WriteLine(car.Wheels);// ?
3.
string model = "Lada Granta";
RefreshValue(model);
Console.WriteLine(model);// ?
4.
var lastNames = new List<string>() {"Иванов", "Петров", "Сидоров"};
RefreshValue(lastNames);
Console.WriteLine(string.Join(“,”, lastNames));// ?
*/

namespace ConsoleApp2
{
    class Program
    {
        public class Car
        {
            public string Model { get; set; }
            public int Wheels { get; set; }
        }

        private static void RefreshValue(int value)
        {
            value = 0;
        }

        private static void RefreshValue(ref int value)
        {
            value = 0;
        }

        private static void RefreshValue(string value)
        {
            //value = null;
            value = "123";
        }

        private static void RefreshValue(List<string> value)
        {
            value = new List<string>();
            value.Add("I'm empty");
        }

        static void Main(string[] args)
        {
            int i = 8;
            RefreshValue(i);
            Console.WriteLine(i);// 8

            var car = new Car();
            car.Wheels = 4;
            RefreshValue(car.Wheels);
            Console.WriteLine(car.Wheels);// 4

            string model = "Lada Granta";
            RefreshValue(model);
            Console.WriteLine(model);// "Lada Granta"

            var lastNames = new List<string>() { "Иванов", "Петров", "Сидоров" };
            RefreshValue(lastNames);
            Console.WriteLine(string.Join(",", lastNames));// ?
        }
    }
}
