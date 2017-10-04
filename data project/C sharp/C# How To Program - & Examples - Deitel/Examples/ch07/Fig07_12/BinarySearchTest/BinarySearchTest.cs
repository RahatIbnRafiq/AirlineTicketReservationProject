// Fig. 7.12: BinarySearchTest.cs
// Demonstrating a binary search of an array.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BinarySearchTest
{
   /// <summary>
   /// Summary description for BinarySearchTest.
   /// </summary>
   public class BinarySearchTest : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label promptLabel;

      private System.Windows.Forms.TextBox inputTextBox;

      private System.Windows.Forms.Label resultLabel;
      private System.Windows.Forms.Label displayLabel;
      private System.Windows.Forms.Label outputLabel;

      private System.Windows.Forms.Button findButton;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      int[] a = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 
                  18, 20, 22, 24, 26, 28 };

      public BinarySearchTest()
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
         this.displayLabel = new System.Windows.Forms.Label();
         this.resultLabel = new System.Windows.Forms.Label();
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.promptLabel = new System.Windows.Forms.Label();
         this.findButton = new System.Windows.Forms.Button();
         this.outputLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // displayLabel
         // 
         this.displayLabel.Location = new System.Drawing.Point(261, 8);
         this.displayLabel.Name = "displayLabel";
         this.displayLabel.Size = new System.Drawing.Size(152, 20);
         this.displayLabel.TabIndex = 3;
         // 
         // resultLabel
         // 
         this.resultLabel.Location = new System.Drawing.Point(213, 8);
         this.resultLabel.Name = "resultLabel";
         this.resultLabel.Size = new System.Drawing.Size(40, 16);
         this.resultLabel.TabIndex = 2;
         this.resultLabel.Text = "Result:";
         // 
         // inputTextBox
         // 
         this.inputTextBox.Location = new System.Drawing.Point(99, 8);
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.TabIndex = 1;
         this.inputTextBox.Text = "";
         // 
         // promptLabel
         // 
         this.promptLabel.Location = new System.Drawing.Point(27, 8);
         this.promptLabel.Name = "promptLabel";
         this.promptLabel.Size = new System.Drawing.Size(56, 16);
         this.promptLabel.TabIndex = 0;
         this.promptLabel.Text = "Enter key";
         // 
         // findButton
         // 
         this.findButton.Location = new System.Drawing.Point(152, 40);
         this.findButton.Name = "findButton";
         this.findButton.Size = new System.Drawing.Size(136, 24);
         this.findButton.TabIndex = 5;
         this.findButton.Text = "Find Key";
         this.findButton.Click += new System.EventHandler(this.findButton_Click);
         // 
         // outputLabel
         // 
         this.outputLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.outputLabel.Location = new System.Drawing.Point(10, 80);
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size(420, 72);
         this.outputLabel.TabIndex = 4;
         // 
         // BinarySearchTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(440, 157);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.findButton,
                                                                      this.outputLabel,
                                                                      this.displayLabel,
                                                                      this.resultLabel,
                                                                      this.inputTextBox,
                                                                      this.promptLabel});
         this.Name = "BinarySearchTest";
         this.Text = "BinarySearch";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new BinarySearchTest() );
      }

      // searches for an element by calling
      // BinarySearch and displaying results
      private void findButton_Click( object sender, 
         System.EventArgs e )
      {
         int searchKey = Int32.Parse( inputTextBox.Text );

         // initialize display string for the new search
         outputLabel.Text = "Portions of array searched\n";

         // perform the binary search
         int element = BinarySearch( a, searchKey );

         if ( element != -1 )
            displayLabel.Text = "Found value in element " +
               element;
         else
            displayLabel.Text = "Value not found";

      } // end findButton_Click

      // searchs array for specified key
      public int BinarySearch( int[] array, int key )
      {
         int low = 0;                  // low subscript
         int high = array.Length - 1;  // high subscript
         int middle;                   // middle subscript

         while ( low <= high )
         {
            middle = ( low + high ) / 2;

            // the following line displays the portion
            // of the array currently being manipulated during
            // each iteration of the binary search loop
            BuildOutput( a, low, middle, high );

            if ( key == array[ middle ] )   // match
               return middle;
            else if ( key < array[ middle ] )
               high = middle - 1;   // search low end of array
            else
               low = middle + 1;

         } // end binary search

         return -1;  // search key not found

      } // end method BinarySearch

      public void BuildOutput( 
         int[] array, int low, int mid, int high )
      {
         for ( int i = 0; i < array.Length; i++ )
         {
            if ( i < low || i > high )
               outputLabel.Text += "    ";

            // mark middle element in output
            else if ( i == mid )
               outputLabel.Text += 
                  array[ i ].ToString( "00" ) + "* ";
            else
               outputLabel.Text += 
                  array[ i ].ToString( "00" ) + "  ";
         }

         outputLabel.Text += "\n";

      } // end BuildOutput

   } // end class BinarySearchTest

} // end namespace BinarySearchTest

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
