using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alchemy.Ingredients;
using Alchemy.Potions;

namespace Alchemy.Recipies
{
    class Recipe_firebomb_:Recipe
    {
        public Recipe_firebomb_()
        {
            Ingredients.Add(new Ingredient_blackpowder_());
            Ingredients.Add(new Ingredient_vampiredust_());
            Ingredients.Add(new Ingredient_ratshide_());
        }
        public override Potion GetPotion()
        {
            return new Potion_firebomb_();
        }
    }
}
