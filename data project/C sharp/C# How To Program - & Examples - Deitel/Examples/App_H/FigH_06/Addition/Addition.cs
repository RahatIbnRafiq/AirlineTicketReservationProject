// Fig. H.6: Addition.cs
// Uses a COM component to add two integers.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Deitel_DLL;

namespace Addition
{
   // Adds two integers using a COM component
   public class Addition : System.Windows.Forms.Form
   {
      // display labels
      private System.Windows.Forms.Label SecondLabel;
      private System.Windows.Forms.Label FirstLabel;

      // integer text boxes
      private System.Windows.Forms.TextBox resultBox;
      private System.Windows.Forms.TextBox firstIntegerBox;
      private System.Windows.Forms.TextBox secondIntegerBox;

      // calculates addition
      private System.Windows.Forms.Button calculateButton;

      private CAddition additionObject = new CAddition(); 
      
      // Required designer variable.
      private System.ComponentModel.Container 
         components = null;

      public Addition()
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
         this.FirstLabel = new System.Windows.Forms.Label();
         this.SecondLabel = new System.Windows.Forms.Label();
         this.firstIntegerBox = new System.Windows.Forms.TextBox();
         this.secondIntegerBox = new System.Windows.Forms.TextBox();
         this.calculateButton = new System.Windows.Forms.Button();
         this.resultBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // FirstLabel
         // 
         this.FirstLabel.Location = new System.Drawing.Point(88, 24);
         this.FirstLabel.Name = "FirstLabel";
         this.FirstLabel.Size = new System.Drawing.Size(72, 16);
         this.FirstLabel.TabIndex = 0;
         this.FirstLabel.Text = "First Integer";
         // 
         // SecondLabel
         // 
         this.SecondLabel.Location = new System.Drawing.Point(72, 88);
         this.SecondLabel.Name = "SecondLabel";
         this.SecondLabel.Size = new System.Drawing.Size(100, 16);
         this.SecondLabel.TabIndex = 1;
         this.SecondLabel.Text = "Second Integer";
         // 
         // firstIntegerBox
         // 
         this.firstIntegerBox.Location = new System.Drawing.Point(40, 40);
         this.firstIntegerBox.Name = "firstIntegerBox";
         this.firstIntegerBox.Size = new System.Drawing.Size(176, 20);
         this.firstIntegerBox.TabIndex = 2;
         this.firstIntegerBox.Text = "";
         this.firstIntegerBox.TextChanged += new System.EventHandler(this.integerBox_TextChanged);
         // 
         // secondIntegerBox
         // 
         this.secondIntegerBox.Location = new System.Drawing.Point(40, 104);
         this.secondIntegerBox.Name = "secondIntegerBox";
         this.secondIntegerBox.Size = new System.Drawing.Size(176, 20);
         this.secondIntegerBox.TabIndex = 3;
         this.secondIntegerBox.Text = "";
         this.secondIntegerBox.TextChanged += new System.EventHandler(this.integerBox_TextChanged);
         // 
         // calculateButton
         // 
         this.calculateButton.Enabled = false;
         this.calculateButton.Location = new System.Drawing.Point(80, 144);
         this.calculateButton.Name = "calculateButton";
         this.calculateButton.TabIndex = 4;
         this.calculateButton.Text = "Calculate";
         this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
         // 
         // resultBox
         // 
         this.resultBox.Location = new System.Drawing.Point(56, 192);
         this.resultBox.Name = "resultBox";
         this.resultBox.ReadOnly = true;
         this.resultBox.Size = new System.Drawing.Size(136, 20);
         this.resultBox.TabIndex = 5;
         this.resultBox.Text = "";
         this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // Addition
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(240, 237);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.resultBox,
                                                                      this.calculateButton,
                                                                      this.secondIntegerBox,
                                                                      this.firstIntegerBox,
                                                                      this.SecondLabel,
                                                                      this.FirstLabel});
         this.Name = "Addition";
         this.Text = "Adding integers using a COM component";
         this.ResumeLayout(false);

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
		#endregion

      // The main entry point for the application.
      [STAThread]
      static void Main() 
      {
         Application.Run( new Addition() );
      }

      // event handler to enable calculateButton
      private void integerBox_TextChanged( object sender, 
         System.EventArgs e )
      {
         // enable calculate button if both boxes
         // contain text
         if ( firstIntegerBox.Text != "" && 
            secondIntegerBox.Text != "" )
            calculateButton.Enabled = true;
         else
            calculateButton.Enabled = false;
            
      } // end method integerBox_TextChanged

      // event hander that displays sum when calculate
      // is clicked
      private void calculateButton_Click( object sender, 
         System.EventArgs e )
      {
         int firstInteger, secondInteger, total;
         
         firstInteger = Int32.Parse( firstIntegerBox.Text );
         secondInteger = Int32.Parse( secondIntegerBox.Text );
         
         // addition object invokes AddFunction that
         // returns integer value
         total = additionObject.AddFunction( ref firstInteger,
            ref secondInteger );
            
         resultBox.Text = total.ToString();
      } // end method calculateButton_Click 
   } // end class Addition
} // end namespace Addition

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