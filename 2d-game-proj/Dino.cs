using System;
using System.Numerics;

namespace MohawkGame2D
{
    public class Dino
    {
        float dinoX = 0;
        float dinoY = 0;
        float velocityY = 0;
        bool stepping = false; // determines which leg of the dino is raised
        int steppingTimer = 4; // frames until next step

        public void DrawDino(float x, float y)
        {

            // draw body and legs
            Draw.FillColor = Color.Black;
            Draw.Rectangle(x - 25, y - 30, 50, 40);
            if (stepping)
            {
                Draw.Rectangle(x - 18, y + 10, 4, 10);
                Draw.Rectangle(x + 14, y + 10, 4, 20);
            }
            else
            {
                Draw.Rectangle(x - 18, y + 10, 4, 20);
                Draw.Rectangle(x + 14, y + 10, 4, 10);
            }

            // draw eyes
            Draw.FillColor = Color.White;
            Draw.Rectangle(x - 10, y - 12, 4, 4);
            Draw.Rectangle(x + 10, y - 12, 4, 4);

            // decrement steppingTimer and flip stepping if 0
            steppingTimer--;
            if (steppingTimer == 0)
            {
                stepping = !stepping; // switch which leg is raised
                steppingTimer = 4;
            }
        }

        // run a physics step, then draw the dino at the final position
        public void Step()
        {
            dinoY += velocityY;

            if (dinoY > 290) // if dino is below floor
            {
                dinoY = 290;
                velocityY = 0;
            }
            else
            {
                velocityY += 1;
            }

            DrawDino(dinoX, dinoY);
        }

        // dino position getters/setters
        public float GetDinoX() { return dinoX; }
        public float GetDinoY() { return dinoY; }
        public Vector2 GetDinoXY() { return new Vector2(dinoX, dinoY); }
        public void SetDinoX(float x) { dinoX = x; }
        public void SetDinoY(float y) { dinoY = y; }
        public void SetDinoYVel(float yvel) { velocityY = yvel; }
    }
}
