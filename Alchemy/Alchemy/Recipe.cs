using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    internal class Recipe
    {

        public Recipe(List<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }
        public Recipe()
        {

        }
        public List<Ingredient> Ingredients = new List<Ingredient>();
        public static bool operator ==(Recipe r1, Recipe r2)
        {
          
            if (r1.Ingredients.Count != r2.Ingredients.Count) return false;
            int ingredientslast = r2.Ingredients.Count;
            for (int i = 0; i < r1.Ingredients.Count; i++)
            {
                for (int j = 0; j < r2.Ingredients.Count; j++)
                {
                    if (r1.Ingredients[i] == r2.Ingredients[j])
                    {
                        ingredientslast--;
                    }
                }
            }
            return ingredientslast == 0;
        }
        public static bool operator !=(Recipe r1, Recipe r2)
        {
            return !(r1 == r2);
        }
        public virtual Potion GetPotion()
        {
            return null;
        }
        public override string ToString()
        {
            String result = "";
            foreach (Ingredient i in Ingredients)
            {
                result += i.Name + ", ";
            }
            if (result.Length > 0)
                result = result.Substring(0, result.Length - 2);
            return result;
        }
    }
}
