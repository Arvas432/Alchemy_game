using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    class Enemy
    {
        public Enemy(int hp, int dmg, string name,int givengold,int level)
        {
            HP = hp;
            Dmg = dmg;
            Name = name;
            Givengold = givengold;
            Level = level;
        }
        public int Level { get; set; }
        public string Name { get; set; }
        public int Givengold { get; set; }
        public int HP
        {
            get
            {
                return _hp;
            }
            set
            {
                if (value <= 0)
                {
                    _hp = 0;
                }
                else
                {
                    _hp = value;
                }
            }
        }
        public int Dmg { get; set; }
        private int _hp;
        
    }
}
