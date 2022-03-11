using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace GameScript.Codes
{
    public class Vector2 {

        /// <summary>
        /// This is X value which can be used for width
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// This is Y value which can be used for height
        /// </summary>
        public int y { get; set; }


        /// <summary>
        /// This data type has two values: x and y axis
        /// </summary>
        public Vector2(int x, int y) {
            this.x = x;
            this.y = y;
        }
        

    }
}