// Fig. 23.25: StackTest.cs
// Demonstrates class Stack of namespace System.Collections.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace StackTest
{
   // demonstrate Stack collection
   public class StackTest : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label inputLabel;
      private System.Windows.Forms.TextBox inputTextBox;
      private System.Windows.Forms.Button pushButton;
      private System.Windows.Forms.Button popButton;
      private System.Windows.Forms.Button peekButton;
      private System.Windows.Forms.Button isEmptyButton;
      private System.Windows.Forms.Button searchButton;
      private System.Windows.Forms.Button displayButton;
      private System.Windows.Forms.Label statusLabel;
      
      // Required designer variable.
      private System.ComponentModel.Container components = null;

      private Stack stack;

      public StackTest()
      {
         // Required for Windows Form Designer support
         InitializeComponent();

         // create Stack
         stack = new Stack();
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
         this.inputLabel = new System.Windows.Forms.Label();
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.pushButton = new System.Windows.Forms.Button();
         this.popButton = new System.Windows.Forms.Button();
         this.peekButton = new System.Windows.Forms.Button();
         this.isEmptyButton = new System.Windows.Forms.Button();
         this.searchButton = new System.Windows.Forms.Button();
         this.displayButton = new System.Windows.Forms.Button();
         this.statusLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // inputLabel
         // 
         this.inputLabel.Location = new System.Drawing.Point(8, 8);
         this.inputLabel.Name = "inputLabel";
         this.inputLabel.Size = new System.Drawing.Size(80, 23);
         this.inputLabel.TabIndex = 0;
         this.inputLabel.Text = "Enter a string:";
         this.inputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // inputTextBox
         // 
         this.inputTextBox.Location = new System.Drawing.Point(88, 8);
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.Size = new System.Drawing.Size(112, 20);
         this.inputTextBox.TabIndex = 1;
         this.inputTextBox.Text = "";
         // 
         // pushButton
         // 
         this.pushButton.Location = new System.Drawing.Point(208, 8);
         this.pushButton.Name = "pushButton";
         this.pushButton.TabIndex = 2;
         this.pushButton.Text = "Push";
         this.pushButton.Click += new System.EventHandler(this.pushButton_Click);
         // 
         // popButton
         // 
         this.popButton.Location = new System.Drawing.Point(288, 8);
         this.popButton.Name = "popButton";
         this.popButton.TabIndex = 3;
         this.popButton.Text = "Pop";
         this.popButton.Click += new System.EventHandler(this.popButton_Click);
         // 
         // peekButton
         // 
         this.peekButton.Location = new System.Drawing.Point(368, 8);
         this.peekButton.Name = "peekButton";
         this.peekButton.TabIndex = 4;
         this.peekButton.Text = "Peek";
         this.peekButton.Click += new System.EventHandler(this.peekButton_Click);
         // 
         // isEmptyButton
         // 
         this.isEmptyButton.Location = new System.Drawing.Point(448, 8);
         this.isEmptyButton.Name = "isEmptyButton";
         this.isEmptyButton.TabIndex = 5;
         this.isEmptyButton.Text = "Is Empty?";
         this.isEmptyButton.Click += new System.EventHandler(this.isEmptyButton_Click);
         // 
         // searchButton
         // 
         this.searchButton.Location = new System.Drawing.Point(528, 8);
         this.searchButton.Name = "searchButton";
         this.searchButton.TabIndex = 6;
         this.searchButton.Text = "Search";
         this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
         // 
         // displayButton
         // 
         this.displayButton.Location = new System.Drawing.Point(608, 8);
         this.displayButton.Name = "displayButton";
         this.displayButton.TabIndex = 7;
         this.displayButton.Text = "Display";
         this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
         // 
         // statusLabel
         // 
         this.statusLabel.Location = new System.Drawing.Point(16, 48);
         this.statusLabel.Name = "statusLabel";
         this.statusLabel.Size = new System.Drawing.Size(664, 23);
         this.statusLabel.TabIndex = 8;
         // 
         // StackTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(688, 77);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.statusLabel,
                                                                      this.displayButton,
                                                                      this.searchButton,
                                                                      this.isEmptyButton,
                                                                      this.peekButton,
                                                                      this.popButton,
                                                                      this.pushButton,
                                                                      this.inputTextBox,
                                                                      this.inputLabel});
         this.Name = "StackTest";
         this.Text = "StackTest";
         this.ResumeLayout(false);

      }
		#endregion


      // main entry point for the application
      [STAThread]
      static void Main() 
      {
         Application.Run( new StackTest() );
      }

      // push element onto stack
      private void pushButton_Click(
         object sender, System.EventArgs e )
      {
         stack.Push( inputTextBox.Text ); 
         statusLabel.Text = "Pushed: " + inputTextBox.Text;
      }

      // pop element from stack
      private void popButton_Click(
         object sender, System.EventArgs e )
      {
         // pop element
         try
         {         
            statusLabel.Text = "Popped: " + stack.Pop();
         }
      
            // print message if stack is empty
         catch ( InvalidOperationException invalidOperation )
         {
            statusLabel.Text = invalidOperation.ToString();
         }
      }

      // peek at top element of stack
      private void peekButton_Click(
         object sender, System.EventArgs e )
      {
         // view top element
         try
         {         
            statusLabel.Text = "Top: " + stack.Peek();
         }
      
            // print message if stack is empty
         catch ( InvalidOperationException invalidOperation )
         {
            statusLabel.Text = invalidOperation.ToString();
         }
      }

      // determine whether stack is empty
      private void isEmptyButton_Click(
         object sender, System.EventArgs e )
      {
         statusLabel.Text = ( stack.Count == 0 ? 
            "Stack is empty" : "Stack is not empty" );
      }

      // determine whether specified element is on stack
      private void searchButton_Click(
         object sender, System.EventArgs e )
      {
         string result = stack.Contains( inputTextBox.Text ) ? 
            " found" : " not found";

         statusLabel.Text = inputTextBox.Text + result;
      }

      // display stack contents
      private void displayButton_Click(
         object sender, System.EventArgs e )
      {
         IEnumerator enumerator = stack.GetEnumerator();
         StringBuilder buffer = new StringBuilder();
      
         // while the enumerator can move on to the next element
         // print that element out.
         while ( enumerator.MoveNext() )
            buffer.Append( enumerator.Current + " " );

         statusLabel.Text = buffer.ToString();
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
