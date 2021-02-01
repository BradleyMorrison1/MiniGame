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

        public void MovePlayer()
        {
            

            ConsoleKeyInfo userInput = Console.ReadKey(true);

            switch (userInput.KeyChar)
            {
                case 'w':
                    Console.SetCursorPosition(playerX, playerY--);
                    Console.Write(playerCharacter);
                    break;
                case 'a':
                    Console.SetCursorPosition(playerX--, playerY);
                    Console.Write(playerCharacter);
                    break;

                case 's':
                    Console.SetCursorPosition(playerX, playerY++);
                    Console.Write(playerCharacter);
                    break;

                case 'd':
                    Console.SetCursorPosition(playerX++, playerY);
                    Console.Write(playerCharacter);
                    break;

                case 'W':
                    Console.SetCursorPosition(playerX, playerY--);
                    Console.Write(playerCharacter);
                    break;
                case 'A':
                    Console.SetCursorPosition(playerX--, playerY);
                    Console.Write(playerCharacter);
                    break;

                case 'S':
                    Console.SetCursorPosition(playerX, playerY++);
                    Console.Write(playerCharacter);
                    break;

                case 'D':
                    Console.SetCursorPosition(playerX++, playerY);
                    Console.Write(playerCharacter);
                    break;
            }
        }
    }
}
