using System;

namespace FizzBuzzApp
{
    class FizzBuzz
    {
        private int zakres;

        
        public FizzBuzz(int maxLiczba)
        {
            zakres = maxLiczba;
        }

       
        public void WyswietlFizzBuzz()
        {
            for (int i = 1; i <= zakres; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }

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
