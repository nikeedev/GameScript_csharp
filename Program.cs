using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using GameScript.Codes;

namespace GameScript
{
    public static class Program
    {
        static void Main(string[] args)
        {
            
            Vector2 worldSize = new Vector2(5, 5);
            Vector2 position = new Vector2(2, 2);
            
            string player = "#";

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            CreateGame.PaintGame(position, player, worldSize);
            
            Console.ReadLine();
        }
    }
}
