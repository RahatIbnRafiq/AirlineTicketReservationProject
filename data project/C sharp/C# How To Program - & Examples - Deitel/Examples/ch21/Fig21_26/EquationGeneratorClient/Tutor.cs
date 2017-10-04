// Fig. 21.26: Tutor.cs
// Math tutor program.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace EquationGeneratorClient
{
   public class Tutor : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel2;

      private System.Windows.Forms.Label questionLabel;
      private System.Windows.Forms.TextBox answerTextBox;
      private System.Windows.Forms.Button okButton;
      private System.Windows.Forms.Button generateButton;

      private System.Windows.Forms.RadioButton oneRadioButton;
      private System.Windows.Forms.RadioButton twoRadioButton;
      private System.Windows.Forms.RadioButton 
         threeRadioButton;
      private System.Windows.Forms.RadioButton addRadioButton;
      private System.Windows.Forms.RadioButton 
         subtractRadioButton;
      private System.Windows.Forms.RadioButton 
         multiplyRadioButton;

      private System.ComponentModel.Container components = 
         null;
      private int level = 1;

      private localhost.Equation equation;
      private localhost.Generator generator = 
         new localhost.Generator();
      private string operation = "+";

      public Tutor()
      {
         InitializeComponent();
      }

      #region Windows Form Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.subtractRadioButton = new System.Windows.Forms.RadioButton();
         this.answerTextBox = new System.Windows.Forms.TextBox();
         this.threeRadioButton = new System.Windows.Forms.RadioButton();
         this.generateButton = new System.Windows.Forms.Button();
         this.panel1 = new System.Windows.Forms.Panel();
         this.oneRadioButton = new System.Windows.Forms.RadioButton();
         this.twoRadioButton = new System.Windows.Forms.RadioButton();
         this.panel2 = new System.Windows.Forms.Panel();
         this.multiplyRadioButton = new System.Windows.Forms.RadioButton();
         this.addRadioButton = new System.Windows.Forms.RadioButton();
         this.questionLabel = new System.Windows.Forms.Label();
         this.okButton = new System.Windows.Forms.Button();
         this.panel1.SuspendLayout();
         this.panel2.SuspendLayout();
         this.SuspendLayout();
         // 
         // subtractRadioButton
         // 
         this.subtractRadioButton.Location = new System.Drawing.Point(88, 8);
         this.subtractRadioButton.Name = "subtractRadioButton";
         this.subtractRadioButton.Size = new System.Drawing.Size(80, 24);
         this.subtractRadioButton.TabIndex = 1;
         this.subtractRadioButton.Text = "Subtraction";
         this.subtractRadioButton.CheckedChanged += new System.EventHandler(this.operationRadioButtons_Click);
         // 
         // answerTextBox
         // 
         this.answerTextBox.Location = new System.Drawing.Point(168, 24);
         this.answerTextBox.Name = "answerTextBox";
         this.answerTextBox.TabIndex = 3;
         this.answerTextBox.Text = "";
         // 
         // threeRadioButton
         // 
         this.threeRadioButton.Location = new System.Drawing.Point(168, 8);
         this.threeRadioButton.Name = "threeRadioButton";
         this.threeRadioButton.Size = new System.Drawing.Size(40, 24);
         this.threeRadioButton.TabIndex = 3;
         this.threeRadioButton.Text = "3";
         this.threeRadioButton.CheckedChanged += new System.EventHandler(this.levelRadioButtons_Click);
         // 
         // generateButton
         // 
         this.generateButton.Location = new System.Drawing.Point(288, 64);
         this.generateButton.Name = "generateButton";
         this.generateButton.Size = new System.Drawing.Size(96, 88);
         this.generateButton.TabIndex = 5;
         this.generateButton.Text = "Generate Additon Example";
         this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
         // 
         // panel1
         // 
         this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                             this.oneRadioButton,
                                                                             this.twoRadioButton,
                                                                             this.threeRadioButton});
         this.panel1.Location = new System.Drawing.Point(16, 112);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(256, 40);
         this.panel1.TabIndex = 0;
         // 
         // oneRadioButton
         // 
         this.oneRadioButton.Checked = true;
         this.oneRadioButton.Location = new System.Drawing.Point(16, 8);
         this.oneRadioButton.Name = "oneRadioButton";
         this.oneRadioButton.Size = new System.Drawing.Size(32, 24);
         this.oneRadioButton.TabIndex = 1;
         this.oneRadioButton.TabStop = true;
         this.oneRadioButton.Text = "1";
         this.oneRadioButton.CheckedChanged += new System.EventHandler(this.levelRadioButtons_Click);
         // 
         // twoRadioButton
         // 
         this.twoRadioButton.Location = new System.Drawing.Point(88, 8);
         this.twoRadioButton.Name = "twoRadioButton";
         this.twoRadioButton.Size = new System.Drawing.Size(40, 24);
         this.twoRadioButton.TabIndex = 2;
         this.twoRadioButton.Text = "2";
         this.twoRadioButton.CheckedChanged += new System.EventHandler(this.levelRadioButtons_Click);
         // 
         // panel2
         // 
         this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                             this.multiplyRadioButton,
                                                                             this.subtractRadioButton,
                                                                             this.addRadioButton});
         this.panel2.Location = new System.Drawing.Point(16, 64);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(256, 40);
         this.panel2.TabIndex = 1;
         // 
         // multiplyRadioButton
         // 
         this.multiplyRadioButton.Location = new System.Drawing.Point(168, 8);
         this.multiplyRadioButton.Name = "multiplyRadioButton";
         this.multiplyRadioButton.Size = new System.Drawing.Size(88, 24);
         this.multiplyRadioButton.TabIndex = 2;
         this.multiplyRadioButton.Text = "Multiplication";
         this.multiplyRadioButton.CheckedChanged += new System.EventHandler(this.operationRadioButtons_Click);
         // 
         // addRadioButton
         // 
         this.addRadioButton.Checked = true;
         this.addRadioButton.Location = new System.Drawing.Point(16, 8);
         this.addRadioButton.Name = "addRadioButton";
         this.addRadioButton.Size = new System.Drawing.Size(64, 24);
         this.addRadioButton.TabIndex = 0;
         this.addRadioButton.TabStop = true;
         this.addRadioButton.Text = "Addition";
         this.addRadioButton.CheckedChanged += new System.EventHandler(this.operationRadioButtons_Click);
         // 
         // questionLabel
         // 
         this.questionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.questionLabel.Location = new System.Drawing.Point(16, 24);
         this.questionLabel.Name = "questionLabel";
         this.questionLabel.Size = new System.Drawing.Size(136, 23);
         this.questionLabel.TabIndex = 2;
         // 
         // okButton
         // 
         this.okButton.Enabled = false;
         this.okButton.Location = new System.Drawing.Point(288, 24);
         this.okButton.Name = "okButton";
         this.okButton.Size = new System.Drawing.Size(96, 23);
         this.okButton.TabIndex = 4;
         this.okButton.Text = "OK";
         this.okButton.Click += new System.EventHandler(this.okButton_Click);
         // 
         // Tutor
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(416, 165);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.generateButton,
                                                                      this.okButton,
                                                                      this.answerTextBox,
                                                                      this.questionLabel,
                                                                      this.panel2,
                                                                      this.panel1});
         this.Name = "Tutor";
         this.Text = "Tutor";
         this.panel1.ResumeLayout(false);
         this.panel2.ResumeLayout(false);
         this.ResumeLayout(false);

      }
		#endregion

      [STAThread]
      static void Main()
      {
         Application.Run( new Tutor() );
      }

      // generates new equation on click event
      protected void generateButton_Click( object sender, 
         System.EventArgs e )
      {
         // generate equation using current operation
         // and level
         equation = generator.GenerateEquation( operation, 
            level );
      
         // display left-hand side of equation
         questionLabel.Text = equation.LeftHandSide;

         okButton.Enabled = true;
         answerTextBox.Enabled = true;      

      } // end method generateButton_Click

      // check users answer
      protected void okButton_Click( object sender, 
         System.EventArgs e )
      {
         // determine correct result from Equation 
         // object
         int answer = equation.Result;

         // get user's answer
         int myAnswer = Int32.Parse( answerTextBox.Text );

         // test if user's answer is correct
         if ( answer == myAnswer )
         {
            questionLabel.Text = "";
            answerTextBox.Text = "";
            okButton.Enabled = false;
            MessageBox.Show( "Correct! Good job!" );
         }
         else
            MessageBox.Show( "Incorrect. Try again." );

      } // end method okButton_Click

      // set the selected operation
      protected void operationRadioButtons_Click( object sender,
         EventArgs e )
      {      
         RadioButton item = ( RadioButton ) sender;

         // set the operation to be the appropriate symbol
         if ( item == addRadioButton )
            operation = "+";
         else if ( item == subtractRadioButton )
            operation = "-";
         else
            operation = "*";

         generateButton.Text = "Generate " + item.Text +
            " Example";

      } // end method operationRadioButtons_Click

      // set the current level
      protected void levelRadioButtons_Click( object sender,
         EventArgs e )
      {
         if ( sender == oneRadioButton )
            level = 1;
         else if ( sender == twoRadioButton )
            level = 2;
         else
            level = 3;

      } // end method levelRadioButtons_Click

   } // end class Tutor

} // end namespace EquationGeneratorClient


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
