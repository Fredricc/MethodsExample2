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
            Product.TotalNoProduct++;
            product2 = new Product();
            Product.TotalNoProduct++;
            product3 = new Product();
            Product.TotalNoProduct++;

            //Initialize fields
            product1.productID = 1001;
            product1.productName = "Mobile";
            product1.cost = 20000;
            product1.quantityInStock = 1200;
            product2.productID = 1002;
            product2.productName = "Laptop";
            product2.cost = 45000;
            product2.quantityInStock = 3400;
            product3.productID = 1003;
            product3.productName = "Speeker";
            product3.cost = 36000;
            product3.quantityInStock = 1000;

            //Call methods
            product1.CalculateTax();
            product2.CalculateTax();
            product3 .CalculateTax();

            //get values from fields
            Console.WriteLine("Product1:");
            Console.WriteLine("ProductID: "+ product1.productID);
            Console.WriteLine("Product Name: " + product1.productName);
            Console.WriteLine("Cost: "+ product1.cost);
            Console.WriteLine("Quantity in Stock: "+ product1.quantityInStock);
            Console.WriteLine("Date of Purchase: "+ product1.dateOfPurchase);
            Console.WriteLine("Tax: " + product1.tax);
            Console.WriteLine();

            Console.WriteLine("Product2:");
            Console.WriteLine("ProductID: " + product2.productID);
            Console.WriteLine("Product Name: " + product2.productName);
            Console.WriteLine("Cost: " + product2.cost);
            Console.WriteLine("Quantity in Stock: " + product2.quantityInStock);
            Console.WriteLine("Date of Purchase: " + product2.dateOfPurchase);
            Console.WriteLine("Tax: " + product2.tax);
            Console.WriteLine();

            Console.WriteLine("Product3:");
            Console.WriteLine("ProductID: " + product3.productID);
            Console.WriteLine("Product Name: " + product3.productName);
            Console.WriteLine("Cost: " + product3.cost);
            Console.WriteLine("Quantity in Stock: " + product3.quantityInStock);
            Console.WriteLine("Date of Purchase: " + product3.dateOfPurchase);
            Console.WriteLine("Tax: " + product3.tax);
            Console.WriteLine();


            int totalQuantity = product1.quantityInStock + product2.quantityInStock + product3.quantityInStock;
            Console.WriteLine("TotalQuantity: " + totalQuantity);
            Console.WriteLine("Total no. of products: " + Product.TotalNoProduct);
            Console.WriteLine("Category of Products" + Product.CategoryName); //Output : Electronics

            //TO DO: Findout the highest cost of all three products.
            Console.ReadKey();

        }
    }
}