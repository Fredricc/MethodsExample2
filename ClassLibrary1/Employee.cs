namespace ClassLibrary1
{
    public class Employee
    {
        //fields
        public int empID;
        public string empName;
        public string job;

        //static field
        public static string companyName;

        //constructor
        public Employee(int empID, string empName, string job)
        {
            this.empID = empID;
            this.empName = empName;
            this.job = job;
        }

        //static constructor
        static Employee()
        {
            companyName = "Pundit Zone Ltd";
        }
    }
}
