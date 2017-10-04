// Fig. 8.13: Employee.cs
// Employee class contains static data and a static method.

using System;

namespace StaticTest
{
   // Employee class definition
   public class Employee : Object
   {
      private string firstName;
      private string lastName;
      private static int count;  // Employee objects in memory

      // constructor increments static Employee count
      public Employee( string fName, string lName )
      {
         firstName = fName;
         lastName = lName;

         ++count;
            
         Console.WriteLine( "Employee object constructor: " +
            firstName + " " + lastName + "; count = " + Count );           
      }
	   
      // destructor decrements static Employee count
      ~Employee()
      {
         --count;
            
         Console.WriteLine( "Employee object destructor: " +
            firstName + " " + lastName + "; count = " + Count );
      }
      
      // FirstName property
      public string FirstName
      {
         get
         {
            return firstName;
         }
      }

      // LastName property
      public string LastName
      {
         get
         {
            return lastName;
         }
      }

      // static Count property
      public static int Count
      {
         get
         {
            return count;
         }
      }

   } // end class Employee
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
