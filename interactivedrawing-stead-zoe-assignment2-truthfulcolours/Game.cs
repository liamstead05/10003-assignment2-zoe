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
            Draw.FillColor = square;
            Draw.Square(225, 25, 150);
            if (mouseClick==true)
            {
                square = Random.Color();
            }
            Draw.FillColor = triangle;
            Draw.Triangle(100, 250, 25, 375, 175, 375);
            if (mouseClick==true)
            {
                triangle = Random.Color();
            }
            Draw.FillColor = hexagon;
            Draw.Quad(225, 310, 265, 250, 335, 250, 375, 310);
            Draw.Quad(225, 310, 265, 375, 335, 375, 375, 310);
            if (mouseClick==true)
            {
                hexagon = Random.Color();
            }
        }
    }
}
