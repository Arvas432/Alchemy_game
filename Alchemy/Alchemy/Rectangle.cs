using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    class Rectangle
    {
        public Rectangle(int x,int y,int height, int width)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;
        }
        public void Draw()
        {
            for(int i = 0; i < Width; i ++)
            {
                Console.SetCursorPosition(X + i, Y);
                Console.Write("*");
            }
            X += Width;
            for(int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(X,Y+i);
                Console.Write("*");
            }
            Y += Height;
            for(int i = 0; i < Width; i ++)
            {
                Console.SetCursorPosition(X - i, Y);
                Console.Write("*");
            }
            X -= Width;
            for(int i = 0; i < Height; i ++)
            {
                Console.SetCursorPosition(X, Y-i);
                Console.Write("*");
            }
            Y -= Height;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value-1;
            }
        }
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value-1;
            }
        }
        private int _width;
        private int _height;
    }
}
