// Fig. 10.23: Interfaces2Test.cs
// Demonstrating polymorphism with interfaces in 
// Point-Circle-Cylinder hierarchy.

using System.Windows.Forms;

public class Interfaces2Test
{
   public static void Main( string[] args )
   {
      // instantiate Point3, Circle3 and Cylinder3 objects
      Point3 point = new Point3( 7, 11 );
      Circle3 circle = new Circle3( 22, 8, 3.5 );
      Cylinder3 cylinder = new Cylinder3( 10, 10, 3.3, 10 );

      // create array of IShape references
      IShape[] arrayOfShapes = new IShape[ 3 ];

      // arrayOfShapes[ 0 ] references Point3 object
      arrayOfShapes[ 0 ] = point;

      // arrayOfShapes[ 1 ] references Circle3 object
      arrayOfShapes[ 1 ] = circle;

      // arrayOfShapes[ 2 ] references Cylinder3 object
      arrayOfShapes[ 2 ] = cylinder;

      string output = point.Name + ": " + point + "\n" +
         circle.Name + ": " + circle + "\n" +
         cylinder.Name + ": " + cylinder;

      foreach ( IShape shape in arrayOfShapes )
      {
         output += "\n\n" + shape.Name + ":\nArea = " + 
            shape.Area() + "\nVolume = " + shape.Volume();
      }

      MessageBox.Show( output, "Demonstrating Polymorphism" );
   }
}