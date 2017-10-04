// Fig. 24.13: TextToSpeech.cs
// Providing audio for people with visual impairments.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SpeechTest
{
   /// <summary>
   /// helps users navigate a form with the aid of audio cues
   /// </summary>
   public class TextToSpeech : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label nameLabel;
      private System.Windows.Forms.Label phoneLabel;

      private System.Windows.Forms.TextBox nameTextBox;
      private System.Windows.Forms.TextBox phoneTextBox;
      private System.Windows.Forms.TextBox passwordTextBox;

      private System.Windows.Forms.Button submitButton;

      private System.Windows.Forms.Label passwordLabel;

      private AxHTTSLib.AxTextToSpeech speaker;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      // default constructor
      public TextToSpeech()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();

         //
         // TODO: Add any constructor code after InitializeComponent call
         //
         
         // set Form to be visible to accessibility applications
         this.IsAccessible = true;

         // let all controls be visible to accessibility applications
         foreach ( Control current in this.Controls )
            current.IsAccessible = true;
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
         System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TextToSpeech));
         this.nameLabel = new System.Windows.Forms.Label();
         this.phoneLabel = new System.Windows.Forms.Label();
         this.nameTextBox = new System.Windows.Forms.TextBox();
         this.phoneTextBox = new System.Windows.Forms.TextBox();
         this.passwordTextBox = new System.Windows.Forms.TextBox();
         this.submitButton = new System.Windows.Forms.Button();
         this.passwordLabel = new System.Windows.Forms.Label();
         this.speaker = new AxHTTSLib.AxTextToSpeech();
         ((System.ComponentModel.ISupportInitialize)(this.speaker)).BeginInit();
         this.SuspendLayout();
         // 
         // nameLabel
         // 
         this.nameLabel.AccessibleDescription = "User Name";
         this.nameLabel.AccessibleName = "User Name";
         this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.nameLabel.Location = new System.Drawing.Point(32, 32);
         this.nameLabel.Name = "nameLabel";
         this.nameLabel.Size = new System.Drawing.Size(96, 23);
         this.nameLabel.TabIndex = 5;
         this.nameLabel.Text = "Name";
         this.nameLabel.MouseHover += new System.EventHandler(this.controls_MouseHover);
         // 
         // phoneLabel
         // 
         this.phoneLabel.AccessibleDescription = "Phone Number Label";
         this.phoneLabel.AccessibleName = "Phone Number Label";
         this.phoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.phoneLabel.Location = new System.Drawing.Point(32, 64);
         this.phoneLabel.Name = "phoneLabel";
         this.phoneLabel.Size = new System.Drawing.Size(96, 23);
         this.phoneLabel.TabIndex = 6;
         this.phoneLabel.Text = "Phone Number";
         this.phoneLabel.MouseHover += new System.EventHandler(this.controls_MouseHover);
         // 
         // nameTextBox
         // 
         this.nameTextBox.AccessibleDescription = "Enter User Name";
         this.nameTextBox.AccessibleName = "User Name TextBox";
         this.nameTextBox.Location = new System.Drawing.Point(152, 32);
         this.nameTextBox.Name = "nameTextBox";
         this.nameTextBox.TabIndex = 1;
         this.nameTextBox.Text = "";
         this.nameTextBox.MouseHover += new System.EventHandler(this.controls_MouseHover);
         // 
         // phoneTextBox
         // 
         this.phoneTextBox.AccessibleDescription = "Enter Phone Number";
         this.phoneTextBox.AccessibleName = "Phone Number TextBox";
         this.phoneTextBox.Location = new System.Drawing.Point(152, 64);
         this.phoneTextBox.Name = "phoneTextBox";
         this.phoneTextBox.TabIndex = 2;
         this.phoneTextBox.Text = "";
         this.phoneTextBox.MouseHover += new System.EventHandler(this.controls_MouseHover);
         // 
         // passwordTextBox
         // 
         this.passwordTextBox.AccessibleDescription = "Enter Password";
         this.passwordTextBox.AccessibleName = "Password TextBox";
         this.passwordTextBox.Location = new System.Drawing.Point(152, 96);
         this.passwordTextBox.Name = "passwordTextBox";
         this.passwordTextBox.PasswordChar = '*';
         this.passwordTextBox.TabIndex = 3;
         this.passwordTextBox.Text = "";
         this.passwordTextBox.MouseHover += new System.EventHandler(this.controls_MouseHover);
         // 
         // submitButton
         // 
         this.submitButton.AccessibleDescription = "Submit the Information";
         this.submitButton.AccessibleName = "Submit Information";
         this.submitButton.Location = new System.Drawing.Point(112, 144);
         this.submitButton.Name = "submitButton";
         this.submitButton.TabIndex = 4;
         this.submitButton.Text = "&Submit";
         this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
         this.submitButton.MouseHover += new System.EventHandler(this.controls_MouseHover);
         // 
         // passwordLabel
         // 
         this.passwordLabel.AccessibleDescription = "Password Label";
         this.passwordLabel.AccessibleName = "Password Label";
         this.passwordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.passwordLabel.Location = new System.Drawing.Point(32, 96);
         this.passwordLabel.Name = "passwordLabel";
         this.passwordLabel.Size = new System.Drawing.Size(96, 23);
         this.passwordLabel.TabIndex = 7;
         this.passwordLabel.Text = "Password";
         this.passwordLabel.MouseHover += new System.EventHandler(this.controls_MouseHover);
         // 
         // speaker
         // 
         this.speaker.AccessibleDescription = "Give Information about Form";
         this.speaker.AccessibleName = "Speaker";
         this.speaker.Enabled = true;
         this.speaker.Location = new System.Drawing.Point(288, 40);
         this.speaker.Name = "speaker";
         this.speaker.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("speaker.OcxState")));
         this.speaker.Size = new System.Drawing.Size(112, 104);
         this.speaker.TabIndex = 8;
         this.speaker.TabStop = false;
         // 
         // TextToSpeech
         // 
         this.AccessibleDescription = "Registration Form";
         this.AccessibleName = "Registration Form";
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(416, 181);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.speaker,
                                                                      this.passwordLabel,
                                                                      this.submitButton,
                                                                      this.passwordTextBox,
                                                                      this.phoneTextBox,
                                                                      this.nameTextBox,
                                                                      this.phoneLabel,
                                                                      this.nameLabel});
         this.Name = "TextToSpeech";
         this.Text = "TextToSpeech";
         ((System.ComponentModel.ISupportInitialize)(this.speaker)).EndInit();
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new TextToSpeech() );
      }

      // tell user over which control the mouse is
      private void controls_MouseHover( 
         object sender, System.EventArgs e )
      {	
         // if mouse is over a Label, tell user to enter information
         if ( sender.GetType() == nameLabel.GetType() )
         {	
            Label temporary = ( Label) sender;
            speaker.Speak( "Please enter your " + temporary.Text +
               " in the textbox to the right" );
         }

         // if mouse is over a TextBox, tell user what 
         // information was entered
         else if ( sender.GetType() == nameTextBox.GetType() )
         {
            TextBox temporary = ( TextBox ) sender;
            speaker.Speak( "You have entered " + 
               ( temporary.Text == "" ? "nothing" : 
               temporary.Text ) + " in the " + temporary.Name );
         }

         // otherwise, user is over Button, so tell user to click
         // it to submit the information
         else
            speaker.Speak( 
               "Click on this button to submit your information" );

      } // end method controls_MouseHover

      // thank user for information submition
      private void submitButton_Click( 
         object sender, System.EventArgs e )
      {
         speaker.Speak( 
            "Thank you, your information has been submitted." );

         Application.Exit();
      }

   } // end class TextToSpeech
}

/**************************************************************************
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
 *************************************************************************/
