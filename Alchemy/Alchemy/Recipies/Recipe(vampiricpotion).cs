using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alchemy.Ingredients;
using Alchemy.Potions;

namespace Alchemy.Recipies
{
    class Recipe_vampiricpotion_:Recipe
    {
        public Recipe_vampiricpotion_()
        {
            Ingredients.Add(new Ingredient_vampiredust_());
            Ingredients.Add(new Ingredient_hagravenclaw_());
            Ingredients.Add(new Ingredient_water_());
        }
        public override Potion GetPotion()
        {
            return new Potion_vampiricpotion_();
        }
    }
}
