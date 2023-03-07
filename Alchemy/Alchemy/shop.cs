using Alchemy.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    internal static class shop
    {
       
        private static MyIO IO = new MyIO();
        public static void BuyIngredient(Player pl)
        {

            int i;
            bool shopping = true;
            string input = null;
            bool check = false;
            int result;
            while (shopping)
            {
                i = 1;
                IO.Println($"У вас {pl.Gold} Золота", ConsoleColor.Green);
                IO.Println("Купить ингредиент:");
                foreach (var a in Gamemechanics.ExistingIngredients)
                {
                    IO.Print($"{i}.");
                    IO.Println($"{a.Name} ({a.Price}) золота", ConsoleColor.Yellow);
                    i++;
                }
                IO.Println($"{i}. Выход", ConsoleColor.Red);
                input = IO.ReadString();
                check = int.TryParse(input, out result);
                if (check && result >= 1 && result <= Gamemechanics.ExistingIngredients.Count)
                {
                    if (pl.Gold < Gamemechanics.ExistingIngredients[result - 1].Price)
                    {
                        IO.Println("Вам не хватает денег", ConsoleColor.Red);
                        IO.ReadString();
                        Console.Clear();
                    }
                    else
                    {
                        pl.AddIngredient(Gamemechanics.ExistingIngredients[result - 1]);
                        pl.ChangeGold(-Gamemechanics.ExistingIngredients[result - 1].Price);
                        shopping = false;
                        IO.Println("Покупка прошла успешно", ConsoleColor.Green);
                        IO.ReadString();
                        Console.Clear();
                    }
                }
                else if (result == Gamemechanics.ExistingIngredients.Count + 1)
                {
                    shopping = false;
                    Console.Clear();
                }
                else
                {
                    IO.Println("НИЗЯ");
                    IO.ReadString();
                    Console.Clear();
                }
            }
        }
    }
}
