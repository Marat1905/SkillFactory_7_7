// See https://aka.ms/new-console-template for more information

// Инициализация классов
using SkillFactory.Domain.Model;
using System.Diagnostics.Metrics;

Customer customer1 = new("Максим", "Санкт-Петербург");
Customer customer2 = new("Анатолий", "Кострома");
Shop shop1 = new("Магнит", "Магадан");

HomeDelivery homeDelivery1 = new(0,customer1);

ShopDelivery shopDelivery1 = new(0, customer1, shop1);
PickPointDelivery pickPointDelivery1 =new(0,customer2,"Москва");

Product<int> product1 = new(1,"Картошка",10,10);
Product<int> product2 = new(1, "Земляника", 10, 10);
Courier courier1 = new("Mark", "1234567");
Courier courier2 = new("Jhon", "7654321");

Order<int,HomeDelivery> order1 = new(1, homeDelivery1, product1, 2, courier1);
Order<int,ShopDelivery> order2 = new(2, shopDelivery1, product2, 20, courier2);
Order<int,PickPointDelivery> order3 = new(3, pickPointDelivery1, product1, 1);

// Вывод информации о заказах
order1.DisplayOrderInfo();
Console.WriteLine();
order2.DisplayOrderInfo();
Console.WriteLine();
order3.DisplayOrderInfo();

Console.ReadKey();
