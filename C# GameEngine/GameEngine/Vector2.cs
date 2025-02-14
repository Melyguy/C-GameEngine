using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__GameEngine.GameEngine
{
    public class Vector2
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vector2()
        {
             X = Zero().X;
             Y = Zero().Y;

        }
        public Vector2(float x, float y)
        {
            this.X = X;
            this.Y = Y;
        }


        /// <summary>
        /// Returns a new Vector2 with the values of 0,0
        /// </summary>
        /// <returns></returns>
        public static Vector2 Zero()
        {
            return new Vector2(0,0);
        }
    }
}
