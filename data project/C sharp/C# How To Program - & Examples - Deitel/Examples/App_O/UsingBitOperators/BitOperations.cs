// Fig. O.6: BitOperations.cs
// A class that demonstrates miscellaneous bit operations

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace UsingBitOperators
{
	/// <summary>
	/// allows user to test bit operators
	/// </summary>
	public class BitOperations : System.Windows.Forms.Form
	{
      private System.Windows.Forms.Label promptLabel;
      private System.Windows.Forms.Label representationLabel;
      private System.Windows.Forms.Label value1Label;
      private System.Windows.Forms.Label value2Label;
      private System.Windows.Forms.Label resultLabel;

      // display bit reprentations
      private System.Windows.Forms.Label bit1Label;
      private System.Windows.Forms.Label bit2Label;
      private System.Windows.Forms.Label resultBitLabel;

      // allow user to perform bit operations
      private System.Windows.Forms.Button andButton;
      private System.Windows.Forms.Button inclusiveOrButton;
      private System.Windows.Forms.Button exclusiveOrButton;
      private System.Windows.Forms.Button complementButton;

      // user inputs two integers
      private System.Windows.Forms.TextBox bit1TextBox;
      private System.Windows.Forms.TextBox bit2TextBox;

      private System.Windows.Forms.TextBox resultTextBox;

      private int value1, value2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		// default constructor
		public BitOperations()
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
         this.representationLabel = new System.Windows.Forms.Label();
         this.value1Label = new System.Windows.Forms.Label();
         this.value2Label = new System.Windows.Forms.Label();
         this.resultLabel = new System.Windows.Forms.Label();
         this.bit1Label = new System.Windows.Forms.Label();
         this.bit2Label = new System.Windows.Forms.Label();
         this.resultBitLabel = new System.Windows.Forms.Label();
         this.bit1TextBox = new System.Windows.Forms.TextBox();
         this.bit2TextBox = new System.Windows.Forms.TextBox();
         this.resultTextBox = new System.Windows.Forms.TextBox();
         this.andButton = new System.Windows.Forms.Button();
         this.inclusiveOrButton = new System.Windows.Forms.Button();
         this.exclusiveOrButton = new System.Windows.Forms.Button();
         this.complementButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // promptLabel
         // 
         this.promptLabel.AutoSize = true;
         this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.promptLabel.Location = new System.Drawing.Point(64, 8);
         this.promptLabel.Name = "promptLabel";
         this.promptLabel.Size = new System.Drawing.Size(107, 14);
         this.promptLabel.TabIndex = 0;
         this.promptLabel.Text = "Enter two integers:";
         // 
         // representationLabel
         // 
         this.representationLabel.AutoSize = true;
         this.representationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.representationLabel.Location = new System.Drawing.Point(296, 8);
         this.representationLabel.Name = "representationLabel";
         this.representationLabel.Size = new System.Drawing.Size(111, 14);
         this.representationLabel.TabIndex = 1;
         this.representationLabel.Text = "Bit representations:";
         // 
         // value1Label
         // 
         this.value1Label.AutoSize = true;
         this.value1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.value1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.value1Label.Location = new System.Drawing.Point(16, 40);
         this.value1Label.Name = "value1Label";
         this.value1Label.Size = new System.Drawing.Size(52, 16);
         this.value1Label.TabIndex = 2;
         this.value1Label.Text = "Value 1:";
         // 
         // value2Label
         // 
         this.value2Label.AutoSize = true;
         this.value2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.value2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.value2Label.Location = new System.Drawing.Point(16, 72);
         this.value2Label.Name = "value2Label";
         this.value2Label.Size = new System.Drawing.Size(52, 16);
         this.value2Label.TabIndex = 3;
         this.value2Label.Text = "Value 2:";
         // 
         // resultLabel
         // 
         this.resultLabel.AutoSize = true;
         this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.resultLabel.Location = new System.Drawing.Point(16, 104);
         this.resultLabel.Name = "resultLabel";
         this.resultLabel.Size = new System.Drawing.Size(45, 16);
         this.resultLabel.TabIndex = 4;
         this.resultLabel.Text = "Result:";
         // 
         // bit1Label
         // 
         this.bit1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.bit1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.bit1Label.Location = new System.Drawing.Point(200, 40);
         this.bit1Label.Name = "bit1Label";
         this.bit1Label.Size = new System.Drawing.Size(248, 16);
         this.bit1Label.TabIndex = 5;
         // 
         // bit2Label
         // 
         this.bit2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.bit2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.bit2Label.Location = new System.Drawing.Point(200, 72);
         this.bit2Label.Name = "bit2Label";
         this.bit2Label.Size = new System.Drawing.Size(248, 16);
         this.bit2Label.TabIndex = 6;
         // 
         // resultBitLabel
         // 
         this.resultBitLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.resultBitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.resultBitLabel.Location = new System.Drawing.Point(200, 104);
         this.resultBitLabel.Name = "resultBitLabel";
         this.resultBitLabel.Size = new System.Drawing.Size(248, 16);
         this.resultBitLabel.TabIndex = 7;
         // 
         // bit1TextBox
         // 
         this.bit1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.bit1TextBox.Location = new System.Drawing.Point(88, 40);
         this.bit1TextBox.Name = "bit1TextBox";
         this.bit1TextBox.TabIndex = 8;
         this.bit1TextBox.Text = "";
         // 
         // bit2TextBox
         // 
         this.bit2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.bit2TextBox.Location = new System.Drawing.Point(88, 72);
         this.bit2TextBox.Name = "bit2TextBox";
         this.bit2TextBox.TabIndex = 9;
         this.bit2TextBox.Text = "";
         // 
         // resultTextBox
         // 
         this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.resultTextBox.Location = new System.Drawing.Point(88, 104);
         this.resultTextBox.Name = "resultTextBox";
         this.resultTextBox.TabIndex = 10;
         this.resultTextBox.Text = "";
         // 
         // andButton
         // 
         this.andButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.andButton.Location = new System.Drawing.Point(16, 136);
         this.andButton.Name = "andButton";
         this.andButton.Size = new System.Drawing.Size(96, 40);
         this.andButton.TabIndex = 11;
         this.andButton.Text = "AND";
         this.andButton.Click += new System.EventHandler(this.andButton_Click);
         // 
         // inclusiveOrButton
         // 
         this.inclusiveOrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.inclusiveOrButton.Location = new System.Drawing.Point(128, 136);
         this.inclusiveOrButton.Name = "inclusiveOrButton";
         this.inclusiveOrButton.Size = new System.Drawing.Size(96, 40);
         this.inclusiveOrButton.TabIndex = 12;
         this.inclusiveOrButton.Text = "Inclusive OR";
         this.inclusiveOrButton.Click += new System.EventHandler(this.inclusiveOrButton_Click);
         // 
         // exclusiveOrButton
         // 
         this.exclusiveOrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.exclusiveOrButton.Location = new System.Drawing.Point(240, 136);
         this.exclusiveOrButton.Name = "exclusiveOrButton";
         this.exclusiveOrButton.Size = new System.Drawing.Size(96, 40);
         this.exclusiveOrButton.TabIndex = 13;
         this.exclusiveOrButton.Text = "Exclusive Or";
         this.exclusiveOrButton.Click += new System.EventHandler(this.exclusiveOrButton_Click);
         // 
         // complementButton
         // 
         this.complementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.complementButton.Location = new System.Drawing.Point(352, 136);
         this.complementButton.Name = "complementButton";
         this.complementButton.Size = new System.Drawing.Size(96, 40);
         this.complementButton.TabIndex = 14;
         this.complementButton.Text = "Complement";
         this.complementButton.Click += new System.EventHandler(this.complementButton_Click);
         // 
         // BitOperations
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(472, 189);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.complementButton,
                                                                      this.exclusiveOrButton,
                                                                      this.inclusiveOrButton,
                                                                      this.andButton,
                                                                      this.resultTextBox,
                                                                      this.bit2TextBox,
                                                                      this.bit1TextBox,
                                                                      this.resultBitLabel,
                                                                      this.bit2Label,
                                                                      this.bit1Label,
                                                                      this.resultLabel,
                                                                      this.value2Label,
                                                                      this.value1Label,
                                                                      this.representationLabel,
                                                                      this.promptLabel});
         this.Name = "BitOperations";
         this.Text = "BitOperations";
         this.ResumeLayout(false);

      }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run( new BitOperations() );
		}

      // AND
      private void andButton_Click(
         object sender, System.EventArgs e )
      {
         SetFields();

         // update resultTextBox
         resultTextBox.Text = 
            string.Format( "{0}", value1 & value2 );

         resultBitLabel.Text = GetBits( value1 & value2 );
      }

      // inclusive OR
      private void inclusiveOrButton_Click(
         object sender, System.EventArgs e )
      {
         SetFields();

         // update resultTextBox
         resultTextBox.Text = 
            string.Format( "{0}", value1 | value2 );
         resultBitLabel.Text = GetBits( value1 | value2 );
      }

      // exclusive OR
      private void exclusiveOrButton_Click(
         object sender, System.EventArgs e )
      {
         SetFields();

         // update resultTextBox
         resultTextBox.Text = 
            string.Format( "{0}", value1 ^ value2 );
         resultBitLabel.Text = GetBits( value1 ^ value2 );
      }

      // complement of first integer
      private void complementButton_Click(
         object sender, System.EventArgs e )
      {
         value1 = Convert.ToInt32( bit1TextBox.Text );
         bit1Label.Text = GetBits( value1 );

         // update resultTextBox
         resultTextBox.Text = string.Format( "{0}", ~value1 );
         resultBitLabel.Text = GetBits( ~value1 );
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
            // append 0 or 1 depending on the result of masking
            output.Append( 
               ( number & displayMask ) == 0 ? "0" : "1" );

            // shift left so that mask will find bit of 
            // next digit in the next iteration of loop
            number <<= 1;

            if ( c % 8 == 0 )
               output.Append( " " );
         }

         return output.ToString();

      } // end method GetBits

      // set fields of Form
      private void SetFields()
      {
         // retrieve input values
         value1 = Convert.ToInt32( bit1TextBox.Text );
         value2 = Convert.ToInt32( bit2TextBox.Text );

         // set labels to display bit representations of integers
         bit1Label.Text = GetBits( value1 );
         bit2Label.Text = GetBits( value2 );
      }

	} // end class BitOperations
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
