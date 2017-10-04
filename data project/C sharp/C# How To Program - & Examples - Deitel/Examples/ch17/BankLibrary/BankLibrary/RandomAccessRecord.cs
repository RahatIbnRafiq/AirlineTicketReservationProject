// Fig. 17.14: RandomAccessRecord.cs
// Data-record class for random-access applications.

using System;

namespace BankLibrary
{
   public class RandomAccessRecord
   {
      // length of firstName and lastName
      private const int CHAR_ARRAY_LENGTH = 15;

      private const int SIZE_OF_CHAR = 2;
      private const int SIZE_OF_INT32 = 4;
      private const int SIZE_OF_DOUBLE = 8;

      // length of record
      public const int SIZE = SIZE_OF_INT32 +
         2 * ( SIZE_OF_CHAR * CHAR_ARRAY_LENGTH ) + SIZE_OF_DOUBLE;

      // record data
      private int account;
      private char[] firstName = new char[ CHAR_ARRAY_LENGTH ];
      private char[] lastName = new char[ CHAR_ARRAY_LENGTH ];
      private double balance;

      // default constructor sets members to default values
      public RandomAccessRecord() : this( 0, "", "", 0.0 )
      {
      }

      // overloaded counstructor sets members to parameter values
      public RandomAccessRecord( int accountValue,
         string firstNameValue, string lastNameValue, 
         double balanceValue )
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
            return new string( firstName );
         }

         set
         {
            // determine length of string parameter
            int stringSize = value.Length;

            // firstName string representation
            string firstNameString = value;

            // append spaces to string parameter if too short
            if ( CHAR_ARRAY_LENGTH >= stringSize )
            {
               firstNameString = value +
                  new string( ' ', CHAR_ARRAY_LENGTH - stringSize );
            }
            else
            {
               // remove characters from string parameter if too long
               firstNameString = 
                  value.Substring( 0, CHAR_ARRAY_LENGTH );
            }

            // convert string parameter to char array
            firstName = firstNameString.ToCharArray();

         } // end set

      } // end property FirstName

      // property LastName
      public string LastName
      {
         get
         {
            return new string( lastName );
         }

         set
         {
            // determine length of string parameter
            int stringSize = value.Length;

            // lastName string representation
            string lastNameString = value;

            // append spaces to string parameter if too short
            if ( CHAR_ARRAY_LENGTH >= stringSize )
            {
               lastNameString = value +
                  new string( ' ', CHAR_ARRAY_LENGTH - stringSize );
            }
            else
            {
               // remove characters from string parameter if too long
               lastNameString = 
                  value.Substring( 0, CHAR_ARRAY_LENGTH );
            }

            // convert string parameter to char array
            lastName = lastNameString.ToCharArray();

         } // end set

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

   } // end class RandomAccessRecord

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