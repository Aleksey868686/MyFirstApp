// See https://aka.ms/new-console-template for more information

(string Name, string Surname, string Login, int LoginLength, bool HasPet, int Age, string[] favColors) User;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Введите имя");
    User.Name = Console.ReadLine();
    Console.WriteLine("Введите фамилию");
    User.Surname = Console.ReadLine();
    Console.WriteLine("Введите логин");
    User.Login = Console.ReadLine();
    User.LoginLength = User.Login.Length;
    Console.WriteLine("Есть ли у вас животные? Да или Нет");
    User.HasPet = Console.ReadLine() == "Да" ? true : false;
    Console.WriteLine($"Животные {User.HasPet}");
    Console.WriteLine("Введите возраст пользователя");
    User.Age = checked((byte)int.Parse(Console.ReadLine()));

    User.favColors = new string[3];
    Console.WriteLine("Введите три любимых цвета пользователя");

    for (int i = 0; i < User.favColors.Length; i++)
    {
        User.favColors[i] = Console.ReadLine();
    }
}
//Console.Write("Enter pet's name: ");
//Pet.Name = Console.ReadLine();
//Console.Write("Enter pet's type: ");
//Pet.Type = Console.ReadLine();
//Console.Write("Enter pet's age: ");
//Pet.Age = checked((byte)int.Parse(Console.ReadLine()));
//Pet.NameCount = Pet.Name.Length;
//Console.WriteLine($"Your pet's name is {Pet.Name}, age is {Pet.Age}, type is {Pet.Type} and pet's nameCount: {Pet.NameCount}");

//(string name, int age) anketa;

//var (name, age) = ("Евгения", 27);
//Console.WriteLine($"Имя и возраст: {name} и {age}");
//Console.Write("Enter your name: ");
//name = Console.ReadLine();
//Console.Write("Enter your age: ");
//age = checked((byte)int.Parse(Console.ReadLine()));
//Console.Write("When is your birhtday? ");
//var birthday = Console.ReadLine();
//Console.WriteLine($"Your name is {name}, age is {age} and your birthday is {birthday}");












