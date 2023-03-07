using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    internal class RandomGenerator
    {
        private RandomGenerator()
        {

        }
        public static Random getInstance()
        {
            if (rnd == null)
            {
                rnd = new Random();

            }
            return rnd;
        }
        private static Random rnd = new Random();
    }
}
