// See https://aka.ms/new-console-template for more information

//(string name, int age) anketa;
var (name, age) = ("Евгения", 27);
Console.WriteLine($"Имя и возраст: {name} и {age}");
Console.Write("Enter your name: ");
name = Console.ReadLine();
Console.Write("Enter your age: ");
age = checked((byte)int.Parse(Console.ReadLine()));
Console.Write("When is your birhtday? ");
var birthday = Console.ReadLine();
Console.WriteLine($"Your name is {name}, age is {age} and your birthday is {birthday}");








