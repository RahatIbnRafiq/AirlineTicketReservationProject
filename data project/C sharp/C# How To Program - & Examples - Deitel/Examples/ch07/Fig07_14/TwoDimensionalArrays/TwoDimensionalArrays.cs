// Fig. 7.14: TwoDimensionalArrays.cs
// Initializing two-dimensional arrays.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TwoDimensionalArrays
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class TwoDimensionalArrays : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Button showOutputButton;
      private System.Windows.Forms.Label outputLabel;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public TwoDimensionalArrays()
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
         this.showOutputButton = new System.Windows.Forms.Button();
         this.outputLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // showOutputButton
         // 
         this.showOutputButton.Location = new System.Drawing.Point(102, 8);
         this.showOutputButton.Name = "showOutputButton";
         this.showOutputButton.Size = new System.Drawing.Size(88, 23);
         this.showOutputButton.TabIndex = 0;
         this.showOutputButton.Text = "Show Output";
         this.showOutputButton.Click += new System.EventHandler(this.showOutputButton_Click);
         // 
         // outputLabel
         // 
         this.outputLabel.Location = new System.Drawing.Point(8, 48);
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size(280, 104);
         this.outputLabel.TabIndex = 1;
         // 
         // TwoDimensionalArrays
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 165);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.outputLabel,
                                                                      this.showOutputButton});
         this.Name = "TwoDimensionalArrays";
         this.Text = "TwoDimensionalArrays";
         this.ResumeLayout(false);

      }
      #endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new TwoDimensionalArrays() );
      }

      private void showOutputButton_Click( object sender, 
         System.EventArgs e )
      {
         // declaration and initialization of rectangular array
         int[,] array1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

         // declaration and initialization of jagged array
         int[][] array2 = new int[ 3 ][];
         array2[ 0 ] = new int[] { 1, 2 };
         array2[ 1 ] = new int[] { 3 };
         array2[ 2 ] = new int[] { 4, 5, 6 };

         outputLabel.Text = "Values in array1 by row are\n";

         // output values in array1
         for ( int i = 0; i < array1.GetLength( 0 ); i++ )
         {
            for ( int j = 0; j < array1.GetLength( 1 ); j++ ) 
               outputLabel.Text += array1[ i, j ] + "  ";

            outputLabel.Text += "\n";
         }

         outputLabel.Text += "\nValues in array2 by row are\n";
      
         // output values in array2
         for ( int i = 0; i < array2.Length; i++ )
         {
            for ( int j = 0; j < array2[ i ].Length; j++ )
               outputLabel.Text += array2[ i ][ j ] + "  ";

            outputLabel.Text += "\n";
         }
      
      } // end method showOutputButton_Click
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