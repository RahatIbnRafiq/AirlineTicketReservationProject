// Fig. 17.18: Transaction.cs
// Handles record transactions.

// C# namespaces
using System;
using System.IO;
using System.Windows.Forms;

// Deitel namespaces
using BankLibrary;

namespace TransactionProcessor
{
   public class Transaction
   {
      // number of records to write to disk
      private const int NUMBER_OF_RECORDS = 100;

      // stream through which data moves to and from file
      private FileStream file;

      // stream for reading bytes from file
      private BinaryReader binaryInput;

      // stream for writing bytes to file
      private BinaryWriter binaryOutput;

      // create/open file containing empty records
      public void OpenFile( string fileName )
      {
         // write empty records to file
         try
         {
            // create FileStream from new file or existing file
            file = new FileStream( fileName, FileMode.OpenOrCreate );

            // use FileStream for BinaryWriter to read bytes from file
            binaryInput = new BinaryReader( file );

            // use FileStream for BinaryWriter to write bytes to file
            binaryOutput = new BinaryWriter( file );

            // determine whether file has just been created
            if ( file.Length == 0 )
            {
               // record to be written to file
               RandomAccessRecord blankRecord = 
                  new RandomAccessRecord();

               // new record can hold NUMBER_OF_RECORDS records
               file.SetLength( RandomAccessRecord.SIZE *
                  NUMBER_OF_RECORDS );

               // write blank records to file
               for ( int i = 0; i < NUMBER_OF_RECORDS; i++ )
               {
                  // move file-position pointer to next position
                  file.Position = i * RandomAccessRecord.SIZE;

                  // write blank record to file
                  binaryOutput.Write( blankRecord.Account );
                  binaryOutput.Write( blankRecord.FirstName );
                  binaryOutput.Write( blankRecord.LastName );
                  binaryOutput.Write( blankRecord.Balance );
               }
            }
         }

            // notify user of error during writing of blank records
         catch( IOException )
         { 
            MessageBox.Show("Cannot create file", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
         }

      } // end method OpenFile

      // retrieve record depending on whether account is valid
      public RandomAccessRecord GetRecord( string accountValue )
      {
         // store file data associated with account in record
         try
         {
            // record to store file data
            RandomAccessRecord record = new RandomAccessRecord();
               
            // get value from TextBox's account field
            int accountNumber = Int32.Parse( accountValue );

            // if account is invalid, do not read data
            if ( accountNumber < 1 || 
               accountNumber > NUMBER_OF_RECORDS )
            {
               // set record's account field with account number
               record.Account = accountNumber;
            }

               // get data from file if account is valid
            else
            {
               // locate position in file where record exists
               file.Seek( ( accountNumber - 1 ) *
                  RandomAccessRecord.SIZE, 0 );

               // read data from record
               record.Account = binaryInput.ReadInt32();
               record.FirstName = binaryInput.ReadString();
               record.LastName = binaryInput.ReadString();
               record.Balance = binaryInput.ReadDouble();
            }

            return record;
         }

            // notify user of error during reading
         catch( IOException )
         {
            MessageBox.Show( "Cannot read file", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error );
         }

         return null;

      } // end method GetRecord;

      // add record to file at position determined by accountNumber
      public bool AddRecord( 
         RandomAccessRecord record, int accountNumber )
      {
         // write record to file
         try
         {
            // move file position pointer to appropriate position
            file.Seek( ( accountNumber - 1 ) * 
               RandomAccessRecord.SIZE, 0 );

            // write data to file
            binaryOutput.Write(record.Account);
            binaryOutput.Write(record.FirstName);
            binaryOutput.Write(record.LastName);
            binaryOutput.Write(record.Balance);
         }

            // notify user if error occurs during writing
         catch( IOException )
         {
            MessageBox.Show( "Error Writing To File", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error );

            return false; // failure
         }

         return true; // success

      } // end method AddRecord
            
   } // end class Transaction
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