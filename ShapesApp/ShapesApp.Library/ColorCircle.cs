using System;
namespace ShapesApp.Library
{
    public class ColorCircle : Circle
    {
        public string Color {get; set; }
    
        public double GetPerimeter()
        {
            System.Console.WriteLine("calculating perimeter" );
            return 2*Math.PI * Radius;
        }
    }
}