// See https://aka.ms/new-console-template for more information

(string name, int age) anketa;
Console.Write("Enter your name: ");
anketa.name = Console.ReadLine();
Console.Write("Enter your age: ");
anketa.age = checked((byte)int.Parse(Console.ReadLine()));
Console.Write("When is your birhtday? ");
var birthday = Console.ReadLine();
Console.WriteLine($"Your name is {name}, age is {age} and your birthday is {birthday}");








