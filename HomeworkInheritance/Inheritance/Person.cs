using System;

namespace Inheritance
{
    public class Person
    {
        protected string Name { get;  set; }
        protected uint Age { get; set; }
        protected bool IsMale { get;  set; }

        public Person(string name,uint age,bool isMale) {
            Name = name;
            Age = age;
            IsMale = isMale;
        }

        public void ShowPersonInfo() {
            string Gender;
            if (IsMale == true) {
                Gender = "Male";
            }
            else {
                Gender = "Female";
            }
            Console.WriteLine($"Name - {Name}\nAge - {Age}\nGender - {Gender}");
        }
    
    }
}
