using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alchemy.Potions;

namespace Alchemy.Recipies
{
    internal class Recipe_blackpoison_ : Recipe
    {
        public Recipe_blackpoison_()
        {
            Ingredients.Add(new Ingredient_poisonousbellflower_());
            Ingredients.Add(new Ingredient_hagravenclaw_());
            Ingredients.Add(new Ingredient_bluemountainflower_());
        }
        public override Potion GetPotion()
        {
            //return new BlackPotion();
            //return new BlackPotion();`
            return new Potion_blackpoison_();
        }
    }
}
