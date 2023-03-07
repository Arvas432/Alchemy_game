using Alchemy.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alchemy.Ingredients;

namespace Alchemy
{
    internal class Combat
    {
        Random rnd = RandomGenerator.getInstance();
        private MyIO iO = new MyIO();
        public void Fight(Player player)
        {
            int BattleChance = rnd.Next(0, 4);
            switch (BattleChance)
            {
                case 0:
                    Battle(player, new Enemies_BigBugay_());
                    break;
                case 1:
                    Battle(player, new Enemies_EvilPasina_());
                    break;
                case 2:
                    Battle(player, new Enemies_RabidBear_());
                    break;
                case 3:
                    Battle(player, new Enemies_Leha_());
                    break;
            }
        }
        public void Battle(Player pl, Enemy en)
        {
            bool fighting = true;
            string input;
            bool check = false;
            int result;
            
                iO.Println($"Вы видите существо {en.Name} с ({en.HP}) Здоровья!", ConsoleColor.Magenta);
                while (fighting)
                {
                    if (pl.PlayerPotions.Count == 0 && en.HP > 0)
                    {
                        iO.Println("У вас Закончились зелья побег из боя", ConsoleColor.Red);
                        iO.ReadString();
                        Console.Clear();
                        fighting = false;
                    }
                    if (en.HP <= 0 && pl.Hp >=1)
                    {
                        iO.Println("Вы побеждаете и получаете:", ConsoleColor.Green);
                        iO.Println($"{en.Givengold} Золота", ConsoleColor.Yellow);
                        int chance = rnd.Next(1,101);
                        int lootcount;
                        List<Ingredient> givableingredients = new List<Ingredient>();
                        givableingredients.Add(new Ingredient_bearsclaw_());
                        givableingredients.Add(new Ingredient_blackpowder_());
                        givableingredients.Add(new Ingredient_bluemountainflower_());
                        givableingredients.Add(new Ingredient_butterflywing_());
                        givableingredients.Add(new Ingredient_dragonstounge_());
                        givableingredients.Add(new Ingredient_giantstoe_());
                        givableingredients.Add(new Ingredient_hagravenclaw_());
                        givableingredients.Add(new Ingredient_moss_());
                        givableingredients.Add(new Ingredient_poisonousbellflower_());
                        givableingredients.Add(new Ingredient_ratshide_());
                        givableingredients.Add(new Ingredient_vampiredust_());
                        givableingredients.Add(new Ingredient_water_());
                        if(chance >=90)
                        {
                            lootcount = en.Level + 4;
                        }
                        else if(chance >= 80)
                        {
                            lootcount = en.Level + 3;
                        }
                        else if(chance >= 60)
                        {
                            lootcount = en.Level + 2;
                        }
                        else
                        {
                            lootcount = en.Level + 1;
                        }
                        for(int i = 0; i< lootcount;i++)
                        {
                            Ingredient given = givableingredients[rnd.Next(givableingredients.Count)];
                            iO.Println($"Вы получили {given.Name}",ConsoleColor.Cyan);
                            pl.PlayerIngredients.Add(given);
                        }
                        pl.Gold += en.Givengold;
                        iO.ReadString();
                        Console.Clear();
                        fighting = false;
                    }
                    if (fighting)
                    {
                        iO.Println($"Выберите что делать");
                        iO.Println($"1. -Бежать");
                        iO.Println($"2. -Остаться и биться");
                        input = iO.ReadString();
                        Console.Clear();
                        check = int.TryParse(input, out result);
                        if (check && (result == 1 || result == 2))
                        {
                            if (result == 1)
                            {
                                iO.Println("Вы сбежали из боя", ConsoleColor.Red);
                                iO.ReadString();
                                Console.Clear();
                                fighting = false;
                            }
                            else if (result == 2)
                            {
                                PLayerTurn(pl, en);
                                iO.Println($"{en.Name} наносит вам {en.Dmg} урона", ConsoleColor.Red);
                                pl.Hp -= en.Dmg;
                                iO.ReadString();
                                Console.Clear();
                            }
                        }
                        else
                        {
                            iO.Println("Введите еще раз");
                            iO.ReadString();
                            Console.Clear();
                        }
                    }
                }
        }
        public Potion PlayerChoosePotion(Player pl)
        {
            bool check = false;
            bool choosing = true;
            int num;
            string input;
            Potion result = null;
            int i;
            while (choosing)
            {
                if (pl.PlayerPotions.Count > 0)
                {
                    iO.Println("Выберите Зелье которое хотите использовать", ConsoleColor.Magenta);
                    iO.Println("");
                    i = 1;
                    foreach (var a in pl.PlayerPotions)
                    {
                        iO.Print($"{i}.");
                        iO.Println($"{a.Name} {a.Dmg} урона, {a.Regen} Реген", ConsoleColor.Cyan);
                        i++;
                    }

                    input = iO.ReadString();
                    check = int.TryParse(input, out num);
                    if (!check || num < 1 || num > pl.PlayerPotions.Count + 1)
                    {
                        iO.Println("введите еще раз");
                        iO.ReadString();
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        if (check && num >= 1 && num <= pl.PlayerPotions.Count)
                        {
                            result = pl.PlayerPotions[num - 1];
                            choosing = false;
                        }
                    }
                }
                else
                {
                    choosing = false;
                    return null;
                }
            }
            return result;
        }
        public void PLayerTurn(Player player, Enemy enemy)
        {
            iO.Println($"У вас {player.Hp} Здоровья", ConsoleColor.Blue);
            iO.Println($"У врага {enemy.HP} Здоровья,", ConsoleColor.Red);
            Potion attackingpotion = PlayerChoosePotion(player);
            player.PlayerPotions.Remove(attackingpotion);
            player.Hp += attackingpotion.Regen;
            enemy.HP -= attackingpotion.Dmg;
        }
    }
}
