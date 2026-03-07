namespace _230_6_1
{


    internal class Program
    {

        public class Employee
        {

            // Base class Employee with id num, first name, last name
            // as well as a default constructor, set-all constructor, get and set methods for each data member
            public int id_num;
            public string first_name;
            public string last_name;

            public Employee()
            {
                this.id_num = 0;
                this.first_name = "No Label";
                this.last_name = "No Label";

            }

            public Employee(int id_num, string first_name, string last_name)
            {
                this.id_num = id_num;
                this.first_name = first_name;
                this.last_name = last_name;

            }

            public int getEmployeeIdNum()
            {
                return this.id_num;
            }

            public string getEmployeeFirstName()
            {
                return this.first_name;
            }

            public string getEmployeeLastName()
            {
                return this.last_name;
            }

            public void setEmployeeIdNum(int id_num)
            {
                this.id_num = id_num;
            }

            public void setEmployeeFirstName(string first_name)
            {
                this.first_name = first_name;
            }

            public void setEmployeeLastName(string last_name)
            {
                this.last_name = last_name;
            }

            // set data method for Employee
            public void setData(int id_num = 0, string first_name = "No Label", string last_name = "No Label")
            {
                this.id_num = id_num;
                this.first_name = first_name;
                this.last_name = last_name;
            }
            // display data method for Employee

            public string displayEmployeeData()
            {
                return id_num.ToString() + " " + first_name + " " + last_name;
            }

            // earnings for Employee
        }

        public class SalaryWorker : Employee
        {
            // salary data
            private float salary;   
            // default
            public SalaryWorker() : base()
            {
                this.salary = 0;
            }
            // set all

            public SalaryWorker(int id_num, string first_name, string last_name, float salary) : 
                base(id_num, first_name, last_name)
            {
                this.salary = salary;
            }
            // set data
            public void setSalaryworker(int Id_num = 0, string First_name = "No Label", string Last_name = "No Label",
                float Salary = 0)
            {
                this.id_num = Id_num;
                this.first_name = First_name;
                this.last_name = Last_name;
                this.salary = Salary;
            }
            // set salary
            public float getSalary()
            {
                return this.salary;
            }
            // get salary
            public void setSalary(float salary)
            {
                this.salary = salary;
            }
            // display data
            public override string displayEmployeeData()
            {
                return base.displayEmployeeData() + " " + salary.ToString();
            }
            // earnings
            


        }








        // SalaryWorker Subclass which inherits + salary






        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
