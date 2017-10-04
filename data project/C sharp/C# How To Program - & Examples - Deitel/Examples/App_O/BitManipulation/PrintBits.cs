// Fig O.5: PrintBits.cs
// Printing the bits that constitute an integer.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace BitManipulation
{
	/// <summary>
	/// displays bit representation of user input
	/// </summary>
   public class PrintBits : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label promptLabel;
      private System.Windows.Forms.Label viewLabel;

      // for user input
      private System.Windows.Forms.TextBox inputTextBox;
      
      // bit representation displayed here
      private System.Windows.Forms.Label displayLabel;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      // default constructor
      public PrintBits()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();

         //
         // TODO: Add any constructor code after InitializeComponent call
         //
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
         this.promptLabel = new System.Windows.Forms.Label();
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.viewLabel = new System.Windows.Forms.Label();
         this.displayLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // promptLabel
         // 
         this.promptLabel.AutoSize = true;
         this.promptLabel.Location = new System.Drawing.Point(8, 16);
         this.promptLabel.Name = "promptLabel";
         this.promptLabel.Size = new System.Drawing.Size(88, 13);
         this.promptLabel.TabIndex = 0;
         this.promptLabel.Text = "Enter an integer:";
         // 
         // inputTextBox
         // 
         this.inputTextBox.Location = new System.Drawing.Point(104, 16);
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.TabIndex = 1;
         this.inputTextBox.Text = "";
         this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
         // 
         // viewLabel
         // 
         this.viewLabel.AutoSize = true;
         this.viewLabel.Location = new System.Drawing.Point(208, 16);
         this.viewLabel.Name = "viewLabel";
         this.viewLabel.Size = new System.Drawing.Size(108, 13);
         this.viewLabel.TabIndex = 2;
         this.viewLabel.Text = "The integer in bits is:";
         // 
         // displayLabel
         // 
         this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.displayLabel.Location = new System.Drawing.Point(320, 16);
         this.displayLabel.Name = "displayLabel";
         this.displayLabel.Size = new System.Drawing.Size(224, 23);
         this.displayLabel.TabIndex = 3;
         // 
         // PrintBits
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(552, 53);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.displayLabel,
                                                                      this.viewLabel,
                                                                      this.inputTextBox,
                                                                      this.promptLabel});
         this.Name = "PrintBits";
         this.Text = "PrintBits";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new PrintBits() );
      }

      // process integer when user presses Enter
      private void inputTextBox_KeyDown(
         object sender, System.Windows.Forms.KeyEventArgs e )
      {
         // if user pressed Enter
         if ( e.KeyCode == Keys.Enter )
         {
            // test whether user enetered an integer
            try
            {
               displayLabel.Text = GetBits( 
                  Convert.ToInt32( inputTextBox.Text ) );
            }

               // if value is not integer, exception is thrown
            catch ( FormatException )
            {
               MessageBox.Show( "Please Enter an Integer",
                  "Error", MessageBoxButtons.OK,
                  MessageBoxIcon.Error );
            }
         }

      } // end method inputTextBox_KeyDown

      // convert integer to its bit representation
      public string GetBits( int number )
      {
         int displayMask = 1 << 31;

         StringBuilder output = new StringBuilder();

         // get each bit, add space every 8 bits 
         // for display formatting
         for ( int c = 1; c <= 32; c++ )
         {
            // append 0 or 1 depending on result of masking
            output.Append( 
               ( number & displayMask ) == 0 ? "0" : "1" );

            // shift left so that mask will find bit of 
            // next digit during next iteration of loop
            number <<= 1;

            if ( c % 8 == 0 )
               output.Append( " " );
         }

         return output.ToString();

      } // end method GetBits

   } // end class PrintBits
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
