using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alchemy.Ingredients;
using Alchemy.Potions;

namespace Alchemy.Recipies
{
    class Recipe_grosssludge_:Recipe
    {
        public Recipe_grosssludge_()
        {
            Ingredients.Add(new Ingredient_giantstoe_());
            Ingredients.Add(new Ingredient_hagravenclaw_());
            Ingredients.Add(new Ingredient_moss_());
            Ingredients.Add(new Ingredient_ratshide_());
        }
        public override Potion GetPotion()
        {
            return new Potion_grosssludge_();
        }
    }
}
