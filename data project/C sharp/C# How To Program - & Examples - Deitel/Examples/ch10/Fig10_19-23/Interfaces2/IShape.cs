// Fig. 10.19: IShape.cs
// Interface IShape for Point, Circle, Cylinder Hierarchy.

public interface IShape
{
   // classes that implement IShape must implement these methods
   // and this property
   double Area();
   double Volume();
   string Name { get; }
}