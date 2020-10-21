using System;
using NotePad;

namespace Secure
{
    public class SecureNotepad
    {
        public string SecureNotePadName { get; set; }
        public NotePage[] SecurePages { get; set; }
        public int PagesAmount { get; set; }
        protected string Password { get; set; }

        public SecureNotepad(string noteName, int pagesAmount, string password)
        {
            Password = password;
            SecureNotePadName = noteName;
            PagesAmount = pagesAmount;
            SecurePages = new NotePage[pagesAmount];
            for (int i = 0; i < SecurePages.Length; i++)
            {
                SecurePages[i] = new NotePage();
            }
            MakePageIndex();
            SecureAllPages();
        }
        public void SecureAllPages() {
            for (int i = 0; i < SecurePages.Length; i++) {
                SecurePages[i].Secure = true;
            }
        }

        private void MakePageIndex()
        {
            for (int i = 0; i < SecurePages.Length; i++)
            {
                SecurePages[i].Index = i + 1;
            }
        }

        public virtual void AddTxtToPage(string password, string text, int pageIndex)
        {
            if (Password == password)
            {
                pageIndex--;
                SecurePages[pageIndex].Txt += $"\n{text}\n";
            }
            else throw new NotepadExceptions(this.SecureNotePadName);
        }

        public virtual void ReplaceTxtFromPage(string password, string text, int pageIndex)
        {
            if (Password == password)
            {
                pageIndex--;
                if (SecurePages[pageIndex].Txt != null)
                {
                    SecurePages[pageIndex].Txt = "\n" + text +"\n";
                }
                else throw new NotepadExceptions(pageIndex, $"\nReplaceTxtFromPage Error--{SecurePages[pageIndex].Index}--");
            }
            else throw new NotepadExceptions(this.SecureNotePadName);
        }

        public virtual void DeleteTxtFromPage(string password, int pageIndex)
        {
            if (Password == password)
            {
                if (SecurePages[pageIndex].Txt != null)
                {
                    SecurePages[pageIndex].Txt = null;
                }
                else throw new NotepadExceptions(pageIndex, $"\nDeleteTxtFromPage Error --{SecurePages[pageIndex].Index}--");
            }
            else throw new NotepadExceptions(this.SecureNotePadName);
        }

        public virtual void PreviewPage(string password, int pageIndex)
        {
            if (Password == password)
            {
                pageIndex -= 1;
                if (SecurePages[pageIndex].Txt != null)
                {
                    Console.WriteLine($"{SecurePages[pageIndex].Title} --{SecurePages[pageIndex].Index}--\n{SecurePages[pageIndex].Txt}\n");
                }
                else throw new NotepadExceptions(pageIndex, $"\nError PreviewPage --{SecurePages[pageIndex].Index}--");
            }
            else throw new NotepadExceptions(this.SecureNotePadName);

        }

       
    }
}
