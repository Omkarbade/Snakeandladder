using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakeandladder
{
    public class StartPosition
    {
        // Instance variable
        int position = 0;
        const int MaxPosition = 100;
        const int MinPosition = -1;
        const int LADDER = 1;
        const int SNAKE = 2;
        Random random = new Random(); //Calling object class  

        public void StartGame() //Calling Method
        {
            Console.WriteLine("Player position is: " + position);
            int i = 0;
            while (i <= MaxPosition) //Using while loop till game reaches max position
            {
                int DiceValue = random.Next(1, 7); //Generating random number between 0 and 6
                int PlayCheck = random.Next(0, 3); //Generating random number between 0 and 2 to control movement of player position
                if (position <= MinPosition)
                {
                    position = 0;
                }
                else
                {
                    switch (PlayCheck)
                    {
                        case (LADDER):
                            position += DiceValue;
                            break;
                        case (SNAKE):
                            position -= DiceValue;
                            break;
                        default:
                            break;
                    }
                }
                i++;
            }
            Console.WriteLine("Position of player after end of game: " + position);
        }
    }

}
