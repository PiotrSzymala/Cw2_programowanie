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

            if (productName == "stop")
                break;


            Console.WriteLine("Give quantity: ");
            productQuantity = int.Parse(Console.ReadLine());

            orderDictionary.Add(productName, productQuantity);

            Console.WriteLine();

        } while (true);

        Order result = new Order(client, orderDictionary);


        Console.WriteLine("Order accepted!");
        Console.WriteLine();

        OrderDisplayer.Display(result);
    }
}