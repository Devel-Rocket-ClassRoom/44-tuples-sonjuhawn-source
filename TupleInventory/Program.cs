using System;
using System.Collections.Generic;
using System.Xml.Linq;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("=== 아이템 인벤토리 ===");

List<(string name, int quantity, int price)> Inventory = new List<(string name, int quantity, int price)>();

AddItem(Inventory, "체력 포션", 3, 500);
AddItem(Inventory, "마나 포션", 5, 800);
AddItem(Inventory, "해독제", 2, 300);
AddItem(Inventory, "엘릭서", 1, 5000);
foreach (var item in Inventory)
{
    Console.WriteLine($"{item.name} - 수량: {item.quantity}개, 단가: {item.price}원");
}

Console.WriteLine("=== 가장 비싼 아이템 ===");
(string name, int price) = FindMostExpensive(Inventory);
Console.WriteLine($"이름:{name}, 단가:{price}");

Console.WriteLine("=== 인벤토리 합산 ===");
(int allquantity, int allprice) = CalculateTotal(Inventory);
Console.WriteLine($"총 가치: {allprice}");
Console.WriteLine($"총 가치: {allquantity}");


void AddItem(List<(string name, int quantity, int price)> inventory, string name, int quantity, int price)
{
    var item = (name, quantity, price);
    inventory.Add(item);
}
(string name, int price) FindMostExpensive(List<(string name, int quantity, int price)> inventory)
{
    (string name, int price) max = ("", 0);
    foreach (var item in inventory)
    {
        if(item.price > max.price)
        {
            max = (item.name,item.price);
        }
    }
    return max;
}

(int totalValue, int totalCount) CalculateTotal(List<(string name, int quantity, int price)> inventory)
{
    (int quantity, int price) total = (0, 0);
    foreach(var item in inventory)
    {
        total.quantity += item.quantity;
        total.price += item.price * item.quantity;
    }
    return total;
}