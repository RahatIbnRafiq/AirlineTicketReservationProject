// Fig. 7.9: ArrayReferenceTest.cs
// Testing the effects of passing array references
// by value and by reference.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ArrayReferenceTest
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class ArrayReferenceTest : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label outputLabel;
      private System.Windows.Forms.Button showOutputButton;

      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public ArrayReferenceTest()
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
         this.showOutputButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // outputLabel
         // 
         this.outputLabel.Location = new System.Drawing.Point(10, 40);
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size(272, 280);
         this.outputLabel.TabIndex = 0;
         // 
         // showOutputButton
         // 
         this.showOutputButton.Location = new System.Drawing.Point(101, 8);
         this.showOutputButton.Name = "showOutputButton";
         this.showOutputButton.Size = new System.Drawing.Size(91, 23);
         this.showOutputButton.TabIndex = 1;
         this.showOutputButton.Text = "Show Output";
         this.showOutputButton.Click += new System.EventHandler(this.showOutputButton_Click);
         // 
         // ArrayReferenceTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 325);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.showOutputButton,
                                                                      this.outputLabel});
         this.Name = "ArrayReferenceTest";
         this.Text = "ArrayReferenceTest";
         this.ResumeLayout(false);

      }
      #endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new ArrayReferenceTest() );
      }

      private void showOutputButton_Click( object sender, 
         System.EventArgs e )
      {
         // create and initialize firstArray
         int[] firstArray = { 1, 2, 3 };

         // copy firstArray reference
         int[] firstArrayCopy = firstArray;

         outputLabel.Text = 
            "Test passing firstArray reference by value";

         outputLabel.Text += "\n\nContents of firstArray " +
            "before calling FirstDouble:\n\t";

         // print contents of firstArray
         for ( int i = 0; i < firstArray.Length; i++ )
            outputLabel.Text += firstArray[ i ] + " ";

         // pass reference firstArray by value to FirstDouble
         FirstDouble( firstArray );

         outputLabel.Text += "\n\nContents of firstArray after " +
            "calling FirstDouble\n\t";

         // print contents of firstArray
         for ( int i = 0; i < firstArray.Length; i++ )
            outputLabel.Text += firstArray[ i ] + " ";

         // test whether reference was changed by FirstDouble
         if ( firstArray == firstArrayCopy )
            outputLabel.Text += 
               "\n\nThe references refer to the same array\n";
         else
            outputLabel.Text += 
               "\n\nThe references refer to different arrays\n";

         // create and initialize secondArray
         int[] secondArray = { 1, 2, 3 };

         // copy secondArray reference
         int[] secondArrayCopy = secondArray;

         outputLabel.Text += "\nTest passing secondArray " +
            "reference by reference";

         outputLabel.Text += "\n\nContents of secondArray " +
            "before calling SecondDouble:\n\t";

         // print contents of secondArray before method call
         for ( int i = 0; i < secondArray.Length; i++ )
            outputLabel.Text += secondArray[ i ] + " ";

         SecondDouble( ref secondArray );

         outputLabel.Text += "\n\nContents of secondArray " +
            "after calling SecondDouble:\n\t";

         // print contents of secondArray after method call
         for ( int i = 0; i < secondArray.Length; i++ )
            outputLabel.Text += secondArray[ i ] + " ";

         // test whether reference was changed by SecondDouble
         if ( secondArray == secondArrayCopy )
            outputLabel.Text += 
               "\n\nThe references refer to the same array\n";
         else
            outputLabel.Text += 
               "\n\nThe references refer to different arrays\n"; 
        
      } // end method showOutputButton_Click

      // modify elements of array and attempt to modify
      // reference 
      void FirstDouble( int[] array )
      {
         // double each element's value
         for ( int i = 0; i < array.Length; i++ )
            array[ i ] *= 2;

         // create new reference and assign it to array
         array = new int[] { 11, 12, 13 };
      }

      // modify elements of array and change reference array
      // to refer to a new array
      void SecondDouble( ref int[] array )
      {
         // double each element's value
         for ( int i = 0; i < array.Length; i++ )
            array[ i ] *= 2;

         // create new reference and assign it to array
         array = new int[] { 11, 12, 13 };
      }    
   }
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