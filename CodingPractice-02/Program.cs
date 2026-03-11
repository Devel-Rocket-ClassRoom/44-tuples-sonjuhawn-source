using System;
using System.Reflection.Metadata;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("'''");
{
    (int sum, int count) n = Tally();

    Console.WriteLine($"합계:{n.sum} 개수:{n.count}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    var n = Calculate();

    Console.WriteLine($"합계:{n.Sum} 개수:{n.Count}");

    (int Sum, int Count) Calculate()
    {
        var result = (45, 6);
        return result;
    }
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    var n = GetPair();

    Console.WriteLine($"{n.first}, {n.second}");

    (int first, int second) GetPair() => (100, 200);
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    int[] num = { 5, 2, 8, 1, 9, 3 };

    var result = FindMinMax(num);

    Console.WriteLine($"최솟값: {result.min}, 최댓값: {result.max}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    var zero = ZeroZero();

    Console.WriteLine($"{zero.Item1}, {zero.Item2}");
    
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    var n= ("Bob", 23);
    (string name, int age) = n;

    Console.WriteLine($"이름: {name}");
    Console.WriteLine($"나이: {age}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    var (sum, count) = Tally();
    Console.WriteLine($"{sum}, {count}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    string n1 = "";
    int n2 = 0;
    var p = ("Alice", 30);
    (n1, n2) = p;
    Console.WriteLine($"{n1}, {n2}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    var (_, age, _) = GetPerson();
    Console.WriteLine($"나이: {age}");
}
Console.WriteLine("'''\n");

static (int, int) Tally()
{
    var result = (12, 3);
    return result;
}

static (int min, int max) FindMinMax(int[] num)
{
    int min = num[0];
    int max = num[0];

    foreach (int i in num)
    {
        if (i < min)
        {
            min = i;
        }
        if (i > max)
        {
            max = i;
        }
    }
    return (min, max);
}

static (int, int) ZeroZero()
{
    return default;
}

static (string name, int age, char gender) GetPerson() => ("Bob", 23, 'M');