// Fig. 17.11: ReadSequentialAccessFile.cs
// Reading a sequential-access file.

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

// Deitel namespaces
using BankLibrary;

namespace ReadSequentialAccess
{
   public class ReadSequentialAccessFileForm : BankUIForm
   {
      System.Windows.Forms.Button openButton;
      System.Windows.Forms.Button nextButton;

      private System.ComponentModel.Container components = null;

      // stream through which serializable data are read from file
      private FileStream input;

      // object for deserializing Record in binary format
      private BinaryFormatter reader = new BinaryFormatter();

      public ReadSequentialAccessFileForm()
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
         this.openButton.TabIndex = 0;
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
         this.nextButton.Text = "Next Record";
         this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
         // 
         // ReadSequentialAccessFileForm
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
         this.Name = "ReadSequentialAccessFileForm";
         this.Text = "Reading a Sequential File";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new ReadSequentialAccessFileForm() );
      }

      // invoked when user clicks Open button
      private void openButton_Click(
         object sender, System.EventArgs e )
      {
         // create dialog box enabling user to open file
         OpenFileDialog fileChooser = new OpenFileDialog();
         DialogResult result = fileChooser.ShowDialog();
         string fileName; // name of file containing data

         // exit event handler if user clicked Cancel
         if ( result == DialogResult.Cancel )
            return;

         // get specified file name
         fileName = fileChooser.FileName; 
         ClearTextBoxes();

         // show error if user specified invalid file
         if ( fileName == "" || fileName == null )
            MessageBox.Show( "Invalid File Name", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error );
         else
         {
            // create FileStream to obtain read access to file
            input = new FileStream( fileName, FileMode.Open,
               FileAccess.Read );

            // enable next record button
            nextButton.Enabled = true;
         }
   
      } // end method openButton_Click

      // invoked when user clicks Next button
      private void nextButton_Click(
         object sender, System.EventArgs e )
      {
         // deserialize Record and store data in TextBoxes
         try
         {
            // get next Record available in file
            Record record =
               ( Record )reader.Deserialize( input );

            // store Record values in temporary string array
            string[] values = new string[] { 
                                              record.Account.ToString(),
                                              record.FirstName.ToString(),
                                              record.LastName.ToString(),
                                              record.Balance.ToString() };

            // copy string array values to TextBox values
            SetTextBoxValues( values );
         }

            // handle exception when no Records in file
         catch( SerializationException )
         {
            // close FileStream if no Records in file
            input.Close(); 

            // enable Open Record button
            openButton.Enabled = true; 

            // disable Next Record button
            nextButton.Enabled = false; 

            ClearTextBoxes();

            // notify user if no Records in file
            MessageBox.Show( "No more records in file", "",
               MessageBoxButtons.OK, MessageBoxIcon.Information );
         }

      } // end method nextButton_Click

   } // end class readSequentialAccessFileForm
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