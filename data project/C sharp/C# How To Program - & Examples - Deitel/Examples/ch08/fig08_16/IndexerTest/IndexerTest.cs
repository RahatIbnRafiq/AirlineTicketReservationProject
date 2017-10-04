// Fig. 8.16: IndexerTest.cs
// Indexers provide access to an object's members via a 
// subscript operator.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace IndexerTest
{
   // Box class definition represents a box with length, 
   // width and height dimensions
   public class Box
   {
      private string[] names = { "length", "width", "height" };
      private double[] dimensions = new double[ 3 ];

      // constructor
      public Box( double length, double width, double height ) 
      {
         dimensions[ 0 ] = length;
         dimensions[ 1 ] = width;
         dimensions[ 2 ] = height;
      }

      // access dimensions by index number
      public double this[ int index ]
      {
         get
         {
            return ( index < 0 || index > dimensions.Length ) ?
               -1 : dimensions[ index ];
         }

         set
         {
            if ( index >= 0 && index < dimensions.Length )
               dimensions[ index ] = value;
         }
      
      } // end numeric indexer
      
      // access dimensions by their names
      public double this[ string name ]
      {
         get
         {
            // locate element to get
            int i = 0;
 
            while ( i < names.Length && 
                    name.ToLower() != names[ i ] )
               i++;
            
            return ( i == names.Length ) ? -1 : dimensions[ i ];
         }

         set
         {
            // locate element to set
            int i = 0;
 
            while ( i < names.Length && 
                    name.ToLower() != names[ i ] )
               i++;
            
            if ( i != names.Length )
               dimensions[ i ] = value;
         }
      
      } // end indexer
   
   } // end class Box
   
   // Class IndexerTest
   public class IndexerTest : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label indexLabel;
      private System.Windows.Forms.Label nameLabel;

      private System.Windows.Forms.TextBox indexTextBox;
      private System.Windows.Forms.TextBox valueTextBox;

      private System.Windows.Forms.Button nameSetButton;
      private System.Windows.Forms.Button nameGetButton;

      private System.Windows.Forms.Button intSetButton;
      private System.Windows.Forms.Button intGetButton;
      
      private System.Windows.Forms.TextBox resultTextBox;

      // required designer variable
      private System.ComponentModel.Container components = null;

      private Box box;

      // constructor
      public IndexerTest()
      {
         // required for Windows Form Designer support
         InitializeComponent();

         // create block
         box = new Box( 0.0, 0.0, 0.0 );
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
         this.valueTextBox = new System.Windows.Forms.TextBox();
         this.indexTextBox = new System.Windows.Forms.TextBox();
         this.indexLabel = new System.Windows.Forms.Label();
         this.nameLabel = new System.Windows.Forms.Label();
         this.nameSetButton = new System.Windows.Forms.Button();
         this.intGetButton = new System.Windows.Forms.Button();
         this.intSetButton = new System.Windows.Forms.Button();
         this.nameGetButton = new System.Windows.Forms.Button();
         this.resultTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // valueTextBox
         // 
         this.valueTextBox.Location = new System.Drawing.Point(96, 41);
         this.valueTextBox.Name = "valueTextBox";
         this.valueTextBox.Size = new System.Drawing.Size(104, 20);
         this.valueTextBox.TabIndex = 1;
         this.valueTextBox.Text = "";
         // 
         // indexTextBox
         // 
         this.indexTextBox.Location = new System.Drawing.Point(96, 9);
         this.indexTextBox.Name = "indexTextBox";
         this.indexTextBox.Size = new System.Drawing.Size(104, 20);
         this.indexTextBox.TabIndex = 0;
         this.indexTextBox.Text = "";
         // 
         // indexLabel
         // 
         this.indexLabel.Location = new System.Drawing.Point(8, 11);
         this.indexLabel.Name = "indexLabel";
         this.indexLabel.Size = new System.Drawing.Size(88, 16);
         this.indexLabel.TabIndex = 8;
         this.indexLabel.Text = "Index to set/get";
         // 
         // nameLabel
         // 
         this.nameLabel.Location = new System.Drawing.Point(8, 43);
         this.nameLabel.Name = "nameLabel";
         this.nameLabel.Size = new System.Drawing.Size(88, 16);
         this.nameLabel.TabIndex = 9;
         this.nameLabel.Text = "Value to set";
         // 
         // nameSetButton
         // 
         this.nameSetButton.Location = new System.Drawing.Point(368, 40);
         this.nameSetButton.Name = "nameSetButton";
         this.nameSetButton.Size = new System.Drawing.Size(136, 23);
         this.nameSetButton.TabIndex = 7;
         this.nameSetButton.Text = "Set Value by Name";
         this.nameSetButton.Click += new System.EventHandler(this.nameSetButton_Click);
         // 
         // intGetButton
         // 
         this.intGetButton.Location = new System.Drawing.Point(224, 8);
         this.intGetButton.Name = "intGetButton";
         this.intGetButton.Size = new System.Drawing.Size(136, 23);
         this.intGetButton.TabIndex = 4;
         this.intGetButton.Text = "Get Value by Index";
         this.intGetButton.Click += new System.EventHandler(this.intGetButton_Click);
         // 
         // intSetButton
         // 
         this.intSetButton.Location = new System.Drawing.Point(368, 8);
         this.intSetButton.Name = "intSetButton";
         this.intSetButton.Size = new System.Drawing.Size(136, 23);
         this.intSetButton.TabIndex = 5;
         this.intSetButton.Text = "Set Value by Index";
         this.intSetButton.Click += new System.EventHandler(this.intSetButton_Click);
         // 
         // nameGetButton
         // 
         this.nameGetButton.Location = new System.Drawing.Point(224, 40);
         this.nameGetButton.Name = "nameGetButton";
         this.nameGetButton.Size = new System.Drawing.Size(136, 23);
         this.nameGetButton.TabIndex = 6;
         this.nameGetButton.Text = "Get Value by Name";
         this.nameGetButton.Click += new System.EventHandler(this.nameGetButton_Click);
         // 
         // resultTextBox
         // 
         this.resultTextBox.Location = new System.Drawing.Point(8, 80);
         this.resultTextBox.Name = "resultTextBox";
         this.resultTextBox.Size = new System.Drawing.Size(496, 20);
         this.resultTextBox.TabIndex = 10;
         this.resultTextBox.Text = "";
         // 
         // IndexerTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(512, 109);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.resultTextBox,
                                                                      this.nameLabel,
                                                                      this.indexLabel,
                                                                      this.nameSetButton,
                                                                      this.nameGetButton,
                                                                      this.intSetButton,
                                                                      this.intGetButton,
                                                                      this.valueTextBox,
                                                                      this.indexTextBox});
         this.Name = "IndexerTest";
         this.Text = "IndexerTest";
         this.ResumeLayout(false);

      }
		#endregion

      // main entry point for application
      [STAThread]
      static void Main() 
      {
         Application.Run( new IndexerTest() );
      }

      // display value at specified index number
      private void ShowValueAtIndex( string prefix, int index )
      {
         resultTextBox.Text = 
            prefix + "box[ " + index + " ] = " + box[ index ];
      }

      // display value with specified name
      private void ShowValueAtIndex( string prefix, string name )
      {
         resultTextBox.Text = 
            prefix + "box[ " + name + " ] = " + box[ name ];
      }

      // clear indexTextBox and valueTextBox
      private void ClearTextBoxes()
      {
         indexTextBox.Text = "";
         valueTextBox.Text = "";
      }

      // get value at specified index
      private void intGetButton_Click( 
         object sender, System.EventArgs e )
      {
         ShowValueAtIndex( 
            "get: ", Int32.Parse( indexTextBox.Text ) );
         ClearTextBoxes();
      }

      // set value at specified index
      private void intSetButton_Click( 
         object sender, System.EventArgs e )
      {
         int index = Int32.Parse( indexTextBox.Text );
         box[ index ] = Double.Parse( valueTextBox.Text );

         ShowValueAtIndex( "set: ", index );
         ClearTextBoxes();
      }

      // get value with specified name
      private void nameGetButton_Click( 
         object sender, System.EventArgs e )
      {
         ShowValueAtIndex( "get: ", indexTextBox.Text );
         ClearTextBoxes();
      }

      // set value with specified name
      private void nameSetButton_Click( 
         object sender, System.EventArgs e )
      {
         box[ indexTextBox.Text ] = 
            Double.Parse( valueTextBox.Text );

         ShowValueAtIndex( "set: ", indexTextBox.Text );
         ClearTextBoxes();
      }

   } // end class IndexerTest
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