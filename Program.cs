using System.Text;

class Program
{
    static void Main(string[] args)
    {
        //c++ you use \o for break reference in char arrays
        Strings strings = new() { str = ['l', 'U', 'i', 'Z', ' ', '$', 'h', 'O', 'w', ' ', ' ', ' ', 'a', '\t'] };
        Strings str = new() { str = ['l', 'U', 'i', 'z', 'z', '$', '\t'] };
        Strings str2 = new() { str = ['m', 'e', 'd', 'i', 'c', 'a', 'l', '\t'] };
        Strings str3 = new() { str = ['d', 'e', 'c', 'i', 'm', 'a', 'l', '\t'] };
        Strings str4 = new() { str = ['A', 'B', 'C', '\t'] };
        strings.StrLength();
        // strings.ToUpper();
        // str.ToUpper();
        // strings.Count();
        // strings.CountWhiteSpace();
        // strings.HasSpecialCharacter(ref strings);
        // strings.ReverseString(ref strings);
        // strings.ReverseString2(ref strings);

        // strings.StartsWithOptimized(str.str);

        // strings.CheckPalindrome();

        // strings.FindDuplicate(str);
        // str.FindDuplicateHash(str);
        // str.FindDuplicateInBits(str);
        // str.CheckForAnagramHash(str2, str3);
        // str.CheckForAnagramAsBits(str2, str3);

        str.Permutation(str4, 0);
        // str4.PermutationSwapping(0, 2);



    }
}