// Fig 17.9: CreateSequentialAccessFile.cs
// Creating a sequential-access file.

// C# namespaces
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

// Deitel namespace
using BankLibrary;

namespace CreateFile
{
   public class CreateFileForm : BankUIForm
   {
      private System.Windows.Forms.Button saveButton;
      private System.Windows.Forms.Button enterButton;
      private System.Windows.Forms.Button exitButton;

      private System.ComponentModel.Container components = null;

      // serializes Record in binary format
      private BinaryFormatter formatter = new BinaryFormatter();

      // stream through which serializable data is written to file
      private FileStream output;

      public CreateFileForm()
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
         this.saveButton = new System.Windows.Forms.Button();
         this.enterButton = new System.Windows.Forms.Button();
         this.exitButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // accountTextBox
         // 
         this.accountTextBox.TabIndex = 1;
         this.firstNameTextBox.TabIndex = 2;
         this.lastNameTextBox.TabIndex = 3;
         this.balanceTextBox.TabIndex = 4;
         // 
         // saveButton
         // 
         this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
         this.saveButton.Location = new System.Drawing.Point(16, 240);
         this.saveButton.Name = "saveButton";
         this.saveButton.Size = new System.Drawing.Size(112, 32);
         this.saveButton.TabIndex = 0;
         this.saveButton.Text = "Save As";
         this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
         // 
         // enterButton
         // 
         this.enterButton.Enabled = false;
         this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
         this.enterButton.Location = new System.Drawing.Point(144, 240);
         this.enterButton.Name = "enterButton";
         this.enterButton.Size = new System.Drawing.Size(112, 32);
         this.enterButton.TabIndex = 5;
         this.enterButton.Text = "Enter";
         this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
         // 
         // exitButton
         // 
         this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
         this.exitButton.Location = new System.Drawing.Point(272, 240);
         this.exitButton.Name = "exitButton";
         this.exitButton.Size = new System.Drawing.Size(112, 32);
         this.exitButton.TabIndex = 6;
         this.exitButton.Text = "Exit";
         this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
         // 
         // CreateFileForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
         this.ClientSize = new System.Drawing.Size(400, 287);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.balanceTextBox,
                                                                      this.lastNameTextBox,
                                                                      this.firstNameTextBox,
                                                                      this.accountTextBox,
                                                                      this.balanceLabel,
                                                                      this.lastNameLabel,
                                                                      this.firstNameLabel,
                                                                      this.accountLabel,
                                                                      this.exitButton,
                                                                      this.enterButton,
                                                                      this.saveButton});
         this.Name = "CreateFileForm";
         this.Text = "Creating a Sequential File";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new CreateFileForm() );
      }

      // invoked when user clicks Save button
      private void saveButton_Click(
         object sender, System.EventArgs e )
      {
         // create dialog box enabling user to save file
         SaveFileDialog fileChooser = new SaveFileDialog();
         DialogResult result = fileChooser.ShowDialog();
         string fileName; // name of file to save data

         // allow user to create file
         fileChooser.CheckFileExists = false;

         // exit event handler if user clicked "Cancel"
         if ( result == DialogResult.Cancel )
            return;

         // get specified file name
         fileName = fileChooser.FileName;

         // show error if user specified invalid file
         if ( fileName == "" || fileName == null )
            MessageBox.Show( "Invlaid File Name", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error );
         else
         {
            // save file via FileStream if user specified valid file
            try
            {
               // open file with write access
               output = new FileStream( fileName,
                  FileMode.OpenOrCreate, FileAccess.Write );

               // disable Save button and enable Enter button
               saveButton.Enabled = false;
               enterButton.Enabled = true;
            }

               // handle exception if file does not exist
            catch ( FileNotFoundException )
            {
               // notify user if file does not exist
               MessageBox.Show( "File Does Not Exist", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
         }
      } // end method saveButton_Click

      // invoke when user clicks Enter button
      private void enterButton_Click(
         object sender, System.EventArgs e )
      {
         // store TextBox values string array
         string[] values = GetTextBoxValues();

         // Record containing TextBox values to serialize
         Record record = new Record();

         // determine whether TextBox account field is empty
         if ( values[ ( int )TextBoxIndices.ACCOUNT ] != "" )
         {
            // store TextBox values in Record and serialize Record
            try
            {
               // get account number value from TextBox
               int accountNumber = Int32.Parse( 
                  values[ ( int )TextBoxIndices.ACCOUNT ] );

               // determine whether accountNumber is valid
               if ( accountNumber > 0 )
               {
                  // store TextBox fields in Record
                  record.Account = accountNumber;
                  record.FirstName =
                     values[ ( int )TextBoxIndices.FIRST ];
                  record.LastName =
                     values[ ( int )TextBoxIndices.LAST ];
                  record.Balance = Double.Parse( values[
                     ( int )TextBoxIndices.BALANCE ] );

                  // write Record to FileStream (serialize object)
                  formatter.Serialize( output, record );
               }
               else
               {
                  // notify user if invalid account number
                  MessageBox.Show( "Invalid Account Number", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error );
               }
            }

               // notify user if error occurs in serialization
            catch( SerializationException )
            {
               MessageBox.Show( "Error Writing to File", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
               // notify user if error occurs regarding parameter format
            catch( FormatException )
            {
               MessageBox.Show( "Invalid Format", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
         }

         ClearTextBoxes(); // clear TextBox values

      } // end method enterButton_Click

      // invoked when user clicks Exit button
      private void exitButton_Click(
         object sender, System.EventArgs e )
      {
         // determine whether file exists
         if ( output != null )
         {
            // close file
            try
            {
               output.Close();
            }

               // notify user of error closing file
            catch( IOException )
            {
               MessageBox.Show( "Cannot close file", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
         }

         Application.Exit();
   
      } // end method exitButton_Click

   } // end class CreateFileForm
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