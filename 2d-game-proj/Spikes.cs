using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class Spikes
    {
        Dino Dino = new Dino();
        Vector2 spikePos;

        public void Spawn(float y)
        {
            spikePos = new Vector2(800, y);
            Step(0);
        }

        public void Step(float by)
        {
            spikePos[0] += by;
            
            if (spikePos[0] > Dino.GetDinoX()-20 && spikePos[0] < Dino.GetDinoY()+20)
            {

            }

            DrawSpike(spikePos);
        }

        public void DrawSpike(Vector2 at)
        {
            float x = at[0];
            float y = at[1];

            Draw.FillColor = Color.Black;
            if (y == 290)
            {
                Draw.Triangle(x, y - 5, x - 17, y + 30, x + 17, y + 30);
            }
            else
            {
                Draw.Triangle(x, y + 5, x - 17, y - 30, x + 17, y - 30);
                Draw.Rectangle(x - 17, 0, 17 * 2, y - 30);
            }
        }
    }
}
