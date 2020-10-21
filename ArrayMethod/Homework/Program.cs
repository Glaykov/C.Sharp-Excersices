using System;

namespace Homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrMeth Array = new ArrMeth();
            int[] array1 = new int[Array.ArrSize()];
            int[] array2 = new int[Array.ArrSize()];
            Array.AssignValues(array1, array2);
            int[] arrray = Array.DivideArraysElements(array1, array2);

            try
            {
                Array.CheckForException(arrray);
                
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("It's impossible to delete by 0 ...");
                Array.Print(arrray);
            }
            Array.Print(arrray);


            Console.ReadKey();
        }
    }
}
