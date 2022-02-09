using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace gameScript.Codes
{    
    public class CreateGame
    {
        
        public static void PaintGame(Vector2 Position, char Player, Vector2 WorldSize) {
            for (int j=0; j < WorldSize.y; j++) {
                for (int i=0; i < WorldSize.x; i++) {
                    Console.Write("  ");
                    if (i == Position.x) {
                        if (j == Position.y) {
                            Console.Write(Player);
                        }
                    }
                }
                Console.WriteLine("");

            }
        }
    }
}