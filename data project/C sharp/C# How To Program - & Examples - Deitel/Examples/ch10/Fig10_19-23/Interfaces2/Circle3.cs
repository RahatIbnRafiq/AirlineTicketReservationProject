// Fig. 10.21: Circle3.cs
// Circle3 inherits from class Point3 and overrides key members.
using System;

   // Circle3 inherits from class Point3
public class Circle3 : Point3
{
   private double radius; // Circle3 radius

   // default constructor
   public Circle3()
   {
      // implicit call to Point3 constructor occurs here
   }

   // constructor
   public Circle3( int xValue, int yValue, double radiusValue )
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
         // ensure non-negative Radius value
         if ( value >= 0 )
            radius = value;
      }
   }

   // calculate Circle3 diameter
   public double Diameter()
   {
      return Radius * 2;
   }

   // calculate Circle3 circumference
   public double Circumference()
   {
      return Math.PI * Diameter();
   }

   // calculate Circle3 area
   public override double Area()
   {
      return Math.PI * Math.Pow( Radius, 2 );
   }

   // return string representation of Circle3 object
   public override string ToString()
   {
      return "Center = " + base.ToString() +
         "; Radius = " + Radius;
   }

   // override property Name from class Point3
   public override string Name
   {
      get
      {
         return "Circle3";
      }
   }

} // end class Circle3
