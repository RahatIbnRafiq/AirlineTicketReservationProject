// Fig. 10.2: Circle.cs
// Circle class that inherits from class Point.

using System;

// Circle class definition inherits from Point
public class Circle : Point
{
   private double radius; // circle's radius

   // default constructor
   public Circle()
   {
      // implicit call to Point constructor occurs here
   }

   // constructor
   public Circle( int xValue, int yValue, double radiusValue ) 
      : base( xValue, yValue )
   {
      Radius = radiusValue;
   }

   // property Radius
   public double Radius
   {
      get
      {
         return radius;
      }

      set
      {
         if ( value >= 0 )
            radius = value;
      }

   } // end property Radius

   // calculate Circle diameter
   public double Diameter()
   {
      return Radius * 2;
   }

   // calculate Circle circumference
   public double Circumference()
   {
      return Math.PI * Diameter();
   }

   // calculate Circle area
   public double Area()
   {
      return Math.PI * Math.Pow( Radius, 2 );
   }

   // return string representation of Circle
   public override string ToString()
   {
      return "Center = " + base.ToString() +
         "; Radius = " + Radius;
   }

} // end class Circle
