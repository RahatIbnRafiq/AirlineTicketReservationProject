// Fig. 6.15: FactorialTest.cs
// Calculating factorials with recursion.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FactorialTestSpace
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class FactorialTest : System.Windows.Forms.Form
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;
      private System.Windows.Forms.Button showFactorialsButton;
      private System.Windows.Forms.Label outputLabel;

      public FactorialTest()
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
         this.outputLabel = new System.Windows.Forms.Label();
         this.showFactorialsButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // outputLabel
         // 
         this.outputLabel.Location = new System.Drawing.Point(12, 48);
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size(208, 168);
         this.outputLabel.TabIndex = 0;
         // 
         // showFactorialsButton
         // 
         this.showFactorialsButton.Location = new System.Drawing.Point(68, 8);
         this.showFactorialsButton.Name = "showFactorialsButton";
         this.showFactorialsButton.Size = new System.Drawing.Size(96, 23);
         this.showFactorialsButton.TabIndex = 1;
         this.showFactorialsButton.Text = "Show Factorials";
         this.showFactorialsButton.Click += new System.EventHandler(this.showFactorialsButton_Click);
         // 
         // FactorialTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(232, 221);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.showFactorialsButton,
                                                                      this.outputLabel});
         this.Name = "FactorialTest";
         this.Text = "FactorialTest";
         this.ResumeLayout(false);

      }
      #endregion
      
      public long Factorial( long number )
      {
         if ( number <= 1 )      // base case
            return 1;
      
         else
            return number * Factorial( number - 1 );
      }
      
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new FactorialTest());
      }

      private void showFactorialsButton_Click(object sender, System.EventArgs e)
      {
         outputLabel.Text = "";

         for ( long i = 0; i <= 10; i++ )
            outputLabel.Text += i + "! = " + 
               Factorial( i ) + "\n";      
      }

   } // end of class FactorialTest

} // end of namespace FactorialTestSpace

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
