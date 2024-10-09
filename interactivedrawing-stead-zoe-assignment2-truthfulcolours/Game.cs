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
        // Variables for the random colours of the four shapes
        Color circle = Random.Color();
        Color square = Random.Color();
        Color triangle = Random.Color();
        Color hexagon = Random.Color();
        Color box = new Color(190, 190, 190);
        bool mouseClick;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            // Window size and title, which is the name of the application
            Window.SetTitle("truthful colours");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Change background colour to selected background colour
            Window.ClearBackground(Color.OffWhite);
            
            // Cal
            mouseClick = Input.IsMouseButtonPressed(MouseInput.Left);
            Draw.FillColor = circle;
            Draw.LineColor = Color.Black;
            Draw.Circle(105, 105, 75);
            if (mouseClick==true)
            {
                circle = Random.Color();
            }
            Draw.FillColor = square;
            Draw.LineColor = Color.Black;
            Draw.Square(220, 30, 150);
            if (mouseClick==true)
            {
                square = Random.Color();
            }
            Draw.FillColor = triangle;
            Draw.LineColor = Color.Black;
            Draw.Triangle(105, 240, 30, 365, 180, 365);
            if (mouseClick==true)
            {
                triangle = Random.Color();
            }
            Draw.FillColor = hexagon;
            Draw.LineColor = Color.Black;
            Draw.Quad(220, 295, 260, 235, 330, 235, 370, 295);
            Draw.Quad(220, 295, 260, 360, 330, 360, 370, 295);
            if (mouseClick==true)
            {
                hexagon = Random.Color();
            }
            Draw.FillColor = box;
            Draw.LineColor = box;
            Draw.Rectangle(0, 0, 400, 20);
            Draw.Rectangle(0, 0, 20, 400);
            Draw.Rectangle(0, 380, 400, 20);
            Draw.Rectangle(380, 0, 20, 400);
            Draw.Rectangle(190, 0, 20, 400);
            Draw.Rectangle(0, 190, 400, 20);
        }
    }
}
