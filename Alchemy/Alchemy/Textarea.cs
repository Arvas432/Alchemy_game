using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    class Textarea
    {
        private Rectangle border = new Rectangle(1, 1, 20, Console.BufferWidth-2);
        public void GlamurPrint(string input,ConsoleColor color)
        {
            border.Draw();
            Console.SetCursorPosition(border.X+1, border.Y+1);
            Console.ForegroundColor = color;
            foreach (string s in input.Split('\n'))
            {
                Console.SetCursorPosition(border.X +1, Console.CursorTop);
             
                Console.WriteLine(s);
            }
            Console.ResetColor();
        }
    }
}
