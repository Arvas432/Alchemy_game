using Alchemy.Ingredients;
using Alchemy.Recipies;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    internal class Gamemechanics
    {
        private MyIO IO = new MyIO();
        private Crafting crafting = new Crafting();
        private Combat combat = new Combat();
        private bool playing = true;
        public static List<Recipe> baserecipes = new List<Recipe>()
        {
            new Recipe_blackpoison_(),
            new Recipe_dragonsmaw_(),
            new Recipe_firebomb_(),
            new Recipe_grosssludge_(),
            new Recipe_healingdrink_(),
            new Recipe_helishbrew_(),
            new Recipe_strongpoison_(),
            new Recipe_vampiricpotion_(),
            new Recipe_weakpoison_()
        };
        public static List<Ingredient> ExistingIngredients = new List<Ingredient>() {
            new Ingredient_bearsclaw_(),
            new Ingredient_blackpowder_(),
            new Ingredient_bluemountainflower_(),
            new Ingredient_butterflywing_(),
            new Ingredient_dragonstounge_(),
            new Ingredient_giantstoe_(),
            new Ingredient_hagravenclaw_(),
            new Ingredient_moss_(),
            new Ingredient_poisonousbellflower_(),
            new Ingredient_ratshide_(),
            new Ingredient_vampiredust_(),
            new Ingredient_water_()
        };
        public void Game()
        {
            string input;
            bool check = false;
            Player player = null;
            int result = 0;
            int result2 = 0;
            while (!check || (result2 != 1 && result2 != 2))
            {
                check = false;
                IO.Println("1. Новая игра", ConsoleColor.Magenta);
                IO.Println("2. Загрузить старое сохранение", ConsoleColor.Magenta);
                input = IO.ReadString();
                check = int.TryParse(input, out result2);
                if (check)
                {
                    switch (result2)
                    {
                        case 1:
                            player = new Player(500, 2000);
                            break;
                        case 2:
                            Save save = new Save();
                            player = save.GetPlayer();
                            break;
                        default:
                            check = false;
                            Console.Clear();
                            break;
                    }
                }
            }
            Console.Clear();
            while (playing)
            {
                check = false;
                while (!check || playing)
                {
                    IO.Println("Выберите что хотите делать");
                    IO.Println("1.Крафт зелий", ConsoleColor.Magenta);
                    IO.Println("2.Бой", ConsoleColor.Red);
                    IO.Println("3.Магазин", ConsoleColor.Yellow);
                    IO.Println("4.Сохранить прогресс", ConsoleColor.Cyan);
                    IO.Println("5.Выйти", ConsoleColor.DarkRed);
                    input = IO.ReadString();
                    check = int.TryParse(input, out result);

                    if (check && result >= 1 && result <= 5)
                    {
                        switch (result)
                        {
                            case 1:
                                Potion p = crafting.CraftPotion(player);
                                if (p != null)
                                {
                                    player.PlayerPotions.Add(p);
                                }
                                break;
                            case 2:
                                combat.Fight(player);
                                break;
                            case 3:
                                shop.BuyIngredient(player);
                                break;
                            case 4:
                                Save save = new Save(player);
                                save.SaveToFile();
                                Console.Clear();
                                break;
                            case 5:
                                playing = false;
                                break;
                        }
                    }
                    else
                    {
                        IO.Println("Введите еще");
                        Console.Clear();
                    }
                    if (player.Hp <= 1)
                    {
                        playing = false;
                    }
                }
            }
            if (player.Hp <= 0)
            {
                IO.Println("ВЫ Проиграли", ConsoleColor.Red);
            }

        }
    }
}