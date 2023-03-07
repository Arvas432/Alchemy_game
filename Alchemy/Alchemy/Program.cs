using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alchemy.Enemies;
using Alchemy.Ingredients;

namespace Alchemy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Gamemechanics gamemechanics = new Gamemechanics();
            gamemechanics.Game();
        }
    }
}
