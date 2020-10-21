namespace NotePad
{
    public interface INotePage:IPage
    {
        int Index { get; }
        string SearchWordInPages(string word);
        void PrintAllPagesWithDigits();


    }
}
