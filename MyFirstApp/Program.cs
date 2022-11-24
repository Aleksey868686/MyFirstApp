internal class Program
{
    private static void Main(string[] args)
    {
        static bool CheckNum(string number, out int correctNumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    correctNumber = intnum;
                    return false;
                }
                else
                {
                    Console.WriteLine("Введите число больше нуля");
                    correctNumber = 0;
                    return true;
                }
            }
            correctNumber = 0;
            return true;
        }

        static (string name, string surname, int age, bool hasPet, int petsQuantity, string[] petsNickname, int favColors, string[] arrOfColors) CreateData()
        {
            (string name, string surname, int age, bool hasPet, int petsQuantity, string[] petsNickname, int favColors, string[] arrOfColors) DataTuple;
            Console.WriteLine("Введите имя");
            DataTuple.name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            DataTuple.surname = Console.ReadLine();

            string ageRead;
            int intage;
            do
            {
                Console.WriteLine("Введите возраст цифрами:");
                ageRead = Console.ReadLine();
            } while (CheckNum(ageRead, out intage));
            DataTuple.age = intage;

            Console.WriteLine("Есть ли у вас животные? Да или Нет");
            DataTuple.hasPet = Console.ReadLine() == "Да" ? true : false;


            string petsQuant;
            int intPetsQuant;
            if (DataTuple.hasPet)
            {
                do
                {
                    Console.WriteLine("Сколько у Вас питомцев?");
                    petsQuant = Console.ReadLine();
                } while (CheckNum(petsQuant, out intPetsQuant));
                DataTuple.petsQuantity = intPetsQuant;
                DataTuple.petsNickname = ShowPetsNicknames(DataTuple.petsQuantity);

            }
            else
            {
                DataTuple.petsQuantity = 0;
                DataTuple.petsNickname = ShowPetsNicknames(DataTuple.petsQuantity);
            }

            string favColorsQuant;
            int intfavColorsQuant;
            do
            {
                Console.WriteLine("Сколько у Вас любимых цветов?");
                favColorsQuant = Console.ReadLine();
            } while (CheckNum(favColorsQuant, out intfavColorsQuant));

            DataTuple.favColors = intfavColorsQuant;
            DataTuple.arrOfColors = ShowfavColors(DataTuple.favColors);

            return DataTuple;
        }

        static string[] ShowPetsNicknames(int petsQuantity)
        {

            string[] petsNicknames = new string[petsQuantity];
            if (petsQuantity > 0)
            {
                for (int i = 0; i < petsQuantity; i++)
                {
                    Console.WriteLine("Введите кличку");
                    petsNicknames[i] = Console.ReadLine();
                }
                return petsNicknames;
            }
            else
            {
                var emptyArray = new string[] { "Нет животных - нет клички!" };
                return emptyArray;
            }

        }

        static string[] ShowfavColors(int favColorsQuantity)
        {
            string[] arrOfColors = new string[favColorsQuantity];
            for (int i = 0; i < favColorsQuantity; i++)
            {
                Console.WriteLine("Введите любимый цвет:");
                arrOfColors[i] = Console.ReadLine();
            }
            return arrOfColors;
        }

        static void ShowTuple((string name, string surname, int age, bool hasPet, int petsQuantity, string[] petsNickname, int favColors, string[] arrOfColors) DataTuple)
        {
            Console.WriteLine($"Ваше имя: {DataTuple.name}");
            Console.WriteLine($"Ваша фамилия: {DataTuple.surname}");
            Console.WriteLine($"Ваш возраст {DataTuple.age}");
            foreach (var item in DataTuple.petsNickname)
            {
                Console.WriteLine($"Ваши любимые животные: {item}");
            }

            foreach (var item in DataTuple.arrOfColors)
            {
                Console.WriteLine($"Ваши любимые цвета: {item}");
            }
        }

        ShowTuple(CreateData());
    }
}