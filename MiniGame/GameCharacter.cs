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

        public void checkCoordRange()
        {
            if (playerX < 0) playerX = 0;
            if (playerY < 0) playerX = 0;
        }

        public void MovePlayer()
        {
            checkCoordRange();

            ConsoleKeyInfo userInput = Console.ReadKey(true);

            switch (userInput.KeyChar)
            {
                case 'w':
                    Console.Clear();
                    Console.SetCursorPosition(playerX, playerY--);
                    Console.Write(playerCharacter);
                    break;
                case 'a':
                    Console.Clear();
                    Console.SetCursorPosition(playerX--, playerY);
                    Console.Write(playerCharacter);
                    break;

                case 's':
                    Console.Clear();
                    Console.SetCursorPosition(playerX, playerY++);
                    Console.Write(playerCharacter);
                    break;

                case 'd':
                    Console.Clear();
                    Console.SetCursorPosition(playerX++, playerY);
                    Console.Write(playerCharacter);
                    break;

                case 'W':
                    Console.Clear();
                    Console.SetCursorPosition(playerX, playerY--);
                    Console.Write(playerCharacter);
                    break;
                case 'A':
                    Console.Clear();
                    Console.SetCursorPosition(playerX--, playerY);
                    Console.Write(playerCharacter);
                    break;

                case 'S':
                    Console.Clear();
                    Console.SetCursorPosition(playerX, playerY++);
                    Console.Write(playerCharacter);
                    break;

                case 'D':
                    Console.Clear();
                    Console.SetCursorPosition(playerX++, playerY);
                    Console.Write(playerCharacter);
                    break;
            }
        }
    }
}
