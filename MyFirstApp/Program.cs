// See https://aka.ms/new-console-template for more information

//(string Name, string Surname, string Login, int LoginLength, bool HasPet, int Age, string[] favColors) User;

//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine("Введите имя");
//    User.Name = Console.ReadLine();
//    Console.WriteLine("Введите фамилию");
//    User.Surname = Console.ReadLine();
//    Console.WriteLine("Введите логин");
//    User.Login = Console.ReadLine();
//    User.LoginLength = User.Login.Length;
//    Console.WriteLine("Есть ли у вас животные? Да или Нет");
//    User.HasPet = Console.ReadLine() == "Да" ? true : false;
//    Console.WriteLine($"Животные {User.HasPet}");
//    Console.WriteLine("Введите возраст пользователя");
//    User.Age = checked((byte)int.Parse(Console.ReadLine()));

//    User.favColors = new string[3];
//    Console.WriteLine("Введите три любимых цвета пользователя");

//    for (int i = 0; i < User.favColors.Length; i++)
//    {
//        User.favColors[i] = Console.ReadLine();
//    }
//}


//(string Name, string[] Dishes) User;
//Console.WriteLine("Введите имя");
//User.Name = Console.ReadLine();

//User.Dishes = new string[5];

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine($"Введите любимое блюдо {i+1}");
//    User.Dishes[i] = Console.ReadLine();
//}

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


//(string name, int age) anketa;

//Console.Write("Введите имя: ");
//anketa.name = Console.ReadLine();
//Console.Write("Введите возраст с цифрами: ");
//anketa.age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Ваше имя: {0}", anketa.name);
//Console.WriteLine("Ваш возраст: {0}", anketa.age);


//static void ChangeAge(ref int age)
//{
//    Console.Write("Введите возраст с цифрами внутри метода: ");
//    age = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Ваш возраст внутри метода: {0}", age);
//}
//ChangeAge(ref anketa.age);
//Console.WriteLine("Ваш возраст снаружи метода: {0}", anketa.age);

//Console.ReadKey();


//static string ShowColor(string username, int age)
//{
//    Console.WriteLine($"{username}, {age},\n напишите свой любимый цвет на английском с маленькой буквы");
//    var color = Console.ReadLine();

//    switch (color)
//    {
//        case "red":
//            Console.BackgroundColor = ConsoleColor.Red;
//            Console.ForegroundColor = ConsoleColor.Black;

//            Console.WriteLine("Your color is red!");
//            break;

//        case "green":
//            Console.BackgroundColor = ConsoleColor.Green;
//            Console.ForegroundColor = ConsoleColor.Black;

//            Console.WriteLine("Your color is green!");
//            break;
//        case "cyan":
//            Console.BackgroundColor = ConsoleColor.Cyan;
//            Console.ForegroundColor = ConsoleColor.Black;

//            Console.WriteLine("Your color is cyan!");
//            break;
//        default:
//            Console.BackgroundColor = ConsoleColor.Yellow;
//            Console.ForegroundColor = ConsoleColor.Red;

//            Console.WriteLine("Your color is yellow!");
//            break;
//    }
//    return color;
//}

//string[] favColors = new string[3];
//for (int i = 0; i < favColors.Length; i++)
//{
//    favColors[i] = ShowColor(anketa.name, anketa.age);
//}

//static int[] GetArrayFromConsole(int num = 5)
//{
//    var result = new int[num];


//    for (int i = 0; i < result.Length; i++)
//    {
//        Console.WriteLine($"Введите элемент массива номер {i + 1}");
//        result[i] = int.Parse(Console.ReadLine());
//    }

//    for (int i = 0; i < result.Length; i++)
//    {
//        Console.Write(result[i]);
//        Console.WriteLine();
//    }

//    return result;
//}

//static void SortArray(in int[] arr, out int[] sorteddesc, out int[] sortedasc)
//{
//    sorteddesc = SortArrayDesc(arr);
//    sortedasc = SortArrayAsc(arr);
//}

//static int[] SortArrayDesc(int[] array)
//{
//    int buffer = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//        for (int j = i + 1; j < array.Length; j++)
//        {
//            if (array[i] < array[j])
//            {
//                buffer = array[i];
//                array[i] = array[j];
//                array[j] = buffer;
//            }
//        }
//    }
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.WriteLine(array[i]);
//    }
//    return array;
//}
//static int[] SortArrayAsc(int[] array)
//{
//    int buffer = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//        for (int j = i + 1; j < array.Length; j++)
//        {
//            if (array[i] > array[j])
//            {
//                buffer = array[i];
//                array[i] = array[j];
//                array[j] = buffer;
//            }
//        }
//    }
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write(array[i]);
//    }
//    return array;
//}
//int[] arr1 = { 1, 3, 5, 7, 2 };
//SortArray(arr1, out int[] sorteddesc, out int[] sortedasc);

//var array = GetArrayFromConsole(10);
//var sortedarray = SortArray(array);

//static void ShowArray(int[] array, bool sortFlag = false)
//{
//    var temp = array;
//    if (sortFlag)
//    {
//        SortArray(temp);
//    }

//}

//ShowArray(array, true);


//var arr = new int[] { 1, 2, 3 };
//BigDataOperation(arr);

//Console.WriteLine(arr[0]);


//static void BigDataOperation(in int[] arr)
//{
//    arr[0] = 4;
//}



Console.WriteLine("Напишите что-то");
var str = Console.ReadLine();

Console.WriteLine("Укажите глубину эха");
var deep = int.Parse(Console.ReadLine());

Echo(str, deep);

Console.ReadKey();


static void Echo(string saidworld, int deep)
{
    var modif = saidworld;
    if (modif.Length > 2)
    {
        modif = modif.Remove(0, 2);
    }
    Console.WriteLine("..." + modif);

    if (deep > 1)
    {
        Echo(modif, deep - 1);
    }
}