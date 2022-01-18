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
        Random random = new Random(); //Calling object class  

        public void StartGame() //Calling Method
        {
            Console.WriteLine("Player position is: " + position);
            int RandomNum = random.Next(1, 7); //Generating random number between 0 and 6
            Console.WriteLine("randomNum: " + RandomNum);
        }
    }
}
