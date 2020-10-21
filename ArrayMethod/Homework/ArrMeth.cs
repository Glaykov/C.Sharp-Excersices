using System;


namespace Homework
{
    public class ArrMeth
    {
       public int ArrSize()
        {
               Console.WriteLine("Enter array size:");
               int size = int.Parse(Console.ReadLine());
               return size;
        }

        public void AssignValues(int[] arr1, int[] arr2)
        {
            
                for (int i = 0; i < arr1.Length; i++)
                {
                    Console.WriteLine($"Enter values for element {i} in arr1:");
                    arr1[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.WriteLine($"Enter values for element {i} in arr2:");
                    arr2[i] = int.Parse(Console.ReadLine());
                }
        }
        

        public int[] DivideArraysElements(int[] a, int[] b)
        {
            int[] c;

            if (a.Length > b.Length)
            {
                c = new int[a.Length];
            }
            else
            {
                c = new int[b.Length];
            }

            if (a.Length > b.Length)
            {
                for (int i= 0; i < b.Length; i++){
                    if (b[i] != 0) {
                        c[i] = a[i] / b[i];
                    } else {
                        c[i] = 0;
                    }
                }
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (b[i] != 0)
                    {
                        c[i] = a[i] / b[i];
                    }
                    else
                    {
                        c[i] = 0;
                    }
                }

            }

            if (a.Length > b.Length)
            {
                for (int i = b.Length; i < c.Length; i++)
                {
                        c[i] = -1;
                }
            }
            else {
                for (int i = a.Length; i < c.Length; i++)
                {
                        c[i] = -1;
                }
            }
            return c;
        }

        public void CheckForException(int[] a) {
            for (int i = 0; i < a.Length; i++) {
                if (a[i] == 0) {
                    throw new DivideByZeroException("Trying to divide by zero .");
                }
            }
        }

        public void Print(int[] arr)
        {
            foreach (int a in arr)
            {
                Console.Write($"{a}  ");
            }
        }


    }
}
