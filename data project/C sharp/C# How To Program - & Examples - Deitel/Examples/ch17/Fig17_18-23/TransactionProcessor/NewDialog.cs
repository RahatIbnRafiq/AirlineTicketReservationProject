// Fig. 17.22: NewDialog.cs
// Enables user to insert new record into file.

// C# namespaces
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

// Deitel namespaces
using BankLibrary;
               
namespace TransactionProcessor
{            
   public class NewDialogForm : BankUIForm
   {
      private System.Windows.Forms.Button saveButton;
      private System.Windows.Forms.Button cancelButton;

      private System.ComponentModel.Container components = null;

      // reference to object that handles transactions
      private Transaction transactionProxy;

      // delegate for method that displays previous window
      public MyDelegate showPreviousWindow;

      public NewDialogForm( )
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();
      }

      // constructor
      public NewDialogForm( Transaction transactionProxyValue,
         MyDelegate delegateValue )
      {
         InitializeComponent();
         showPreviousWindow = delegateValue;

         // instantiate object that handles transactions
         transactionProxy = transactionProxyValue;
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if( disposing )
         {
            if(components != null)
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
         this.cancelButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // accountTextBox
         // 
         this.accountTextBox.TabIndex = 0;
         // 
         // firstNameTextBox
         // 
         this.firstNameTextBox.TabIndex = 1;
         // 
         // lastNameTextBox
         // 
         this.lastNameTextBox.TabIndex = 2;
         // 
         // balanceTextBox
         // 
         this.balanceTextBox.TabIndex = 3;
         // 
         // saveButton
         // 
         this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
         this.saveButton.Location = new System.Drawing.Point(32, 232);
         this.saveButton.Name = "saveButton";
         this.saveButton.Size = new System.Drawing.Size(144, 32);
         this.saveButton.TabIndex = 4;
         this.saveButton.Text = "Save Record";
         this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
         // 
         // cancelButton
         // 
         this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
         this.cancelButton.Location = new System.Drawing.Point(216, 232);
         this.cancelButton.Name = "cancelButton";
         this.cancelButton.Size = new System.Drawing.Size(144, 32);
         this.cancelButton.TabIndex = 5;
         this.cancelButton.Text = "Cancel";
         this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
         // 
         // NewDialogForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
         this.ClientSize = new System.Drawing.Size(400, 279);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.cancelButton,
                                                                      this.balanceTextBox,
                                                                      this.lastNameTextBox,
                                                                      this.firstNameTextBox,
                                                                      this.accountTextBox,
                                                                      this.balanceLabel,
                                                                      this.lastNameLabel,
                                                                      this.firstNameLabel,
                                                                      this.accountLabel,
                                                                      this.saveButton});
         this.Name = "NewDialogForm";
         this.Text = "Create Record";
         this.ResumeLayout(false);

      }
		#endregion

      // invoked when user clicks Cancel button
      private void cancelButton_Click(
         object sender, System.EventArgs e )
      {
         Hide();
         ClearTextBoxes();
         showPreviousWindow();

      } // end method cancelButton_Click

      // invoked when user clicks Save As button
      private void saveButton_Click(
         object sender, System.EventArgs e )
      {
         RandomAccessRecord record =
            transactionProxy.GetRecord( GetTextBoxValues()
            [ ( int )TextBoxIndices.ACCOUNT ] );

         // if record exists, add it to file
         if ( record != null )
            InsertRecord( record );

         Hide();
         ClearTextBoxes();
         showPreviousWindow();

      } // end method saveButton_Click

      // insert record in file at position specified by accountNumber
      private void InsertRecord( RandomAccessRecord record )
      {
         //store TextBox values in string array
         string[] textBoxValues = GetTextBoxValues();

         // store TextBox account field
         int accountNumber = Int32.Parse(
            textBoxValues[ ( int )TextBoxIndices.ACCOUNT ] );

         // notify user and return if record account is not empty
         if ( record.Account != 0 )
         {
            MessageBox.Show(
               "Record Already Exists or Invalid Number", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
         }

         // store values in record
         record.Account = accountNumber;
         record.FirstName = 
            textBoxValues[ ( int )TextBoxIndices.FIRST];
         record.LastName = 
            textBoxValues[ ( int )TextBoxIndices.LAST];
         record.Balance = Double.Parse( 
            textBoxValues[ ( int )TextBoxIndices.BALANCE ] );

         // add record to file
         try
         {
            if ( transactionProxy.AddRecord(
               record, accountNumber ) == false )

               return; // if error
         }

            // notify user if error occurs in parameter mismatch
         catch( FormatException )
         {
            MessageBox.Show( "Invalid Balance", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error );
         }

         MessageBox.Show( "Record Created", "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information );

      } // end method InsertRecord

   } // end class NewDialogForm
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