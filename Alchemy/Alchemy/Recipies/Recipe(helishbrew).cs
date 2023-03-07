using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alchemy.Ingredients;
using Alchemy.Potions;

namespace Alchemy.Recipies
{
    internal class Recipe_helishbrew_ : Recipe
    {
        public Recipe_helishbrew_()
        {
            Ingredients.Add(new Ingredient_dragonstounge_());
            Ingredients.Add(new Ingredient_blackpowder_());
            Ingredients.Add(new Ingredient_water_());
            Ingredients.Add(new Ingredient_moss_());
        }
        public override Potion GetPotion()
        {
            return new Potion_hellishbrew_();
        }
    }
}
