using System;
namespace ShapesApp.Library
{
    public class Circle : IShapes
    {
        public int Dimensions => 2;

        public int Sides => 7 ;

        public double Area => Math.PI * Radius * Radius;

        public double Radius{get; set; }

        public virtual double GetPerimeter() => 2*Math.PI * Radius;


        
    }
}