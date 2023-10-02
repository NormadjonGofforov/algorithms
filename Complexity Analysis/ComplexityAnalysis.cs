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
