

using System;

namespace StudentDemo
{
   public class Student
    {
        public string Name;
        public string Subject;
        public double Grade;
        public uint YearsInCollege;
        public uint Age;
        bool HasDegree;
        public decimal Money;

        public Student() {
            Grade = 4.5;
            YearsInCollege = 1;
            HasDegree = false;
            Money = 0;
        }

        public Student(string name, string subject, uint age) : this() {
            Name = name;
            Subject = subject;
            Age = age;
        }

        public void UpYear() {
            if (HasDegree == true) {
                Console.WriteLine("This student has degree.");
                return;
            }
            YearsInCollege++;
            if (YearsInCollege == 4) {
                HasDegree = true;
            }

        }

        public decimal RecieveScholarship(double min, decimal amount) {
            if (Grade>=min && Age<30) {
                Money += amount; 
            }
            return Money;
        }
       

    }
}
