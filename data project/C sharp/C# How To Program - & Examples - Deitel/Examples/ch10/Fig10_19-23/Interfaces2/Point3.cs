// Fig. 10.20: Point3.cs
// Point3 implements interface IShape and represents
// an x-y coordinate pair.
using System;

// Point3 implements interface IShape
public class Point3 : IShape
{
   private int x, y; // Point3 coordinates

   // default constructor
   public Point3()
   {
      // implicit call to Object constructor occurs here
   }

   // constructor
   public Point3( int xValue, int yValue )
   {
      X = xValue;
      Y = yValue;
   }

   // propertyX
   public int X
   {
      get
      {
         return x;
      }

      set
      {
         x = value;
      }
   }
      
   // property Y
   public int Y
   {
      get
      {
         return y;
      }

      set
      {
         y = value;
      }
   }

   // return string representation of Point3 object
   public override string ToString()
   {
      return "[" + X + ", " + Y + "]";
   }

   // implement interface IShape method Area
   public virtual double Area()
   {
      return 0;
   }

   // implement interface IShape method Volume
   public virtual double Volume()
   {
      return 0;
   }

   // implement property Name of interface IShape
   public virtual string Name
   {
      get
      {
         return "Point3";
      }
   }

} // end class Point3

