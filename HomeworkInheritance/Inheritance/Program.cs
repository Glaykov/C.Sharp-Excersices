using System;

namespace Inheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person Ivan = new Person("Ivan", 24, true);
            Student Gabriela = new Student("Gabriela", 18, false, 4.10);
            Employee Stefan = new Employee("Stefan", 35, true, 1200.23m);

            Ivan.ShowPersonInfo();
            Console.WriteLine("..............");
            Gabriela.ShowStudentInfo();
            Console.WriteLine("..............");
            Stefan.ShowEmployeeInfo(2);

            Console.ReadKey();
        }
    }
}
