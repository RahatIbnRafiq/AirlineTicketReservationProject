// Fig 17.17: ReadRandomAccessFile.cs
// Reads and displays random-access file contents.

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

namespace ReadRandomAccessFile
{
   public class ReadRandomAccessFileForm : BankUIForm
   {
      private System.Windows.Forms.Button openButton;
      private System.Windows.Forms.Button nextButton;

      private System.ComponentModel.Container components = null;

      // stream through which data are read from file
      private FileStream fileInput;

      // stream for reading bytes from file
      private BinaryReader binaryInput;

      // index of current record to be displayed
      private int currentRecordIndex;

      public ReadRandomAccessFileForm()
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
         this.nextButton = new System.Windows.Forms.Button();
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
         this.openButton.Location = new System.Drawing.Point(32, 232);
         this.openButton.Name = "openButton";
         this.openButton.Size = new System.Drawing.Size(144, 32);
         this.openButton.TabIndex = 80;
         this.openButton.Text = "Open File";
         this.openButton.Click += new System.EventHandler(this.openButton_Click);
         // 
         // nextButton
         // 
         this.nextButton.Enabled = false;
         this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
         this.nextButton.Location = new System.Drawing.Point(216, 232);
         this.nextButton.Name = "nextButton";
         this.nextButton.Size = new System.Drawing.Size(144, 32);
         this.nextButton.TabIndex = 5;
         this.nextButton.Text = "Next";
         this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
         // 
         // ReadRandomAccessFileForm
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
                                                                      this.nextButton,
                                                                      this.openButton});
         this.Name = "ReadRandomAccessFileForm";
         this.Text = "Read Random-Access File";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new ReadRandomAccessFileForm() );
      }

      // invoked when user clicks Open button
      private void openButton_Click(
         object sender, System.EventArgs e )
      {
         // create dialog box enabling user to open file
         OpenFileDialog fileChooser = new OpenFileDialog();
         DialogResult result = fileChooser.ShowDialog();

         // get file name from user
         string fileName = fileChooser.FileName;

         // exit eventhandler if user clicked Cancel
         if ( result == DialogResult.Cancel )
            return;

         // show error if user specified invalid file
         if ( fileName == "" || fileName == null )
            MessageBox.Show( "Invalid File Name", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error );
         else
         {
            // create FileStream to obtain read access to file
            fileInput = new FileStream( fileName, 
               FileMode.Open, FileAccess.Read );

            // use FileStream for BinaryWriter to read bytes from file
            binaryInput = new BinaryReader( fileInput );

            openButton.Enabled = false; // disable Open button
            nextButton.Enabled = true; // enable Next button

            currentRecordIndex = 0;
            ClearTextBoxes();
         }
   
      } // end method openButton_Click

      // invoked when user clicks Next button
      private void nextButton_Click(
         object sender, System.EventArgs e )
      {
         // record to store file data
         RandomAccessRecord record = new RandomAccessRecord();

         // read record and store data in TextBoxes
         try
         {
            string[] values; // for storing TextBox values

            // get next record available in file
            while( record.Account == 0 )
            {
               // set file position pointer to next record in file
               fileInput.Seek( 
                  currentRecordIndex * RandomAccessRecord.SIZE, 0 );

               currentRecordIndex += 1;

               // read data from record
               record.Account = binaryInput.ReadInt32();
               record.FirstName = binaryInput.ReadString();
               record.LastName = binaryInput.ReadString();
               record.Balance = binaryInput.ReadDouble();
            }

            // store record values in temporary string array
            values = new string[] {
                                     record.Account.ToString(),
                                     record.FirstName,
                                     record.LastName,
                                     record.Balance.ToString() };

            // copy string array values to TextBox values
            SetTextBoxValues( values );
         }

            // handle exception when no records in file
         catch( IOException )
         {
            // close streams if no records in file
            fileInput.Close();
            binaryInput.Close();

            openButton.Enabled = true; // enable Open button
            nextButton.Enabled = false; // disable Next button
            ClearTextBoxes();

            // notify user if no records in file
            MessageBox.Show("No more records in file", "",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
         }

      } // end method nextButton_Click

   } // end class ReadRandomAccessFileForm
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