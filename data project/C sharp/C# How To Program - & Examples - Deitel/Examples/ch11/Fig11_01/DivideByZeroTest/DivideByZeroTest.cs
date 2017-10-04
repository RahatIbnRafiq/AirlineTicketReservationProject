// Fig 11.1: DivideByZeroTest.cs
// Basics of C# exception handling.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace divideZero1
{
   /// <summary>
   /// class demonstrates how to handle exceptions from
   /// division by zero in integer arithmetic and from 
   /// improper numeric formatting
   /// </summary>
   public class DivideByZeroTest : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label numeratorLabel;
      private System.Windows.Forms.TextBox numeratorTextBox;

      private System.Windows.Forms.Label denominatorLabel;
      private System.Windows.Forms.TextBox denominatorTextBox;

      private System.Windows.Forms.Button divideButton;
      private System.Windows.Forms.Label outputLabel;

      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      // default constructor
      public DivideByZeroTest()
      {
         // Required for Windows Form Designer support
         InitializeComponent();
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if ( disposing )
         {
            if ( components != null ) 
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
         this.divideButton = new System.Windows.Forms.Button();
         this.denominatorTextBox = new System.Windows.Forms.TextBox();
         this.numeratorTextBox = new System.Windows.Forms.TextBox();
         this.denominatorLabel = new System.Windows.Forms.Label();
         this.outputLabel = new System.Windows.Forms.Label();
         this.numeratorLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // divideButton
         // 
         this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.divideButton.Location = new System.Drawing.Point(16, 88);
         this.divideButton.Name = "divideButton";
         this.divideButton.Size = new System.Drawing.Size(120, 32);
         this.divideButton.TabIndex = 3;
         this.divideButton.Text = "Click to Divide";
         this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
         // 
         // denominatorTextBox
         // 
         this.denominatorTextBox.Location = new System.Drawing.Point(136, 48);
         this.denominatorTextBox.Name = "denominatorTextBox";
         this.denominatorTextBox.Size = new System.Drawing.Size(120, 20);
         this.denominatorTextBox.TabIndex = 5;
         this.denominatorTextBox.Text = "";
         // 
         // numeratorTextBox
         // 
         this.numeratorTextBox.Location = new System.Drawing.Point(136, 8);
         this.numeratorTextBox.Name = "numeratorTextBox";
         this.numeratorTextBox.Size = new System.Drawing.Size(120, 20);
         this.numeratorTextBox.TabIndex = 4;
         this.numeratorTextBox.Text = "";
         // 
         // denominatorLabel
         // 
         this.denominatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.denominatorLabel.Location = new System.Drawing.Point(8, 50);
         this.denominatorLabel.Name = "denominatorLabel";
         this.denominatorLabel.Size = new System.Drawing.Size(112, 16);
         this.denominatorLabel.TabIndex = 1;
         this.denominatorLabel.Text = "Enter denominator";
         // 
         // outputLabel
         // 
         this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.outputLabel.Location = new System.Drawing.Point(168, 96);
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size(72, 23);
         this.outputLabel.TabIndex = 2;
         // 
         // numeratorLabel
         // 
         this.numeratorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.numeratorLabel.Location = new System.Drawing.Point(8, 10);
         this.numeratorLabel.Name = "numeratorLabel";
         this.numeratorLabel.Size = new System.Drawing.Size(112, 16);
         this.numeratorLabel.TabIndex = 0;
         this.numeratorLabel.Text = "Enter numerator";
         // 
         // DivideByZeroTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(264, 133);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.divideButton,
                                                                      this.denominatorTextBox,
                                                                      this.numeratorTextBox,
                                                                      this.numeratorLabel,
                                                                      this.outputLabel,
                                                                      this.denominatorLabel});
         this.Name = "DivideByZeroTest";
         this.Text = "DivideByZero";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new DivideByZeroTest() );
      } 

      // obtain integers input by user and divide numerator
      // by denominator
      private void divideButton_Click( 
         object sender, System.EventArgs e )
      {
         outputLabel.Text = "";

         // retrieve user input and call Quotient
         try
         {
            // Convert.ToInt32 generates FormatException if 
            // argument is not an integer
            int numerator = Convert.ToInt32( numeratorTextBox.Text );
            int denominator = 
               Convert.ToInt32( denominatorTextBox.Text );

            // division generates DivideByZeroException if
            // denominator is 0
            int result = numerator / denominator;

            outputLabel.Text = result.ToString();

         } // end try

            // process invalid number format
         catch ( FormatException )
         {
            MessageBox.Show( "You must enter two integers",
               "Invalid Number Format", 
               MessageBoxButtons.OK, MessageBoxIcon.Error );
         }

            // user attempted to divide by zero
         catch ( DivideByZeroException divideByZeroException )
         {
            MessageBox.Show( divideByZeroException.Message,
               "Attempted to Divide by Zero",
               MessageBoxButtons.OK, MessageBoxIcon.Error );
         }

      } // end method divideButton_Click

   } // end class DivideByZeroTest
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
