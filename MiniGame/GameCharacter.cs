using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame
{
    class GameCharacter
    {
        public string playerCharacter = "█";
        public string userInput;

        public int playerX = Console.CursorLeft;
        public int playerY = Console.CursorTop;

        public void CheckCoordRange()
        {
            if (playerX <= 0) playerX ++;
            if (playerY <= 0) playerY ++;
        }

        public void DrawCharacter()
        {
            Console.SetCursorPosition(playerX, playerY);
            CheckCoordRange();
            Console.WriteLine(playerCharacter);
        }

        public void MovePlayer()
        {
            ConsoleKeyInfo userInput = Console.ReadKey(true);

            switch (userInput.KeyChar)
            {
                case 'w':
                    Console.Clear();
                    playerY--;
                    DrawCharacter();
                    break;
                case 'a':
                    Console.Clear();
                    playerX--;
                    DrawCharacter();
                    break;

                case 's':
                    Console.Clear();
                    playerY++;
                    DrawCharacter();
                    break;

                case 'd':
                    Console.Clear();
                    playerX++;
                    DrawCharacter();
                    break;

                case 'W':
                    Console.Clear();
                    playerY--;
                    DrawCharacter();
                    break;
                case 'A':
                    Console.Clear();
                    playerX--;
                    DrawCharacter();
                    break;

                case 'S':
                    Console.Clear();
                    playerY++;
                    DrawCharacter();
                    break;

                case 'D':
                    Console.Clear();
                    playerX++;
                    DrawCharacter();
                    break;
            }
        }
    }
}
