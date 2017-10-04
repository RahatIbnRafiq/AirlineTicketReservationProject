// Fig. 17.8: Record.cs
// Serializable class that represents a data record.

using System;

namespace BankLibrary
{
   [Serializable]
   public class Record
   {
      private int account;
      private string firstName;
      private string lastName;
      private double balance;

      // default constructor sets members to default values
      public Record() : this( 0, "", "", 0.0 )
      {
      }

      // overloaded constructor sets members to parameter values
      public Record( int accountValue, string firstNameValue,
         string lastNameValue, double balanceValue )
      {
         Account = accountValue;
         FirstName = firstNameValue;
         LastName = lastNameValue;
         Balance = balanceValue;

      } // end constructor

      // property Account
      public int Account
      {
         get
         {
            return account;
         }

         set
         {
            account = value;
         }

      } // end property Account

      // property FirstName
      public string FirstName
      {
         get
         {
            return firstName;
         }

         set
         {
            firstName = value;
         }

      } // end property FirstName

      // property LastName
      public string LastName
      {
         get
         {
            return lastName;
         }

         set
         {
            lastName = value;
         }

      } // end property LastName

      // property Balance
      public double Balance
      {
         get
         {
            return balance;
         }

         set
         {
            balance = value;
         }

      } // end property Balance

   } // end class Record
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