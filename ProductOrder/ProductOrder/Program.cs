internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Order
{
    private string orderNumber;
    private DateTime orderDate;
    private string[] productsOrdered;
    private int itemsAmount;
    private OrderStatus status;

    Order(int amount, DateTime date)
    {
        itemsAmount = amount;
        orderDate = date;
        orderNumber = string.Empty;
        productsOrdered = Array.Empty<string>();
        OrderStatus = OrderStatus.False;
    }
}

class OrderStatus
{
    private bool hasShipped;

    public bool False()
    {
        return false;
    }
}

class Product
{
    private string productID;
    private double productPrice;

    Product(string itemID, double itemPrice)
    {
        productID = itemID;
        productPrice = itemPrice;
    }
}