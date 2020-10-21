using System;

namespace ComputerDemo

{
    public class Computer
    {
        public int YearProduced;

        public decimal Price;

        public bool IsNotebook;

        public double HardDiskMemory;

        public double FreeMemory;

        public string OperatingSystem;

        public Computer() {
            this.IsNotebook = false;
            this.OperatingSystem = "Windows 8.1";
        }

        public Computer(int year, decimal price, double hardDiskMemory, double freeMemory):this(){

            this.YearProduced = year;
            this.Price = price;
            this.HardDiskMemory = hardDiskMemory;
            this.FreeMemory = freeMemory;
        }

        public Computer(int year, decimal price, bool isNotebook, double hardDiskMemory, double freeMemory, string operatingSystem) {
            this.YearProduced = year;
            this.Price = price;
            this.IsNotebook = isNotebook;
            this.HardDiskMemory = hardDiskMemory;
            this.FreeMemory = freeMemory;
            this.OperatingSystem = operatingSystem;
            }

        public int ComparePrice(Computer c) {
            if (this.Price > c.Price)
            {
                return 1;
            }
            else if (c.Price > this.Price)
            {
                return 2;
            }
            else 
                return 0;
        }

        public void CompareInfo(int compareNum,string firstPc,string secondPc) {
            

            if (compareNum == 1)
            {
                Console.WriteLine($"{firstPc} is more expensive than {secondPc}.");
                
            }
            else if (compareNum == 2)
            {
                Console.WriteLine($"{secondPc} is more expensive than {firstPc}.");
                
            }
            else
                Console.WriteLine("These two computers have the same price.");
            
        }
        
        public void ChangeOperatingSystem(string newOperatingSystem) {
            OperatingSystem = newOperatingSystem;
        }

        public void UseMemory(double memory) {
            if (memory > this.FreeMemory) {
                Console.WriteLine("Not enough free memory.");
            }else
                this.FreeMemory = FreeMemory - memory;
        }

        public void printInfo(string pcName) {

            Console.WriteLine($"{pcName} parameteres : \n\nProduced - {this.YearProduced} \nPrice - {this.Price}$ \nNotebook - {this.IsNotebook} " +
                    $"\nHard Disk - {this.HardDiskMemory}GB \nFree Memory - {this.FreeMemory}GB \nOperating System - {this.OperatingSystem}");

            Console.WriteLine("\n____________________________\n");
        }


    }
}
