// Fig. 21.24: Generator.asmx.cs
// Web Service to generate random equations based on a
// specified operation and difficulty level.

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;

namespace EquationGenerator
{
   [ WebService( Namespace = "http://www.deitel.com/csphtp1/ch21",
        Description = "A Web service that generates questions " +
        "based on the specified mathematical operation and " +
        "level of difficulty chosen." ) ]
   public class Generator : System.Web.Services.WebService
   {
      public Generator()
      {
         InitializeComponent();
      }

		#region Component Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
      }
		#endregion

      [ WebMethod ( Description =
           "Method that generates a random equation." ) ]
      public Equation GenerateEquation( string operation, 
         int level )
      {
         // find maximum and minimum number to be used
         int maximum = ( int ) Math.Pow( 10, level ), 
            minimum = ( int ) Math.Pow( 10, level - 1 );

         Random random = new Random();

         // create equation consisting of two random numbers
         // between minimum and maximum parameters
         Equation equation = new Equation(
            random.Next( minimum, maximum ), 
            random.Next( minimum, maximum ), operation );

         return equation;

      } // end method GenerateEquation

   } // end class Generator

} // end namespace EquationGenerator

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
