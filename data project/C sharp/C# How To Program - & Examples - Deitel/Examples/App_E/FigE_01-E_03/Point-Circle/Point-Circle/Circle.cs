// Fig. E.2: Circle.cs
// Class Circle inherits from Point.

using System;

namespace CircleTest
{
   /// <summary>
   /// Class <c><b>Circle</b></c> inherits from class 
   /// <c><b>Point</b></c>. It has an additional member to
   /// represent the radius, a property that provides access 
   /// to it and method <c><b>Area</b></c> to compute the area 
   /// of the circle.
   /// </summary>
   public class Circle : Point
   {
      /// <summary>
      /// This private member of <c><b>Circle</b></c> 
      /// represents the radius.
      /// </summary>
      private double radius;

      /// <summary>
      /// Default constructor for class <c><b>Circle</b></c>.
      /// </summary>
      /// <remarks>
      /// Sets the radius to 0.0.
      /// </remarks>
      public Circle()
      {
         // implicit call to base class constructor occurs here
      }

      /// <summary>
      /// Constructor for <c>Circle</c> that accepts two integers
      /// that represent the x- and y-coordinates of the circle
      /// and a <b>double</b> that represents the radius.
      /// </summary>
      /// <remarks>
      /// Uses property <c><b>Radius</b></c> to set the radius 
      /// of the circle, <em>not</em> private member 
      /// <c><b>radius</b></c>.
      /// </remarks>
      /// <param name="xValue">
      /// The x-coordinate of the circle
      /// </param>
      /// <param name="yValue">
      /// The y-coordinate of the circle.
      /// </param>
      /// <param name="radiusValue">
      /// The radius of the circle.
      /// </param>
      public Circle( int xValue, int yValue, double radiusValue )
         : base( xValue, yValue )
      {
         Radius = radiusValue;
      }

      /// <summary>
      /// Provides get and set access to member 
      /// <c><b>radius</b></c>.
      /// </summary>
      /// <remarks>
      /// The <c><b>set</b></c> method ensures that 
      /// <c><b>radius</b></c> is <em>not</em> set to a negative 
      /// number, and sets it to 0.0 if there is an attempt to 
      /// set <c><b>radius</b>></c> to do so.
      /// </remarks>
      /// <value>
      /// <c><b>Radius</b></c> accesses the value of the 
      /// <c><b>radius</b></c> data member.
      /// </value>
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
      }

      /// <summary>
      /// Computes the diameter of the circle.
      /// </summary>
      /// <returns>
      /// Returns the diameter of the circle.
      /// </returns>
      public double Diameter()
      {
         return Radius * 2;
      }

      /// <summary>
      /// Computes the circumference of the circle.
      /// </summary>
      /// <remarks>
      /// Uses constant <c><b>Math.PI</b></c>
      /// <see cref="System.Math.PI"/>
      /// </remarks>
      /// <returns>
      /// Returns the circumference of the circle.
      /// </returns>
      public double Circumference()
      {
         return Math.PI * Diameter();
      }

      /// <summary>
      /// Computes the area of the circle.
      /// </summary>
      /// <remarks>
      /// Uses constant <c><b>Math.PI</b></c>
      /// <see cref="System.Math.PI"/>
      /// </remarks>
      /// <returns>
      /// Returns the area of the circle.
      /// </returns>
      public double Area()
      {
         return Math.PI * Math.Pow( radius, 2 );
      }

      /// <summary>
      /// Converts the <c><b>Circle</b></c> to 
      /// <b>string</b> format.
      /// </summary>
      /// <remarks>
      /// Overrides <c><b>ToString</b></c> method of base class.
      /// <see cref="CircleTest.Point.ToString"/>
      /// </remarks>
      /// <returns>
      /// Returns a string that includes the center of the 
      /// circle and its radius.
      /// </returns>
      public override string ToString()
      {
         return "Center = " + base.ToString() + 
            "; Radius = " + Radius;
      }

   } // end class Circle
}

/*
 ************************************************************************** 
 * (C) Copyright 2002 by Deitel & Associates, Inc. and Prentice Hall.     *
 * All Rights Reserved.                                                   *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************
*/