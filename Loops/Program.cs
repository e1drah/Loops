using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Loops
{
    internal class Program
    {
        static bool gameover;

        static int playerY;
        static int playerX;

        static char input;
        static void Main(string[] args)
        {
            gameover = false;

            PlayerUpdate();
        }
        static void PlayerUpdate()
        {
            while(gameover != true)
            {
                
                if (Console.ReadKey().Key == ConsoleKey.W)
                {
                    Console.WriteLine("Up");
                }
                if (Console.ReadKey().Key == ConsoleKey.S)
                {
                    Console.WriteLine("Down");
                }
                if (Console.ReadKey().Key == ConsoleKey.A)
                {
                    Console.WriteLine("Left");
                }
                if (Console.ReadKey().Key == ConsoleKey.D)
                {
                    Console.WriteLine("Right");
                }
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    gameover = true;
                }
            }
            Environment.Exit(0);
        }

    }
}
