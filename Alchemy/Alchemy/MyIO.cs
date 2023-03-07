using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    class MyIO
    {
        public void Println(string s)
        {
            Console.WriteLine(s);
        }
        public void Print(string s)
        {
            Console.Write(s);
        }
        public void Println(string s,ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        public string ReadString()
        {
           return Console.ReadLine();
        }
        

    }
}
