namespace Cw2_programowanie;

public class Order
{
    public Client PersonWhoOrdered { get; set; }
    public List<Dictionary<string, int>> OrderedProducts { get; set; }


    public Order(Client personWhoOrdered, List<Dictionary<string,int>> orderedProducts)
    {
        PersonWhoOrdered = personWhoOrdered;
        OrderedProducts = orderedProducts;
    }
}