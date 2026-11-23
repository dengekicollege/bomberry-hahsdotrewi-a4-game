using System;
using System.Numerics;
using System.IO;

namespace MohawkGame2D
{
	public class Bases
	{
		public void Setup()
		{

        }
        public bool basefella = true;


        public bool baseguy = true;

        public void Update()
		{

			Draw.FillColor = Color.OffWhite;

			if (basefella == true)
			{
				Draw.Rectangle(Window.Width / 3, Window.Height / 1.65f, 50, 50);
			}

            if (baseguy == true)
            {
                Draw.Rectangle(Window.Width / 1.5f, Window.Height / 1.65f, 50, 50);
            }
            if (Input.IsKeyboardKeyPressed(KeyboardKey.A))
            {
				basefella = false;
                baseguy = false;
            }


            //Draw.Rectangle(Window.Width / 1, Window.Height / 1.65f, 50, 50);
        }
		
		
	}
}