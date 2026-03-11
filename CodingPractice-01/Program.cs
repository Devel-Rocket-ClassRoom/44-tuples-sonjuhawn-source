using System;
using System.Net.Cache;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("'''");
{
    var n = ("Bob", 23);

    Console.WriteLine($"{n.Item1}");
    Console.WriteLine($"{n.Item2}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    var n = (12, 34, 56);

    Console.WriteLine($"{n.Item1}, {n.Item2}, {n.Item3}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    var n = ("Hello", 100, true, 3.14);

    Console.WriteLine($"{n.Item1}, {n.Item2}, {n.Item3} , {n.Item4}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    (string, int) n = ("Alice", 25);

    Console.WriteLine($"{n.Item1}, {n.Item2}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    (ushort Width, ushort Height) n = (1920, 1080);

    Console.WriteLine($"해상도: {n.Width}, {n.Height}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    var n1 = ("Bob", 23);
    var n2 = n1;

    Console.WriteLine($"원본: {n1}");
    Console.WriteLine($"복사본: {n2}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    var n1 = (name: "Bob", age: 23);

    Console.WriteLine(n1.name);
    Console.WriteLine(n1.age);
    Console.WriteLine(n1.Item1);
    Console.WriteLine(n1.Item2);
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    var n1 = (Name: "철수", IsStudent: true, OrderPrice: 1_000);

    Console.WriteLine($"{n1.Name}(학생: {n1.IsStudent}) - 주문: {n1.OrderPrice:N0}원");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    (string name, int age, char gender) n = ("Bob", 23, 'M');

    Console.WriteLine($"이름: {n.name}");
    Console.WriteLine($"나이: {n.age}");
    Console.WriteLine($"성별: {n.gender}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    var now = DateTime.Now;
    var time = (now.Day, now.Month, now.Year);

    Console.WriteLine($"일: {time.Day}");
    Console.WriteLine($"월: {time.Month}");
    Console.WriteLine($"년: {time.Year}");
}
Console.WriteLine("'''\n");