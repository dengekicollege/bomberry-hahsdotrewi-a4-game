// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.IO;
// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        Crosshair crosshair = new Crosshair();

        Vector2 mouseclickpos = Vector2.Zero;
        public void Setup()
        {
            Window.SetTitle("Intercontinental Ballistic Defences");

            Window.SetSize(1280, 720);

            Draw.Circle(mouseclickpos, 50);

            crosshair.Setup();
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            Window.ClearBackground(240, 140, 0);

            //Draw.FillColor = Color.Black;
            //Draw.Circle(Window.Width / 2, Window.Height / 2, 50);
            crosshair.Update();
            if(Input.IsKeyboardKeyPressed(KeyboardKey.Space) == true)
            {
                mouseclickpos = Input.GetMousePosition();
            }
            
            Draw.FillColor = Color.OffWhite;
            Draw.Circle(mouseclickpos, 50);
            Console.WriteLine(mouseclickpos.X);
            Console.WriteLine(mouseclickpos.Y);
        }
    }

}
