using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_4
{
    namespace NumberGenerators
    {
        public class EvenNumberGenerator
        {
            private int currentNumber;

            public EvenNumberGenerator()
            {
                currentNumber = 0;
            }

            public int GenerateNext()
            {
                currentNumber += 2;
                return currentNumber;
            }
        }
    }

    namespace NumberGenerators
    {
        public class OddNumberGenerator
        {
            private int currentNumber;

            public OddNumberGenerator()
            {
                currentNumber = 1;
            }

            public int GenerateNext()
            {
                currentNumber += 2;
                return currentNumber;
            }
        }
    }

    namespace NumberGenerators
    {
        public class PrimeNumberGenerator
        {
            private int currentNumber;

            public PrimeNumberGenerator()
            {
                currentNumber = 2;
            }

            public int GenerateNext()
            {
                while (!IsPrime(currentNumber))
                {
                    currentNumber++;
                }

                int primeNumber = currentNumber;
                currentNumber++;
                return primeNumber;
            }

            private bool IsPrime(int number)
            {
                if (number < 2)
                {
                    return false;
                }

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }

    namespace NumberGenerators
    {
        public class FibonacciGenerator
        {
            public int GenerateNext(int n)
            {
                if (n <= 0)
                    throw new ArgumentException("n must be a positive integer.", nameof(n));

                if (n == 1)
                    return 0;

                if (n == 2)
                    return 1;

                int previous = 0;
                int current = 1;
                int next = 0;

                for (int i = 3; i <= n; i++)
                {
                    next = previous + current;
                    previous = current;
                    current = next;
                }

                return next;
            }
        }
    }
}
