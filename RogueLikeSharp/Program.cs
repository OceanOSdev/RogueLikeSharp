using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RogueLikeSharp
{
    class Program
    {
        /// <summary>
        /// Gets Key state in separate thread.
        /// </summary>
        /// <param name="Key">The key to get</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys Key);
        static void Main(string[] args)
        {
            Player p = new Player("mainPlayer");
            bool quit = false;
            do
            {
                Draw.resetToDefault();
                Draw.drawPlayer(p.Location);
                Draw.drawBackground();
                Console.SetCursorPosition(0, 0);

                if (GetAsyncKeyState(Keys.A) != 0)
                    p.MoveLeft();

                if (GetAsyncKeyState(Keys.S) != 0)
                    p.MoveDown();

                if (GetAsyncKeyState(Keys.D) != 0)
                    p.MoveRight();

                if (GetAsyncKeyState(Keys.W) != 0)
                    p.MoveUp();

                if (GetAsyncKeyState(Keys.Q) != 0)
                    quit = true;

            } while (!quit);
            Console.ReadKey();
        }
    }
}
