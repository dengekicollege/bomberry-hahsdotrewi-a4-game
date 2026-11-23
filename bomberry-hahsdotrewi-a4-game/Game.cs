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

        Bases bases = new Bases();

        Cannon cannon = new Cannon();

        Missile missile = new Missile();

        public Vector2 mouseclickpos = Vector2.Zero;
        public void Setup()
        {
            Window.SetTitle("Intercontinental Ballistic Defences");

            Window.SetSize(1280, 720);

            Draw.Circle(mouseclickpos, 50);

            crosshair.Setup();

            bases.Setup();

            cannon.Setup();

            //missile.Setup();
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            Window.ClearBackground(240, 140, 0);
            // draw the ground where the cannon and bases sit
            Draw.FillColor = Color.Black;
            Draw.Rectangle(0, Window.Height / 1.5f, 1280, Window.Height);

            crosshair.Update();
            bases.Update();
            //get position of last click
            if(Input.IsKeyboardKeyPressed(KeyboardKey.Space) == true)
            {
                mouseclickpos = Input.GetMousePosition();
            }
            
            Draw.FillColor = Color.OffWhite;
            Draw.Circle(mouseclickpos, 50);
            Console.WriteLine(mouseclickpos.X);
            Console.WriteLine(mouseclickpos.Y);

            cannon.Update();

            missile.Render();

            missile.Setup(cannon.centerscreen, );
            
        }
    }

}
