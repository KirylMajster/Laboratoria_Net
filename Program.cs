using System;

namespace FizzBuzzApp
{
    class FizzBuzz
    {
        private int zakres;

        // Konstruktor przyjmujący zakres liczb
        public FizzBuzz(int maxLiczba)
        {
            zakres = maxLiczba;
        }

        // Metoda do wyświetlania FizzBuzz
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
                FizzBuzz fizzBuzz = new FizzBuzz(liczba); // Tworzymy obiekt z podanym zakresem
                fizzBuzz.WyswietlFizzBuzz(); // Wywołujemy metodę
            }
            else
            {
                Console.WriteLine("Błąd: Niepoprawna liczba.");
            }
        }
    }
}
