using System;

// The namespace your code is in.
namespace MohawkGame2D
{
	public class Floor
	{
		float relativeX = 0;

		// draw the floor at the current relativeX position
		public void DrawFloor()
		{
			for (int i = 0; i < 21; i++)
			{
				float originX = relativeX + (i * 40);

				Draw.FillColor = Color.Black;
				Draw.LineColor = new Color(230, 230, 230); // dark gray
				Draw.LineSize = 2;

				Draw.Rectangle(originX, 360, 40, 40);
                Draw.Rectangle(originX, 320, 40, 40);

				// draw floor details
				Draw.LineSize = 0;
				Draw.FillColor = Draw.LineColor;
				Draw.Rectangle(originX + 28, 320, 2, 80); // dividing line
				Draw.Rectangle(originX + 28, 370, 12, 2); // upper right lines
                Draw.Rectangle(originX + 28, 330, 12, 2);
				Draw.Rectangle(originX, 390, 28, 2); // lower left lines
				Draw.Rectangle(originX, 350, 28, 2);
            }
		}

		// Step the infinite floor's relativeX position "by" the given float, accounting for the looping, then DrawFloor()
		public void Step(float by)
		{
			relativeX += by;
			relativeX %= 40;
			DrawFloor();
		}
	}
}
