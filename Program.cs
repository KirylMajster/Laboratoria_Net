using System;

namespace FizzBuzzApp
{

    class Program
    {
        static void Main()
        {
            Console.Write("Podaj górny zakres liczb: ");
            if (int.TryParse(Console.ReadLine(), out int liczba))
            {
                FizzBuzz fizzBuzz = new FizzBuzz(liczba); 
                fizzBuzz.WyswietlFizzBuzz(); 
            }
            else
            {
                Console.WriteLine("Błąd");
            }
        }
    }
}
