using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_4
{
    namespace GuessTheNumberGame
    {
        public class Game
        {
            public int secretNumber;
            public int attempts;
            public int minRange;
            public int maxRange;

            public Game(int minRange, int maxRange)
            {
                this.minRange = minRange;
                this.maxRange = maxRange;
                Random random = new Random();
                secretNumber = random.Next(minRange, maxRange + 1);
                attempts = 0;
            }

            public bool MakeGuess(int number)
            {
                attempts++;

                if (number < secretNumber)
                {
                    Console.WriteLine("Загадане число більше.");
                    return false;
                }
                else if (number > secretNumber)
                {
                    Console.WriteLine("Загадане число менше.");
                    return false;
                }
                else
                {
                    Console.WriteLine($"Ви вгадали! Загадане число - {secretNumber}. Кількість спроб: {attempts}");
                    return true;
                }
            }
        }
    }

}
