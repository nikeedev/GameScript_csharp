using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace gameScript.Codes
{
    public class Vector2 {

        /// <summary>
        /// This is X value which can be used for widht
        /// </summary>
        public float x { get; set; }

        /// <summary>
        /// This is Y value which can be used for heigth
        /// </summary>
        public float y { get; set; }


        /// <summary>
        /// This data type has two values: x and y axes
        /// </summary>
        public Vector2(float x, float y) {
            this.x = x;
            this.y = y;
        }
        

    }
}