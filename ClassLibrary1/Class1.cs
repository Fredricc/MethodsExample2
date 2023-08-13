public class Product
{
    //fields
    public int productID;
    public string productName;
    public double cost;
    public int quantityInStock;
    public static int TotalNoProduct;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;

    //constructor
    public Product()
    {
        dateOfPurchase = DateTime.Now.ToShortDateString();
    }
}