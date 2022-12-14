internal class Program
{
    private static void Main(string[] args)
    {

    }

    abstract class Delivery<TAdress> where TAdress : Adress
    {
        public TAdress ShipAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
    }
    // Реализовано населование класса с обобщением
    class HomeDelivery : Delivery<Adress>
    {
        public Adress ShipAdress { get; private set; }
        private CourierService сourierService;
        public HomeDelivery(CourierService сourierService, Adress ShipAdress)
        {
            this.сourierService = сourierService;
            this.ShipAdress = ShipAdress;
        }
        public void GetFromCourierService(CourierService сourierService) { }
    }
    // Реализовано населование класса с обобщением
    class PickPointDelivery : Delivery<Adress>
    {
        public Adress ShipAdress { get; set; }
        private CourierService сourierService;
        public PickPointDelivery(CourierService сourierService, Adress ShipAdress)
        {
            this.сourierService = сourierService;
            this.ShipAdress = ShipAdress;
        }
        public void GetFromCourierService(CourierService сourierService) { }
    }

    class ShopDelivery : Delivery<Adress>
    {
        public Adress? ShipAdress { get; set; }
        private void GetFromTheShop() { }
    }

    class OrderCollection
    {
        //Реализован индексатор
        private Order<Delivery<Adress>, int>?[] collection;
        public OrderCollection(Order<Delivery<Adress>, int>[] collection)
        {
            this.collection = collection;
        }
        public Order<Delivery<Adress>, int>? this[int index]
        {
            get
            {
                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < collection.Length)
                {
                    return collection[index];
                }
                else
                {
                    return null;
                }
            }
            private set
            {
                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < collection.Length)
                {
                    collection[index] = value;
                }
            }
        }
    }
    class Order<TDelivery,
    TStruct> where TDelivery : Delivery<Adress>
    {
        public Order(TDelivery delivery, TStruct number, string description)
        {
            Delivery = delivery;
            Number = number;
            Description = description;
        }
        public TDelivery Delivery;

        public TStruct Number;

        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.ShipAddress);
        }
    }

    abstract class Product
    {
        protected decimal price;
        public virtual decimal Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Цена должна быть больше нуля!");
                }
            }
        }
        protected int Weight { get; set; }
        //реализовано абстрактное свойство
        public abstract string Name { get; set; }
        public Product(decimal price, int weight, string name)
        {
            Price = price;
            Weight = weight;
            Name = name;
        }
    }
    class ProductCart
    {
        public List<Product> productsList = new List<Product>();
        internal static int SumWeight { get; private set; }
        public int Amount { get; private set; }
        public static decimal SumPrice { get; private set; }
        public void AddToCart(Product ProductName, int Amount)
        {
            productsList.Append(ProductName);
            SumPrice = ProductName.Price * Amount;
        }
        public void GetSumPrice() { }
    }
    class Adress
    {
        public string country;
        public string city;
        public string streetName;
        public string houseNumber;
        public string? appartmentNumber;
        public Adress(string country, string city, string streetName, string houseNumber, string appartmentNumber)
        {
            this.country = country;
            this.city = city;
            this.streetName = streetName;
            this.houseNumber = houseNumber;
            this.appartmentNumber = appartmentNumber;
        }
        public Adress(string country, string city, string streetName, string houseNumber)
        {
            this.country = country;
            this.city = city;
            this.streetName = streetName;
            this.houseNumber = houseNumber;
        }
        public Adress(string city, string streetName, string houseNumber)
        {
            country = "Russia";
            this.city = city;
            this.streetName = streetName;
            this.houseNumber = houseNumber;
        }
    }
    class Book : Product
    {
        string publisher;
        string author;
        private string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Book(decimal price, int weight, string name, string publisher, string author) : base(price, weight, name)
        {
            this.publisher = publisher;
            this.author = author;
            this.name = name;
        }
        //реализована перегрузка оператора
        public static Book operator +(Book a, Book b)
        {

            return new Book(a.Price + b.Price, a.Weight + b.Weight, a.Name + " и " + b.Name, a.publisher + " и " + b.publisher, a.author + " и " + b.author);
        }

    }
    class Food : Product

    {
        public Food(decimal price, int weight, string name) : base(price, weight, name)
        {
            this.name = name;
        }
        private string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public static Food operator +(Food a, Food b)
        {
            return new Food(a.Price + b.Price, a.Weight + b.Weight, a.Name + " и " + b.Name);
        }

    }
    class Clothes : Product
    {
        string season;
        string gender;
        private string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Clothes(decimal price, int weight, string name, string season, string gender) : base(price, weight, name)
        {
            this.season = season;
            this.gender = gender;
            this.name = name;
        }
    }
    class CourierService
    {
        private Courier courier;
        private Secretary secretary;
        public CourierService(Secretary secretary, string servicePhoneNumber)
        {
            courier = new Courier(servicePhoneNumber);
            this.secretary = secretary;
            this.ServicePhoneNumber = servicePhoneNumber;
        }
        public string? ServicePhoneNumber { get; set; }
        public void SendACourier() { }
    }
    class Courier
    {
        public string name = String.Empty;
        public Courier(string courierPhoneNumber)
        {
            CourierPhoneNumber = courierPhoneNumber;
        }
        public string CourierPhoneNumber { get; set; }
        private void GetTheShipAdress() { }

    }
    class Secretary
    {
        public string name = String.Empty;

        private void TakeAfirstCall() { }
    }
}