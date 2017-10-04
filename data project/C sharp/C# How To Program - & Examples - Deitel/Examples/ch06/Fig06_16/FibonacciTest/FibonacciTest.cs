// Fig. 6.16: FibonacciTest.cs
// Recursive fibonacci method.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FibonacciTestSpace
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class FibonacciTest : System.Windows.Forms.Form
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      private System.Windows.Forms.Button calculateButton;

      private System.Windows.Forms.TextBox inputTextBox;

      private System.Windows.Forms.Label displayLabel;
      private System.Windows.Forms.Label promptLabel;

      public FibonacciTest()
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
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.calculateButton = new System.Windows.Forms.Button();
         this.promptLabel = new System.Windows.Forms.Label();
         this.displayLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // inputTextBox
         // 
         this.inputTextBox.Location = new System.Drawing.Point(104, 8);
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.Size = new System.Drawing.Size(112, 20);
         this.inputTextBox.TabIndex = 2;
         this.inputTextBox.Text = "";
         // 
         // calculateButton
         // 
         this.calculateButton.Location = new System.Drawing.Point(6, 40);
         this.calculateButton.Name = "calculateButton";
         this.calculateButton.Size = new System.Drawing.Size(80, 24);
         this.calculateButton.TabIndex = 3;
         this.calculateButton.Text = "Calculate";
         this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
         // 
         // promptLabel
         // 
         this.promptLabel.Location = new System.Drawing.Point(6, 8);
         this.promptLabel.Name = "promptLabel";
         this.promptLabel.Size = new System.Drawing.Size(90, 23);
         this.promptLabel.TabIndex = 0;
         this.promptLabel.Text = "Enter an Integer:";
         // 
         // displayLabel
         // 
         this.displayLabel.Location = new System.Drawing.Point(104, 40);
         this.displayLabel.Name = "displayLabel";
         this.displayLabel.Size = new System.Drawing.Size(136, 40);
         this.displayLabel.TabIndex = 1;
         // 
         // FibonacciTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(248, 85);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.calculateButton,
                                                                      this.inputTextBox,
                                                                      this.displayLabel,
                                                                      this.promptLabel});
         this.Name = "FibonacciTest";
         this.Text = "FibonacciTest";
         this.ResumeLayout(false);

      }
      #endregion
      
      // call Fibonacci and display results
      protected void calculateButton_Click(
         object sender, System.EventArgs e )
      {
         int number = Convert.ToInt32( inputTextBox.Text );      
         int fibonacciNumber = Fibonacci( number );
         displayLabel.Text = "Fibonacci Value is " + fibonacciNumber;
      }

      // calculates Fibonacci number
      public int Fibonacci( int number )
      {
         if ( number == 0 || number == 1 )
            return number;
         else
            return Fibonacci( number - 1 ) + Fibonacci( number - 2 );
      }

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new FibonacciTest() );
      }

   } // end of class FibonacciTest

} // end of namespace FibonacciTestSpace

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

