struct Strings
{
    public char[] str { get; set; }

    public int StrLength()
    {
        int i;
        for (i = 0; str[i] != '\t'; i++)
        {
        }
        return i;
    }

    public void ToUpper()
    {
        //diff between A and a is always 32 in code table
        int i;
        for (i = 0; str[i] != '\t'; i++)
        {
            str[i] = (char)((int)str[i] - 32);
        }
    }

    public void ToggleCases()
    {
        //diff between A and a is always 32 in code table
        int i;
        for (i = 0; str[i] != '\t'; i++)
        {
            //A = 65 Z = 90
            if (str[i] >= 'A' && str[i] <= 'Z')
                str[i] = (char)(str[i] + 32);
            //a = 97 z = 122
            else if (str[i] >= 'a' && str[i] <= 'z')
                str[i] = (char)(str[i] - 32);

            System.Console.WriteLine(str[i]);
        }
    }

    //count vowels and consonants
    public void Count()
    {
        int i, vCount = 0, cCount = 0;
        for (i = 0; str[i] != '\t'; i++)
        {
            if (BCHandle(str[i]))
            {
                vCount++;
            }
            if (Alphabet(str[i]))
            {
                cCount++;
            }
        }
        System.Console.WriteLine(cCount);
        System.Console.WriteLine(vCount);
    }

    static bool Alphabet(char s)
    {
        return s >= 65 && s <= 127;
    }
    static bool NumASCII(char s)
    {
        return s >= 48 && s <= 57;
    }

    static bool BCHandle(char s)
    {
        return s == 'a' || s == 'e' || s == 'i' || s == 'o' || s == 'u' || s == 'A' || s == 'E' || s == 'I' || s == 'O' || s == 'U';
    }

    public void CountWhiteSpace()
    {
        int i, white = 0;
        for (i = 0; str[i] != '\t'; i++)
        {
            if (str[i] == ' ' && str[i - 1] != ' ')
            {
                white++;
            }
        }
        System.Console.WriteLine(white);
    }

    public void HasSpecialCharacter(ref Strings chars)
    {
        int i;
        for (i = 0; chars.str[i] != '\t'; i++)
        {
            if (!Alphabet(chars.str[i]) && !NumASCII(chars.str[i]) && chars.str[i] != ' ')
            {
                System.Console.Write("INVALID CHARACTER: ");
                System.Console.WriteLine(chars.str[i]);

                break;

            }
        }

    }

    public void ReverseString(ref Strings strings)
    {
        int i;
        char[] chars = new char[strings.str.Length + 1];
        for (i = 0; strings.str[i] != '\t'; i++)
        {
        }
        i--;
        int j;
        for (j = 0; i >= 0; i--, j++)
        {
            chars[j] = strings.str[i];
        }
        chars[j] = '\t';
        for (i = 0; chars[i] != '\t'; i++)
        {
            System.Console.WriteLine(chars[i]);
        }

    }

    //reversing without allocate another array in memory.
    public void ReverseString2(ref Strings strings)
    {
        int j;
        int i;
        char temp;
        for (j = 0; strings.str[j] != '\t'; j++)
        {
        }
        j--;
        for (i = 0; i < j; i++, j--)
        {
            temp = strings.str[i];
            strings.str[i] = strings.str[j];
            strings.str[j] = temp;
        }
        for (i = 0; strings.str[i] != '\t'; i++)
        {
            System.Console.WriteLine(strings.str[i]);
        }

    }

}