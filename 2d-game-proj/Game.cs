// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    
    public class Game
    {
        Floor Floor = new Floor();

        // Setup runs once before the game loop begins.
        public void Setup()
        {
            Window.SetSize(800, 800);
        }

        // Update runs every frame.
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            Floor.Step(-4);
        }
    }

}
