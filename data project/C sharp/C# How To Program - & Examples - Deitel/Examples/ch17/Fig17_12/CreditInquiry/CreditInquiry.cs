// Fig. 17.12: CreditInquiry.cs
// Read a file sequentially and display contents based on
// account type specified by user (credit, debit or zero balances).

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

namespace CreditInquiry
{
   public class CreditInquiryForm : System.Windows.Forms.Form
   {
      private System.Windows.Forms.RichTextBox displayTextBox;

      private System.Windows.Forms.Button doneButton;
      private System.Windows.Forms.Button zeroButton;
      private System.Windows.Forms.Button debitButton;
      private System.Windows.Forms.Button creditButton;
      private System.Windows.Forms.Button openButton;

      private System.ComponentModel.Container components = null;

      // stream through which serializable data are read from file
      private FileStream input;

      // object for deserializing CRecord in binary format
      BinaryFormatter reader = new BinaryFormatter();

      // name of file that stores credit, debit and zero balances
      private String fileName;

      public CreditInquiryForm()
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
         this.doneButton = new System.Windows.Forms.Button();
         this.zeroButton = new System.Windows.Forms.Button();
         this.debitButton = new System.Windows.Forms.Button();
         this.creditButton = new System.Windows.Forms.Button();
         this.openButton = new System.Windows.Forms.Button();
         this.displayTextBox = new System.Windows.Forms.RichTextBox();
         this.SuspendLayout();
         // 
         // doneButton
         // 
         this.doneButton.Location = new System.Drawing.Point(696, 216);
         this.doneButton.Name = "doneButton";
         this.doneButton.Size = new System.Drawing.Size(123, 40);
         this.doneButton.TabIndex = 12;
         this.doneButton.Text = "Done";
         this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
         // 
         // zeroButton
         // 
         this.zeroButton.Enabled = false;
         this.zeroButton.Location = new System.Drawing.Point(532, 216);
         this.zeroButton.Name = "zeroButton";
         this.zeroButton.Size = new System.Drawing.Size(123, 40);
         this.zeroButton.TabIndex = 11;
         this.zeroButton.Text = "Zero Balances";
         this.zeroButton.Click += new System.EventHandler(this.get_Click);
         // 
         // debitButton
         // 
         this.debitButton.Enabled = false;
         this.debitButton.Location = new System.Drawing.Point(369, 216);
         this.debitButton.Name = "debitButton";
         this.debitButton.Size = new System.Drawing.Size(123, 40);
         this.debitButton.TabIndex = 10;
         this.debitButton.Text = "Debit Balances";
         this.debitButton.Click += new System.EventHandler(this.get_Click);
         // 
         // creditButton
         // 
         this.creditButton.Enabled = false;
         this.creditButton.Location = new System.Drawing.Point(205, 216);
         this.creditButton.Name = "creditButton";
         this.creditButton.Size = new System.Drawing.Size(123, 40);
         this.creditButton.TabIndex = 9;
         this.creditButton.Text = "Credit Balances";
         this.creditButton.Click += new System.EventHandler(this.get_Click);
         // 
         // openButton
         // 
         this.openButton.Location = new System.Drawing.Point(41, 216);
         this.openButton.Name = "openButton";
         this.openButton.Size = new System.Drawing.Size(123, 40);
         this.openButton.TabIndex = 8;
         this.openButton.Text = "Open File";
         this.openButton.Click += new System.EventHandler(this.openButton_Click);
         // 
         // displayTextBox
         // 
         this.displayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.displayTextBox.Location = new System.Drawing.Point(10, 20);
         this.displayTextBox.Name = "displayTextBox";
         this.displayTextBox.Size = new System.Drawing.Size(830, 180);
         this.displayTextBox.TabIndex = 13;
         this.displayTextBox.Text = "";
         // 
         // CreditInquiryForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
         this.ClientSize = new System.Drawing.Size(849, 271);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.doneButton,
                                                                      this.zeroButton,
                                                                      this.debitButton,
                                                                      this.creditButton,
                                                                      this.openButton,
                                                                      this.displayTextBox});
         this.Name = "CreditInquiryForm";
         this.Text = "CreditInquiry";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new CreditInquiryForm() );
      }

      // invoked when user clicks Open File button
      private void openButton_Click(
         object sender, System.EventArgs e )
      {
         // create dialog box enabling user to open file
         OpenFileDialog fileChooser = new OpenFileDialog();
         DialogResult result = fileChooser.ShowDialog();

         // exit event handler if user clicked Cancel
         if ( result == DialogResult.Cancel )
            return;

         // get name from user
         fileName = fileChooser.FileName;

         // show error if user specified invalid file
         if ( fileName == "" || fileName == null )
            MessageBox.Show( "Invalid File Name", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error );
         else
         {
            // enable all GUI buttons, except for Open File button
            openButton.Enabled = false;
            creditButton.Enabled = true;
            debitButton.Enabled = true;
            zeroButton.Enabled = true;
         }
   
      } // end method openButton_Click

      // invoked when user clicks credit balances,
      // debit balances or zero balances button
      private void get_Click( object sender, System.EventArgs e )
      {
         // convert sender explicitly to object of type button
         Button senderButton = ( Button )sender;

         // get text from clicked Button, which stores account type
         string accountType = senderButton.Text;

         // read and display file information
         try
         {
            // close file from previous operation
            if ( input != null )
               input.Close();

            // create FileStream to obtain read access to file
            input = new FileStream( fileName, FileMode.Open,
               FileAccess.Read );

            displayTextBox.Text = "The accounts are:\r\n";

            // traverse file until end of file
            while ( true )
            {
               // get next Record available in file
               Record record = ( Record )reader.Deserialize( input );

               // store record's last field in balance
               Double balance = record.Balance;

               // determine whether to display balance
               if ( ShouldDisplay( balance, accountType ) )
               {
                  // display record
                  string output = record.Account + "\t" +
                     record.FirstName + "\t" + record.LastName +
                     new string( ' ', 6 ) + "\t";

                  // display balance with correct monetary format
                  output += String.Format( 
                     "{0:F}", balance ) + "\r\n";

                  // copy output to screen
                  displayTextBox.Text += output; 
               }
            }
         }

            // handle exception when file cannot be closed
         catch( IOException )
         {
            MessageBox.Show( "Cannot Close File", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error );
         }
      
            // handle exception when no more records
         catch( SerializationException )
         {
            // close FileStream if no Records in file
            input.Close(); 
         }

      } // end method get_Click

      // determine whether to display given record
      private bool ShouldDisplay( double balance, string accountType )
      {
         if ( balance > 0 )
         {
            // display credit balances
            if ( accountType == "Credit Balances" )
               return true;
         }

         else if ( balance < 0 )
         {
            // display debit balances
            if ( accountType == "Debit Balances" )
               return true;
         }

         else // balance == 0
         {
            // display zero balances
            if ( accountType == "Zero Balances" )
               return true;
         }

         return false;

      } // end method ShouldDisplay

      // invoked when user clicks Done button
      private void doneButton_Click(
         object sender, System.EventArgs e )
      {
         // determine whether file exists
         if ( input != null )
         {
            // close file
            try
            {
               input.Close();
            }

               // handle exception if FileStream does not exist
            catch( IOException )
            {
               // notify user of error closing file
               MessageBox.Show( "Cannot close file", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }

         Application.Exit();
   
      } // end method doneButton_Click

   } // end class CreditInquiryForm
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