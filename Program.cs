using C_4;
using C_4.NumberGenerators;
using C_4.Figures; 
using System;
using System.Reflection.Emit;
using System.Text;
using C_4.GuessTheNumberGame;

namespace C_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            bool Input = true;

            while (Input)
            {

                Console.WriteLine("Оберіть завдання (1-4):");
                int task = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (task)
                {
                    case 1:

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
                        break;

                    case 2:

                        Triangle triangle = new Triangle();
                        int height = 5; 
                        for (int i = 1; i <= height; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }

                        Console.ReadLine();
                

                Rectangle rectangle = new Rectangle();
                        int width = 10;  
                        int length = 5;  
                       
                        for (int i = 0; i < length; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }

                        Console.ReadLine(); 
                

                Square square = new Square();
                int sidelength = 5;  

                
                for (int i = 0; i < sidelength; i++)
                {
                    for (int j = 0; j < sidelength; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }

                Console.ReadLine(); 
          
            break;

                    case 3:
                        Console.WriteLine("Вгадайте число в діапазоні від 1 до 1000.");
                        Game game = new Game(1, 1000);

                        bool isGameOver = false;

                        do
                        {
                            Console.Write("Введіть ваше число: ");
                            int userGuess;
                            if (int.TryParse(Console.ReadLine(), out userGuess))
                            {
                                isGameOver = game.MakeGuess(userGuess);
                            }
                            else
                            {
                                Console.WriteLine("Введено недійсне число. Спробуйте ще раз.");
                            }
                        } while (!isGameOver);

                        Console.ReadLine();
                
                break;

                    case 4:
                        Console.Write("Введіть кількість голосних: ");
                        int numVowels = int.Parse(Console.ReadLine());

                        Console.Write("Введіть кількість приголосних: ");
                        int numConsonants = int.Parse(Console.ReadLine());

                        Console.Write("Введіть максимальну довжину слова: ");
                        int maxWordLength = int.Parse(Console.ReadLine());

                        Console.Write("Введіть кількість слів: ");
                        int numWords = int.Parse(Console.ReadLine());

                        string loremIpsum = PseudoGenerator.GenerateLoremIpsum(numVowels, numConsonants, maxWordLength, numWords);
                        Console.WriteLine("\nЗгенерований псевдотекст:\n");
                        Console.WriteLine(loremIpsum);

                        Console.ReadLine();
                
                break;


                }
            }
        }

    }

}


