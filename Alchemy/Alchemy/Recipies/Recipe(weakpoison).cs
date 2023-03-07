using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alchemy.Ingredients;
using Alchemy.Potions;

namespace Alchemy.Recipies
{
    class Recipe_weakpoison_:Recipe
    {
        public Recipe_weakpoison_()
        {
            Ingredients.Add(new Ingredient_moss_());
            Ingredients.Add(new Ingredient_poisonousbellflower_());
            Ingredients.Add(new Ingredient_water_());
        }
        public override Potion GetPotion()
        {
            return new Potion_weakpoison_();
        }
    }
}
