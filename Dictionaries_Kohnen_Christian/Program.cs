using System;
using System.Collections;
using System.Collections.Generic;

namespace Disctionaries_Kohnen_Christian
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> topGames = new Dictionary<int, string>();   //creates a dictionary of favorite games
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

            foreach(KeyValuePair <int, string> kvp in topGames)                 //for each key in the list, print the name and key of the game
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            if (topGames.ContainsKey(1))                                        //if the game's key is 1, print that it is my favorite game
            {
                Console.WriteLine($"My favorite game is: {topGames[1]}");
            }

            string result = "";                                                 //creates empty string

            topGames.TryGetValue(11, out result);                               //treies to get a key number of 11

            if(result != "")                                                    //if there is something in the string, it prints the result
            {
                Console.WriteLine(result);
            }
            else                                                                //otherwise, there is no number 11
            {
                Console.WriteLine("There is no 11th game.");
            }

            if (topGames.ContainsKey(5))                                        //if there is a key of number 5, replaces it with Resident evil 6
            {
                topGames[5] = "Resident Evil 6";
            }

            Console.Write(topGames[5]);                                         // print number 5

            Hashtable hashTable = new Hashtable(topGames);                      //creates hashtable and is equal to topGame

            string faveGame = (string)hashTable[1];                             //creates string called faveGame

            Console.WriteLine($"Favorite Game: {faveGame}");                    //write faveGame

            Hashtable capital = new Hashtable() {                               //creates hastable for states and their capitals
                { "Oklahoma", "Oklahoma City" },
                { "New York", "Albany" },
                { "Masachusets", "Boston" },
                { "Texas", "Austin" },
                { "Ohio", "Colombus" },
            };

            foreach (DictionaryEntry kvp in capital)                            //for each state, write the key and the value
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            capital.Clear();                                                    //clears hastable
        }
    }
}