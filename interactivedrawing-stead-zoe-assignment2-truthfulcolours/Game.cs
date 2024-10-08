// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Color circle = Random.Color();
        Color square = Random.Color();
        Color triangle = Random.Color();
        Color hexagon = Random.Color();
        bool mouseClick;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("truthful colours");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            mouseClick = Input.IsMouseButtonPressed(MouseInput.Left);
            Draw.FillColor = circle;
            Draw.Circle(100, 100, 75);
            if (mouseClick==true)
            {
                circle = Random.Color();
            }

        }
    }
}
