// Fig O.9: BitArrayTest.cs
// Demonstrates BitArray class.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace UsingBitArray
{
	/// <summary>
	/// implements Sieve of Eratosthenes
	/// </summary>
	public class BitArrayTest : System.Windows.Forms.Form
	{
      private System.Windows.Forms.Label promptLabel;

      // user inputs integer
      private System.Windows.Forms.TextBox inputTextBox;

      // display prime numbers
      private System.Windows.Forms.TextBox outputTextBox;

      // displays whether input integer is prime
      private System.Windows.Forms.Label displayLabel;

      private BitArray sieve;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

      // default constructor
		public BitArrayTest()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

         // create BitArray and set all bits to true
         sieve = new BitArray( 1024 );
         sieve.SetAll( true );

         int finalBit = ( int ) Math.Sqrt( sieve.Length );

         // perform sieve operation
         for ( int i = 2; i < finalBit; i++ )
            if ( sieve.Get( i ) )
               for ( int j = 2 * i; j < sieve.Length; j += i )
                  sieve.Set( j, false );

         int counter = 0;

         // display prime numbers
         for ( int i = 2; i < sieve.Length; i++ )
            if ( sieve.Get( i ) )
               outputTextBox.Text += i + 
                  ( ++counter % 7 == 0 ? "\r\n" : "   " );
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
         this.outputTextBox = new System.Windows.Forms.TextBox();
         this.displayLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // promptLabel
         // 
         this.promptLabel.AutoSize = true;
         this.promptLabel.Location = new System.Drawing.Point(8, 16);
         this.promptLabel.Name = "promptLabel";
         this.promptLabel.Size = new System.Drawing.Size(146, 13);
         this.promptLabel.TabIndex = 0;
         this.promptLabel.Text = "Enter a value from 1 to 1023";
         // 
         // inputTextBox
         // 
         this.inputTextBox.Location = new System.Drawing.Point(160, 8);
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.TabIndex = 1;
         this.inputTextBox.Text = "";
         this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
         // 
         // outputTextBox
         // 
         this.outputTextBox.Location = new System.Drawing.Point(16, 48);
         this.outputTextBox.Multiline = true;
         this.outputTextBox.Name = "outputTextBox";
         this.outputTextBox.ReadOnly = true;
         this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.outputTextBox.Size = new System.Drawing.Size(240, 160);
         this.outputTextBox.TabIndex = 2;
         this.outputTextBox.Text = "";
         // 
         // displayLabel
         // 
         this.displayLabel.Location = new System.Drawing.Point(16, 216);
         this.displayLabel.Name = "displayLabel";
         this.displayLabel.Size = new System.Drawing.Size(176, 16);
         this.displayLabel.TabIndex = 3;
         // 
         // BitArrayTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(288, 245);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.displayLabel,
                                                                      this.outputTextBox,
                                                                      this.inputTextBox,
                                                                      this.promptLabel});
         this.Name = "BitArrayTest";
         this.Text = "BitArrayTest";
         this.ResumeLayout(false);

      }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run( new BitArrayTest() );
		}

      private void inputTextBox_KeyDown(
         object sender, System.Windows.Forms.KeyEventArgs e )
      {  
         // if user pressed Enter
         if ( e.KeyCode == Keys.Enter )
         {
            int number = Convert.ToInt32( inputTextBox.Text );

            // if sieve is true at index of integer
            // input by user, then number is prime
            if ( sieve.Get( number ) )
               displayLabel.Text = number + " is a prime number";
            else
               displayLabel.Text = 
                  number + " is not a prime number";
         }
      } // end method inputTextBox_KeyDown

	} // end class BitArrayTest
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

