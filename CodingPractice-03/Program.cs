using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("'''");
{
    var t1 = ("one", 1);
    var t2 = ("one", 1);
    var t3 = ("two", 2);

    Console.WriteLine(t1.Equals(t2));
    Console.WriteLine(t1.Equals(t3));
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    var t1 = ("one", 1);
    var t2 = ("one", 1);

    Console.WriteLine(t2 == t1);
    Console.WriteLine(t2 != t1);

}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    (string name, int age) p1 = ("Alice", 25);
    (string name, int age) p2 = p1;

    Console.WriteLine(p2);
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    (string name, int age, char sex) p1 = ("Bob", 23, 'M');
    (string age, int sex, char name) p2 = p1;

    Console.WriteLine(p2);
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    List<(string name, int age)> p = new() {
    ("Alice", 25),
    ("Bob", 30),
    ("Charlie", 35)
    };

    foreach (var (name, age) in p)
    {
        Console.WriteLine($"{name}: {age}세");
    }
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    Dictionary<(int x, int y), string> pos = new() {
    { (0, 0), "원점" },
    { (1, 0), "오른쪽" },
    { (0, 1), "위" }
    };

    Console.WriteLine(pos[(0, 0)]);
    Console.WriteLine(pos[(1, 0)]);
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    var tuple1 = new Tuple<string, int>("Bob", 23);
    Console.WriteLine($"{tuple1.Item1}, {tuple1.Item2}");

    var tuple2 = Tuple.Create("Alice", 25);
    Console.WriteLine($"{tuple2.Item1}, {tuple2.Item2}");
}
Console.WriteLine("'''\n");
