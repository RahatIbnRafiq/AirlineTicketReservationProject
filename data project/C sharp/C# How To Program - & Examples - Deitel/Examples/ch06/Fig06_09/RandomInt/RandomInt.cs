// Fig. 6.9: RandomInt.cs
// Generating random integer values.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace RandomInt
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class RandomInt : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Button showOutputButton;
      private System.Windows.Forms.Label outputLabel;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public RandomInt()
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
         this.showOutputButton.Location = new System.Drawing.Point(101, 16);
         this.showOutputButton.Name = "showOutputButton";
         this.showOutputButton.Size = new System.Drawing.Size(91, 23);
         this.showOutputButton.TabIndex = 0;
         this.showOutputButton.Text = "Show Output";
         this.showOutputButton.Click += new System.EventHandler(this.showOutputButton_Click);
         // 
         // outputLabel
         // 
         this.outputLabel.Location = new System.Drawing.Point(14, 56);
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size(264, 64);
         this.outputLabel.TabIndex = 1;
         // 
         // RandomInt
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 125);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.outputLabel,
                                                                      this.showOutputButton});
         this.Name = "RandomInt";
         this.Text = "RandomInt";
         this.ResumeLayout(false);

      }
      #endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new RandomInt());
      }

      private void showOutputButton_Click(object sender, System.EventArgs e)
      {
         Random randomInteger = new Random();

         outputLabel.Text = "";

         // loop 20 times
         for ( int counter = 1; counter <= 20; counter++ )
         {
            // pick random integer between 1 and 6
            int nextValue = randomInteger.Next( 1, 7 );
            
            outputLabel.Text += nextValue + "   "; // append value to output

            // add newline after every 5 values
            if ( counter % 5 == 0 )
               outputLabel.Text += "\n";
         }
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