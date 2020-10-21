
using System;

namespace StudentDemo
{
    public class StudentGroup
    {
        public string GroupSubject;
        int FreePlaces;
        Student[] students;


        public StudentGroup()
        {
            this.students = new Student[5];
            this.FreePlaces = 5;
        }

        public StudentGroup(string subject) : this()
        {
            this.GroupSubject = subject;
        }

        public void AddStudent(Student s)
        {

            if (s.Subject == GroupSubject)
            {
                for (int i = 0; i < this.students.Length; i++)

                {
                    if (this.students[i] == null)
                    {
                        this.students[i] = s;
                        FreePlaces--;
                        break;
                    }
                }

            }
            else
                return;
        }

        public void EmptyGroup()
        {
            students = new Student[5];
            FreePlaces = 5;
        }

        public void PrintStudentsInGroup()
        {
            Console.WriteLine($"Students in {GroupSubject} group are : ");
            foreach (Student i in students)
            {
                if (i != null)
                {

                    Console.Write($"{i.Name}, {i.Age}-years old, {i.YearsInCollege} -year in colleage with {i.Grade}. \n");
                }
                else
                    return;
            }
        }

        public void BestStudentInGroup() {
            int index = 0;
            double best = students[0].Grade;

            for (int i = 1; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    double current = this.students[i].Grade;
                    if (current > best)
                    {
                        index = i;
                    }
                }
            }
                

            Console.WriteLine($"Best student in group is : {students[index].Name} with {students[index].Grade} grade.");
            
          

        }


    }

   
}
            
            
        

    

