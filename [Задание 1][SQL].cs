[Задание 1][SQL]

Дана таблица DoorLogs содержащая логи открытия дверей предприятия.
DoorLogs(
Door_Id int not null, --идентификатор двери
LogDate DateTime not null) --дата очередного открытия

Содержимое таблицы:

|Door_Id | LogDate |
|0 | 2018-05-10T00:00:00Z |
|1 | 2018-05-18T00:00:00Z |
|2 | 2018-05-24T00:00:00Z |
|3 | 2018-05-26T00:00:00Z |
|4 | 2018-05-28T00:00:00Z |
|3 | 2018-06-03T00:00:00Z |
|4 | 2018-06-08T00:00:00Z |
|0 | 2018-06-15T00:00:00Z |

Вывести записи последнего открытия по каждой двери и количество открытий.

Ожидаемый вывод:
|Door_Id | LogDate |Count
|0 | 2018-06-15T00:00:00Z |2
|1 | 2018-05-18T00:00:00Z |1
|2 | 2018-05-24T00:00:00Z |1
|3 | 2018-06-03T00:00:00Z |2
|4 | 2018-06-08T00:00:00Z |2

Ответ:

 


[Задание 2][C#]
Напишите программу, которая выводит на экран числа от 1 до 100.
При этом вместо чисел, кратных трем, программа должна выводить слово «Fizz»,
а вместо чисел, кратных пяти — слово «Buzz». Если число кратно и 3, и 5,
то программа должна выводить слово «FizzBuzz»

Ответ:


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


[Задание 5][C#]
Из последовательности notAllStrings выбрать только строковые элементы,
упорядочить слова по длине и затем в алфавитном порядке. Нужно использовать Linq.
Результат должен получиться следующим: One,Two,Five,Four,Three
object[] notAllStrings = { "One", "Two", "Three", "Four", "Five", 6 };

Ответ:



[Задание 6][C#]
На входе:
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



[Задание 7][C#]Что выведется на экран?
int[] numeric = Enumerable.Range(1, 5).ToArray();
var resSum = numeric.Sum();
var resNum2 = numeric.Where(n => n < 4);

Console.WriteLine(resSum); // ?
Console.WriteLine(string.Join(",", resNum2)); // ?
numeric[2] = 0;
Console.WriteLine(resSum); // ?
Console.WriteLine(string.Join(",", resNum2)); // ?


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
}


[Задание 9][C#]
В чем проблема данного кода?
public ActionResult ActionAsync()
{
    var data = GetDataAsync().Result;

    return View(data);
}

private async Task<string> GetDataAsync()
{
    var result = await MyWebService.GetDataAsync();
    return result.ToString();
}
