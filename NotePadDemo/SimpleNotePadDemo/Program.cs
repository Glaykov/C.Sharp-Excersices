using System;

namespace NotePad
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SimpleNotePad NotePadDemo = new SimpleNotePad("FirstNotePadDemo", 10);
            NotePadDemo.Pages[0].AddTxt("This is First Page of SimpleNotePad.");
            NotePadDemo.Pages[0].Title = "First Page TItle.";
            NotePadDemo.AddTxtToPage("Adding text to first page", 1);
            NotePadDemo.PreviewPage(1);

            NotePadDemo.AddTxtToPage("The Australasian Antarctic Expedition (1911–1914), headed by Douglas Mawson...", 2);
            NotePadDemo.Pages[1].Title = "Antartic Expedition";
            NotePadDemo.PreviewPage(2);

            NotePadDemo.ReplaceTxtFromPage("Changing whole content of page two .", 2);
            NotePadDemo.PreviewPage(2);

            try
            {
                NotePadDemo.PreviewPage(3);
            }
            catch (NotepadExceptions ex)
            {
                Console.WriteLine(ex.Message);
                try
                {
                    NotePadDemo.ReplaceTxtFromPage("", 4);
                }
                catch (NotepadExceptions ex1)
                {
                    Console.WriteLine(ex1.Message);
                    try
                    {
                        NotePadDemo.DeleteTxtFromPage(6);
                    }
                    catch (NotepadExceptions ex2)
                    {
                        Console.WriteLine(ex2.Message);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}


