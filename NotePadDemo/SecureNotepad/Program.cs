using System;
using NotePad;

namespace Secure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SecureNotepad SecureNotePad1 = new SecureNotepad("SecureNote", 4, "0101");
            SecureNotePad1.AddTxtToPage("0101", "This is First Page of SecureNotePad.", 1);
            SecureNotePad1.SecurePages[0].Title = "First SecurePage TItle.";
            SecureNotePad1.AddTxtToPage("0101", "Adding text to first secure page", 1);
            SecureNotePad1.PreviewPage("0101", 1);

            SecureNotePad1.AddTxtToPage("0101", "Info in these pages is secure, every action requires password....", 2);
            SecureNotePad1.SecurePages[1].Title = "Antartic Expedition";
            SecureNotePad1.PreviewPage("0101", 2);
            SecureNotePad1.ReplaceTxtFromPage("0101", "Changing content of page 2 .", 2);

            try
            {
                SecureNotePad1.SecurePages[0].Title = "First Page TItle Changed.";
                SecureNotePad1.AddTxtToPage("0101", "Adding text to second page", 2);
                SecureNotePad1.PreviewPage("0101", 2);
                SecureNotePad1.PreviewPage("1212", 2);
            }
            catch (NotepadExceptions ex)
            {
                Console.WriteLine(ex.Message);
                try
                {
                    SecureNotePad1.SecurePages[0].AddTxt("This is First Page of SecureNotePad.");
                }
                catch (NotepadExceptions ex1)
                {
                    Console.WriteLine(ex1.Message);
                    try
                    {
                        SecureNotePad1.SecurePages[1].DeleteTxt("asdas");
                    }
                    catch (NotepadExceptions ex2)
                    {
                        Console.WriteLine(ex2.Message);
                        try
                        {
                            SecureNotePad1.SecurePages[2].Preview();
                        }
                        catch (Exception ex3)
                        {
                            Console.WriteLine(ex3.Message);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}