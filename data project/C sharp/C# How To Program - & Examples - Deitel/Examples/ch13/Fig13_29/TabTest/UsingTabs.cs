// Fig. 13.29: UsingTabs.cs
// Using TabControl to display various font settings.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TabTest
{
   /// <summary>
   /// Summary description for UsingTabs.
   /// </summary>
   public class UsingTabs : System.Windows.Forms.Form
   {
      // output label reflects text changes
      private System.Windows.Forms.Label displayLabel;

      // table control containing table pages colorTabPage,
      // sizeTabPage, messageTabPage and aboutTabPage
      private System.Windows.Forms.TabControl 
         optionsTabControl;

      // table page containing color options
      private System.Windows.Forms.TabPage colorTabPage;
      private System.Windows.Forms.RadioButton 
         greenRadioButton;
      private System.Windows.Forms.RadioButton redRadioButton;
      private System.Windows.Forms.RadioButton 
         blackRadioButton;

      // table page containing font size options
      private System.Windows.Forms.TabPage sizeTabPage;
      private System.Windows.Forms.RadioButton 
         size20RadioButton;
      private System.Windows.Forms.RadioButton 
         size16RadioButton;
      private System.Windows.Forms.RadioButton 
         size12RadioButton;

      // table page containing text display options
      private System.Windows.Forms.TabPage messageTabPage;
      private System.Windows.Forms.RadioButton 
         goodByeRadioButton;
      private System.Windows.Forms.RadioButton 
         helloRadioButton;

      // table page containing about message
      private System.Windows.Forms.TabPage aboutTabPage;
      private System.Windows.Forms.Label messageLabel;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container 
         components = null;

      public UsingTabs()
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
         this.displayLabel = new System.Windows.Forms.Label();
         this.optionsTabControl = new System.Windows.Forms.TabControl();
         this.colorTabPage = new System.Windows.Forms.TabPage();
         this.greenRadioButton = new System.Windows.Forms.RadioButton();
         this.redRadioButton = new System.Windows.Forms.RadioButton();
         this.blackRadioButton = new System.Windows.Forms.RadioButton();
         this.sizeTabPage = new System.Windows.Forms.TabPage();
         this.size20RadioButton = new System.Windows.Forms.RadioButton();
         this.size16RadioButton = new System.Windows.Forms.RadioButton();
         this.size12RadioButton = new System.Windows.Forms.RadioButton();
         this.messageTabPage = new System.Windows.Forms.TabPage();
         this.goodByeRadioButton = new System.Windows.Forms.RadioButton();
         this.helloRadioButton = new System.Windows.Forms.RadioButton();
         this.aboutTabPage = new System.Windows.Forms.TabPage();
         this.messageLabel = new System.Windows.Forms.Label();
         this.optionsTabControl.SuspendLayout();
         this.colorTabPage.SuspendLayout();
         this.sizeTabPage.SuspendLayout();
         this.messageTabPage.SuspendLayout();
         this.aboutTabPage.SuspendLayout();
         this.SuspendLayout();
         // 
         // displayLabel
         // 
         this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.displayLabel.Location = new System.Drawing.Point(24, 192);
         this.displayLabel.Name = "displayLabel";
         this.displayLabel.Size = new System.Drawing.Size(272, 40);
         this.displayLabel.TabIndex = 3;
         this.displayLabel.Text = "Hello!";
         this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // optionsTabControl
         // 
         this.optionsTabControl.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                        this.colorTabPage,
                                                                                        this.sizeTabPage,
                                                                                        this.messageTabPage,
                                                                                        this.aboutTabPage});
         this.optionsTabControl.Location = new System.Drawing.Point(16, 16);
         this.optionsTabControl.Name = "optionsTabControl";
         this.optionsTabControl.SelectedIndex = 0;
         this.optionsTabControl.Size = new System.Drawing.Size(280, 168);
         this.optionsTabControl.TabIndex = 2;
         // 
         // colorTabPage
         // 
         this.colorTabPage.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                   this.greenRadioButton,
                                                                                   this.redRadioButton,
                                                                                   this.blackRadioButton});
         this.colorTabPage.Location = new System.Drawing.Point(4, 22);
         this.colorTabPage.Name = "colorTabPage";
         this.colorTabPage.Size = new System.Drawing.Size(272, 142);
         this.colorTabPage.TabIndex = 0;
         this.colorTabPage.Text = "Color";
         // 
         // greenRadioButton
         // 
         this.greenRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.greenRadioButton.Location = new System.Drawing.Point(16, 104);
         this.greenRadioButton.Name = "greenRadioButton";
         this.greenRadioButton.TabIndex = 2;
         this.greenRadioButton.Text = "Green";
         this.greenRadioButton.CheckedChanged += new System.EventHandler(this.greenRadioButton_CheckedChanged);
         // 
         // redRadioButton
         // 
         this.redRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.redRadioButton.Location = new System.Drawing.Point(16, 64);
         this.redRadioButton.Name = "redRadioButton";
         this.redRadioButton.TabIndex = 1;
         this.redRadioButton.Text = "Red";
         this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
         // 
         // blackRadioButton
         // 
         this.blackRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.blackRadioButton.Location = new System.Drawing.Point(16, 24);
         this.blackRadioButton.Name = "blackRadioButton";
         this.blackRadioButton.TabIndex = 0;
         this.blackRadioButton.Text = "Black";
         this.blackRadioButton.CheckedChanged += new System.EventHandler(this.blackRadioButton_CheckedChanged);
         // 
         // sizeTabPage
         // 
         this.sizeTabPage.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                  this.size20RadioButton,
                                                                                  this.size16RadioButton,
                                                                                  this.size12RadioButton});
         this.sizeTabPage.Location = new System.Drawing.Point(4, 22);
         this.sizeTabPage.Name = "sizeTabPage";
         this.sizeTabPage.Size = new System.Drawing.Size(272, 142);
         this.sizeTabPage.TabIndex = 1;
         this.sizeTabPage.Text = "Size";
         this.sizeTabPage.Visible = false;
         // 
         // size20RadioButton
         // 
         this.size20RadioButton.Location = new System.Drawing.Point(16, 104);
         this.size20RadioButton.Name = "size20RadioButton";
         this.size20RadioButton.TabIndex = 2;
         this.size20RadioButton.Text = "20 point";
         this.size20RadioButton.CheckedChanged += new System.EventHandler(this.size20RadioButton_CheckedChanged);
         // 
         // size16RadioButton
         // 
         this.size16RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.size16RadioButton.Location = new System.Drawing.Point(16, 64);
         this.size16RadioButton.Name = "size16RadioButton";
         this.size16RadioButton.TabIndex = 1;
         this.size16RadioButton.Text = "16 point";
         this.size16RadioButton.CheckedChanged += new System.EventHandler(this.size16RadioButton_CheckedChanged);
         // 
         // size12RadioButton
         // 
         this.size12RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.size12RadioButton.Location = new System.Drawing.Point(16, 24);
         this.size12RadioButton.Name = "size12RadioButton";
         this.size12RadioButton.TabIndex = 0;
         this.size12RadioButton.Text = "12 point";
         this.size12RadioButton.CheckedChanged += new System.EventHandler(this.size12RadioButton_CheckedChanged);
         // 
         // messageTabPage
         // 
         this.messageTabPage.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                     this.goodByeRadioButton,
                                                                                     this.helloRadioButton});
         this.messageTabPage.Location = new System.Drawing.Point(4, 22);
         this.messageTabPage.Name = "messageTabPage";
         this.messageTabPage.Size = new System.Drawing.Size(272, 142);
         this.messageTabPage.TabIndex = 2;
         this.messageTabPage.Text = "Message";
         this.messageTabPage.Visible = false;
         // 
         // goodByeRadioButton
         // 
         this.goodByeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.goodByeRadioButton.Location = new System.Drawing.Point(16, 64);
         this.goodByeRadioButton.Name = "goodByeRadioButton";
         this.goodByeRadioButton.TabIndex = 1;
         this.goodByeRadioButton.Text = "Goodbye!";
         this.goodByeRadioButton.CheckedChanged += new System.EventHandler(this.goodByeRadioButton_CheckedChanged);
         // 
         // helloRadioButton
         // 
         this.helloRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.helloRadioButton.Location = new System.Drawing.Point(16, 24);
         this.helloRadioButton.Name = "helloRadioButton";
         this.helloRadioButton.TabIndex = 0;
         this.helloRadioButton.Text = "Hello!";
         this.helloRadioButton.CheckedChanged += new System.EventHandler(this.helloRadioButton_CheckedChanged);
         // 
         // aboutTabPage
         // 
         this.aboutTabPage.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                   this.messageLabel});
         this.aboutTabPage.Location = new System.Drawing.Point(4, 22);
         this.aboutTabPage.Name = "aboutTabPage";
         this.aboutTabPage.Size = new System.Drawing.Size(272, 142);
         this.aboutTabPage.TabIndex = 3;
         this.aboutTabPage.Text = "About";
         this.aboutTabPage.Visible = false;
         // 
         // messageLabel
         // 
         this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.messageLabel.Location = new System.Drawing.Point(16, 16);
         this.messageLabel.Name = "messageLabel";
         this.messageLabel.Size = new System.Drawing.Size(248, 104);
         this.messageLabel.TabIndex = 0;
         this.messageLabel.Text = "Tabs are used to organize controls and conserve screen space.";
         // 
         // UsingTabs
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(328, 245);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.displayLabel,
                                                                      this.optionsTabControl});
         this.Name = "UsingTabs";
         this.Text = "UsingTabs";
         this.optionsTabControl.ResumeLayout(false);
         this.colorTabPage.ResumeLayout(false);
         this.sizeTabPage.ResumeLayout(false);
         this.messageTabPage.ResumeLayout(false);
         this.aboutTabPage.ResumeLayout(false);
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new UsingTabs() );
      }

      // event handler for black color radio button
      private void blackRadioButton_CheckedChanged(
         object sender, System.EventArgs e )
      {
         displayLabel.ForeColor = Color.Black;
      }

      // event handler for red color radio button
      private void redRadioButton_CheckedChanged(
         object sender, System.EventArgs e )
      {
         displayLabel.ForeColor = Color.Red;
      }

      // event handler for green color radio button
      private void greenRadioButton_CheckedChanged(
         object sender, System.EventArgs e )
      {
         displayLabel.ForeColor = Color.Green;
      }

      // event handler for size 12 radio button
      private void size12RadioButton_CheckedChanged(
         object sender, System.EventArgs e )
      {
         displayLabel.Font = 
            new Font( displayLabel.Font.Name, 12 );
      }

      // event handler for size 16 radio button
      private void size16RadioButton_CheckedChanged(
         object sender, System.EventArgs e )
      {
         displayLabel.Font = 
            new Font( displayLabel.Font.Name, 16 );
      }

      // event handler for size 20 radio button
      private void size20RadioButton_CheckedChanged(
         object sender, System.EventArgs e )
      {
         displayLabel.Font = 
            new Font( displayLabel.Font.Name, 20 );      
      }

      // event handler for message "Hello!" radio button
      private void helloRadioButton_CheckedChanged(
         object sender, System.EventArgs e )
      {
         displayLabel.Text = "Hello!";
      }

      // event handler for message "Goodbye!" radio button
      private void goodByeRadioButton_CheckedChanged(
         object sender, System.EventArgs e )
      {
         displayLabel.Text = "Goodbye!";
      }

   } // end class UsingTabs
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
