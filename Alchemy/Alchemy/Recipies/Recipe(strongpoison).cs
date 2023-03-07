using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alchemy.Ingredients;
using Alchemy.Potions;

namespace Alchemy.Recipies
{
    class Recipe_strongpoison_:Recipe
    {
        public Recipe_strongpoison_()
        {
            Ingredients.Add(new Ingredient_poisonousbellflower_());
            Ingredients.Add(new Ingredient_vampiredust_());
            Ingredients.Add(new Ingredient_hagravenclaw_());
        }
        public override Potion GetPotion()
        {
            return new Potion_strongpoison_();
        }
    }
}
