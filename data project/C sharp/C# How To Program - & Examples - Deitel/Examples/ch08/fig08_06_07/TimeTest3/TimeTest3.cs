// Fig. 8.7: TimeTest3.cs
// Demonstrating Time3 properties Hour, Minute and Second.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TimeTest3
{
   // TimeTest3 class definition
   public class TimeTest3 : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label hourLabel;
      private System.Windows.Forms.TextBox hourTextBox;
      private System.Windows.Forms.Button hourButton;

      private System.Windows.Forms.Label minuteLabel;
      private System.Windows.Forms.TextBox minuteTextBox;
      private System.Windows.Forms.Button minuteButton;

      private System.Windows.Forms.Label secondLabel;
      private System.Windows.Forms.TextBox secondTextBox;
      private System.Windows.Forms.Button secondButton;

      private System.Windows.Forms.Button addButton;

      private System.Windows.Forms.Label displayLabel1;
      private System.Windows.Forms.Label displayLabel2;

      // required designer variable
      private System.ComponentModel.Container components = null;

      private Time3 time;

      public TimeTest3()
      {
         // Required for Windows Form Designer support
         InitializeComponent();

         time = new Time3();
         UpdateDisplay();
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
         this.hourLabel = new System.Windows.Forms.Label();
         this.minuteLabel = new System.Windows.Forms.Label();
         this.secondLabel = new System.Windows.Forms.Label();
         this.hourTextBox = new System.Windows.Forms.TextBox();
         this.minuteTextBox = new System.Windows.Forms.TextBox();
         this.secondTextBox = new System.Windows.Forms.TextBox();
         this.hourButton = new System.Windows.Forms.Button();
         this.minuteButton = new System.Windows.Forms.Button();
         this.secondButton = new System.Windows.Forms.Button();
         this.addButton = new System.Windows.Forms.Button();
         this.displayLabel1 = new System.Windows.Forms.Label();
         this.displayLabel2 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // hourLabel
         // 
         this.hourLabel.Location = new System.Drawing.Point(8, 10);
         this.hourLabel.Name = "hourLabel";
         this.hourLabel.Size = new System.Drawing.Size(72, 16);
         this.hourLabel.TabIndex = 0;
         this.hourLabel.Text = "Hour:";
         // 
         // minuteLabel
         // 
         this.minuteLabel.Location = new System.Drawing.Point(8, 43);
         this.minuteLabel.Name = "minuteLabel";
         this.minuteLabel.Size = new System.Drawing.Size(72, 16);
         this.minuteLabel.TabIndex = 1;
         this.minuteLabel.Text = "Minute:";
         // 
         // secondLabel
         // 
         this.secondLabel.Location = new System.Drawing.Point(8, 74);
         this.secondLabel.Name = "secondLabel";
         this.secondLabel.Size = new System.Drawing.Size(72, 16);
         this.secondLabel.TabIndex = 2;
         this.secondLabel.Text = "Second:";
         // 
         // hourTextBox
         // 
         this.hourTextBox.Location = new System.Drawing.Point(64, 8);
         this.hourTextBox.Name = "hourTextBox";
         this.hourTextBox.Size = new System.Drawing.Size(32, 20);
         this.hourTextBox.TabIndex = 3;
         this.hourTextBox.Text = "";
         // 
         // minuteTextBox
         // 
         this.minuteTextBox.Location = new System.Drawing.Point(64, 41);
         this.minuteTextBox.Name = "minuteTextBox";
         this.minuteTextBox.Size = new System.Drawing.Size(32, 20);
         this.minuteTextBox.TabIndex = 4;
         this.minuteTextBox.Text = "";
         // 
         // secondTextBox
         // 
         this.secondTextBox.Location = new System.Drawing.Point(64, 72);
         this.secondTextBox.Name = "secondTextBox";
         this.secondTextBox.Size = new System.Drawing.Size(32, 20);
         this.secondTextBox.TabIndex = 5;
         this.secondTextBox.Text = "";
         // 
         // hourButton
         // 
         this.hourButton.Location = new System.Drawing.Point(104, 7);
         this.hourButton.Name = "hourButton";
         this.hourButton.Size = new System.Drawing.Size(96, 23);
         this.hourButton.TabIndex = 6;
         this.hourButton.Text = "Set Hour";
         this.hourButton.Click += new System.EventHandler(this.hourButton_Click);
         // 
         // minuteButton
         // 
         this.minuteButton.Location = new System.Drawing.Point(104, 40);
         this.minuteButton.Name = "minuteButton";
         this.minuteButton.Size = new System.Drawing.Size(96, 23);
         this.minuteButton.TabIndex = 7;
         this.minuteButton.Text = "Set Minute";
         this.minuteButton.Click += new System.EventHandler(this.minuteButton_Click);
         // 
         // secondButton
         // 
         this.secondButton.Location = new System.Drawing.Point(104, 71);
         this.secondButton.Name = "secondButton";
         this.secondButton.Size = new System.Drawing.Size(96, 23);
         this.secondButton.TabIndex = 8;
         this.secondButton.Text = "Set Second";
         this.secondButton.Click += new System.EventHandler(this.secondButton_Click);
         // 
         // addButton
         // 
         this.addButton.Location = new System.Drawing.Point(104, 104);
         this.addButton.Name = "addButton";
         this.addButton.Size = new System.Drawing.Size(96, 23);
         this.addButton.TabIndex = 9;
         this.addButton.Text = "Add 1 to Second";
         this.addButton.Click += new System.EventHandler(this.addButton_Click);
         // 
         // displayLabel1
         // 
         this.displayLabel1.Location = new System.Drawing.Point(224, 39);
         this.displayLabel1.Name = "displayLabel1";
         this.displayLabel1.Size = new System.Drawing.Size(176, 23);
         this.displayLabel1.TabIndex = 10;
         // 
         // displayLabel2
         // 
         this.displayLabel2.Location = new System.Drawing.Point(224, 71);
         this.displayLabel2.Name = "displayLabel2";
         this.displayLabel2.Size = new System.Drawing.Size(176, 33);
         this.displayLabel2.TabIndex = 11;
         // 
         // TimeTest3
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(408, 133);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.displayLabel2,
                                                                      this.displayLabel1,
                                                                      this.addButton,
                                                                      this.secondButton,
                                                                      this.minuteButton,
                                                                      this.hourButton,
                                                                      this.secondTextBox,
                                                                      this.minuteTextBox,
                                                                      this.hourTextBox,
                                                                      this.secondLabel,
                                                                      this.minuteLabel,
                                                                      this.hourLabel});
         this.Name = "TimeTest3";
         this.Text = "Using Properties";
         this.ResumeLayout(false);

      }
		#endregion

      // main entry point for application
      [STAThread]
      static void Main() 
      {
         Application.Run( new TimeTest3() );
      }

      // update display labels
      public void UpdateDisplay()
      {
         displayLabel1.Text = "Hour: " + time.Hour + 
            "; Minute: " + time.Minute +
            "; Second: " + time.Second;
         displayLabel2.Text = "Standard time: " +
            time.ToStandardString() + "\nUniversal time: " +
            time.ToUniversalString();
      }

      // set Hour property when hourButton pressed
      private void hourButton_Click( 
         object sender, System.EventArgs e )
      {
         time.Hour = Int32.Parse( hourTextBox.Text );
         hourTextBox.Text = "";
         UpdateDisplay();
      }

      // set Minute property when minuteButton pressed
      private void minuteButton_Click(
         object sender, System.EventArgs e )
      {
         time.Minute = Int32.Parse( minuteTextBox.Text );
         minuteTextBox.Text = "";
         UpdateDisplay();      
      }

      // set Second property when secondButton pressed
      private void secondButton_Click(
         object sender, System.EventArgs e )
      {
         time.Second = Int32.Parse( secondTextBox.Text );
         secondTextBox.Text = "";
         UpdateDisplay();      
      }

      // add one to Second when addButton pressed
      private void addButton_Click(
         object sender, System.EventArgs e )
      {
         time.Second = ( time.Second + 1 ) % 60;

         if ( time.Second == 0 )
         {
            time.Minute = ( time.Minute + 1 ) % 60;

            if ( time.Minute == 0 )
               time.Hour = ( time.Hour + 1 ) % 24;
         }

         UpdateDisplay();

      } // end method addButton_Click

   } // end class TimeTest3
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
