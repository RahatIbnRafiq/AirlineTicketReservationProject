// Fig. E.1: Point.cs
// Class Point maintains an X and Y coordinate.

using System;

namespace CircleTest
{
   /// <summary>
   /// Class <c><b>Point</b></c> defines a point as a pair
   /// of x- and y-coordinates.
   /// </summary>
   public class Point 
   {
      /// <summary>
      /// This private member of <c><b>Point</b></c>  
      /// represents the x-coordinate.
      /// </summary>
      /// <returns> The x-coordinate as an integer.</returns>
      private int x;

      /// <summary>
      /// This private member of <c><b>Point</b></c>  
      /// represents the x-coordinate.
      /// </summary>
      /// <returns> The y-coordinate as an integer.</returns>
      private int y;

      /// <summary>
      /// Default constructor for class <c><b>Point</b></c>.
      /// </summary>
      /// <remarks>
      /// Sets properties <c><b>X</b></c> and <c><b>Y</b></c> to 0.
      /// </remarks>
      public Point()
      {
         // implicit call to base-class constructor occurs here
      }

      /// <summary>
      /// Constructor for <c><b>Point</b></c> that accepts two
      /// integers that represent the x- and
      /// y-coordinates of the point.
      /// </summary>
      /// <remarks>
      /// Uses <c><b>X</b></c> and <c><b>Y</b></c> 
      /// properties to set the coordinates of the point, 
      /// <em>not</em> private members <c><b>xCoordinate</b></c> 
      /// and <c><b>yCoordinate</b></c>.
      /// </remarks>
      /// <param name="xValue">
      /// The x-coordinate of the circle
      /// </param>
      /// <param name="yValue">
      /// The y-coordinate of the circle.
      /// </param>
      public Point( int xValue, int yValue )
      {
         // implicit call to base-class constructor occurs here
         X = xValue;
         Y = yValue;
      }

      /// <summary>
      /// Provides get and set access to member 
      /// <c><b>xCoordinate</b></c>.
      /// </summary>
      /// <value>
      /// <c><b>X</b></c> accesses the value of the 
      /// <c><b>xCoordinate</b></c> data member.
      /// </value>
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

      /// <summary>
      /// Provides get and set access to member 
      /// <c><b>yCoordinate</b></c>.
      /// </summary>
      /// <value>
      /// <c><b>Y</b></c> accesses the value of the 
      /// <c><b>yCoordinate</b></c> data member.
      /// </value>
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

      /// <summary>
      /// Converts the <c><b>Point</b></c> to 
      /// <b>string</b> format.
      /// </summary>     
      /// <returns>
      /// Returns a string in format: 
      /// [x-coordinate, y-coordinate].
      /// </returns>
      public override string ToString()
      {
         return "[" + X + ", " + Y + "]";
      }

   } // end class Point
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