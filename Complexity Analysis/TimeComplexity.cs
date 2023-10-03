using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int target = 7;

        int index = FindElement(numbers, target);
        
        if (index != -1)
        {
            Console.WriteLine($"Element {target} massivda topildi, indeksi: {index}");
        }
        else
        {
            Console.WriteLine($"Element {target} massivda topilmadi.");
        }
    }

    static int FindElement(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }
        
        return -1;
    }
}


/// Bu kodni tahlil qilib chiqamiz:

/// "FindElement" funksiya massivni elementlarni bir-birini tekshirib, kerakli elementni topish uchun o'z ichiga oladi.
/// Massivni boshidan boshlab barcha elementlarni tekshiradi.
/// Agar kerakli element topilsa, funksiya indeksni qaytaradi.
/// Agar topilmasa, -1 ni qaytaradi.
/// Bu algoritmning vaqt complexity si O(n) bo'lib, chunki massivning uzunligi (n) ga bog'liq ravishda har bir elementni 
/// tekshirish vaqtini talab qiladi. O'sha n darajadagi har bir elementni tekshirishni yonaltirgan algoritmning 
/// vaqt complexity si O(1) (amaliyotni yakunlash uchun sababi) bo'lib qoladi.
