// Fig. 15.16: CharMethods.cs
// Demonstrates Shared character testing methods 
// from Char structure

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace StaticCharMethods
{
   /// <summary>
   /// Form displays information about specific characters.
   /// </summary>
   public class StaticCharMethods : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label enterLabel;
      private System.Windows.Forms.TextBox inputTextBox;
      private System.Windows.Forms.Button analyzeButton;
      private System.Windows.Forms.TextBox outputTextBox;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public StaticCharMethods()
      {
         //
         // Required for Windows Form Designer support
         //
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
         this.enterLabel = new System.Windows.Forms.Label();
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.analyzeButton = new System.Windows.Forms.Button();
         this.outputTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // enterLabel
         // 
         this.enterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.enterLabel.Location = new System.Drawing.Point(16, 16);
         this.enterLabel.Name = "enterLabel";
         this.enterLabel.Size = new System.Drawing.Size(120, 23);
         this.enterLabel.TabIndex = 0;
         this.enterLabel.Text = "Enter a character:";
         this.enterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // inputTextBox
         // 
         this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.inputTextBox.Location = new System.Drawing.Point(144, 16);
         this.inputTextBox.Multiline = true;
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.Size = new System.Drawing.Size(56, 24);
         this.inputTextBox.TabIndex = 1;
         this.inputTextBox.Text = "";
         // 
         // analyzeButton
         // 
         this.analyzeButton.Location = new System.Drawing.Point(40, 64);
         this.analyzeButton.Name = "analyzeButton";
         this.analyzeButton.Size = new System.Drawing.Size(136, 24);
         this.analyzeButton.TabIndex = 2;
         this.analyzeButton.Text = "Analyze Character";
         this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
         // 
         // outputTextBox
         // 
         this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.outputTextBox.Location = new System.Drawing.Point(24, 112);
         this.outputTextBox.Multiline = true;
         this.outputTextBox.Name = "outputTextBox";
         this.outputTextBox.Size = new System.Drawing.Size(168, 152);
         this.outputTextBox.TabIndex = 3;
         this.outputTextBox.Text = "";
         // 
         // StaticCharMethods
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(224, 277);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.outputTextBox,
                                                                      this.analyzeButton,
                                                                      this.inputTextBox,
                                                                      this.enterLabel});
         this.Name = "StaticCharMethods";
         this.Text = "Static Character Methods";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new StaticCharMethods());
      }

      // handle analyzeButton_Click
      private void analyzeButton_Click(object sender, System.EventArgs e)
      {
         char character = Convert.ToChar( inputTextBox.Text );
         BuildOutput(character);
      } // end method analyzeButton_Click

      // display character information in outputTextBox
      private void BuildOutput( char inputCharacter )
      {
         string output;

         output = "is digit: " +
            Char.IsDigit( inputCharacter ) + "\r\n";

         output += "is letter: " +
            Char.IsLetter( inputCharacter ) + "\r\n";

         output += "is letter or digit: " +
            Char.IsLetterOrDigit( inputCharacter ) + "\r\n";

         output += "is lower case: " +
            Char.IsLower( inputCharacter ) + "\r\n";

         output += "is upper case: " +
            Char.IsUpper( inputCharacter ) + "\r\n";

         output += "to upper case: " +
            Char.ToUpper( inputCharacter ) + "\r\n";

         output += "to lower case: " +
            Char.ToLower( inputCharacter ) + "\r\n";

         output += "is punctuation: " +
            Char.IsPunctuation( inputCharacter ) + "\r\n";

         output += "is symbol: " + Char.IsSymbol( inputCharacter );

         outputTextBox.Text = output;

      } // end method BuildOutput

   } // end class StaticCharMethods
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