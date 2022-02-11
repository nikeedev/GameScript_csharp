using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace gameScript.Codes
{    
    public class CreateGame
    {

        public static string VersionNow = "v.0.0.4"; 


        public static void PaintGame(Vector2 Position, string Player, Vector2 WorldSize) {
            string spaces = new string(' ', Player.Length);
            Console.Title = "                        {                                                             GameScript::Paint -------------  "+VersionNow+"                                                            }       ";
            for (int j=0; j < WorldSize.y; j++) {
                for (int i=0; i < WorldSize.x; i++) {
                    Console.Write("  ");
                    if (i == Position.x - 1) {
                        if (j == Position.y) {
                            Console.Write(Player + spaces);
                            i += 1;
                        }
                    }
                }
                Console.WriteLine("");

            }
        }
    }
}