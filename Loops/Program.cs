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

        static ConsoleKeyInfo input;
        static void Main(string[] args)
        {
            gameover = false;

            PlayerUpdate();
        }
        static void PlayerUpdate()
        {
            while(gameover != true)
            {
                input = Console.ReadKey();

                if (input.Key == ConsoleKey.W)
                {
                    Console.WriteLine("Up");
                }
                if (input.Key == ConsoleKey.S)
                {
                    Console.WriteLine("Down");
                }
                if (input.Key == ConsoleKey.A)
                {
                    Console.WriteLine("Left");
                }
                if (input.Key == ConsoleKey.D)
                {
                    Console.WriteLine("Right");
                }
                if (input.Key == ConsoleKey.Escape)
                {
                    gameover = true;
                }
            }
            Environment.Exit(0);
        }

    }
}
