using System;

class Program
{
    static void Main()
    {
        int[] myArray = { 1, 2, 3, 4, 5 };

        ShowAllElements(myArray);

        Console.ReadKey();
    }

    static void ShowAllElements(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.WriteLine(element);
        }
    }
}

/// Ushbu kodning vaqt complexity si O(n), chunki ShowAllElements funksiya massivdagi har bir elementni bir marta chaqiradi. 
/// Bu o'nlik vaqt complexity ni anglatadi. 
/// Xotira complexity si esa o'nlik, chunki massivning o'lchami elementlar soniga bog'liq o'zgaradi.
