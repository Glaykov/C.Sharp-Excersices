using System;
using System.Runtime.CompilerServices;

namespace NotePad
{
    public class SimpleNotePad : NotePage
    {
        public string NotePadName { get; set; }
        public NotePage[] Pages { get; set; }
        public int PagesAmount { get; set; }

        public SimpleNotePad(string noteName, int pagesAmount)
        {
            NotePadName = noteName;
            PagesAmount = pagesAmount;
            Pages = new NotePage[pagesAmount];
            for (int i = 0; i < Pages.Length; i++)
            {
                Pages[i] = new NotePage();
            }
            MakePageIndex();
        }

        private void MakePageIndex()
        {
            for (int i = 0; i < Pages.Length; i++)
            {
                Pages[i].Index = i + 1;
            }
        }

        public void AddTxtToPage(string text, int pageIndex)
        {
            pageIndex--;
            Pages[pageIndex].Txt += $"\n{text}";
        }

        public void ReplaceTxtFromPage(string text, int pageIndex)
        {
            pageIndex--;
            if (Pages[pageIndex].Txt != null)
            {
                Pages[pageIndex].Txt = "\n" + text;
            }
            else throw new NotepadExceptions(pageIndex, $"\nReplaceTxtFromPage Error--{Pages[pageIndex].Index}--");
        }

        public void DeleteTxtFromPage(int pageIndex)
        {
            pageIndex--;
            if (Pages[pageIndex].Txt != null)
            {
                Pages[pageIndex].Txt = null;
            }
            else throw new NotepadExceptions(pageIndex, $"\nDeleteTxtFromPage Error --{Pages[pageIndex].Index}--");
        }

        public void PreviewPage(int pageIndex)
        {
            pageIndex --;
            if (Pages[pageIndex].Txt != null)
            {
                Console.WriteLine($"{Pages[pageIndex].Title} --{Pages[pageIndex].Index}--\n{Pages[pageIndex].Txt}\n");
            }
            else throw new NotepadExceptions(pageIndex, $"\nError PreviewPage --{Pages[pageIndex].Index}--");
        }

        public override string SearchWordInPages(string word)
        {
            string current = "Page ";
            for (int i = 0; i < Pages.Length; i++)
            {
                if (this.Pages[i].Txt.Contains(word))
                {
                    current += $"{this.Pages[i].Index} contains this word - '{word}'";
                }
            }
            if (current == "Page ")
            {
                return "No matches";
            }
            else return current;
        }

        public override void PrintAllPagesWithDigits()
        {
            for (int i = 0; i < Pages.Length; i++)
            {
                for (int a = 0; a < Pages[i].Txt.Length; a++)
                {
                    if (Char.IsDigit(Pages[i].Txt[a]))
                    {
                        Console.WriteLine($"{Pages[i].ToString()}\n");
                    }
                }
            }
        }
    }
}
