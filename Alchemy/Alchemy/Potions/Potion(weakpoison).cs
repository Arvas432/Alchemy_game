using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy.Potions
{
    class Potion_weakpoison_:Potion
    {
        public Potion_weakpoison_():base("слабый яд","наносит противнику 50 урона ядом и моральный ущерб",50,0,PotionType.weakpoison)
        {

        }
    }
}
