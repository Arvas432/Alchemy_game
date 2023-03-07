using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy.Potions
{
    class Potion_healingdrink_: Potion
    {
        public Potion_healingdrink_():base("исцеляющий напиток","напиток с освежающим привкусом грибка ногтей великана восстанавливает вам 400 здоровья",0,400,PotionType.healingdrink)
        {

        }
    }
}
