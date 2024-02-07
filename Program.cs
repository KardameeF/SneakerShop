using SneakerShop;

class Program
{
    static void Main(string[] args)
    {
        IShoeRepository shoeRepository = new ShoeRepository();
        ShoeService shoeService = new ShoeService(shoeRepository);

        bool running = true;
        while (running)
        {
            Console.WriteLine("Welcome to SneakerShop! Choose an option:");
            Console.WriteLine("1: Add Shoe");
            Console.WriteLine("2: Display All Shoes");
            Console.WriteLine("3: Delete Shoe");
            Console.WriteLine("4: Exit");

            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    // Логика за добавяне на обувка
                    break;
                case "2":
                    foreach (var shoe in shoeService.GetAllShoes())
                    {
                        Console.WriteLine($"Model: {shoe.Model}, Size: {shoe.Size}, Price: {shoe.Price}, Color: {shoe.Color}");
                    }
                    break;
                case "3":
                    // Логика за изтриване на обувка
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}
