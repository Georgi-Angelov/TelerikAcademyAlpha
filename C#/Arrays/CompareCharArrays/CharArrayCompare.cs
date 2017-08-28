using System;

class CompareCharArrays
{
    static void Main()
    {
        bool differenceFound = false;
        
        string firstCharArray = Console.ReadLine();
        string secondCharArray = Console.ReadLine();

        int counter = 0;
        
        while (counter < firstCharArray.Length && counter < secondCharArray.Length)
        {
            char tempChar1, tempChar2;

            tempChar1 = SmallToCapital(firstCharArray[counter]);
            tempChar2 = SmallToCapital(secondCharArray[counter]);

            if (tempChar1 > tempChar2)
            {
                Console.WriteLine(">");
                differenceFound = true;
                break;
            }

            else if (tempChar1 < tempChar2)
            {
                Console.WriteLine("<");
                differenceFound = true;
                break;
            }

            else counter++;
        }
        
        if (!differenceFound)
        {
            if (firstCharArray.Length > secondCharArray.Length)
            {
                Console.WriteLine(">");
            }
            else if (firstCharArray.Length < secondCharArray.Length)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }

    

    private static char SmallToCapital(char ch)
    {
        if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
        { 
            return Convert.ToChar(ch - 32);
        }
        else
        {
            return ch;
        }
    }
}