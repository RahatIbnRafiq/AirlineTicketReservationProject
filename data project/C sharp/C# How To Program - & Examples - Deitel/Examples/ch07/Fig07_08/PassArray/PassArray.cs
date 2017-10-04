// Fig. 7.8: PassArray.cs
// Passing arrays and individual elements to methods.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace PassArray
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class PassArray : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Button showOutputButton;
      private System.Windows.Forms.Label outputLabel;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public PassArray()
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
         this.showOutputButton.Location = new System.Drawing.Point(106, 8);
         this.showOutputButton.Name = "showOutputButton";
         this.showOutputButton.Size = new System.Drawing.Size(80, 23);
         this.showOutputButton.TabIndex = 0;
         this.showOutputButton.Text = "Show Output";
         this.showOutputButton.Click += new System.EventHandler(this.showOutputButton_Click);
         // 
         // outputLabel
         // 
         this.outputLabel.Location = new System.Drawing.Point(8, 48);
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size(280, 184);
         this.outputLabel.TabIndex = 1;
         // 
         // PassArray
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 237);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.outputLabel,
                                                                      this.showOutputButton});
         this.Name = "PassArray";
         this.Text = "PassArray";
         this.ResumeLayout(false);

      }
      #endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new PassArray() );
      }

      private void showOutputButton_Click( object sender, 
         System.EventArgs e )
      {
         int[] a = { 1, 2, 3, 4, 5 };

         outputLabel.Text = "Effects of passing entire array " +
            "call-by-reference:\n\nThe values of the original " +
            "array are:\n\t";

         for ( int i = 0; i < a.Length; i++ )
            outputLabel.Text += "   " + a[ i ];

         ModifyArray( a );   // array is passed call-by-reference

         outputLabel.Text += 
            "\n\nThe values of the modified array are:\n\t";

         // display elements of array a
         for ( int i = 0; i < a.Length; i++ )
            outputLabel.Text += "   " + a[ i ];

         outputLabel.Text += "\n\nEffects of passing array " +
            "element call-by-value:\n\na[ 3 ] before " +
            "ModifyElement: " + a[ 3 ];

         // array element passed call-by-value
         ModifyElement( a[ 3 ] );

         outputLabel.Text += 
            "\na[ 3 ] after ModifyElement: " + a[ 3 ];
      }

      // method modifies the array it receives,
      // original will be modified
      public void ModifyArray( int[] b )
      {
         for ( int j = 0; j < b.Length; j++ )
            b[ j ] *= 2;
      }

      // method modifies the integer passed to it
      // original will not be modified
      public void ModifyElement( int e )
      {
         outputLabel.Text += 
            "\nvalue received in ModifyElement: " + e;

         e *= 2;

         outputLabel.Text += 
            "\nvalue calculated in ModifyElement: " + e;
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