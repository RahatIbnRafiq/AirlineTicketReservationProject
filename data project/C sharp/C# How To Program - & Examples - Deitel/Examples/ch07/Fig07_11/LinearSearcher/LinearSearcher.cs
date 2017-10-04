// Fig. 7.11: LinearSearcher.cs
// Demonstrating linear searching of an array.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace LinearSearcher
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class LinearSearcher : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Button searchButton;
      private System.Windows.Forms.TextBox inputTextBox;
      private System.Windows.Forms.Label outputLabel;

      int[] a = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 
                  28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50 };

      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public LinearSearcher()
      {
         InitializeComponent();
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
         this.searchButton = new System.Windows.Forms.Button();
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.outputLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // searchButton
         // 
         this.searchButton.Location = new System.Drawing.Point(8, 8);
         this.searchButton.Name = "searchButton";
         this.searchButton.TabIndex = 0;
         this.searchButton.Text = "Search";
         this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
         // 
         // inputTextBox
         // 
         this.inputTextBox.Location = new System.Drawing.Point(96, 9);
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.Size = new System.Drawing.Size(88, 20);
         this.inputTextBox.TabIndex = 1;
         this.inputTextBox.Text = "";
         // 
         // outputLabel
         // 
         this.outputLabel.Location = new System.Drawing.Point(8, 40);
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size(184, 23);
         this.outputLabel.TabIndex = 2;
         // 
         // LinearSearcher
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(200, 69);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.outputLabel,
                                                                      this.inputTextBox,
                                                                      this.searchButton});
         this.Name = "LinearSearcher";
         this.Text = "LinearSearch";
         this.ResumeLayout(false);

      }
      #endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new LinearSearcher());
      }

      private void searchButton_Click( object sender, 
         System.EventArgs e )
      {
         int searchKey = Int32.Parse( inputTextBox.Text );

         int elementIndex = LinearSearch( a, searchKey );

         if ( elementIndex != -1 )
            outputLabel.Text = 
               "Found value in element " + elementIndex;

         else
            outputLabel.Text = "Value not found";
      
      } // end method searchButton_Click

      // search array for the specified key value
      public int LinearSearch( int[] array, int key )
      {
         for ( int n = 0; n < array.Length; n++ )
         {
            if ( array[ n ] == key )
               return n;
         }

         return -1;

      } // end method LinearSearch
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