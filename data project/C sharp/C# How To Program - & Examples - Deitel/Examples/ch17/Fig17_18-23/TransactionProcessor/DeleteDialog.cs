// Fig. 17.23: DeleteDialog.cs
// Enables user to delete records in file.

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
   public class DeleteDialogForm : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label accountLabel;
      private System.Windows.Forms.TextBox accountTextBox;

      private System.Windows.Forms.Button deleteButton;
      private System.Windows.Forms.Button cancelButton;

      private System.ComponentModel.Container components = null;

      // reference to object that handles transactions
      private Transaction transactionProxy;

      // delegate for method that displays previous window
      private MyDelegate showPreviousWindow;

      public DeleteDialogForm()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();
      }

      // initialize components and set members to parameter values
      public DeleteDialogForm( Transaction transactionProxyValue, 
         MyDelegate delegateValue)
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
         this.accountLabel = new System.Windows.Forms.Label();
         this.cancelButton = new System.Windows.Forms.Button();
         this.accountTextBox = new System.Windows.Forms.TextBox();
         this.deleteButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // accountLabel
         // 
         this.accountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.accountLabel.Location = new System.Drawing.Point(24, 16);
         this.accountLabel.Name = "accountLabel";
         this.accountLabel.Size = new System.Drawing.Size(136, 20);
         this.accountLabel.TabIndex = 0;
         this.accountLabel.Text = "Account Number";
         this.accountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // cancelButton
         // 
         this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.cancelButton.Location = new System.Drawing.Point(176, 64);
         this.cancelButton.Name = "cancelButton";
         this.cancelButton.Size = new System.Drawing.Size(133, 32);
         this.cancelButton.TabIndex = 0;
         this.cancelButton.Text = "Cancel";
         this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
         // 
         // accountTextBox
         // 
         this.accountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.accountTextBox.Location = new System.Drawing.Point(176, 16);
         this.accountTextBox.Name = "accountTextBox";
         this.accountTextBox.Size = new System.Drawing.Size(128, 26);
         this.accountTextBox.TabIndex = 3;
         this.accountTextBox.Text = "";
         // 
         // deleteButton
         // 
         this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.deleteButton.Location = new System.Drawing.Point(16, 64);
         this.deleteButton.Name = "deleteButton";
         this.deleteButton.Size = new System.Drawing.Size(133, 32);
         this.deleteButton.TabIndex = 1;
         this.deleteButton.Text = "Delete Record";
         this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
         // 
         // DeleteDialogForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
         this.ClientSize = new System.Drawing.Size(328, 111);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.cancelButton,
                                                                      this.deleteButton,
                                                                      this.accountTextBox,
                                                                      this.accountLabel});
         this.Name = "DeleteDialogForm";
         this.Text = "Delete Record";
         this.ResumeLayout(false);

      }
		#endregion

      // invoked when user clicks Delete Record button
      private void deleteButton_Click(
         object sender, System.EventArgs e)
      {
         RandomAccessRecord record =
            transactionProxy.GetRecord( accountTextBox.Text );

         // if record exists, delete it in file
         if ( record != null )
            DeleteRecord( record );

         this.Hide();
         showPreviousWindow();

      } // end method deleteButton_Click

      // invoked when user clicks Cancel button
      private void cancelButton_Click(
         object sender, System.EventArgs e)
      {
         this.Hide();
         showPreviousWindow();
   
      } // end method cancelButton_Click

      // delete record in file at position specified by accountNumber
      public void DeleteRecord( RandomAccessRecord record )
      {
         int accountNumber = record.Account;

         // display error message if record does not exist
         if ( record.Account == 0 )
         {
            MessageBox.Show( "Record Does Not Exist", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error );
            accountTextBox.Clear();

            return;
         }

         // create blank record
         record = new RandomAccessRecord();

         // write over file record with empty record
         if ( transactionProxy.AddRecord(
            record, accountNumber ) == true )

            // notify user of successful deletion
            MessageBox.Show( "Record Deleted", "Success",
               MessageBoxButtons.OK, MessageBoxIcon.Information );
         else

            // notify user of failure
            MessageBox.Show( 
               "Record could not be deleted", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error );

         accountTextBox.Clear();

      } // end method DeleteRecord

   } // end class DeleteDialogForm
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