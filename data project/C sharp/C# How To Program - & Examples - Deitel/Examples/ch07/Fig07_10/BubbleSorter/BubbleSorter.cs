// Fig. 7.10: BubbleSorter.cs
// Sorting an array's values into ascending order.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BubbleSorter
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class BubbleSorter : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Button sortButton;
      private System.Windows.Forms.Label outputLabel;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public BubbleSorter()
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
         this.sortButton = new System.Windows.Forms.Button();
         this.outputLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // sortButton
         // 
         this.sortButton.Location = new System.Drawing.Point(109, 8);
         this.sortButton.Name = "sortButton";
         this.sortButton.TabIndex = 0;
         this.sortButton.Text = "Sort";
         this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
         // 
         // outputLabel
         // 
         this.outputLabel.Location = new System.Drawing.Point(8, 40);
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size(280, 64);
         this.outputLabel.TabIndex = 1;
         // 
         // BubbleSort
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 109);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.outputLabel,
                                                                      this.sortButton});
         this.Name = "BubbleSort";
         this.Text = "BubbleSort";
         this.ResumeLayout(false);

      }
      #endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new BubbleSorter());
      }

      private void sortButton_Click( object sender, 
            System.EventArgs e )
      {
         int[] a =  { 2, 6, 4, 8, 10, 12, 89, 68, 45, 37 };
      
         outputLabel.Text = "Data items in original order\n";

         for ( int i = 0; i < a.Length; i++ )
            outputLabel.Text += "   " + a[ i ];

         // sort elements in array a
         BubbleSort( a );

         outputLabel.Text += "\n\nData items in ascending order\n";

         for ( int i = 0; i < a.Length; i++ )
            outputLabel.Text += "   " + a[ i ];

      } // end method sortButton_Click

      // sort the elements of an array with bubble sort
      public void BubbleSort( int[] b )
      {
         for ( int pass = 1; pass < b.Length; pass++ ) // passes

            for ( int i = 0; i < b.Length - 1; i++ )   // one pass

               if ( b[ i ] > b[ i + 1 ] )      // one comparison
                  Swap( b, i );         // one swap
      }

      // swap two elements of an array
      public void Swap( int[] c, int first )
      {
         int hold;      // temporary holding area for swap

         hold = c[ first ];
         c[ first ] = c[ first + 1 ];
         c[ first + 1 ] = hold;
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