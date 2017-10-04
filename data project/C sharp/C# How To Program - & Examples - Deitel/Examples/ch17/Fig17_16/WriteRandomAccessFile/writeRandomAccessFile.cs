// Fig 17.16: WriteRandomAccessFile.cs
// Write data to a random-access file.

// C# namespaces
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

// Deitel namespaces
using BankLibrary;

namespace WriteRandomAccessFile
{
   public class WriteRandomAccessFileForm : BankUIForm
   {
      private System.Windows.Forms.Button openButton;
      private System.Windows.Forms.Button enterButton;

      private System.ComponentModel.Container components = null;

      // number of RandomAccessRecords to write to disk
      private const int NUMBER_OF_RECORDS = 100;

      // stream through which data are written to file
      private FileStream fileOutput;

      // stream for writing bytes to file
      private BinaryWriter binaryOutput;

      public WriteRandomAccessFileForm()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if( disposing )
         {
            if (components != null) 
            {
               components.Dispose();
            }
         }
         base.Dispose( disposing );
      }

		#region Windows Form Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.openButton = new System.Windows.Forms.Button();
         this.enterButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // accountTextBox
         // 
         this.accountTextBox.TabIndex = 1;
         // 
         // firstNameTextBox
         // 
         this.firstNameTextBox.TabIndex = 2;
         // 
         // lastNameTextBox
         // 
         this.lastNameTextBox.TabIndex = 3;
         // 
         // balanceTextBox
         // 
         this.balanceTextBox.TabIndex = 4;
         // 
         // openButton
         // 
         this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
         this.openButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
         this.openButton.Location = new System.Drawing.Point(32, 232);
         this.openButton.Name = "openButton";
         this.openButton.Size = new System.Drawing.Size(144, 32);
         this.openButton.TabIndex = 0;
         this.openButton.Text = "Open File";
         this.openButton.Click += new System.EventHandler(this.openButton_Click);
         // 
         // enterButton
         // 
         this.enterButton.Enabled = false;
         this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
         this.enterButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
         this.enterButton.Location = new System.Drawing.Point(216, 232);
         this.enterButton.Name = "enterButton";
         this.enterButton.Size = new System.Drawing.Size(144, 32);
         this.enterButton.TabIndex = 5;
         this.enterButton.Text = "Enter";
         this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
         // 
         // WriteRandomAccessFileForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
         this.ClientSize = new System.Drawing.Size(400, 279);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.balanceTextBox,
                                                                      this.lastNameTextBox,
                                                                      this.firstNameTextBox,
                                                                      this.accountTextBox,
                                                                      this.balanceLabel,
                                                                      this.lastNameLabel,
                                                                      this.firstNameLabel,
                                                                      this.accountLabel,
                                                                      this.enterButton,
                                                                      this.openButton});
         this.Name = "WriteRandomAccessFileForm";
         this.Text = "Write Random-Access File";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new WriteRandomAccessFileForm() );
      }

      // invoked when user clicks Open button
      private void openButton_Click(
         object sender, System.EventArgs e )
      {
         // create dialog box enabling user to Open file
         OpenFileDialog fileChooser = new OpenFileDialog();
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
            // open file if file already exists
            try
            {
               // create FileStream to hold records
               fileOutput = new FileStream( fileName, 
                  FileMode.Open, FileAccess.Write );

               // create object for writing bytes to file
               binaryOutput = new BinaryWriter( fileOutput );

               // disable Open button and enable Enter button
               openButton.Enabled = false; 
               enterButton.Enabled = true;
            }

               // notify user if file does not exist
            catch( IOException )
            {
               MessageBox.Show("File Does Not Exits", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }

      } // end method openButton_Click

      // invoked when user clicks Enter button
      private void enterButton_Click(
         object sender, System.EventArgs e )
      {
         // TextBox values string array
         string[] values = GetTextBoxValues();

         // determine whether TextBox account field is empty
         if ( values[ ( int )TextBoxIndices.ACCOUNT ] != "" )
         {
            // write record to file at appropriate position
            try
            {
               // get account number value from TextBox
               int accountNumber = Int32.Parse( 
                  values[ ( int )TextBoxIndices.ACCOUNT ] );

               // determine whether accountNumber is valid
               if ( accountNumber > 0 && 
                  accountNumber <= NUMBER_OF_RECORDS )
               {
                  // move file position pointer
                  fileOutput.Seek( ( accountNumber - 1 ) *
                     RandomAccessRecord.SIZE, SeekOrigin.Begin );

                  // write data to file
                  binaryOutput.Write( accountNumber );
                  binaryOutput.Write(
                     values[ ( int )TextBoxIndices.FIRST ] );
                  binaryOutput.Write(
                     values[ ( int )TextBoxIndices.LAST ] );
                  binaryOutput.Write( Double.Parse( values[
                     ( int )TextBoxIndices.BALANCE ] ) );
               }
               else
               {
                  // notify user if invalid account number
                  MessageBox.Show("Invalid Account Number", "Error", 
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }

               // handle number-format exception
            catch( FormatException )
            {
               // notify user if error occurs when formatting numbers
               MessageBox.Show("Invalid Balance", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
         }

         ClearTextBoxes(); // clear text box values
   
      } // end method enterButton_Click

   } // end class WriteRandomAccessFileForm

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
