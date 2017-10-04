// Fig. 10.22: Cylinder3.cs
// Cylinder3 inherits from class Circle2 and overrides key members.
using System;

   // Cylinder3 inherits from class Circle3
public class Cylinder3 : Circle3
{
   private double height; // Cylinder3 height

   // default constructor
   public Cylinder3()
   {
      // implicit call to Circle3 constructor occurs here
   }

   // constructor
   public Cylinder3( int xValue, int yValue, double radiusValue,
      double heightValue ) : base( xValue, yValue, radiusValue )
   {
      Height = heightValue;
   }

   // property Height
   public double Height
   {
      get
      {
         return height;
      }

      set
      {
         // ensure non-negative Height value
         if ( value >= 0 )
            height = value;
      }
   }

   // calculate Cylinder3 area
   public override double Area()
   {
      return 2 * base.Area() + base.Circumference() * Height;
   }

   // calculate Cylinder3 volume
   public override double Volume()
   {
      return base.Area() * Height;
   }

   // return string representation of Cylinder3 object
   public override string ToString()
   {
      return "Center = " + base.ToString() +
         "; Height = " + Height;
   }

   // override property Name from class Circle3
   public override string Name
   {
      get
      {
         return "Cylinder3";
      }
   }

} // end class Cylinder3
