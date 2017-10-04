// Fig. 17.21: UpdateDialog.cs
// Enables user to update records in file.

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
   public class UpdateDialogForm : BankUIForm
   {
      private System.Windows.Forms.Label transactionLabel;
      private System.Windows.Forms.TextBox transactionTextBox;

      private System.Windows.Forms.Button saveButton;
      private System.Windows.Forms.Button cancelButton;

      private System.ComponentModel.Container components = null;
   
      // reference to object that handles transactions
      private Transaction transactionProxy;

      // delegate for method that displays previous window
      private MyDelegate showPreviousWindow;

      public UpdateDialogForm()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();
      }
      
      // initialize components and set members to parameter values
      public UpdateDialogForm(
         Transaction transactionProxyValue, 
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
         this.transactionTextBox = new System.Windows.Forms.TextBox();
         this.transactionLabel = new System.Windows.Forms.Label();
         this.cancelButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // accountTextBox
         // 
         this.accountTextBox.TabIndex = 0;
         this.accountTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.accountTextBox_KeyDown);
         // 
         // firstNameTextBox
         // 
         this.firstNameTextBox.TabStop = false;
         // 
         // lastNameTextBox
         // 
         this.lastNameTextBox.TabStop = false;
         // 
         // balanceTextBox
         // 
         this.balanceTextBox.TabStop = false;
         // 
         // saveButton
         // 
         this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
         this.saveButton.Location = new System.Drawing.Point(32, 288);
         this.saveButton.Name = "saveButton";
         this.saveButton.Size = new System.Drawing.Size(144, 32);
         this.saveButton.TabIndex = 3;
         this.saveButton.Text = "Save Changes";
         this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
         // 
         // transactionTextBox
         // 
         this.transactionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
         this.transactionTextBox.Location = new System.Drawing.Point(184, 240);
         this.transactionTextBox.Name = "transactionTextBox";
         this.transactionTextBox.Size = new System.Drawing.Size(185, 26);
         this.transactionTextBox.TabIndex = 1;
         this.transactionTextBox.Text = "";
         this.transactionTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.transactionTextBox_KeyDown);
         // 
         // transactionLabel
         // 
         this.transactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
         this.transactionLabel.Location = new System.Drawing.Point(24, 240);
         this.transactionLabel.Name = "transactionLabel";
         this.transactionLabel.Size = new System.Drawing.Size(136, 24);
         this.transactionLabel.TabIndex = 10;
         this.transactionLabel.Text = "Transaction";
         // 
         // cancelButton
         // 
         this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
         this.cancelButton.Location = new System.Drawing.Point(216, 288);
         this.cancelButton.Name = "cancelButton";
         this.cancelButton.Size = new System.Drawing.Size(144, 32);
         this.cancelButton.TabIndex = 4;
         this.cancelButton.Text = "Cancel";
         this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
         // 
         // UpdateDialogForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
         this.ClientSize = new System.Drawing.Size(400, 335);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.balanceTextBox,
                                                                      this.lastNameTextBox,
                                                                      this.firstNameTextBox,
                                                                      this.accountTextBox,
                                                                      this.balanceLabel,
                                                                      this.lastNameLabel,
                                                                      this.firstNameLabel,
                                                                      this.accountLabel,
                                                                      this.cancelButton,
                                                                      this.transactionLabel,
                                                                      this.transactionTextBox,
                                                                      this.saveButton});
         this.Name = "UpdateDialogForm";
         this.Text = "Update Record";
         this.ResumeLayout(false);

      }
		#endregion

      // invoked when user enters text in account TextBox
      private void accountTextBox_KeyDown(
         object sender, System.Windows.Forms.KeyEventArgs e )
      {
         // determine whether user pressed Enter key
         if ( e.KeyCode == Keys.Enter )
         {
            // retrieve record associated with account from file
            RandomAccessRecord record =
               transactionProxy.GetRecord( GetTextBoxValues()
               [ ( int )TextBoxIndices.ACCOUNT ] );

            // return if record does not exist
            if ( record == null )
               return;

            // determine whether record is empty
            if ( record.Account != 0 )
            {
               // store record values in string array
               string[] values = {
                                    record.Account.ToString(),
                                    record.FirstName.ToString(),
                                    record.LastName.ToString(),
                                    record.Balance.ToString() };

               // copy string array value to TextBox values
               SetTextBoxValues( values );
               transactionTextBox.Text = "[Charge or Payment]";

            }
            else
            {
               // notify user if record does not exist
               MessageBox.Show(
                  "Record Does Not Exist", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
         }

      } // end method accountTextBox_KeyDown

      // invoked when user enters text in transaction TextBox
      private void transactionTextBox_KeyDown(
         object sender, System.Windows.Forms.KeyEventArgs e )
      {
         // determine whether user pressed Enter key
         if ( e.KeyCode == Keys.Enter )
         {
            // calculate balance using transaction TextBox value
            try
            {
               // retrieve record associated with account from file
               RandomAccessRecord record = 
                  transactionProxy.GetRecord( GetTextBoxValues()
                  [ ( int )TextBoxIndices.ACCOUNT ] );

               // get transaction TextBox value
               double transactionValue = 
                  Double.Parse( transactionTextBox.Text );

               // calculate new balance (old balance + transaction)
               double newBalance = 
                  record.Balance + transactionValue;

               // store record values in string array
               string[] values = {
                  record.Account.ToString(),
                  record.FirstName.ToString(),
                  record.LastName.ToString(),
                  newBalance.ToString() };

               // copy string array value to TextBox values
               SetTextBoxValues( values );

               // clear transaction TextBox
               transactionTextBox.Text = "";
            }

               // notify user if error occurs in parameter mismatch
            catch( FormatException )
            {
               MessageBox.Show( 
                  "Invalid Transaction", "Error", 
                  MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
         }

      } // end method transactionTextBox_KeyDown

      // invoked when user clicks Save button
      private void saveButton_Click(
         object sender, System.EventArgs e )
      {
         RandomAccessRecord record = 
            transactionProxy.GetRecord( GetTextBoxValues()
            [ ( int )TextBoxIndices.ACCOUNT ] );

         // if record exists, update in file
         if ( record != null )
            UpdateRecord( record );

         Hide();
         ClearTextBoxes();
         showPreviousWindow();
   
      } // end method saveButton_Click

      // invoked when user clicks Cancel button
      private void cancelButton_Click(
         object sender, System.EventArgs e )
      {
         Hide();
         ClearTextBoxes();
         showPreviousWindow();
   
      } // end method cancelButton_Click

      // update record in file at position specified by accountNumber
      public void UpdateRecord( RandomAccessRecord record )
      {
         // store TextBox values in record and write record to file
         try
         {
            int accountNumber = record.Account;
            string[] values = GetTextBoxValues();

            // store values in record
            record.Account = accountNumber;
            record.FirstName = 
               values[ ( int )TextBoxIndices.FIRST ];
            record.LastName = 
               values[ ( int )TextBoxIndices.LAST ];
            record.Balance = 
               Double.Parse( 
               values[ ( int )TextBoxIndices.BALANCE ] );

            // add record to file
            if ( transactionProxy.AddRecord(
               record, accountNumber ) == false )

               return; // if error
         }

            // notify user if error occurs in parameter mismatch
         catch( FormatException )
         {
            MessageBox.Show( "Invalid Balance", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error );

            return;
         }

         MessageBox.Show( "Record Updated", "Success",
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information );

      } // end method UpdateRecord

   } // end class UpdateDialogForm
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