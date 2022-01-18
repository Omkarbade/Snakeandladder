using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakeandladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake & Ladder program");
            StartPosition StartPosition = new StartPosition();
            StartPosition.StartGame();
            Console.ReadLine();
        }
    }
}
