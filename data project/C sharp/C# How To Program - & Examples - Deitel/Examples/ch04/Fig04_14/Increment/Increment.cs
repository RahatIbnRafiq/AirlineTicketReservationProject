// Fig. 4.14: Increment.cs
// Preincrementing and postincrementing

using System;

namespace Increment
{
   /// <summary>
   /// Summary description for Class1.
   /// </summary>
   class Increment
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main(string[] args)
      {         
         int c;
   
         c = 5;
         Console.WriteLine( c );   // print 5
         Console.WriteLine( c++ ); // print 5 then postincrement
         Console.WriteLine( c );   // print 6

         Console.WriteLine();      // skip a line

         c = 5;
         Console.WriteLine( c );   // print 5
         Console.WriteLine( ++c ); // preincrement then print 6
         Console.WriteLine( c );   // print 6s
      
      } // end of method Main
   
   } // end of class Increment
}