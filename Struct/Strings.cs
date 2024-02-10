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
            CheckCase(ref str[i]);
        }
    }
    static void CheckCase(ref char str)
    {
        if (str > 'Z' && str <= 'z')
            str = (char)((int)str - 32);
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

    //i think is a good idea always use this with tuUpper or lower
    public void StartsWith(char[] chars)
    {
        int i, j;

        for (i = 0, j = 0; str[i] != '\t' && chars[j] != '\t'; i++, j++)
        {
            System.Console.WriteLine(str[i]);
            // if (str[i] != chars[j]) break;
            //using ASCII values instead directly char
            if (str[i] == chars[j]) System.Console.WriteLine("Do something is equal here");
            else if (str[i] >= chars[j]) System.Console.WriteLine("Income string is smaller than the stored one");
            else System.Console.WriteLine("Incoming string is bigger");
        }
    }

    // i will make a more optimal version where i don't use ToUpper on startsWith
    public void StartsWithOptimized(char[] chars)
    {
        int i, j;
        for (i = 0, j = 0; str[i] != '\t' && chars[j] != '\t'; i++, j++)
        {
            CheckCase(ref str[i]);
            CheckCase(ref chars[j]);
            if (str[i] == chars[j]) System.Console.WriteLine("Do something is equal here");
            else if (str[i] >= chars[j]) System.Console.WriteLine("Income string is smaller than the stored one");
            else System.Console.WriteLine("Incoming string is bigger");
        }
    }

    public void CheckPalindrome()
    {
        char[] chars = ['m', 'a', 'd', 'a', 'm'];
        for (int i = 0, j = chars.Length - 1; i <= j; i++, j--)
        {
            System.Console.WriteLine(chars[i] == chars[j]);
        }
    }

    public int Max(char[] st)
    {
        int max = st[0];
        int i;
        for (i = 0; st[i] != '\t'; i++)
        {
            if (max < st[i]) max = st[i];
        }
        return max;
    }

    //@@@@@@@@@@@@@@@@ challenges
    public void FindDuplicate(Strings strings)
    {
        for (int i = 0; strings.str[i] != '\t'; i++)
        {
            for (int j = i + 1; strings.str[j] != '\t'; j++)
            {
                if (strings.str[i] == strings.str[j])
                    strings.str[j] = '0';
            }
            System.Console.WriteLine(strings.str[i]);
        }

    }

    //i definitely should use another approach
    // public void FindDuplicateHash(Strings strings)
    // {
    //     int[] chars = new int['A' + 'z'];
    //     int i;
    //     for (i = 0; strings.str[i] != '\t'; i++)
    //     {
    //         if (strings.str[i] >= 'A' && strings.str[i] <= 'Z')
    //             chars[strings.str[i] - 'A']++;
    //         else if (strings.str[i] >= 'a' && strings.str[i] <= 'z')
    //             chars[strings.str[i] - 'a']++;
    //     }
    //     chars[i] = '\t';
    //     for (i = 0; i < chars.Length; i++)
    //     {
    //         System.Console.WriteLine(i + );
    //         System.Console.WriteLine(chars[i]);
    //     }
    // }
    //i will use only  upper
    public void FindDuplicateHash(Strings strings)
    {
        int[] chars = new int['Z' - 'A' + 1];
        int i;
        for (i = 0; strings.str[i] != '\t'; i++)
        {
            if (!Alphabet(strings.str[i]) && !NumASCII(strings.str[i]) && strings.str[i] != ' ') break;
            CheckCase(ref strings.str[i]);
            chars[strings.str[i] - 'A']++;
        }
        string output = "";
        for (i = 0; i < chars.Length; i++)
        {
            // System.Console.WriteLine(i + 'A');
            // System.Console.WriteLine(chars[i]);
            if (chars[i] > 1)
            {
                output += (char)(i + 'A');
            }
        }
        System.Console.WriteLine(output);
    }

    //Now we gonna start use bits

    public void FindDuplicateInBits(Strings strings)
    {
        //c# already declare as int 32 bit here, so the size in bit will be enough for
        //store values between 65 to 97 as ASCII 
        int H = 0, x;
        int i;
        for (i = 0; strings.str[i] != '\t'; i++)
        {
            CheckCase(ref strings.str[i]);
            x = 1;
            // x = x << (strings.str[i] - 97);
            //left shifting this (strings.str[i] - 97) amount of time 
            x <<= strings.str[i] - 97;
            if ((x & H) > 0)
            {
                System.Console.WriteLine(strings.str[i]);
            }
            else H = x | H;
        }
    }

    public void CheckForAnagramHash(Strings strings, Strings strings1)
    {
        //check if the words has exactly the same amount of index and same letters as well
        //does not matter if the words is different. Like decimal and medical 

        // Remember about lower case here i'm to lazy right now to operate
        if (strings.str.Length != strings1.str.Length) return;
        int i;
        int[] chars = new int['z' - 'a'];
        for (i = 0; strings.str[i] != '\t' && strings1.str[i] != '\t'; i++)
        {
            chars[strings.str[i] - 'a']++;
            chars[strings1.str[i] - 'a']--;
        }
        string output = "";
        for (i = 0; i < chars.Length; i++)
        {
            // System.Console.WriteLine(i + 'A');
            // System.Console.WriteLine(chars[i]);
            if (chars[i] < 0)
            {
                output += (char)(i + 'a');
                break;
            }
        }
        //the result for anagram should be "" otherwise will print the different letters
        System.Console.WriteLine(output);
    }

    //this one just works if there is no DUPLICATED letters in the same string
    public void CheckForAnagramAsBits(Strings strings, Strings strings1)
    {
        //check if the words has exactly the same amount of index and same letters as well
        //does not matter if the words is different. Like decimal and medical 
        int H = 0, J = 0, x;
        int i;
        for (i = 0; strings.str[i] != '\t' && strings1.str[i] != '\t'; i++)
        {
            CheckCase(ref strings.str[i]);
            x = 1;
            // x = x << (strings.str[i] - 97);
            //left shifting this (strings.str[i] - 97) amount of time 
            x <<= strings.str[i] - 97;
            if ((x & H) > 0)
            {
                System.Console.WriteLine(strings.str[i]);
            }
            else H = x | H;

            x = 1;
            x <<= strings1.str[i] - 97;

            if ((x & J) > 0)
            {
                System.Console.WriteLine(strings1.str[i]);
            }
            else J = x | J;
        }
        System.Console.WriteLine(H);
        System.Console.WriteLine(J);
        //if is equal means the bits are allocated in same places so anagram condition check
        if (H == J) { H = 0; J = 0; }
        System.Console.WriteLine(H);
        System.Console.WriteLine(J);
        // System.Console.WriteLine(H);
    }

}