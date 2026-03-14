using System;
namespace _230_6_1
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

        public virtual string earnings()
        {
            return "0";
        }


    }
    public class SalaryWorker : Employee
    {
        // salary data
        public float salary;
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
        public new string displayEmployeeData()
        {
            return base.displayEmployeeData() + " " + salary.ToString();
        }
        // earnings


        public override string earnings() {
        
            return String.Format("Salary Worker       {0,-5}{1,-12}{2,-12}{3,-10}", this.id_num.ToString(), this.first_name, this.last_name, (Math.Round((this.salary / 52), 2)).ToString());
            //return (this.id_num).ToString() + this.last_name + this.first_name + (Math.Round((this.salary / 52), 2));
        }

    }

    public class HourlyWorker : Employee
    {
        // salary data
        private float payrate;
        private float hours_worked;
        // default
        public HourlyWorker() : base()
        {
            this.payrate = 0;
            this.hours_worked = 0;
        }
        // set all
        public HourlyWorker(int id_num, string first_name, string last_name, float payrate, float hours_worked) :
        base(id_num, first_name, last_name)
        {
            this.payrate = payrate;
            this.hours_worked = hours_worked;
        }
        // set data
        public void setHourlyWorker(int Id_num = 0, string First_name = "No Label", string Last_name = "No Label",
            float Hours_worked = 0, float Payrate = 0)
        {
            this.id_num = Id_num;
            this.first_name = First_name;
            this.last_name = Last_name;
            this.hours_worked = Hours_worked;
            this.payrate = Payrate;
        }
        // set hours worked
        public float getHoursWorked()
        {
            return this.hours_worked;
        }
        // get hours worked
        public void setHoursWorked(float hours_worked)
        {
            this.hours_worked = hours_worked;
        }
        public float getPayrate()
        {
            return this.payrate;
        }
        public void setPayrate(float payrate)
        {
            this.payrate = payrate;
        }
        // display data
        public string displayEmployeeData()
        {
            return base.displayEmployeeData() + " " + payrate.ToString() + " " + hours_worked.ToString();
        }
        // earnings

        public override string earnings()
        {
            float weeklypay;
            if (this.hours_worked > 40)
            {
                weeklypay = ((float)(40 * payrate + (hours_worked - 40) * 1.5 * payrate));
            }
            else
            {
                weeklypay = (float)(hours_worked * payrate);
            }
            return String.Format("Hourly Worker       {0,-5}{1,-12}{2,-12}{3,-10}", this.id_num.ToString(), this.first_name, this.last_name, Math.Round(weeklypay, 2).ToString());
        }
    }


    public class CommissionWorker : Employee
    {
        // salary data
        public float salary;
        public float comm_rate;
        public float sales;
        // default
        public CommissionWorker() : base()
        {
            this.salary = 0;
            this.comm_rate = 0;
            this.sales = 0;
        }
        // set all
        public CommissionWorker(int id_num, string first_name, string last_name, float salary, float comm_rate, float sales) :
            base(id_num, first_name, last_name)
        {
            this.salary = salary;
            this.comm_rate = comm_rate;
            this.sales = sales;
        }
        // set data
        public void setCommissionWorker(int Id_num = 0, string First_name = "No Label", string Last_name = "No Label",
            float Salary = 0, float Comm_rate = 0, float Sales = 0)
        {
            this.id_num = Id_num;
            this.first_name = First_name;
            this.last_name = Last_name;
            this.salary = Salary;
            this.comm_rate = Comm_rate;
            this.sales = Sales;
        }
        // set hours worked
        public float getSalary()
        {
            return this.salary;
        }
        // get hours worked
        public void setSalary(float hours_worked)
        {
            this.salary = hours_worked;
        }

        public float getCommRate()
        {
            return this.comm_rate;
        }
        public void setCommRate(float comm_rate)
        {
            this.comm_rate = comm_rate;
        }

        public float getSales()
        {
            return this.sales;
        }
        public void setSales(float sales)
        {
            this.sales = sales;
        }

        // display data
        public string displayEmployeeData()
        {
            return base.displayEmployeeData() + " " + this.salary.ToString() + " " + this.comm_rate.ToString() + this.sales.ToString();
        }

        public override string earnings()
        {
            float weeklypay = (float)(this.sales * this.comm_rate + salary / 52);
            return String.Format("Commission Worker   {0,-5}{1,-12}{2,-12}{3,-10}", this.id_num.ToString(), this.first_name, this.last_name, Math.Round(weeklypay, 2).ToString());
        }


    }


    public class PieceWorker : Employee
    {
        // salary data
        public float wageperpiece;
        public float quantity;
        // default
        public PieceWorker() : base()
        {
            this.wageperpiece = 0;
            this.quantity = 0;
        }
        // set all
        public PieceWorker(int id_num, string first_name, string last_name, float wageperpiece, float quantity) :
            base(id_num, first_name, last_name)
        {
            this.wageperpiece = wageperpiece;
            this.quantity = quantity;
        }
        // set data
        public void setCommissionWorker(int Id_num = 0, string First_name = "No Label", string Last_name = "No Label",
            float Wageperpiece = 0, float Quantity = 0)
        {
            this.id_num = Id_num;
            this.first_name = First_name;
            this.last_name = Last_name;
            this.wageperpiece = Wageperpiece;
            this.quantity = Quantity;
        }
        // set hours worked
        public float getWagePerPiece()
        {
            return this.wageperpiece;
        }
        // get hours worked
        public void SetWagePerPiece(float wageperpiece)
        {
            this.wageperpiece = wageperpiece;
        }

        public float getQuantity()
        {
            return this.quantity;
        }
        public void setQuantityfloat(float quantity)
        {
            this.quantity = quantity;
        }

        // display data
        public string displayEmployeeData()
        {
            return base.displayEmployeeData() + " " + this.wageperpiece.ToString() + " " + this.quantity.ToString();
        }

        public override string earnings()
        {
            float weeklypay = (float)(this.wageperpiece * this.quantity);
            return String.Format("Piece Worker        {0,-5}{1,-12}{2,-12}{3,-10}", this.id_num.ToString(), this.first_name, this.last_name, Math.Round(weeklypay, 2).ToString());
        }

    }
}
