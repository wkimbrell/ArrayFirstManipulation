using System;
class Program
{
    static void Main(string[] args)
    {
        int[] myArray = { 1, 2, 3, 4, 5 };
        foreach (int value in myArray)
        {
            Console.WriteLine(value);
        }

        int[] myArray2 = { 1, 2, 3, 4, 5, 6, 7, 8, 8, 10 };
        foreach (int value in myArray2)
        {
            Console.WriteLine(value);
        }

        int sum = 0;
        foreach (int value in myArray2)
        {
            sum += value;
        }
        Console.WriteLine(sum);

        
        int product = 1;
        foreach (int value in myArray2)
        {
            product *= value;
        }
        Console.WriteLine(product);


        char[] letters = new char[8];
        letters[0] = 'a';
        letters[1] = 'b';
        letters[2] = 'c';
        letters[3] = 'd';
        letters[5] = 'f';

        Console.WriteLine(letters[letters.Length - 1]);
        Console.WriteLine(letters[4]);
        for (int i = 0; i < letters.Length / 2; i++)
        {
            Console.WriteLine(letters[i]);
        }

    }
}


/*
 * 1. The last char would be null
 * 2. Still null
 * It still does the first half, but does a,b,c,d 
 */