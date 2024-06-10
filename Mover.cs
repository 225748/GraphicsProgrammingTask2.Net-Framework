using System.Drawing;
using System.Collections.Specialized;
using System.Numerics;
using System.Data.Common;

namespace GraphicsProgramming_.Net_Framework_
{
    public class Mover
    {
        Random rnd = new Random(0
        Vector2 location;
        Vector2 veloctiy;

        public Mover(int width, int height)
        {
            location = new Vector2(width/2, height/2); // place in centre of form
            veloctiy = new Vector2(3, 2); //ratio of horizontal to verticle movement
        }

        public void Update()
        {
            location = Vector2.Add(location, veloctiy);
        }

        public void Display(Graphics e)
        {
            e.FillEllipse(Brushes.BlueViolet, location.X, location.Y, 100, 100);
        }
    }
    
}