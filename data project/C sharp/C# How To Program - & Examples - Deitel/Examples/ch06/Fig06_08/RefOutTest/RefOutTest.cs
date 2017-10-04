// Fig. 6.8: RefOutTest.cs
// Demonstrating ref and out parameters.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace RefOutTest
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class RefOutTest : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Button showOutputButton;
      private System.Windows.Forms.Label outputLabel;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public RefOutTest()
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
         this.showOutputButton.Location = new System.Drawing.Point(105, 8);
         this.showOutputButton.Name = "showOutputButton";
         this.showOutputButton.Size = new System.Drawing.Size(83, 23);
         this.showOutputButton.TabIndex = 0;
         this.showOutputButton.Text = "Show Output";
         this.showOutputButton.Click += new System.EventHandler(this.showOutputButton_Click);
         // 
         // outputLabel
         // 
         this.outputLabel.Location = new System.Drawing.Point(10, 40);
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size(272, 104);
         this.outputLabel.TabIndex = 1;
         // 
         // RefOutTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 149);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.outputLabel,
                                                                      this.showOutputButton});
         this.Name = "RefOutTest";
         this.Text = "RefOutTest";
         this.ResumeLayout(false);

      }
      #endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new RefOutTest());
      }

      // x passed by reference and method modifies
      // original variable's value
      void SquareRef( ref int x )
      {
         x = x * x;
      }

      // x passed as out parameter and method initializes
      // and modifies original variable's value
      void SquareOut( out int x )
      {
         x = 6;
         x = x * x;
      }

      // x passed by value and method cannot modify
      // original variable's value
      void Square( int x )
      {
         x = x * x;
      }

      private void showOutputButton_Click(
         object sender, System.EventArgs e )
      {
         int y = 5; // create new int and initialize to 5
         int z;     // declare z, but do not initialize it

         // display original values of y and z
         outputLabel.Text = "Original value of y: " + y + "\n";
         outputLabel.Text += "Original value of z: uninitialized\n\n";

         // pass y and z by reference
         SquareRef( ref y );
         SquareOut( out z );

         // display values of y and z after modified by methods
         // SquareRef and SquareOut
         outputLabel.Text += "Value of y after SquareRef: " + y + "\n";
         outputLabel.Text += "Value of z after SquareOut: " + z + "\n\n";

         // pass y and z by value
         Square( y );
         Square( z );

         // display unchanged values of y and z
         outputLabel.Text += "Value of y after Square: " + y + "\n";
         outputLabel.Text += "Value of z after Square: " + z + "\n";


      } // end method showOutputButton_Click
   }
}
