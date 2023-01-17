using System;

/*
 [Задание 4][C#]

public abstract class Building
{
    public virtual int GetFloors()
    {
        return 0;
    }
}

public class House : Building
{
    public override int GetFloors()
    {
        return 1;
    }
}

public class SkyScraper : House
{
    public override int GetFloors()
    {
        return 30;
    }
}

public class OrdinaryHouse : House
{
    public new int GetFloors()
    {
        return 5;
    }
}

Чему равен результат вызова метода GetFloors?
1.
Building house1 = new SkyScraper();
Console.WriteLine(house1.GetFloors()); //?
2.
House house2 = new SkyScraper();
Console.WriteLine(house2.GetFloors()); //?
3.
House house3 = new OrdinaryHouse();
Console.WriteLine(house3.GetFloors()); //?
4.
OrdinaryHouse house4 = new House();
Console.WriteLine(house4.GetFloors()); //?
*/

namespace ConsoleApp3
{
    class Program
    {
        public abstract class Building
        {
            public virtual int GetFloors()
            {
                return 0;
            }
        }

        public class House : Building
        {
            public override int GetFloors()
            {
                return 1;
            }
        }

        public class SkyScraper : House
        {
            public override int GetFloors()
            {
                return 30;
            }
        }

        public class OrdinaryHouse : House
        {
            public new int GetFloors()
            {
                return 5;
            }
        }
        static void Main(string[] args)
        {
            Building house1 = new SkyScraper();
            Console.WriteLine(house1.GetFloors()); //30

            House house2 = new SkyScraper();
            Console.WriteLine(house2.GetFloors()); //30

            House house3 = new OrdinaryHouse();
            OrdinaryHouse ordinary = (OrdinaryHouse)house3;
            Console.WriteLine(house3.GetFloors()); //1 потому что классу не видно скрытое метод
            Console.WriteLine(ordinary.GetFloors()); //5 

            //OrdinaryHouse house4 = new House();
            OrdinaryHouse house4 = new ();
            Console.WriteLine(house4.GetFloors()); //?
        }
    }
}
