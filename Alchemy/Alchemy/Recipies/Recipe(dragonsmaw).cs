using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alchemy.Ingredients;
using Alchemy.Potions;

namespace Alchemy.Recipies
{
    class Recipe_dragonsmaw_:Recipe
    {
        public Recipe_dragonsmaw_()
        {
            Ingredients.Add(new Ingredient_dragonstounge_());
            Ingredients.Add(new Ingredient_bearsclaw_());
            Ingredients.Add(new Ingredient_water_());
        }
        public override Potion GetPotion()
        {
            return new Potion_dragonsmaw_();
        }
    }
}
