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
        Random random = new Random(); // object of random class
        //Method
        public void StartGame()
        {
            Console.WriteLine("Player position is: " + position);
            int DiceValue = random.Next(1, 7);          //random number berween 1 to 6 for Dice Value.
            int playCheck = random.Next(0, 3);          //Generating random value between 0 to 2 to control movement of player position
            switch (playCheck)
            {
                case LADDER:
                    Console.WriteLine("Move player position ahead of Dice Value ");
                    break;
                case SNAKE:
                    Console.WriteLine("Move player position behind the Dice Value ");
                    break;
                default:
                    Console.WriteLine("player will stays at his position ");
                    break;
            }
        }
        
    }
}