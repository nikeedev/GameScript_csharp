using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace GameScript.Codes
{    
    public class CreateGame
    {

        public static string VersionNow = "1.2.0"; 


        public static void PaintGame(Vector2 position, string player, Vector2 worldSize) {
            string spaces = new string(' ', player.Length);
            Console.Title = "                        {                                                             GameScript::Paint -------------  v"+VersionNow+"                                                            }       ";
            for (int j=0; j < worldSize.y; j++) {
                for (int i=0; i < worldSize.x; i++) {
                    Console.Write("  ");
                    if (i == position.x - 1) {
                        if (j == position.y) {
                            Console.Write(player + spaces);
                            i += 1;
                        }
                    }
                }
                Console.WriteLine("");

            }
        }
    }
}