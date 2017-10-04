// Fig. D.21: DebugClass.cs
// Console application to demonstrate object debugging.

using System;

namespace ClassDebug
{

   // creates array containing three different classes
   public class DebugEntry
   {
      public int someInteger = 123;
      private int[] integerArray = { 74, 101, 102, 102 };
      private DebugClass debugClass;
      private Random randomObject;
      private object[] list = new object[ 3 ];
      
      // constructor
      public DebugEntry()
      {
         randomObject = new Random();
         debugClass = new DebugClass( "Hello World", 
            new object() );
            
         list[ 0 ] = integerArray;
         list[ 1 ] = debugClass;
         list[ 2 ] = randomObject; 
      }
       
      // display values retrieved from three objects
      public void DisplayValues()
      {
         Console.WriteLine( randomObject.Next() );
         Console.WriteLine( debugClass.SomeString );
         Console.WriteLine( integerArray[ 0 ] );
      }
      
      // main entry point for application
      [STAThread]
      public static void Main()
      {
         DebugEntry entry = new DebugEntry();
         entry.DisplayValues();
      }
   } // end class DebugEntry
   
   // demonstrates class debugging
   public class DebugClass
   {
      // private variables
      private string someString;
      private object privateObject;
      
      // constructor
      public DebugClass( string stringData, 
         object objectData )
      {
         someString = stringData;
         privateObject = objectData;
      }
      
      // accessor property for someString
      public string SomeString
      {
         get
         {
            return someString;
         }

         set
         {
            someString = value;
         }
      } // end property SomeString

   } // end class DebugClass

} // end namespace ClassDebug

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