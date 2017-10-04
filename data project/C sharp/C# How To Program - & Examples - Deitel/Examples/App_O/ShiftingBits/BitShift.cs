// Fig O.7: BitShift.cs
// Demonstrates bitshift operators.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace ShiftingBits
{
	/// <summary>
	/// shifts bits to the right or left
	/// </summary>
	public class BitShift : System.Windows.Forms.Form
	{
      private System.Windows.Forms.Label inputLabel;

      // accepts user input
      private System.Windows.Forms.TextBox inputTextBox;

      // displays integer in bits
      private System.Windows.Forms.Label displayLabel;
      private System.Windows.Forms.Button leftButton;
      private System.Windows.Forms.Button rightButton;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

      // default constructor
		public BitShift()
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
         this.inputLabel = new System.Windows.Forms.Label();
         this.displayLabel = new System.Windows.Forms.Label();
         this.leftButton = new System.Windows.Forms.Button();
         this.rightButton = new System.Windows.Forms.Button();
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // inputLabel
         // 
         this.inputLabel.Location = new System.Drawing.Point(24, 24);
         this.inputLabel.Name = "inputLabel";
         this.inputLabel.TabIndex = 0;
         this.inputLabel.Text = "Integer to shift:";
         // 
         // displayLabel
         // 
         this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.displayLabel.Location = new System.Drawing.Point(32, 64);
         this.displayLabel.Name = "displayLabel";
         this.displayLabel.Size = new System.Drawing.Size(224, 23);
         this.displayLabel.TabIndex = 1;
         // 
         // leftButton
         // 
         this.leftButton.Location = new System.Drawing.Point(40, 112);
         this.leftButton.Name = "leftButton";
         this.leftButton.Size = new System.Drawing.Size(88, 48);
         this.leftButton.TabIndex = 2;
         this.leftButton.Text = "<<";
         this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
         // 
         // rightButton
         // 
         this.rightButton.Location = new System.Drawing.Point(152, 112);
         this.rightButton.Name = "rightButton";
         this.rightButton.Size = new System.Drawing.Size(88, 48);
         this.rightButton.TabIndex = 3;
         this.rightButton.Text = ">>";
         this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
         // 
         // inputTextBox
         // 
         this.inputTextBox.Location = new System.Drawing.Point(152, 24);
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.TabIndex = 4;
         this.inputTextBox.Text = "";
         this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
         // 
         // BitShift
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 181);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.inputTextBox,
                                                                      this.rightButton,
                                                                      this.leftButton,
                                                                      this.displayLabel,
                                                                      this.inputLabel});
         this.Name = "BitShift";
         this.Text = "BitShift";
         this.ResumeLayout(false);

      }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run( new BitShift() );
		}

      // process user input
      private void inputTextBox_KeyDown(
         object sender, System.Windows.Forms.KeyEventArgs e )
      {
         if ( e.KeyCode == Keys.Enter )
            displayLabel.Text =
               GetBits( Convert.ToInt32( inputTextBox.Text ) );
      }

      // do left shift
      private void leftButton_Click(
         object sender, System.EventArgs e )
      {
         // retrieve user input
         int number = Convert.ToInt32( inputTextBox.Text );

         // do left shift operation
         number <<= 1;

         // convert to integer and display in textbox
         inputTextBox.Text = number.ToString();

         // display bits in label
         displayLabel.Text = GetBits( number );
      }

      // do right shift 
      private void rightButton_Click(
         object sender, System.EventArgs e )
      {
         // retrieve user input
         int number = Convert.ToInt32( inputTextBox.Text );

         // do right shift operation
         number >>= 1;

         // convert to integer and display in textbox
         inputTextBox.Text = number.ToString();

         // display bits in label
         displayLabel.Text = GetBits( number );
      }

      // convert integer to its bit representation
      private string GetBits( int number )
      {
         int displayMask = 1 << 31;

         StringBuilder output = new StringBuilder();

         // get each bit, add space every 8 bits 
         // for display formatting
         for ( int c = 1; c <= 32; c++ )
         {
            // append a 0 or 1 depending on the result of masking
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

	} // end class BitShift
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

