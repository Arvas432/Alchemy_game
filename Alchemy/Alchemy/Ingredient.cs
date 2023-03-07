using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    public class Ingredient
    {
        public Ingredient(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return $"{Name}/{Price}";
        }
        public static Ingredient FromString(string input)
        {
            List<string> data = new List<string>(input.Split('/'));
            //Ingredient result = new Ingredient(data[0], int.Parse(data[1]));
            //foreach (var a in Gamemechanics.ExistingIngredients)
            //{
            //    if(a == result)
            //    {
            //        return a;
            //    }
            //}
            return new Ingredient(data[0], int.Parse(data[1]));
        }
        public static bool operator == (Ingredient i1, Ingredient i2)
        {
            return i1.Name == i2.Name;
        }
        public static bool operator !=(Ingredient i1, Ingredient i2)
        {
            return !(i1 == i2);
        }
        public override bool Equals(object obj)
        {
            return obj.GetType() == this.GetType();
        }
        public bool EqualByName(string input)
        {
            return Name == input;
        }
    }
}
