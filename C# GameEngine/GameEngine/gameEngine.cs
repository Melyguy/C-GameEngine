using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using C__GameEngine.GameEngine; // Ensure this line is present

namespace C__GameEngine.C_engine
{
    class Canvas : Form
    {
        public Canvas()
        {
            this.DoubleBuffered = true;
        }
    }

    public abstract class gameEngine
    {
        private Vector2 ScreenSize = new Vector2(512, 512);
        private string Title = "Game";
        private Canvas Window;

        public gameEngine(Vector2 ScreenSize, string Title)
        {
            this.ScreenSize = ScreenSize;
            this.Title = Title;

            Window = new Canvas();
            Window.Size = new Size((int)this.ScreenSize.X, (int)this.ScreenSize.Y);
            Window.Text = this.Title;

            Application.Run(Window);
        }
    }
}
