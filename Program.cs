using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameList = new List<string> { "The Sims", "Fallout", "World of Warcraft", "Beat Saber" };

            var gameOrderByLength = gameList.OrderBy(game => game.Length);

            Console.ReadLine();

            
            //use a for each loop to print to console. DO THAT NEXT
        }
    }
}
