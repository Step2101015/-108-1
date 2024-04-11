/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class Program
{
    static void Main()
    {
        char[] characters = { 'a', 'B', 'c', 'D', 'e', 'F', 'g', 'H', 'i', 'J', 'k' };

        Console.WriteLine("Исходный массив символов:");
        foreach (char ch in characters)
        {
            Console.Write(ch + " ");
        }
        
        Console.WriteLine("\n\nМассив символов после перевода строчных букв в верхний регистр:");
        for (int i = 0; i < characters.Length; i++)
        {
            if (Char.IsLower(characters[i])) // Проверка на строчную букву
            {
                characters[i] = Char.ToUpper(characters[i]);
            }
            Console.Write(characters[i] + " ");
        }
    }
}