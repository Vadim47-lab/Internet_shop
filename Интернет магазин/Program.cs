using System;

namespace Интернет_магазин
{
    class Program
    {
        static void Main(string[] args)
        {
            Application application = new Application();
            application.StartWork();
        }
    }

    class Application
    {
        private readonly Shop _shop;

        public void StartWork()
        {
            string command = "";

            //_internetShop.AddInfo();

            while (command != "exit")
            {
                Console.Write("\n Добро пожаловать в программу: Хранилище книг!\n В данной программе eсть хранилище книг. Каждая книга имеет название, автора, год выпуска, оглавление и количество\n " +
                "страниц. В хранилище можно добавить книгу, убрать книгу, показать все книги и показать книги по указанному параметру\n (по названию, по автору, по году выпуска).\n\n");

                //_internetShop.ShowInfo();

                Console.Write("\n Команды:\n add - добавить книгу,\n del - убрать книгу,\n all - посмотреть все книги в хранилище,\n name - показать книги по названию,\n author - показать книги по" +
                " автору,\n year - показать книги по году выпуска,\n exit - выход из приложения.\n\n");

                Console.Write("\n Введите команду: ");
                command = Console.ReadLine();
                switch (command)
                {
                    case "add":
                        //AddBook();
                        break;
                    case "del":
                        //DeleteBook();
                        break;
                    case "all":
                        //_storage.ShowAllBooks();
                        break;
                    case "name":
                        //ShowNameBooks();
                        break;
                    case "author":
                        //ShowAuthorBooks();
                        break;
                    case "year":
                        //ShowYearBooks();
                        break;
                    case "exit":
                        break;
                }

                Console.Write("\n Нажмите любую клавишу.");
                Console.ReadKey();
                Console.Clear();
            }

            Console.Write("\n Программа База данных игроков завершается.\n");
        }
    }

    class Shop
    {
        private readonly Shop _shop;
        private readonly Warehouse _warehouse;

        public Shop(Warehouse warehouse)
        {
            _warehouse = warehouse;
            _warehouse = new Warehouse();
            _shop = new Shop(_warehouse);
        }

        public void AddInfo()
        {
            Good iPhone12 = new Good("IPhone 12");
            Good iPhone11 = new Good("IPhone 11");
            Cart cart = _shop.AddCart();
            cart.Add(iPhone12, 4);
            cart.Add(iPhone11, 3);

            _warehouse.Delive(iPhone12, 10);
            _warehouse.Delive(iPhone11, 1);

            //Вывод всех товаров на складе с их остатком

            //Вывод всех товаров в корзине

            Console.WriteLine(cart.Order().Paylink);

            cart.Add(iPhone12, 9); //Ошибка, после заказа со склада убираются заказанные товары
        }

        private Cart AddCart()
        {
            return null;
        }
    }

    class Cart
    {
        private readonly Cart _name;
        private readonly int _number;

        public Cart(Cart name, int number)
        {
            _name = name;
            _number = number;
        }

        public void Add(Good good, int number)
        {
            
        }

        public string Order()
        {
            return null;
        }
    }

    class Warehouse
    {
        public void Delive(Good good, int number)
        {
            
        }
    }

    class Good
    {
        private readonly string _name;

        public Good(string name)
        {
            name = _name;
        }
    }
}