using System;
namespace Uppgifter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int age = int.Parse(Console.ReadLine());
            {
                if (age == 16)
                    Console.WriteLine("Du får vara med i tävlingen.");
                else if (age == 17)
                    Console.WriteLine("Du får vara med i tävlingen.");
                else if (age == 18)
                    Console.WriteLine("Du får vara med i tävlingen.");
                else if (age == 19)
                    Console.WriteLine("Du får vara med i tävlingen.");
                else
                    Console.WriteLine("Du får tyvärr inte vara med i tävlingen");
            }
            
        }
    }
}