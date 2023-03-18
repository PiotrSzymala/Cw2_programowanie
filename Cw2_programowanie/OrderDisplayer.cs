namespace Cw2_programowanie;

public static class OrderDisplayer
{
    public static void Display(Order order)
    {
        Console.WriteLine($"{order.PersonWhoOrdered}'s order: ");

        foreach (KeyValuePair<string,int> product in order.OrderedProducts)
        {
            Console.WriteLine($"Product: {product.Key}, quantity: {product.Value}");
        }
    }
}