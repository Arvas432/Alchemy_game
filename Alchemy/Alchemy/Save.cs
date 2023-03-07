using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Alchemy
{
    internal class Save
    {
        public Save(Player p)
        {
            player = p;
        }
        public Save()
        {
            player = new Player();
        }
        protected Player player;
        protected string path = "../../save.txt";

        public void LoadFromFile()
        {
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                List<string> data = new List<string>(sr.ReadLine().Split('|'));
                player.Hp = int.Parse(data[0]);
                player.Gold = int.Parse(data[1]);
                player.PlayerPotions = PotionsFromString(sr.ReadLine());
                player.PlayerIngredients = IngredientsFromString(sr.ReadLine());
            }
        }
        public Player GetPlayer()
        {
            LoadFromFile();
            return player;
        }
        public void SaveToFile()
        {
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                sw.WriteLine($"{player.Hp}|{player.Gold}");
                string potionsstring = "";
                foreach (var a in player.PlayerPotions)
                {
                    potionsstring += a.ToString() + "|";
                }
                if(potionsstring.Length>0)
                {
                    potionsstring = potionsstring.Substring(0, potionsstring.Length - 1);
                }
                sw.Write(potionsstring);
                sw.WriteLine();
                string ingredientsstring = "";
                foreach (var a in player.PlayerIngredients)
                {
                    ingredientsstring += a.ToString() + "|";
                }
                if (ingredientsstring.Length >0)
                {
                    ingredientsstring = ingredientsstring.Substring(0, ingredientsstring.Length - 1);
                }
                sw.WriteLine(ingredientsstring);
            }
        }
        public List<Ingredient> IngredientsFromString(string input)
        {

            List<Ingredient> output = new List<Ingredient>();
            if (string.IsNullOrEmpty(input)) return output;
            List<string> data = new List<string>(input.Split('|'));
            for (int i = 0; i < data.Count; i++)
            {
                output.Add(Ingredient.FromString(data[i]));
            }
            return output;
        }
        public List<Potion> PotionsFromString(string input)
        {
            List<Potion> output = new List<Potion>();
            if (string.IsNullOrEmpty(input)) return output;
            List<string> data = new List<string>(input.Split('|'));
            for (int i = 0; i < data.Count; i++)
            {
                output.Add(Potion.FromString(data[i]));
            }
            return output;
        }
    }
}
