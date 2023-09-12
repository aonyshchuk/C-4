using C_4;
using C_4.NumberGenerators;
using System;
using System.Reflection.Emit;
using System.Text;

namespace C_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            EvenNumberGenerator evenGenerator = new EvenNumberGenerator();
            OddNumberGenerator oddGenerator = new OddNumberGenerator();
            PrimeNumberGenerator primeGenerator = new PrimeNumberGenerator();
            FibonacciGenerator fibonacciGenerator = new FibonacciGenerator();


            Console.WriteLine("Парні числа:");
            for (int i = 0; i < 5; i++)
            {
                int evenNumber = evenGenerator.GenerateNext();
                Console.WriteLine(evenNumber);
            }


            Console.WriteLine("\nНепарні числа:");
            for (int i = 0; i < 5; i++)
            {
                int oddNumber = oddGenerator.GenerateNext();
                Console.WriteLine(oddNumber);
            }


            Console.WriteLine("\nПрості числа:");
            for (int i = 0; i < 5; i++)
            {
                int primeNumber = primeGenerator.GenerateNext();
                Console.WriteLine(primeNumber);
            }


            Console.WriteLine("\nЧисла Фібоначчі:");
            for (int i = 1; i <= 5; i++)
            {
                int fibonacciNumber = fibonacciGenerator.GenerateNext(i);
                Console.WriteLine(fibonacciNumber);
            }
        }

    }

}


