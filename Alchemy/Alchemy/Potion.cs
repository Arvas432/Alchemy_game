using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    internal enum PotionType
    {
        blackpoison,
        dragonsmaw,
        firebomb,
        grosssludge,
        healingdrink,
        helishbrew,
        strongpoison,
        vampiricpotion,
        weakpoison
    }

    internal class Potion
    {
        public Potion(string name, string description, int dmg, int regen, PotionType type)
        {
            Name = name;
            Description = description;
            Dmg = dmg;
            Regen = regen;
            Type = type;
        }
        public string Name { get; set; }
        public PotionType Type { get; set; }
        public override string ToString()
        {
            return $"{Name}/{Description}/{Dmg}/{Regen}/{(int)Type}";
        }
        public static Potion FromString(string input)
        {
            List<string> data = new List<string>(input.Split('/'));
            return new Potion(data[0], data[1],int.Parse(data[2]),int.Parse(data[3]),(PotionType)(int.Parse(data[4])));
        }
        public string Description { get; set; }
        public int Dmg { get; set; }
        public int Regen { get; set; }
    }
}



