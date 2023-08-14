public class Product
{
    //fields
    public int productID;
    public string productName;
    public double cost;
    public double tax;
    public int quantityInStock;
    public static int TotalNoProduct;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;

    //constructor
    public Product()
    {
        dateOfPurchase = DateTime.Now.ToShortDateString();
    }

    /*Method for calculating tax
     * cost <=  20000 then tax  = 10%
     cost > 20000 then tax is 12.5%*/
    public void CalculateTax()
    {
        // create local variable
        double t;

        //calculate tax
        if(cost <= 20000)
        {
            t = cost * 10 / 100;
        }
        else
        {
            t = cost * 12.5 / 100;
        }
        tax = t;
    }

}