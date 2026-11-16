using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class Crosshair
    {
        public void Setup()
        {

        }
        public Vector2 mousepos;
        public void Update()
        {
            Color csColor = new Color(243, 0, 0, 159);
            mousepos = Input.GetMousePosition();
            Draw.FillColor = csColor;
            Draw.LineSize = 0;
            Draw.Circle(mousepos, 5);
        }
    }
}
