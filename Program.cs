using System.Text;

class Program
{
    static void Main(string[] args)
    {
        //c++ you use \o for break reference in char arrays
        Strings strings = new() { str = ['l', 'U', 'i', 'Z', ' ', '$', 'h', 'O', 'w', ' ', ' ', ' ', 'a', '\t'] };
        strings.StrLength();
        // strings.ToUpper();
        strings.Count();
        strings.CountWhiteSpace();
        strings.HasSpecialCharacter(ref strings);
        // strings.ReverseString(ref strings);
        strings.ReverseString2(ref strings);



    }
}