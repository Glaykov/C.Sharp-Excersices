using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NotePad
{
    public class NotePage : INotePage
    {
        public string Title { get; set; }

        public string Txt { get; set; }

        public int Index { get; set; }

        public bool Secure { get; set; }

        public NotePage()  {
            Secure = false;
            Title = null;
            Txt = null;
            Index = 0;
        }

        public void AddTxt(string x)
        {
            if (Secure == true) { throw new NotepadExceptions("AddTxt()-",1); }
            if (Txt == null)
            {
                Txt = "\n" + x ;
            }
            else throw new NotepadExceptions(Index);
        }

        public void DeleteTxt(string x)
        {
            if (Secure == true) { throw new NotepadExceptions("DeleteTxt()-",1); }
            if (Txt == null) {
                throw new NotepadExceptions(Index);
            } else
                Txt = null;
        }

        public string Preview()
        {
            if (Secure == true) { throw new NotepadExceptions("Preview()-",1); }
            if (Txt != null)
            {
                return $"{this.Title}\n{this.Txt}";
            }
            else throw new NotepadExceptions(Index);
        }

        public virtual string SearchWord(string x)
        {
            if (this.Txt.Contains(x))
            {
                return $"Page {Index} contains {x}";
            }
            else
                return $"No matches in page {Index}";
        }

        public bool ContainDigits(int i)
        {
            if (this.Txt.Contains(i.ToString()))
            {
                return true;
            }
            else return false;
        }

        public virtual string SearchWordInPages(string word) {return " ";}

        public virtual void PrintAllPagesWithDigits(){}
    }
}
