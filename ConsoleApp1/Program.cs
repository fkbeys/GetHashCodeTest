// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Models;
using ConsoleApp1.SpeedTests;

Console.WriteLine("The GetHashCode Test");

var stockClass1 = new StockAsClass(1);
var stockClass2 = new StockAsClass(1);

var stockClass1Hash = stockClass1.GetHashCode();
var stockClass2Hash = stockClass2.GetHashCode();

Console.WriteLine($"Basic Class Comparison:{stockClass1Hash},{stockClass2Hash} \n");



var orderClass1 = new Order(1);
var orderClass2 = new Order(1);
var orderClass1Hash = orderClass1.GetHashCode();
var orderClass2Hash = orderClass2.GetHashCode();

Console.WriteLine($"Advanced Class Comparison:{orderClass1Hash},{orderClass2Hash} \n");



var stockRecord1 = new StockAsRecord(1);
var stockRecord2 = new StockAsRecord(1);

var stockRecord1Hash = stockRecord1.GetHashCode();
var stockRecord2Hash = stockRecord2.GetHashCode();

Console.WriteLine($"Record Comparison:{stockRecord1Hash},{stockRecord2Hash}");
Console.WriteLine("Thanks to the C# 9 Team for Record type.\n");

string str1 = "abc";
int str1hash = str1.GetHashCode();
str1 = "def";
int str2hash = str1.GetHashCode();

Console.WriteLine($"String Comparison:{str1hash},{str2hash}\n");


DateTime now = DateTime.Now;
int dt1now = now.GetHashCode();
now = now.AddDays(1); // Yeni bir DateTime nesnesi oluşturulur
int dt2now = now.GetHashCode();

Console.WriteLine($"Datetime Comparison:{dt1now},{dt2now}\n");

StringBuilderSpeedTest stringBuilderSpeedTest = new StringBuilderSpeedTest();


Console.ReadLine();




