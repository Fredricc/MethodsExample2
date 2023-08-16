using ClassLibrary1;

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
            Employee emp1, emp2, emp3;

            //create objects
            product1 = new Product();
            Product.SetTotalNoProduct(Product.GetTotalNoProduct()+1);
            product2 = new Product();
            Product.SetTotalNoProduct(Product.GetTotalNoProduct() + 1);
            product3 = new Product();
            Product.SetTotalNoProduct(Product.GetTotalNoProduct() + 1);

            emp1 = new Employee(101, "Fred", "Developer");
            emp1.Tax = 50;
            emp1.NativePlace = "Kiambu";
            emp2 = new Employee(102, "Faith", "CEO");
            emp2.Tax = 50;
            emp2.NativePlace = "Nairobi";
            emp3 = new Employee(103, "Hellen", "Marketing Manager");
            emp3.Tax = 50;
            emp3.NativePlace = "Kiambu";

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
            product3.SetProductName("Speaker");
            product3.SetCost(36000);
            product3.SetQuantityInStock(1000);

            //Call methods
            double q = 7.4;
            product1.CalculateTax(percentage : in q);
            Console.WriteLine("q is " + q);


            //ref
            double p = 5.6;
            product2.CalculateTax(in p);
            Console.WriteLine("p is " + p);
            product3 .CalculateTax(10000, 3.4);

            //get values from fields
            Console.WriteLine("\n\t::: " + Employee.companyName + " :::");
            Console.WriteLine("\nFirst Employee");
            Console.WriteLine( emp1.EmpID );
            Console.WriteLine(emp1.EmpName);
            Console.WriteLine(emp1.Job );
            Console.WriteLine("Gross Salary: "+ emp1.Salary );
            Console.WriteLine("Net Salary: " + emp1.CalculateNetSalary() );
            Console.WriteLine("Native Place: " + emp1.NativePlace );
            Console.WriteLine();

            Console.WriteLine("Second Employee");
            Console.WriteLine(emp2.EmpID);
            Console.WriteLine(emp2.EmpName);
            Console.WriteLine(emp2.Job);
            Console.WriteLine("Gross Salary: " + emp2.Salary);
            Console.WriteLine("Net Salary: " + emp2.CalculateNetSalary());
            Console.WriteLine("Native Place: " + emp2.NativePlace);

            Console.WriteLine();

            Console.WriteLine("Third Employee");
            Console.WriteLine(emp3.EmpID);
            Console.WriteLine(emp3.EmpName);
            Console.WriteLine(emp3.Job);
            Console.WriteLine("Gross Salary: "+ emp3.Salary);
            Console.WriteLine("Net Salary: " + emp3.CalculateNetSalary());
            Console.WriteLine("Native Place: " + emp3.NativePlace);
            Console.WriteLine();


            //Console.WriteLine("Product1:");
            //Console.WriteLine("ProductID: "+ product1.GetProductID());
            //Console.WriteLine("Product Name: " + product1.GetProductName());
            //Console.WriteLine("Cost: "+ product1.GetCost());
            //Console.WriteLine("Quantity in Stock: "+ product1.GetQuantityInStock());
            //Console.WriteLine("Date of Purchase: "+ product1.GetDateOfPurchase());
            //Console.WriteLine("Tax: " + product1.GetTax());
            //Console.WriteLine();

            //Console.WriteLine("Product2:");
            //Console.WriteLine("ProductID: " + product2.GetProductID());
            //Console.WriteLine("Product Name: " + product2.GetProductName());
            //Console.WriteLine("Cost: " + product2.GetCost());
            //Console.WriteLine("Quantity in Stock: " + product2.GetQuantityInStock());
            //Console.WriteLine("Date of Purchase: " + product2.GetDateOfPurchase());
            //Console.WriteLine("Tax: " + product2.GetTax());
            //Console.WriteLine();

            //Console.WriteLine("Product3:");
            //Console.WriteLine("ProductID: " + product3.GetProductID());
            //Console.WriteLine("Product Name: " + product3.GetProductName());
            //Console.WriteLine("Cost: " + product3.GetCost());
            //Console.WriteLine("Quantity in Stock: " + product3.GetQuantityInStock());
            //Console.WriteLine("Date of Purchase: " + product3.GetDateOfPurchase());
            //Console.WriteLine("Tax: " + product3.GetTax());
            //Console.WriteLine();

            ////total quantity
            //int totalQuantity = Product.GetTotalQuantity(product1, product2, product3);

            ////display totals
            //Console.WriteLine("TotalQuantity: " + totalQuantity);
            //Console.WriteLine("Total no. of products: " + Product.GetTotalNoProduct());
            //Console.WriteLine("Category of Products" + Product.CategoryName); //Output : Electronics

            //TO DO: Find out the highest cost of all three products.
            Console.ReadKey();

        }
    }
}