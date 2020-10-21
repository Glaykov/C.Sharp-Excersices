using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ComputerDemo

{
   public class Program
    {
        public static void Main(string[] args)
        {
            Computer HP = new Computer();
            HP.YearProduced = 2019;
            HP.Price = 650;
            HP.IsNotebook = true;
            HP.HardDiskMemory = 128;
            HP.FreeMemory = 59.8;
            HP.OperatingSystem = "Windows 10";

            Computer Asus = new Computer();
            Asus.YearProduced = 2016;
            Asus.Price = 500;
            Asus.IsNotebook = false;
            Asus.HardDiskMemory = 512;
            Asus.FreeMemory = 212.55;
            Asus.OperatingSystem = "Windows 7";

            Asus.UseMemory(100);

            HP.ChangeOperatingSystem("Linux");

            Asus.printInfo("Asus");
            HP.printInfo("HP");


            Computer Apple = new Computer(2019, 1200, true, 512, 480, "Mac");
            Computer Acer = new Computer(2020, 2000, true, 1000, 980, "Windows 10");
            Computer Huawei = new Computer(2019, 2000, true, 820, 750, "Windows 8");

            Apple.printInfo("Apple");
            Acer.printInfo("Acer");
            Huawei.printInfo("Huawei");





            int compare = Acer.ComparePrice(HP);
            HP.CompareInfo(compare,"Acer","HP");

            compare = Huawei.ComparePrice(Acer);
            Huawei.CompareInfo(compare,"Huawei","Acer");

            



           


            



           



            Console.ReadKey();
        }
    }
}


