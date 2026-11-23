using System;
using System.Numerics;
using System.IO;

namespace MohawkGame2D;

public class Missile
{
	Vector2 position = Vector2.UnitX * 100000;

	Vector2 velocity;

	public void Setup(Vector2 position, Vector2 velocity)
	{
		this.position = position;

		this.velocity = velocity;
	}
	public void UpdatePosition() 
	{
		position += velocity * Time.DeltaTime;
	}
	public void Render() 
	{
		if (Input.IsKeyboardKeyPressed(KeyboardKey.A) == true) {
			Vector2 mouseclickpos = Input.GetMousePosition();
			if (position.Y <= mouseclickpos.Y) {
				Draw.LineSize = 0;
				Draw.FillColor = Color.Black;
				Draw.Circle(position, 5);
				
			}
		}
	}
}
