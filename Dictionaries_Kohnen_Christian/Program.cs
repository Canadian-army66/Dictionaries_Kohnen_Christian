using System;
using System.Collections;
using System.Collections.Generic;

namespace Disctionaries_Kohnen_Christian
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> topGames = new Dictionary<int, string>();
            topGames.Add(1, "Titanfall 2");
            topGames.Add(2, "Helldivers 2");
            topGames.Add(3, "Space Marines 2");
            topGames.Add(4, "Frostpunk");
            topGames.Add(5, "Ace Combat 7");
            topGames.Add(6, "Red Dead Redemption 2");
            topGames.Add(7, "I Love You, Colonel Sanders!");
            topGames.Add(8, "Phasmaphobia");
            topGames.Add(9, "Kona: Brume");
            topGames.Add(10, "Jurassic World: Evolution");

            foreach(KeyValuePair <int, string> kvp in topGames)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            if (topGames.ContainsKey(1))
            {
                Console.WriteLine($"My favorite game is: {topGames[1]}");
            }

            string result = "";

            topGames.TryGetValue(11, out result);

            if(result != "")
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("There is no 115th game.");
            }

            if (topGames.ContainsKey(5))
            {
                topGames[5] = "Resident Evil 6";
            }

            Console.Write(topGames[5]);

            Hashtable hashTable = new Hashtable(topGames);

            string faveGame = (string)hashTable[1];

            Console.WriteLine($"Favorite Game: {faveGame}");

            Hashtable capital = new Hashtable() {
                { "Oklahoma", "Oklahoma City" },
                { "New York", "Albany" },
                { "Masachusets", "Boston" },
                { "Texas", "Austin" },
                { "Ohio", "Colombus" },
            };

            foreach (DictionaryEntry kvp in capital)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            capital.Clear();
        }
    }
}