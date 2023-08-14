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
        if (cost <= 20000)
        {
            t = cost * 10 / 100;
        }
        else
        {
            t = cost * 12.5 / 100;
        }
        tax = t;
    }

    public void SetProductID(int value) { productID = value; }
    public int GetProductID() { return productID; }
    public void SetProductName(string value) { productName = value; }
    public string GetProductName() { return productName; }
    public void SetCost(double value) { cost = value; }
    public double GetCost() { return cost; }
    public void SetTax(double value) { tax = value; }
    public double GetTax() { return tax; }
    public void SetQuantityInStock(int value) { quantityInStock = value; }
    public int GetQuantityInStock() { return quantityInStock; }
    public string GetDateOfPurchase() { return dateOfPurchase; }
}
