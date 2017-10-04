// Fig. 24.24: ArrayListTest.cs
// Using class ArrayList.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace ArrayListTest
{
   // demonstrating ArrayList functionality
   public class ArrayListTest : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Button addButton;
      private System.Windows.Forms.TextBox inputTextBox;
      private System.Windows.Forms.Label inputLabel;
      private System.Windows.Forms.Button removeButton;
      private System.Windows.Forms.Button firstButton;
      private System.Windows.Forms.Button lastButton;
      private System.Windows.Forms.Button isEmptyButton;
      private System.Windows.Forms.Button containsButton;
      private System.Windows.Forms.Button locationButton;
      private System.Windows.Forms.Button trimButton;
      private System.Windows.Forms.Button statisticsButton;
      private System.Windows.Forms.Button displayButton;
      
      // Required designer variable.
      private System.ComponentModel.Container components = null;
      private System.Windows.Forms.TextBox consoleTextBox;

      // ArrayList for manipulating strings
      private ArrayList arrayList = new ArrayList( 1 );

      public ArrayListTest()
      {
         // Required for Windows Form Designer support
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
         this.addButton = new System.Windows.Forms.Button();
         this.removeButton = new System.Windows.Forms.Button();
         this.firstButton = new System.Windows.Forms.Button();
         this.lastButton = new System.Windows.Forms.Button();
         this.isEmptyButton = new System.Windows.Forms.Button();
         this.containsButton = new System.Windows.Forms.Button();
         this.locationButton = new System.Windows.Forms.Button();
         this.trimButton = new System.Windows.Forms.Button();
         this.statisticsButton = new System.Windows.Forms.Button();
         this.displayButton = new System.Windows.Forms.Button();
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.consoleTextBox = new System.Windows.Forms.TextBox();
         this.inputLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // addButton
         // 
         this.addButton.Location = new System.Drawing.Point(200, 8);
         this.addButton.Name = "addButton";
         this.addButton.Size = new System.Drawing.Size(80, 23);
         this.addButton.TabIndex = 0;
         this.addButton.Text = "Add";
         this.addButton.Click += new System.EventHandler(this.addButton_Click);
         // 
         // removeButton
         // 
         this.removeButton.Location = new System.Drawing.Point(8, 56);
         this.removeButton.Name = "removeButton";
         this.removeButton.Size = new System.Drawing.Size(80, 23);
         this.removeButton.TabIndex = 1;
         this.removeButton.Text = "Remove";
         this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
         // 
         // firstButton
         // 
         this.firstButton.Location = new System.Drawing.Point(104, 56);
         this.firstButton.Name = "firstButton";
         this.firstButton.Size = new System.Drawing.Size(80, 23);
         this.firstButton.TabIndex = 2;
         this.firstButton.Text = "First";
         this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
         // 
         // lastButton
         // 
         this.lastButton.Location = new System.Drawing.Point(200, 56);
         this.lastButton.Name = "lastButton";
         this.lastButton.Size = new System.Drawing.Size(80, 23);
         this.lastButton.TabIndex = 3;
         this.lastButton.Text = "Last";
         this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
         // 
         // isEmptyButton
         // 
         this.isEmptyButton.Location = new System.Drawing.Point(8, 104);
         this.isEmptyButton.Name = "isEmptyButton";
         this.isEmptyButton.Size = new System.Drawing.Size(80, 23);
         this.isEmptyButton.TabIndex = 4;
         this.isEmptyButton.Text = "Is Empty?";
         this.isEmptyButton.Click += new System.EventHandler(this.isEmptyButton_Click);
         // 
         // containsButton
         // 
         this.containsButton.Location = new System.Drawing.Point(104, 104);
         this.containsButton.Name = "containsButton";
         this.containsButton.Size = new System.Drawing.Size(80, 23);
         this.containsButton.TabIndex = 5;
         this.containsButton.Text = "Contains";
         this.containsButton.Click += new System.EventHandler(this.containsButton_Click);
         // 
         // locationButton
         // 
         this.locationButton.Location = new System.Drawing.Point(200, 104);
         this.locationButton.Name = "locationButton";
         this.locationButton.Size = new System.Drawing.Size(80, 24);
         this.locationButton.TabIndex = 6;
         this.locationButton.Text = "Location";
         this.locationButton.Click += new System.EventHandler(this.locationButton_Click);
         // 
         // trimButton
         // 
         this.trimButton.Location = new System.Drawing.Point(8, 152);
         this.trimButton.Name = "trimButton";
         this.trimButton.Size = new System.Drawing.Size(80, 24);
         this.trimButton.TabIndex = 7;
         this.trimButton.Text = "Trim";
         this.trimButton.Click += new System.EventHandler(this.trimButton_Click);
         // 
         // statisticsButton
         // 
         this.statisticsButton.Location = new System.Drawing.Point(104, 152);
         this.statisticsButton.Name = "statisticsButton";
         this.statisticsButton.Size = new System.Drawing.Size(80, 23);
         this.statisticsButton.TabIndex = 8;
         this.statisticsButton.Text = "Statistics";
         this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
         // 
         // displayButton
         // 
         this.displayButton.Location = new System.Drawing.Point(200, 152);
         this.displayButton.Name = "displayButton";
         this.displayButton.Size = new System.Drawing.Size(80, 23);
         this.displayButton.TabIndex = 9;
         this.displayButton.Text = "Display";
         this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
         // 
         // inputTextBox
         // 
         this.inputTextBox.Location = new System.Drawing.Point(88, 8);
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.TabIndex = 10;
         this.inputTextBox.Text = "";
         // 
         // consoleTextBox
         // 
         this.consoleTextBox.Location = new System.Drawing.Point(8, 200);
         this.consoleTextBox.Multiline = true;
         this.consoleTextBox.Name = "consoleTextBox";
         this.consoleTextBox.ReadOnly = true;
         this.consoleTextBox.Size = new System.Drawing.Size(272, 64);
         this.consoleTextBox.TabIndex = 11;
         this.consoleTextBox.Text = "";
         // 
         // inputLabel
         // 
         this.inputLabel.Location = new System.Drawing.Point(8, 16);
         this.inputLabel.Name = "inputLabel";
         this.inputLabel.Size = new System.Drawing.Size(72, 24);
         this.inputLabel.TabIndex = 12;
         this.inputLabel.Text = "Enter a string";
         // 
         // ArrayListTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 273);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.inputLabel,
                                                                      this.consoleTextBox,
                                                                      this.inputTextBox,
                                                                      this.displayButton,
                                                                      this.statisticsButton,
                                                                      this.trimButton,
                                                                      this.locationButton,
                                                                      this.containsButton,
                                                                      this.isEmptyButton,
                                                                      this.lastButton,
                                                                      this.firstButton,
                                                                      this.removeButton,
                                                                      this.addButton});
         this.Name = "ArrayListTest";
         this.Text = "ArrayListTest";
         this.ResumeLayout(false);

      }
		#endregion

      // main entry point for the application
      [STAThread]
      static void Main() 
      {
         Application.Run(new ArrayListTest());
      }

      // add item to end of arrayList
      private void addButton_Click(
         object sender, System.EventArgs e )
      {
         arrayList.Add( inputTextBox.Text );
         consoleTextBox.Text = 
            "Added to end: " + inputTextBox.Text;
         inputTextBox.Clear();
      }

      // remove specified item from arrayList
      private void removeButton_Click(
         object sender, System.EventArgs e )
      {
         arrayList.Remove( inputTextBox.Text );
         consoleTextBox.Text = "Removed: " + inputTextBox.Text;
         inputTextBox.Clear();
      }

      // display first element
      private void firstButton_Click(
         object sender, System.EventArgs e )
      {
         // get first element
         try
         {
            consoleTextBox.Text = 
               "First element: " + arrayList[ 0 ];
         }
      
            // show exception if no elements in arrrayList
         catch ( ArgumentOutOfRangeException outOfRange )
         {
            consoleTextBox.Text = outOfRange.ToString();
         }
      }

      // display last element
      private void lastButton_Click(
         object sender, System.EventArgs e )
      {
         // get last element
         try
         {
            consoleTextBox.Text = "Last element: " + 
               arrayList[ arrayList.Count - 1 ];
         }

            // show exception if no elements in arrrayList
         catch ( ArgumentOutOfRangeException outOfRange )
         {
            consoleTextBox.Text = outOfRange.ToString();
         }
      }

      // determine whether arrayList is empty
      private void isEmptyButton_Click(
         object sender, System.EventArgs e )
      {
         consoleTextBox.Text = ( arrayList.Count == 0 ? 
            "arrayList is empty" : "arrayList is not empty" );
      }

      // determine whether arrayList contains specified object
      private void containsButton_Click(
         object sender, System.EventArgs e )
      {
         if ( arrayList.Contains( inputTextBox.Text ) )
            consoleTextBox.Text = "arrayList contains " +
               inputTextBox.Text;
         else
            consoleTextBox.Text = inputTextBox.Text + 
               " not found";
      }

      // determine location of specified object
      private void locationButton_Click(
         object sender, System.EventArgs e )
      {
         consoleTextBox.Text = "Element is at location " +
            arrayList.IndexOf( inputTextBox.Text );
      }

      // trim arrayList to current size
      private void trimButton_Click(
         object sender, System.EventArgs e )
      {
         arrayList.TrimToSize();
         consoleTextBox.Text = "Vector trimmed to size";
      }

      // show arrayList current size and capacity
      private void statisticsButton_Click(
         object sender, System.EventArgs e )
      {
         consoleTextBox.Text = "Size = " + arrayList.Count + 
            "; capacity = " + arrayList.Capacity;
      }

      // display contents of arrayList
      private void displayButton_Click(
         object sender, System.EventArgs e )
      {
         IEnumerator enumerator = arrayList.GetEnumerator();
         StringBuilder buffer = new StringBuilder();

         while ( enumerator.MoveNext() )
            buffer.Append( enumerator.Current + "  " );

         consoleTextBox.Text = buffer.ToString();
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
