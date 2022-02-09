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
        
            Vector2 position = new Vector2(5, 5);
            Vector2 worldSize = new Vector2(10, 10);
            char player = '*';

            CreateGame.PaintGame(position, player, worldSize);
            Console.ReadLine();
        }
    }

    
}
