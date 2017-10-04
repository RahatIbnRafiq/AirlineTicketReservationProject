// Fig. 21.6: HugeInteger.asmx.cs
// HugeInteger Web Service.

using System;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services; // contains Web service related classes

namespace HugeIntegerWebService
{
   /// <summary>
   /// performs operations on large integers
   /// </summary>
   [ WebService( 
        Namespace = "http://www.deitel.com/csphtp1/ch21/",
        Description = "A Web service which provides methods that" +
        " can manipulate large integer values." ) ]
   public class HugeInteger : System.Web.Services.WebService
   {
      // default constructor
      public HugeInteger()
      {
         // CODEGEN: This call is required by the ASP .NET Web 
         // Services Designer
         InitializeComponent();

         number = new int[ MAXIMUM ];
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

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
      }

      // WEB SERVICE EXAMPLE
      // The HelloWorld() example service returns  
      // the string Hello World
      // To build, uncomment the following lines 
      // then save and build the project
      // To test this web service, press F5

      //   [WebMethod]
      //   public string HelloWorld()
      //   {
      //      return "Hello World";
      //   }

      private const int MAXIMUM = 100;
   
      public int[] number;

      // indexer that accepts an integer parameter
      public int this[ int index ]
      {
         get
         {         
            return number[ index ];
         }

         set
         {
            number[ index ] = value;
         }

      } // end indexer

      // returns string representation of HugeInteger
      public override string ToString()
      {
         StringBuilder returnString = new StringBuilder();

         foreach ( int digit in number )
            returnString.Insert( 0, digit );

         return returnString.ToString();
      }

      // creates HugeInteger based on argument
      public static HugeInteger FromString( string integer )
      {
         HugeInteger parsedInteger = new HugeInteger();

         for ( int i = 0; i < integer.Length; i++ )
            parsedInteger[ i ] = Int32.Parse( 
               integer[ integer.Length - i - 1 ].ToString() );

         return parsedInteger;
      }

      // WebMethod that performs integer addition
      // represented by string arguments
      [ WebMethod ( Description = "Adds two huge integers." ) ]
      public string Add( string first, string second )
      {
         int carry = 0;

         HugeInteger operand1 = HugeInteger.FromString( first );
         HugeInteger operand2 = 
            HugeInteger.FromString( second );

         // store result of addition
         HugeInteger result = new HugeInteger();

         // perform addition algorithm for each digit
         for ( int i = 0; i < MAXIMUM; i++ )
         {
            // add two digits in same column
            // result is their sum, plus carry from 
            // previous operation modulus 10
            result[ i ] = 
               ( operand1[ i ] + operand2[ i ] ) % 10 + carry;

            // store remainder of dividing
            // sums of two digits by 10
            carry = ( operand1[ i ] + operand2[ i ] ) / 10;
         }

         return result.ToString();

      } // end method Add

      // WebMethod that performs the subtraction of integers 
      // represented by string arguments
      [ WebMethod ( 
           Description = "Subtracts two huge integers." ) ]
      public string Subtract( string first, string second )
      {
         HugeInteger operand1 = HugeInteger.FromString( first );
         HugeInteger operand2 = 
            HugeInteger.FromString( second );
         HugeInteger result = new HugeInteger();

         // subtract top digit from bottom digit
         for ( int i = 0; i < MAXIMUM; i++ )
         {
            // if top digit is smaller than bottom
            // digit we need to borrow
            if ( operand1[ i ] < operand2[ i ] )
               Borrow( operand1, i );

            // subtract bottom from top
            result[ i ] = operand1[ i ] - operand2[ i ];
         }

         return result.ToString();

      } // end method Subtract

      // borrows 1 from next digit
      private void Borrow( HugeInteger integer, int place )
      {
         // if no place to borrow from, signal problem
         if ( place >= MAXIMUM - 1 )
            throw new ArgumentException();

            // otherwise if next digit is zero,  
            // borrow from digit to left
         else if ( integer[ place + 1 ] == 0 )
            Borrow( integer, place + 1 );

         // add ten to current place because we borrowed
         // and subtract one from previous digit - 
         // this is digit borrowed from
         integer[ place ] += 10;
         integer[ place + 1 ] -= 1;         

      } // end method Borrow

      // WebMethod that returns true if first integer is 
      // bigger than second
      [ WebMethod ( Description = "Determines whether first " +
           "integer is larger than the second integer." ) ]
      public bool Bigger( string first, string second )
      {
         char[] zeroes = { '0' };

         try
         {
            // if elimination of all zeroes from result
            // of subtraction is an empty string,
            // numbers are equal, so return false, 
            // otherwise return true
            if ( Subtract( first, second ).Trim( zeroes ) == "" )
               return false;
            else
               return true;
         }

            // if ArgumentException occurs, first number
            // was smaller, so return false
         catch ( ArgumentException )
         {
            return false;
         }

      } // end method Bigger

      // WebMethod returns true if first integer is 
      // smaller than second
      [ WebMethod ( Description = "Determines whether the " +
           "first integer is smaller than the second integer." ) ]
      public bool Smaller( string first, string second )
      {
         // if second is bigger than first, then first is 
         // smaller than second
         return Bigger( second, first );
      }

      // WebMethod that returns true if two integers are equal
      [ WebMethod ( Description = "Determines whether the " +
           "first integer is equal to the second integer." ) ]
      public bool EqualTo( string first, string second )
      {
         // if either first is bigger than second, or first is 
         // smaller than second, they are not equal
         if ( Bigger( first, second ) || 
            Smaller( first, second ) )
            return false;
         else
            return true;
      }         

   } // end class HugeInteger

} // end namespace HugeIntegerWebService

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
