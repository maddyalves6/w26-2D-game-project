// Include the namespaces (code libraries) you need below.
using Raylib_cs;
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    
    public class Game
    {
        Floor Floor = new Floor();
        Dino Dino = new Dino();
        Spikes Spikes = new Spikes();

        float tempo = -4; // the amount scrolling objects will move each frame

        // Setup runs once before the game loop begins.
        public void Setup()
        {
            Window.SetSize(800, 400);
            Window.SetTitle("littleguy world :)");

            // setup and draw dino
            Dino.SetDinoX(100+tempo);
            Dino.SetDinoY(400);
            Dino.Step();

            Spikes.Spawn(290);
        }

        // Update runs every frame.
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            // if space pressed when dino is grounded, jump
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space) && Dino.GetDinoY() == 290)
            {
                Dino.SetDinoYVel(-15);
            }

            // spawn spike every 2 seconds
            if (Time.SecondsElapsed % 2 <= 0.05)
            {
                if (Random.Bool())
                {
                    Spikes.Spawn(290);
                }
                else
                {
                    Spikes.Spawn(180);
                }
            }

            // up tempo every minute
            if (Time.SecondsElapsed % 60 <= 0.05)
            {
                tempo--;
            }

            Floor.Step(tempo);
            Dino.Step();
            Spikes.Step(tempo);
        }
    }

}
