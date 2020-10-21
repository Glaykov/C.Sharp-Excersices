namespace NotePad
{
    public interface IPage
    {
        string Title { get;}
        string Txt { get;}
        void AddTxt(string x);
        void DeleteTxt(string x);
        string Preview();
        string SearchWord(string x);
        bool ContainDigits(int index);
    }
}
