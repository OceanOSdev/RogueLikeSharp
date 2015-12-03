using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeSharp
{
    /// <summary>
    /// Used to draw to the console with ease
    /// </summary>
    /// <remarks>
    /// In dire need of clean up.
    /// </remarks>
    public static class Draw
    {
        private static int _height = 20, _width = 40;

        /// <summary>
        /// Is a multidimensional array that contains what to draw at each point
        /// </summary>
        public static char[][] gameMap;

        /// <summary>
        /// Height of the map
        /// </summary>
        public static int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                redimension(_height, _width);
            }
        } 

        /// <summary>
        /// Width of the map
        /// </summary>
        public static int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                redimension(_height, _width);
            }
        }

        /// <summary>
        /// Draws Background
        /// </summary> 
        public static void drawBackground()
        {
            for (int height = 0; height < Height; height++)
            {
                for (int width = 0; width < Width; width++)
                {
                    if (gameMap[height][width] == '@')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(gameMap[height][width]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(gameMap[height][width]);
                    }
                }
                Console.WriteLine();
            }
            
        }

        /// <summary>
        /// Sets the characters postion on the gameMap array
        /// </summary>
        /// <param name="x">X-Coordinate</param>
        /// <param name="y">Y-Coordinate</param>
        public static void drawPlayer(int x = 0, int y = 0)
        {
            resetToDefault();
            gameMap[y][x] = '@';
        }

        /// <summary>
        /// Sets the characters position on the gameMap array
        /// </summary>
        /// <param name="pt">The point to draw the character</param>
        public static void drawPlayer(Point pt)
        {
            resetToDefault();
            gameMap[pt.Y][pt.X] = '@';
        }

        /// <summary>
        /// Resets state of screen to defaults
        /// </summary>
        public static void resetToDefault()
        {
            // Resets dimensions
            Height = 20;
            Width = 40;
            gameMap = new char[Height][];
            for (int i = 0; i < Height; i++)
            {
                gameMap[i] = new char[Width];
            }

            // resets contents
            for (int height = 0; height < Height; height++)
            {
                for (int width = 0; width < Width; width++)
                {
                    gameMap[height][width] = '.';
                }
            }
        }

        /// <summary>
        /// Displays information below the grid
        /// </summary>
        /// <param name="info">the information to display</param>
        public static void DisplayInformation(string info)
        {
            Console.SetCursorPosition(0, 20);
            Console.Write(info);
            Console.SetCursorPosition(0, 0);
        }

        /// <summary>
        /// Displays location and health of player
        /// </summary>
        /// <param name="pl">The (one and only) player</param>
        public static void DisplayPlayerInfo(Player pl)
        {
            Console.SetCursorPosition(0,20);
            Console.Write($"Location:\t{pl.Location.ToString()}\nHealth:\t{pl.Health}");
            Console.SetCursorPosition(0, 0);
        }

        private static void redimension(int x, int y)
        {
            
        } 
    }
}
