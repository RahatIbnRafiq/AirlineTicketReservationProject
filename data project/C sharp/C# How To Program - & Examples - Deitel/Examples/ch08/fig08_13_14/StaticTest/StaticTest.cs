// Fig. 8.14: StaticTest.cs
// Demonstrating static class members.

using System;

namespace StaticTest
{
   // StaticTest class definition
   class StaticTest
   {
      // main entry point for application
      static void Main( string[] args )
      {
         Console.WriteLine( "Employees before instantiation: " +
            Employee.Count + "\n" );

         // create two Employees
         Employee employee1 = new Employee( "Susan", "Baker" );
         Employee employee2 = new Employee( "Bob", "Jones" );

         Console.WriteLine( "\nEmployees after instantiation: " +
            "Employee.Count = " + Employee.Count + "\n" );

         // display the Employees 
         Console.WriteLine( "Employee 1: " + 
            employee1.FirstName + " " + employee1.LastName +
            "\nEmployee 2: " + employee2.FirstName +
            " " + employee2.LastName + "\n" );

         // remove reference to objects for 
         // garbage collection
         employee1 = null;
         employee2 = null;

         // force garbage collection
         System.GC.Collect();

         // wait until collection completes
         System.GC.WaitForPendingFinalizers();

         Console.WriteLine( 
            "\nEmployees after garbage collection: " +
            Employee.Count );
      }
   }
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
