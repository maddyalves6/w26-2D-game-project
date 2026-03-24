using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            
            // if dino is aligned with spikes vertically (DOESN'T WORK FOR SOME REASON. SORRY.)
            if (spikePos[0] > Dino.GetDinoX()-10 && spikePos[0] < Dino.GetDinoX()+10)
            {
                Debug.WriteLine("tes");
                // if dino is colliding with spikes
                if (spikePos[1] == 290 && Dino.GetDinoY() > 270)
                {
                    Console.WriteLine("tes");
                    Dino.SetDinoX(-400); // move dino offscreen as a pseudo-game over (no time, sorry)
                }
                else if (spikePos[1] != 290 && Dino.GetDinoY() < spikePos[1] + 5)
                {
                    Dino.SetDinoX(-400);
                }
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
