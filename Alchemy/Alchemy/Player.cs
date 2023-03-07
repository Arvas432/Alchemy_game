using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    class Player
    {
        public Player(int hp, int gold)
        {
            Hp = hp;
            Gold = gold;
        }
        public Player()
        {

        }
        private MyIO IO = new MyIO();
        public List<Ingredient> PlayerIngredients = new List<Ingredient>();
        public List<Potion> PlayerPotions = new List<Potion>();
        public int Gold { get; set; }
        public int Hp
        {
            get
            {
                return _hp;
            }
            set
            {
                if (value <= 0)
                {
                    _hp = 0;
                }
                else
                {
                    _hp = value;
                }
            }
        }
        public void PrintIngredientsInfo()
        {
            int num = 1;
            IO.Println("");
            IO.Println("Твои ингредиенты", ConsoleColor.Magenta);
            IO.Println("");
            foreach (var a in PlayerIngredients)
            {
                IO.Print("-");
                IO.Print($"{num}.");
                IO.Println(a.Name);
                num++;
            }
            IO.Println("");
        }
        public void PrintPotionsInfo()
        {
            int num = 1;
            IO.Println("Твои зелья", ConsoleColor.Magenta);
            foreach (var a in PlayerPotions)
            {
                IO.Print($"{num}.");
                IO.Println(a.Name, ConsoleColor.Green);
                IO.Println(a.Description);
                IO.Println("-----------------------------------------");
                num++;
            }
        }
        public void ChangeGold(int amount)
        {
            Gold += amount;
        }
        public void AddPotion(Potion potion)
        {
            PlayerPotions.Add(potion);
        }
        public void AddIngredient(Ingredient ingredient)
        {
            PlayerIngredients.Add(ingredient);
        }
        private int _hp;
    }
}

