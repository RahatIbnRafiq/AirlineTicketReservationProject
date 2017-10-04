// Fig. 6.18: MethodOverload.cs
// Using overloaded methods.   
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MethodOverloadSpace
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class MethodOverload : System.Windows.Forms.Form
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;
      private System.Windows.Forms.Button showOutputButton;

      private System.Windows.Forms.Label outputLabel;

      public MethodOverload()
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
         this.outputLabel = new System.Windows.Forms.Label();
         this.showOutputButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // outputLabel
         // 
         this.outputLabel.Location = new System.Drawing.Point(8, 40);
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size(224, 40);
         this.outputLabel.TabIndex = 0;
         // 
         // showOutputButton
         // 
         this.showOutputButton.Location = new System.Drawing.Point(76, 8);
         this.showOutputButton.Name = "showOutputButton";
         this.showOutputButton.Size = new System.Drawing.Size(88, 23);
         this.showOutputButton.TabIndex = 1;
         this.showOutputButton.Text = "Show Output";
         this.showOutputButton.Click += new System.EventHandler(this.showOutputButton_Click);
         // 
         // MethodOverload
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(240, 85);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.showOutputButton,
                                                                      this.outputLabel});
         this.Name = "MethodOverload";
         this.Text = "MethodOverload";
         this.ResumeLayout(false);

      }
      #endregion

      // first version, takes one integer
      public int Square ( int x )
      {
         return x * x;
      }

      // second version, takes one double
      public double Square ( double y )
      {
         return y * y;
      }

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.Run( new MethodOverload() );
      }

      private void showOutputButton_Click(object sender, System.EventArgs e)
      {
         // call both versions of Square
         outputLabel.Text = 
            "The square of integer 7 is " + Square( 7 ) +
            "\nThe square of double 7.5 is " + Square ( 7.5 );     
      }

   } // end of class MethodOverload

} // end of namespace MethodOverloadSpace

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