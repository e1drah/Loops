using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        static int boundMinimum;
        static int boundMaximum;

        static int boundX;
        static int boundY;
        static ConsoleKeyInfo input;
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            gameover = false;
            playerX = 0;
            playerY = 0;

            boundMinimum = 0;
            boundMaximum = 100;
            boundX = 100;
            boundY = 100;
            PlayerDraw();
        }
        //updates player position base on user input
        static void PlayerInput()
        {
            while(gameover != true)
            {
                input = Console.ReadKey(true);

                if (input.Key == ConsoleKey.W)
                {
                    playerY -=1;
                    //PlayerDraw();
                }
                if (input.Key == ConsoleKey.S)
                {
                    playerY += 1;
                    //PlayerDraw();
                }
                if (input.Key == ConsoleKey.A)
                {
                    playerX -= 1;
                    //PlayerDraw();
                }
                if (input.Key == ConsoleKey.D)
                {
                    playerX += 1;
                    //PlayerDraw();
                }
                if (input.Key == ConsoleKey.Escape)
                {
                    gameover = true;
                }
                BoundCheck();
            }
            Environment.Exit(0);
        }
        //keeps player in bounds
        //draws player to screen
        static void BoundCheck()
        {
            
            if (playerX < 0)
            {
                playerX = 0;
            }
            if (playerY < 0)
            {
                playerY = 0;
            }
            if (playerX  > boundX)
            {
                playerX = boundX;
            }
            if (playerY > boundY)
            {
                playerY = boundY;
            }
            PlayerDraw();
        }
        static void PlayerDraw()
        {
            Console.Clear();
            Console.SetCursorPosition(playerX, playerY);
            Console.Write("8");
            PlayerInput();
        }
    }
}
