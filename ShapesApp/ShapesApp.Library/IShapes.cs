namespace ShapesApp.Library
{
    //needs to be public, if not it cannot be used somewhere else in the project.
    public interface IShapes
    {
        //an interface is a contract that classes can sign and MUST FOLLOW!
        //No implementations on an interface. 
        int Dimensions{get;}
        int Sides {get; }
        double Area {get; }
        double GetPerimeter();

    }
}