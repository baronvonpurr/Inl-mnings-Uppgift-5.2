using System;

namespace Uppgift5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nummer = new int[3];

            nummer[0] = 3;
            nummer[1] = 1;

            Console.Write("Skriv in ett nummer: ");
            nummer[2] = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{nummer[i]} ");
            }
            Console.ReadKey();
        }
    }
}