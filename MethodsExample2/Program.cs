namespace MethodsExample2
{
    internal class Sample
    {
        static void Main(string[] args)
        {
            //local Constant
            const string developerName = "Fredrick";

            //create reference variable
            Product product1, product2, product3;

            //create objects
            product1 = new Product();
            Product.SetTotalNoProduct(Product.GetTotalNoProduct()+1);
            product2 = new Product();
            Product.SetTotalNoProduct(Product.GetTotalNoProduct() + 1);
            product3 = new Product();
            Product.SetTotalNoProduct(Product.GetTotalNoProduct() + 1);

            //Initialize fields
            product1.SetProductID(1001);
            product1.SetProductName("Mobile");
            product1.SetCost(20000);
            product1.SetQuantityInStock(1200);
            product2.SetProductID(1002);
            product2.SetProductName("Laptop");
            product2.SetCost(45000);
            product2.SetQuantityInStock(3400);
            product3.SetProductID(1003);
            product3.SetProductName("Speeker");
            product3.SetCost(36000);
            product3.SetQuantityInStock(1000);

            //Call methods
            product1.CalculateTax();
            product2.CalculateTax();
            product3 .CalculateTax();

            //get values from fields
            Console.WriteLine("Product1:");
            Console.WriteLine("ProductID: "+ product1.GetProductID());
            Console.WriteLine("Product Name: " + product1.GetProductName());
            Console.WriteLine("Cost: "+ product1.GetCost());
            Console.WriteLine("Quantity in Stock: "+ product1.GetQuantityInStock());
            Console.WriteLine("Date of Purchase: "+ product1.GetDateOfPurchase());
            Console.WriteLine("Tax: " + product1.GetTax());
            Console.WriteLine();

            Console.WriteLine("Product2:");
            Console.WriteLine("ProductID: " + product2.GetProductID());
            Console.WriteLine("Product Name: " + product2.GetProductName());
            Console.WriteLine("Cost: " + product2.GetCost());
            Console.WriteLine("Quantity in Stock: " + product2.GetQuantityInStock());
            Console.WriteLine("Date of Purchase: " + product2.GetDateOfPurchase());
            Console.WriteLine("Tax: " + product2.GetTax());
            Console.WriteLine();

            Console.WriteLine("Product3:");
            Console.WriteLine("ProductID: " + product3.GetProductID());
            Console.WriteLine("Product Name: " + product3.GetProductName());
            Console.WriteLine("Cost: " + product3.GetCost());
            Console.WriteLine("Quantity in Stock: " + product3.GetQuantityInStock());
            Console.WriteLine("Date of Purchase: " + product3.GetDateOfPurchase());
            Console.WriteLine("Tax: " + product3.GetTax());
            Console.WriteLine();

            //total quantity
            int totalQuantity = Product.GetTotalQuantity(product1, product2, product3);

            //display totals
            Console.WriteLine("TotalQuantity: " + totalQuantity);
            Console.WriteLine("Total no. of products: " + Product.GetTotalNoProduct());
            Console.WriteLine("Category of Products" + Product.CategoryName); //Output : Electronics

            //TO DO: Find out the highest cost of all three products.
            Console.ReadKey();

        }
    }
}