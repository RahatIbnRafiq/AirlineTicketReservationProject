// Fig. 17.15: CreateRandomAccessFile.cs
// Creating a random file.

// C# namespaces
using System;
using System.IO;
using System.Windows.Forms;

// Deitel namespaces
using BankLibrary;
     
namespace CreateRandomAccessFile
{
   class CreateRandomAccessFile
   {
      // number of records to write to disk
      private const int NUMBER_OF_RECORDS = 100;

      [STAThread]
      static void Main(string[] args)
      {
         // create random file, then save to disk
         CreateRandomAccessFile file = new CreateRandomAccessFile();
         file.SaveFile();

      } // end method Main

      // write records to disk
      private void SaveFile()
      {
         // record for writing to disk
         RandomAccessRecord blankRecord = new RandomAccessRecord();

         // stream through which serializable data are written to file
         FileStream fileOutput = null;

         // stream for writing bytes to file
         BinaryWriter binaryOutput = null;

         // create dialog box enabling user to save file
         SaveFileDialog fileChooser = new SaveFileDialog();
         DialogResult result = fileChooser.ShowDialog();

         // get file name from user
         string fileName = fileChooser.FileName;

         // exit event handler if user clicked Cancel
         if ( result == DialogResult.Cancel )
            return;

         // show error if user specified invalid file
         if ( fileName == "" || fileName == null )
            MessageBox.Show("Invalid File Name", "Error", 
               MessageBoxButtons.OK, MessageBoxIcon.Error);
         else
         {
            // write records to file
            try
            {
               // create FileStream to hold records
               fileOutput = new FileStream( fileName,
                  FileMode.Create, FileAccess.Write );

               // set length of file
               fileOutput.SetLength( RandomAccessRecord.SIZE *
                  NUMBER_OF_RECORDS );

               // create object for writing bytes to file
               binaryOutput = new BinaryWriter( fileOutput );

               // write empty records to file
               for ( int i = 0; i < NUMBER_OF_RECORDS; i++ )
               {
                  // set file position pointer in file
                  fileOutput.Position = i * RandomAccessRecord.SIZE;

                  // write blank record to file
                  binaryOutput.Write( blankRecord.Account );
                  binaryOutput.Write( blankRecord.FirstName );
                  binaryOutput.Write( blankRecord.LastName );
                  binaryOutput.Write( blankRecord.Balance );
               }

               // notify user of success
               MessageBox.Show("File Created", "Success",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

               // handle exception if error occurs during writing
            catch( IOException )
            {
               // notify user of error
               MessageBox.Show( "Cannot write to file", "Error", 
                  MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
         }

         // close FileStream
         if ( fileOutput == null )
            fileOutput.Close();

         // close BinaryWriter
         if ( binaryOutput == null )
            binaryOutput.Close();

      } // end method SaveFile
   } // end class CreateRandomAccessFile
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