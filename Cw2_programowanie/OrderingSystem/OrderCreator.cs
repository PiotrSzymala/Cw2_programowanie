namespace Cw2_programowanie.OrderingSystem;

public static class OrderCreator
{
    public static void CreateOrder()
    {
        Console.WriteLine("Give client's name:");
        string name = Console.ReadLine();

        Console.WriteLine("Give client's surname:");
        string surname = Console.ReadLine();

        Client client = new Client(name, surname);

        string productName;
        int productQuantity;

        Dictionary<string, int> orderDictionary = new Dictionary<string, int>();

        Console.WriteLine();
        do
        {
            Console.WriteLine("Give product's name or type \"stop\" to end: ");
            productName = Console.ReadLine();

            if (productName.ToLower() == "stop")
                break;


            Console.WriteLine("Give quantity: ");
            if (!int.TryParse(Console.ReadLine(), out int res))
            {
                do
                {
                    Console.WriteLine("Wrong input! Insert number please: ");

                } while (!int.TryParse(Console.ReadLine(), out res));
            }

            productQuantity = res;
            orderDictionary.Add(productName, productQuantity);
            Console.WriteLine();

        } while (true);

        Order result = new Order(client, orderDictionary);


        Console.WriteLine("Order accepted!");
        Console.WriteLine();

        OrderDisplayer.Display(result);
    }
}