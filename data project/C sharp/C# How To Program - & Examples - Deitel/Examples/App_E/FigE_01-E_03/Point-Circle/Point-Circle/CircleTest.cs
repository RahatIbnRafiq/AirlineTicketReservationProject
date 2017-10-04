// Fig. E.3: CircleTest.cs
// Manipulating a Circle object.

using System;
using System.Windows.Forms;

namespace CircleTest
{
   /// <summary>
   /// Class <c><b>CircleTest</b></c> test the
   /// <c><b>Point</b></c> and <c><b>Point</b></c> classes.
   /// </summary>
   class CircleTest
   {
      /// <summary>
      /// Entry point of application.
      /// </summary>
      /// <remarks>
      /// In this application all command-line arguments
      /// are ignored.
      /// </remarks>
      /// <param name="args">
      /// Optional arguments to Main.
      /// </param>
      static void Main( string[] args )
      {
         Circle circle = new Circle( 37, 43, 2.5 );

         // append Circle properties to output
         string output = "X coordinate is " + circle.X + "\n" +
            "Y coordinate is " + circle.Y + "\n" + 
            "Radius is " + circle.Radius;

         // set new coordinates and radius
         circle.X = 2;
         circle.Y = 2;
         circle.Radius = 4.25;

         output += "\n\n" +
            "The new location and radius of circle are " +
            "\n" + circle + "\n";

         // display Circle's Diameter
         output += "Diameter is " + 
            String.Format( "{0:F}", circle.Diameter() ) + "\n";

         // display Circle's Circumference
         output += "Circumference is " +
            String.Format( "{0:F}", circle.Circumference() ) + "\n";

         // display Circle's Area
         output += "Area is " + 
            String.Format( "{0:F}", circle.Area() );

         MessageBox.Show( output, "Demonstrating Class Circle" );

      } // end method Main

   } // end class CircleTest
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