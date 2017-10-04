// Fig. 23.26: HashtableTest.cs
// Demonstrate class Hashtable of namespace System.Collections.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace HashTableTest
{
   // demonstrate Hashtable functionality
   public class HashTableTest : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label firstNameLabel;
      private System.Windows.Forms.Label lastNameLabel;
      private System.Windows.Forms.Button addButton;
      private System.Windows.Forms.TextBox lastNameTextBox;
      private System.Windows.Forms.TextBox consoleTextBox;
      private System.Windows.Forms.TextBox firstNameTextBox;
      private System.Windows.Forms.Button getButton;
      private System.Windows.Forms.Button removeButton;
      private System.Windows.Forms.Button emptyButton;
      private System.Windows.Forms.Button containsKeyButton;
      private System.Windows.Forms.Button clearTableButton;
      private System.Windows.Forms.Button listObjectsButton;
      private System.Windows.Forms.Button listKeysButton;
      private System.Windows.Forms.Label statusLabel;
     
      // Required designer variable.
      private System.ComponentModel.Container components = null;

      // Hashtable to demonstrate functionality
      private Hashtable table;

      public HashTableTest()
      {
         // Required for Windows Form Designer support
         InitializeComponent();

         // create Hashtable object
         table = new Hashtable();
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
         this.lastNameLabel = new System.Windows.Forms.Label();
         this.addButton = new System.Windows.Forms.Button();
         this.lastNameTextBox = new System.Windows.Forms.TextBox();
         this.listKeysButton = new System.Windows.Forms.Button();
         this.removeButton = new System.Windows.Forms.Button();
         this.consoleTextBox = new System.Windows.Forms.TextBox();
         this.containsKeyButton = new System.Windows.Forms.Button();
         this.getButton = new System.Windows.Forms.Button();
         this.firstNameLabel = new System.Windows.Forms.Label();
         this.listObjectsButton = new System.Windows.Forms.Button();
         this.statusLabel = new System.Windows.Forms.Label();
         this.firstNameTextBox = new System.Windows.Forms.TextBox();
         this.clearTableButton = new System.Windows.Forms.Button();
         this.emptyButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lastNameLabel
         // 
         this.lastNameLabel.Location = new System.Drawing.Point(216, 16);
         this.lastNameLabel.Name = "lastNameLabel";
         this.lastNameLabel.Size = new System.Drawing.Size(96, 24);
         this.lastNameLabel.TabIndex = 1;
         this.lastNameLabel.Text = "Last Name (key):";
         // 
         // addButton
         // 
         this.addButton.Location = new System.Drawing.Point(448, 16);
         this.addButton.Name = "addButton";
         this.addButton.Size = new System.Drawing.Size(88, 23);
         this.addButton.TabIndex = 5;
         this.addButton.Text = "Add";
         this.addButton.Click += new System.EventHandler(this.addButton_Click);
         // 
         // lastNameTextBox
         // 
         this.lastNameTextBox.Location = new System.Drawing.Point(320, 16);
         this.lastNameTextBox.Name = "lastNameTextBox";
         this.lastNameTextBox.Size = new System.Drawing.Size(96, 20);
         this.lastNameTextBox.TabIndex = 3;
         this.lastNameTextBox.Text = "";
         // 
         // listKeysButton
         // 
         this.listKeysButton.Location = new System.Drawing.Point(560, 112);
         this.listKeysButton.Name = "listKeysButton";
         this.listKeysButton.Size = new System.Drawing.Size(88, 23);
         this.listKeysButton.TabIndex = 12;
         this.listKeysButton.Text = "List Keys";
         this.listKeysButton.Click += new System.EventHandler(this.listKeysButton_Click);
         // 
         // removeButton
         // 
         this.removeButton.Location = new System.Drawing.Point(448, 48);
         this.removeButton.Name = "removeButton";
         this.removeButton.Size = new System.Drawing.Size(88, 23);
         this.removeButton.TabIndex = 7;
         this.removeButton.Text = "Remove";
         this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
         // 
         // consoleTextBox
         // 
         this.consoleTextBox.Location = new System.Drawing.Point(16, 56);
         this.consoleTextBox.Multiline = true;
         this.consoleTextBox.Name = "consoleTextBox";
         this.consoleTextBox.ReadOnly = true;
         this.consoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.consoleTextBox.Size = new System.Drawing.Size(400, 120);
         this.consoleTextBox.TabIndex = 4;
         this.consoleTextBox.Text = "";
         // 
         // containsKeyButton
         // 
         this.containsKeyButton.Location = new System.Drawing.Point(448, 80);
         this.containsKeyButton.Name = "containsKeyButton";
         this.containsKeyButton.Size = new System.Drawing.Size(88, 23);
         this.containsKeyButton.TabIndex = 9;
         this.containsKeyButton.Text = "Contains Key";
         this.containsKeyButton.Click += new System.EventHandler(this.containsKeyButton_Click);
         // 
         // getButton
         // 
         this.getButton.Location = new System.Drawing.Point(560, 16);
         this.getButton.Name = "getButton";
         this.getButton.Size = new System.Drawing.Size(88, 23);
         this.getButton.TabIndex = 6;
         this.getButton.Text = "Get";
         this.getButton.Click += new System.EventHandler(this.getButton_Click);
         // 
         // firstNameLabel
         // 
         this.firstNameLabel.Location = new System.Drawing.Point(16, 16);
         this.firstNameLabel.Name = "firstNameLabel";
         this.firstNameLabel.Size = new System.Drawing.Size(80, 24);
         this.firstNameLabel.TabIndex = 0;
         this.firstNameLabel.Text = "First Name:";
         // 
         // listObjectsButton
         // 
         this.listObjectsButton.Location = new System.Drawing.Point(448, 112);
         this.listObjectsButton.Name = "listObjectsButton";
         this.listObjectsButton.Size = new System.Drawing.Size(88, 23);
         this.listObjectsButton.TabIndex = 11;
         this.listObjectsButton.Text = "List Objects";
         this.listObjectsButton.Click += new System.EventHandler(this.listObjectsButton_Click);
         // 
         // statusLabel
         // 
         this.statusLabel.Location = new System.Drawing.Point(448, 152);
         this.statusLabel.Name = "statusLabel";
         this.statusLabel.Size = new System.Drawing.Size(192, 23);
         this.statusLabel.TabIndex = 13;
         // 
         // firstNameTextBox
         // 
         this.firstNameTextBox.Location = new System.Drawing.Point(96, 16);
         this.firstNameTextBox.Name = "firstNameTextBox";
         this.firstNameTextBox.Size = new System.Drawing.Size(96, 20);
         this.firstNameTextBox.TabIndex = 2;
         this.firstNameTextBox.Text = "";
         // 
         // clearTableButton
         // 
         this.clearTableButton.Location = new System.Drawing.Point(560, 80);
         this.clearTableButton.Name = "clearTableButton";
         this.clearTableButton.Size = new System.Drawing.Size(88, 23);
         this.clearTableButton.TabIndex = 10;
         this.clearTableButton.Text = "Clear Table";
         this.clearTableButton.Click += new System.EventHandler(this.clearTableButton_Click);
         // 
         // emptyButton
         // 
         this.emptyButton.Location = new System.Drawing.Point(560, 48);
         this.emptyButton.Name = "emptyButton";
         this.emptyButton.Size = new System.Drawing.Size(88, 23);
         this.emptyButton.TabIndex = 8;
         this.emptyButton.Text = "Empty";
         this.emptyButton.Click += new System.EventHandler(this.emptyButton_Click);
         // 
         // HashTableTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(656, 189);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.statusLabel,
                                                                      this.listKeysButton,
                                                                      this.listObjectsButton,
                                                                      this.clearTableButton,
                                                                      this.containsKeyButton,
                                                                      this.emptyButton,
                                                                      this.removeButton,
                                                                      this.getButton,
                                                                      this.addButton,
                                                                      this.consoleTextBox,
                                                                      this.lastNameTextBox,
                                                                      this.firstNameTextBox,
                                                                      this.lastNameLabel,
                                                                      this.firstNameLabel});
         this.Name = "HashTableTest";
         this.Text = "HashTableTest";
         this.ResumeLayout(false);

      }
		#endregion

      // main entry point for the application
      [STAThread]
      static void Main() 
      {
         Application.Run( new HashTableTest() );
      }

      // add last name and Employee object to table
      private void addButton_Click(
         object sender, System.EventArgs e )
      {
         Employee employee = new Employee( firstNameTextBox.Text,
            lastNameTextBox.Text );

         // add new key/value pair
         try
         {
            table.Add( lastNameTextBox.Text, employee );
            statusLabel.Text = "Put: " + employee.ToString();
         }

            // if key is null or already in table, output message
         catch ( ArgumentException argumentException )
         {
            statusLabel.Text = argumentException.ToString();
         }
      }

      // get object for given key
      private void getButton_Click(
         object sender, System.EventArgs e )
      {
         object result = table[ lastNameTextBox.Text ];

         if ( result != null )
            statusLabel.Text = "Get: " + result.ToString();
         else
            statusLabel.Text = "Get: " + lastNameTextBox.Text +
               " not in table";
      }

      // remove key/value pair from table
      private void removeButton_Click(
         object sender, System.EventArgs e )
      {
         table.Remove( lastNameTextBox.Text );
         statusLabel.Text = "Object Removed";
      }

      // determine whether table is empty
      private void emptyButton_Click(
         object sender, System.EventArgs e )
      {
         statusLabel.Text = "Table is " + (
            table.Count == 0 ? "empty" : "not empty" );
      }

      // determine whether table contains specified key
      private void containsKeyButton_Click(
         object sender, System.EventArgs e )
      {
         statusLabel.Text = "Contains key: " + 
            table.ContainsKey( lastNameTextBox.Text );
      }

      // discard all table contents
      private void clearTableButton_Click(
         object sender, System.EventArgs e )
      {
         table.Clear();
         statusLabel.Text = "Clear: Table is now empty";
      }

      // display list of objects in table
      private void listObjectsButton_Click(
         object sender, System.EventArgs e )
      {
         IDictionaryEnumerator enumerator = 
            table.GetEnumerator();
         StringBuilder buffer = new StringBuilder();

         while ( enumerator.MoveNext() )
            buffer.Append( enumerator.Value + "\r\n" );

         consoleTextBox.Text = buffer.ToString();
      }

      // display list of keys in table
      private void listKeysButton_Click(
         object sender, System.EventArgs e )
      {
         IDictionaryEnumerator enumerator = 
            table.GetEnumerator();
         StringBuilder buffer = new StringBuilder();

         while ( enumerator.MoveNext() )
            buffer.Append( enumerator.Key + "\r\n" );

         consoleTextBox.Text = buffer.ToString();
      }

   } // end class HashtableTest

   // class Employee for use with HashtableTest
   class Employee
   {
      private string first, last;

      // constructor
      public Employee( string fName, string lName )
      {
         first = fName;
         last = lName;
      }

      // return Employee first and last names as string
      public override string ToString()
      {
         return first + " " + last;
      }

   } // end class Employee
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
