internal class Program
{
    private static void Main(string[] args)
    {
        //    static bool CheckNum(string number, out int correctNumber)
        //    {
        //        if (int.TryParse(number, out int intnum))
        //        {
        //            if (intnum > 0)
        //            {
        //                correctNumber = intnum;
        //                return false;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Введите число больше нуля");
        //                correctNumber = 0;
        //                return true;
        //            }
        //        }
        //        correctNumber = 0;
        //        return true;
        //    }

        //    static (string name, string surname, int age, bool hasPet, int petsQuantity, string[] petsNickname, int favColors, string[] arrOfColors) CreateData()
        //    {
        //        (string name, string surname, int age, bool hasPet, int petsQuantity, string[] petsNickname, int favColors, string[] arrOfColors) DataTuple;
        //        Console.WriteLine("Введите имя");
        //        DataTuple.name = Console.ReadLine();

        //        Console.WriteLine("Введите фамилию");
        //        DataTuple.surname = Console.ReadLine();

        //        string ageRead;
        //        int intage;
        //        do
        //        {
        //            Console.WriteLine("Введите возраст цифрами:");
        //            ageRead = Console.ReadLine();
        //        } while (CheckNum(ageRead, out intage));
        //        DataTuple.age = intage;

        //        Console.WriteLine("Есть ли у вас животные? Да или Нет");
        //        DataTuple.hasPet = Console.ReadLine() == "Да" ? true : false;


        //        string petsQuant;
        //        int intPetsQuant;
        //        if (DataTuple.hasPet)
        //        {
        //            do
        //            {
        //                Console.WriteLine("Сколько у Вас питомцев?");
        //                petsQuant = Console.ReadLine();
        //            } while (CheckNum(petsQuant, out intPetsQuant));
        //            DataTuple.petsQuantity = intPetsQuant;
        //            DataTuple.petsNickname = ShowPetsNicknames(DataTuple.petsQuantity);

        //        }
        //        else
        //        {
        //            DataTuple.petsQuantity = 0;
        //            DataTuple.petsNickname = ShowPetsNicknames(DataTuple.petsQuantity);
        //        }

        //        string favColorsQuant;
        //        int intfavColorsQuant;
        //        do
        //        {
        //            Console.WriteLine("Сколько у Вас любимых цветов?");
        //            favColorsQuant = Console.ReadLine();
        //        } while (CheckNum(favColorsQuant, out intfavColorsQuant));

        //        DataTuple.favColors = intfavColorsQuant;
        //        DataTuple.arrOfColors = ShowfavColors(DataTuple.favColors);

        //        return DataTuple;
        //    }

        //    static string[] ShowPetsNicknames(int petsQuantity)
        //    {

        //        string[] petsNicknames = new string[petsQuantity];
        //        if (petsQuantity > 0)
        //        {
        //            for (int i = 0; i < petsQuantity; i++)
        //            {
        //                Console.WriteLine("Введите кличку");
        //                petsNicknames[i] = Console.ReadLine();
        //            }
        //            return petsNicknames;
        //        }
        //        else
        //        {
        //            var emptyArray = new string[] { "Нет животных - нет клички!" };
        //            return emptyArray;
        //        }

        //    }

        //    static string[] ShowfavColors(int favColorsQuantity)
        //    {
        //        string[] arrOfColors = new string[favColorsQuantity];
        //        for (int i = 0; i < favColorsQuantity; i++)
        //        {
        //            Console.WriteLine("Введите любимый цвет:");
        //            arrOfColors[i] = Console.ReadLine();
        //        }
        //        return arrOfColors;
        //    }

        //    static void ShowTuple((string name, string surname, int age, bool hasPet, int petsQuantity, string[] petsNickname, int favColors, string[] arrOfColors) DataTuple)
        //    {
        //        Console.WriteLine($"Ваше имя: {DataTuple.name}");
        //        Console.WriteLine($"Ваша фамилия: {DataTuple.surname}");
        //        Console.WriteLine($"Ваш возраст {DataTuple.age}");
        //        foreach (var item in DataTuple.petsNickname)
        //        {
        //            Console.WriteLine($"Ваши любимые животные: {item}");
        //        }

        //        foreach (var item in DataTuple.arrOfColors)
        //        {
        //            Console.WriteLine($"Ваши любимые цвета: {item}");
        //        }
        //    }

        //    ShowTuple(CreateData());

        //    D d = new D();
        //    E e = new E();
        //    d.Display();
        //    ((A)e).Display();
        //    ((B)d).Display();
        //    ((A)d).Display();
        //}

        //class A
        //{
        //    public virtual void Display()
        //    {
        //        Console.WriteLine("A");
        //    }
        //}
        //class B : A
        //{
        //    public new void Display()
        //    {
        //        Console.WriteLine("B");
        //    }
        //}
        //class C : A
        //{
        //    public override void Display()
        //    {
        //        Console.WriteLine("C");
        //    }
        //}
        //class D : B
        //{
        //    public new void Display()
        //    {
        //        Console.WriteLine("D");
        //    }
        //}
        //class E : C
        //{
        //    public new void Display()
        //    {
        //        Console.WriteLine("E");
        //    }
        //}

        //abstract class ComputerPart 
        //{
        //    public abstract void Work();
        //}
        //class Processor : ComputerPart 
        //{
        //    public override void Work()
        //    {
        //        throw new NotImplementedException()
        //    }
        //}
        //class MotherBoard : ComputerPart 
        //{
        //    public override void Work()
        //    {
        //        throw new NotImplementedException();    
        //    }

        //}
        //class GraphicCard : ComputerPart 
        //{
        //    public override void Work()
        //    {
        //        throw new NotImplementedException();    
        //    }
        //}
        //class Obj 
        //{
        //    public string Name;
        //    public string Description;
        //    public static int MaxValue = 2000;
        //}
        //class Helper 
        //{
        //    public static void Swap(ref int a, ref int b)
        //    {
        //        int buffer;
        //        buffer = a;
        //        a = b;
        //        b = buffer;
        //    }
        //}
        //class Obj
        //{
        //    public string Name;
        //    public string Description;

        //    public static string Parent;
        //    public static int DaysInWeek; 
        //    static Obj()
        //    {
        //        Parent = "System.Object";
        //        DaysInWeek = 7;
        //        MaxValue = 2000;
        //    }
        //}
        //static class IntExtensions
        //{
        //    public static int GetNegative(this int number)
        //    {
        //        return number > 0 ? (-1) * number : number;
        //    }
        //    public static int GetPositive(this int number)
        //    {
        //        return number < 0 ?  number : (-1) * number;
        //    }
    }
    abstract class Engine { };
    abstract class CarPart { };
    class ElectricEngine : Engine { };
    class GasEngine : Engine { };
    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;
        public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;
    }
    class Battery : CarPart { };
    class Differential : CarPart { };
    class Wheel : CarPart { };
    class ElectricCar : Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart) { }
    }
    class GasCar : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart) { }
    };

    class Record<T1, T2>
    {
        public DateTime Date;
        public T1 Id;
        public T2 Value;
    }
}