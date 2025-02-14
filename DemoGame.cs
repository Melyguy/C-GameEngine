using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__GameEngine.C_engine;
using C__GameEngine.GameEngine; // Ensure this line is present

namespace C__GameEngine
{
    class DemoGame : C__GameEngine.C_engine.gameEngine
    {
        public DemoGame() : base(new Vector2(615, 515), "Engine Demo")
        {

        }
    }
}
