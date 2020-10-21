using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSecureDeviceDemo
{
    public class Program
    {
        public static void Main(string[] args) { 

            Console.WriteLine("Creating Electronic Secured Notepad...");

            Console.WriteLine("Enter name for Secured Notepad: ");
                string electronicSecuredNotepadName = Console.ReadLine();

            Console.WriteLine("Enter pages count for Electronic Secured Notepad: ");
                int electronicSecuredNotepadPagesCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter password for Secured Notepad: ");
                string electronicSecuredNotepadPassword = Console.ReadLine();

            ElectronicSecureNotepad electronicSecureNotepad = new ElectronicSecureNotepad(electronicSecuredNotepadName, electronicSecuredNotepadPagesCount, electronicSecuredNotepadPassword);

            electronicSecureNotepad.AddTxtToPage("7453", "Some text added to this page", 1);

            Console.ReadKey();
        }
    }
}
