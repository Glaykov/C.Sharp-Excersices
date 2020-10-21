using System;

namespace Inheritance
{
    public class Student : Person
    {
        public double Score { get; private set; }

        public Student(string name,uint age,bool isMale,double score) : base(name,age,isMale) {
            this.Name = name;
            this.Age = age;
            this.IsMale = IsMale;
            this.Score = score;
        }

        public void ShowStudentInfo() {
            this.ShowPersonInfo();
            Console.WriteLine($"Score - {Math.Round(Score,2)}");
        }
    }
}
