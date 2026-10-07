using System;

class Program
{
    static void Main()
    {
        Console.Write("Hur gammal är du? ");
        int alder = int.Parse(Console.ReadLine());

        if (alder < 16)
        {
            Console.WriteLine("Du är för ung för att delta i tävlingen.");
        }
        else if (alder > 19)
        {
            Console.WriteLine("Du är för gammal för att delta i tävlingen.");
        }
        else
        {
            Console.WriteLine("Du får delta i tävlingen!");
        }
    }
}