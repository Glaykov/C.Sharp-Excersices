using System;

namespace Inheritance
{
    public class Employee : Person
    {
        public decimal Salary { get;  private set; }

        public Employee(string name, uint age, bool isMale,decimal salary) : base(name,age,isMale) {
            this.Name = name;
            this.Age = age;
            this.IsMale = isMale;
            this.Salary = salary;
        }

        public void CalculateOvertime(double overtime) {
            double perHour = (double)(Salary / 20) / 8; //Парите, който получава за час ако приемем, че работните дни в месеца са 20.
            double overtimeMoney = overtime * (perHour * 1.5);
            if (overtime > 0)
            {
                Console.WriteLine($"Overtime money - {Math.Round(overtimeMoney,2)}$");
            }
            else
                Console.WriteLine("No overtime money.");
        }

        public void ShowEmployeeInfo(double overtime) {
            this.ShowPersonInfo();
            this.CalculateOvertime(overtime);
        }
    }
}
