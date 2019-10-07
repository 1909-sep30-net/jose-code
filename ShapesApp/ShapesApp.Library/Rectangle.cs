namespace ShapesApp.Library
{
    public class Rectangle: IShapes
    {
        public double Length { get; set; }
        public double Width { get; set; }

        //Shorthand for one line get-only property ( =>)
        public int Sides => 4; 
        public double GetPerimeter()
        {
            return Length * 2 + Width * 2;
        }

        public double Area
        {
            get
            {
                return Length * Width;
            }
        }

        public int Dimensions
        {
            get { return 2; }
        }

        public bool Validate()
        {
            if (Length <= 0)
            {
                return false;
            }
            if (Width <= 0)
            {
                return false;
            }
            else
                return true;
        }
    }
}