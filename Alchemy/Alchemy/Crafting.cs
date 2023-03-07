using Alchemy.Recipies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    internal class Crafting
    {
        private MyIO IO = new MyIO();
        public Potion CraftPotion(Player pl)
        {
            List<Ingredient> inputingredients = new List<Ingredient>();
            List<Ingredient> playeringredients = new List<Ingredient>(pl.PlayerIngredients);
            bool check = false;
            bool crafting = true;
            string input = null;
            int num = 0;
            int i;
            while (crafting)
            {
                i = 1;
                IO.Println("положенные ингредиенты:");
                foreach (var a in inputingredients)
                {
                    IO.Println($"-{a.Name} ", ConsoleColor.Cyan);
                }
                IO.Println("Выбери ингредиенты для зелья:");
                foreach (var a in playeringredients)
                {
                    IO.Print($"-{i}.");
                    IO.Println($"{a.Name}");
                    i++;
                }
                IO.Print($"-{playeringredients.Count + 1}");
                IO.Println(" stop", ConsoleColor.Red);
                IO.Println("");
                input = IO.ReadString();
                check = int.TryParse(input, out num);
                if (!check || num < 1 || num > playeringredients.Count + 2)
                {
                    IO.Println("введите еще раз");
                    IO.ReadString();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    if (check && num >= 1 && num <= playeringredients.Count + 1)
                    {
                        if (num == playeringredients.Count + 1)
                        {
                            crafting = false;
                        }
                        else
                        {
                            inputingredients.Add(playeringredients[num - 1]);
                            playeringredients.RemoveAt(num - 1);
                            check = false;
                        }
                    }
                }
            }
            Recipe InputRecipe = new Recipe(inputingredients);
            bool craftingfail = true;
            foreach (Recipe a in Gamemechanics.baserecipes)
            {
                if (a == InputRecipe)
                {
                    craftingfail = false;
                    IO.Println($"Варка прошла успешно");
                    Potion result = a.GetPotion();
                    IO.Print("Вы сварили:");
                    IO.Println($"{result.Name}", ConsoleColor.Green);
                    IO.ReadString();
                    pl.PlayerIngredients = playeringredients;
                    Console.Clear();
                    return result;

                }
            }
            if (craftingfail)
            {
                IO.Println($"Варка не удалась", ConsoleColor.Red);
                IO.ReadString();
                Console.Clear();
                return null;
            }
            return null;
        }
    }

}
