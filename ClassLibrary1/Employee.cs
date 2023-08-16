namespace ClassLibrary1
{
    public class Employee
    {
        //fields
        private int _empID;
        private string _empName;
        private string _job;

        private static string _companyName;

        //property
        public int EmpID
        {
            set { _empID = value; }
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
    }
}
