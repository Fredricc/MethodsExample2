namespace ClassLibrary1
{
    public class Employee
    {
        //fields
        private int _empID;
        private string _empName;
        private string _job;
        private double _salary = 10000;
        private double _tax;

        private static string _companyName;

        //property
        public int EmpID
        {
            set {
                if (value > 100)
                {
                    _empID = value;
                }
            }
            get { return _empID; }
        }

        public string EmpName
        {
            set { _empName = value; }
            get { return _empName; }
        }

        public string Job
        {
            set { _job = value; }
            get { return _job; }
        }

        //read only property
        public double Salary
        {
            get
            {
                return _salary;
            }
        }

        //write only property
        public double Tax
        {
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _tax = value;
                }
            }
        }

        //Static property
        public static string CompanyName
        {
            set
            {
                if (value.Length <= 20)
                {
                    _companyName = value;
                }
            }
            get { return _companyName; }
        }

        //static field
        public static string companyName;

        //constructor
        public Employee(int empID, string empName, string job)
        {
            this._empID = empID;
            this._empName = empName;
            this._job = job;
        }

        //static constructor
        static Employee()
        {
            companyName = "Pundit Zone Ltd";
        }

        //Method
        public double CalculateNetSalary()
        {
            double t;
            t = _salary - _tax;
            return t;
        }

        //Automatic Property
        public string NativePlace{ get; set; }
    }
}
