// Fig. 12.24: CheckBoxTest.cs
// Using CheckBoxes to toggle italic and bold styles.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CheckBoxTest
{
   /// <summary>
   /// form contains checkboxes to allow
   /// the user to modify sample text
   /// </summary>
   public class CheckBoxTest : System.Windows.Forms.Form
   {
      private System.Windows.Forms.CheckBox boldCheckBox;
      private System.Windows.Forms.CheckBox italicCheckBox;

      private System.Windows.Forms.Label outputLabel;

      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      // default constructor
      public CheckBoxTest()
      {
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
         this.boldCheckBox = 
            new System.Windows.Forms.CheckBox();
         this.outputLabel = 
            new System.Windows.Forms.Label();
         this.italicCheckBox = 
            new System.Windows.Forms.CheckBox();
         this.SuspendLayout();

         // 
         // boldCheckBox
         // 
         this.boldCheckBox.Location = 
            new System.Drawing.Point( 72, 56 );
         this.boldCheckBox.Name = "boldCheckBox";
         this.boldCheckBox.Size = 
            new System.Drawing.Size( 48, 24 );
         this.boldCheckBox.TabIndex = 1;
         this.boldCheckBox.Text = "Bold";

         // register event handlers
         this.boldCheckBox.CheckedChanged += 
            new System.EventHandler(
            this.boldCheckBox_CheckedChanged );

         // 
         // outputLabel
         // 
         this.outputLabel.Location = 
            new System.Drawing.Point( 64, 24 );
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = 
            new System.Drawing.Size( 152, 16 );
         this.outputLabel.TabIndex = 0;
         this.outputLabel.Text = 
            "Watch the font style change";

         // 
         // italicCheckBox
         // 
         this.italicCheckBox.Location = 
            new System.Drawing.Point( 160, 56 );
         this.italicCheckBox.Name = "italicCheckBox";
         this.italicCheckBox.Size = 
            new System.Drawing.Size( 48, 24 );
         this.italicCheckBox.TabIndex = 1;
         this.italicCheckBox.Text = "Italic";
         this.italicCheckBox.CheckedChanged += 
            new System.EventHandler(
            this.italicCheckBox_CheckedChanged );

         // 
         // CheckBoxTest
         // 
         this.AutoScaleBaseSize = 
            new System.Drawing.Size( 5, 13 );
         this.ClientSize = 
            new System.Drawing.Size( 264, 109 );
         this.Controls.AddRange(
            new System.Windows.Forms.Control[] {
               this.italicCheckBox,
               this.boldCheckBox,
               this.outputLabel } );
         this.Name = "CheckBoxTest";
         this.Text = "CheckBoxTest";
         this.ResumeLayout( false );

      } // end method InitializeComponent

      // end region beginning on line 50
      #endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new CheckBoxTest() );
      }

      // make text bold if not bold, 
      // if already bold make not bold
      private void boldCheckBox_CheckedChanged( 
         object sender, System.EventArgs e )
      {
         outputLabel.Font = 
            new Font( outputLabel.Font.Name,
            outputLabel.Font.Size,
            outputLabel.Font.Style ^ FontStyle.Bold );
      }
 
      // make text italic if not italic, 
      // if already italic make not italic
      private void italicCheckBox_CheckedChanged( 
         object sender, System.EventArgs e )
      {
         outputLabel.Font = 
            new Font( outputLabel.Font.Name,
            outputLabel.Font.Size,
            outputLabel.Font.Style ^ FontStyle.Italic );
      }

   } // end class CheckBoxTest

} // end namespace CheckBoxTest

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
