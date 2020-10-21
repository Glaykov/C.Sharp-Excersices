using System;
using System.ComponentModel;

namespace StudentDemo
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Student Ivan = new Student("Ivan", "Economy", 20);
            Student Petar = new Student("Petar", "Electronics", 19);
            Student Lilia = new Student("Lilia", "Industial Managment", 21);
            Student Todor = new Student("Todor", "Computer Science", 20);
            Student Veselin = new Student("Veselin", "Music", 19);
            Student Ivo = new Student("Ivo", "Economy", 20);
            Student Bilyana = new Student("Bilyana", "Economy", 20);


            StudentGroup newGroup = new StudentGroup();


            Lilia.RecieveScholarship(4.5, 200);

            newGroup.AddStudent(Ivo);
            newGroup.AddStudent(Bilyana);
            newGroup.AddStudent(Ivan);

            Ivan.UpYear();


            newGroup.



            Console.ReadKey();
        }
    }
}
