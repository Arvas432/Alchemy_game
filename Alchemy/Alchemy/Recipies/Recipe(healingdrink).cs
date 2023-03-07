using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alchemy.Ingredients;
using Alchemy.Potions;

namespace Alchemy.Recipies
{
    class Recipe_healingdrink_:Recipe
    {
        public Recipe_healingdrink_()
        {
            Ingredients.Add(new Ingredient_giantstoe_());
            Ingredients.Add(new Ingredient_bluemountainflower_());
            Ingredients.Add(new Ingredient_moss_());
        }
        public override Potion GetPotion()
        {
            return new Potion_healingdrink_();
        }
    }
}
