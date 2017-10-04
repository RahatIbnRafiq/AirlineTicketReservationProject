// Fig. 6.13: Scoping.cs
// Demonstrating scope of local and instance variables.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ScopingSpace
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class Scoping : System.Windows.Forms.Form
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;
      private System.Windows.Forms.Label outputLabel;
      private System.Windows.Forms.Button showOutputButton;

      public int x = 1; // instance variable

      public Scoping()
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
         this.outputLabel.Location = new System.Drawing.Point(16, 56);
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size(248, 208);
         this.outputLabel.TabIndex = 0;
         // 
         // showOutputButton
         // 
         this.showOutputButton.Location = new System.Drawing.Point(100, 16);
         this.showOutputButton.Name = "showOutputButton";
         this.showOutputButton.Size = new System.Drawing.Size(80, 23);
         this.showOutputButton.TabIndex = 1;
         this.showOutputButton.Text = "Show Output";
         this.showOutputButton.Click += new System.EventHandler(this.showOutputButton_Click);
         // 
         // Scoping
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(280, 269);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.showOutputButton,
                                                                      this.outputLabel});
         this.Name = "Scoping";
         this.Text = "Scoping";
         this.ResumeLayout(false);

      } // end of method InitializeComponent

      #endregion

      public void MethodA()
      {
         int x = 25;    // initialized each time a is called

         outputLabel.Text = outputLabel.Text +
            "\n\nlocal x in MethodA is " + x +
            " after entering MethodA";

         ++x; // increment local variable x

         outputLabel.Text = outputLabel.Text +
            "\nlocal x in MethodA is " + x + 
            " before exiting MethodA";
      }

      public void MethodB()
      {
         outputLabel.Text = outputLabel.Text +
            "\n\ninstance variable x is " + x +
            " on entering MethodB";

         x *= 10;

         outputLabel.Text = outputLabel.Text + 
            "\ninstance varable x is " + x +
            " on exiting MethodB";
      }

      private void showOutputButton_Click(object sender, System.EventArgs e)
      {  
         int x = 5; // local x in method showOutputButton_Click

         outputLabel.Text =
            "local x in method showOutputButton_Click is " + x;

         MethodA();    // MethodA has automatic local x;
         MethodB();    // MethodB uses instance variable x
         MethodA();    // MethodA creates new automatic local x
         MethodB();    // instance variable x retains its value

         outputLabel.Text = outputLabel.Text + "\n\n" +
            "local x in method showOutputButton_Click is " + x;

      }  // end method ShowOutputButton_Click    
     
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new Scoping() );
      }        

   } // end of class Scoping
 
} // end of namespace ScopingSpace

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
