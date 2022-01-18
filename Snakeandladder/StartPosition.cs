using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakeandladder
{
    public class StartPosition
    {
        //Instance Variables.
        int position = 0;
        const int MaxPosition = 100;
        const int LADDER = 1;
        const int SNAKE = 2;
        Random random = new Random();       // object of random class
        //Method
        public void StartGame()
        {
            Console.WriteLine("Player position is: " + position);
            //Using While Loop to iterate Game till position reaches max position.
            int DiceCount = 0;
            while (position < MaxPosition)
            {
                int DiceValue = random.Next(1, 7);          //random number berween 1 to 6 for Dice Value.
                int playCheck = random.Next(0, 3);          //Generating random value between 0 to 2 to control movement of player position
                switch (playCheck)
                {
                    case LADDER:
                        if (position <= MaxPosition && (position + DiceValue) <= MaxPosition)
                        {
                            position += DiceValue;
                        }
                        break;
                    case SNAKE:
                        if (position > 0 && (position - DiceValue) >= 0)
                        {
                            position -= DiceValue;
                        }
                        break;
                    default:
                        break;
                }
                DiceCount++;
                Console.WriteLine("Dice Roll:{0} and Player Position:{1}", DiceCount, position);
            }
            Console.WriteLine("\nNumber of Dice played: " + DiceCount + "\tPlayer Position: " + position);
        }
    }
}