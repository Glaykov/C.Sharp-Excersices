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
            Student Lilia = new Student("Lilia", "Economy", 21);
            Student Todor = new Student("Todor", "Computer Science", 20);
            Student Veselin = new Student("Veselin", "Music", 19);
            Student Ivo = new Student("Ivo", "Economy", 20);
            Student Bilyana = new Student("Bilyana", "Economy", 20);

            Lilia.RecieveScholarship(4.5, 200);
            Ivan.UpYear();
            Lilia.Grade = 5.5;
            Ivo.Grade = 4.9;
            Ivan.Grade = 4;
            Bilyana.Grade = 5;

            StudentGroup newGroup = new StudentGroup("Economy");

            newGroup.AddStudent(Ivo);
            newGroup.AddStudent(Bilyana);
            newGroup.AddStudent(Ivan);
            newGroup.AddStudent(Lilia);

            newGroup.PrintStudentsInGroup();
            Console.WriteLine(Lilia.Grade);
            newGroup.BestStudentInGroup(); 

            
            Console.ReadKey();
        }
    }
}
