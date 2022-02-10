using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using gameScript.Codes;

namespace gameScript
{
    public class Program
    {
        
        static void Main(string[] args)
        {
        
            Vector2 worldSize = new Vector2(4, 4);
            Vector2 position = new Vector2(worldSize.x/2, worldSize.y/2);
            
            char player = '*';

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            CreateGame.PaintGame(position, player, worldSize);
            Console.ReadLine();
        }
    }

    
}
