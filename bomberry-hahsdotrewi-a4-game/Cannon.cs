using System;
using System.Numerics;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace MohawkGame2D;

public class Cannon
{
	public void Setup()
	{

	}

    public Vector2 centerscreen;
    public void Update()
	{
		
		Draw.LineColor = Color.OffWhite;
		Draw.LineSize = 50;
		Draw.Line(Window.Width / 2, Window.Height / 1.5f, Window.Width / 2, 400);
		Draw.LineSize = 0;
		//Shoot
        if (Input.IsKeyboardKeyPressed(KeyboardKey.A))
        {
			Vector2 mouseclickpos = Input.GetMousePosition();
			centerscreen.X = Window.Width / 2;
			centerscreen.Y = Window.Height / 2;
			//angle to target
			Vector2 vectorFromCannonToTarget = mouseclickpos -= centerscreen;
			float y = vectorFromCannonToTarget.Y;
			float x = vectorFromCannonToTarget.X;
			//angle in radians
			float angleFromCannonToTarget = MathF.Atan2(y, x);
			Vector2 dir = new Vector2(MathF.Cos(angleFromCannonToTarget), MathF.Sin(angleFromCannonToTarget));
        }
    }
}
