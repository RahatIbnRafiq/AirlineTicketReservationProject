// Fig. 16.37:  Agent.cs
// Demonstrates microsoft agent

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace MicrosoftAgent
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class Agent : System.Windows.Forms.Form
   {
      // options
      private System.Windows.Forms.ComboBox actionsCombo;
      private System.Windows.Forms.ComboBox characterCombo;

      private System.Windows.Forms.Button speakButton;
      private System.Windows.Forms.GroupBox characterGroup;
      private AxAgentObjects.AxAgent mainAgent;

      // input
      private System.Windows.Forms.TextBox speechTextBox;
      private System.Windows.Forms.TextBox locationTextBox;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private 
         System.ComponentModel.Container components = null;

      // current agent object
      private AgentObjects.IAgentCtlCharacter speaker;

      public Agent()
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
         System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Agent));
         this.actionsCombo = new System.Windows.Forms.ComboBox();
         this.speechTextBox = new System.Windows.Forms.TextBox();
         this.speakButton = new System.Windows.Forms.Button();
         this.characterGroup = new System.Windows.Forms.GroupBox();
         this.characterCombo = new System.Windows.Forms.ComboBox();
         this.locationTextBox = new System.Windows.Forms.TextBox();
         this.mainAgent = new AxAgentObjects.AxAgent();
         this.characterGroup.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.mainAgent)).BeginInit();
         this.SuspendLayout();
         // 
         // actionsCombo
         // 
         this.actionsCombo.Enabled = false;
         this.actionsCombo.Location = new System.Drawing.Point(312, 72);
         this.actionsCombo.Name = "actionsCombo";
         this.actionsCombo.Size = new System.Drawing.Size(128, 21);
         this.actionsCombo.TabIndex = 11;
         this.actionsCombo.Text = "Select an Action";
         this.actionsCombo.SelectedIndexChanged += new System.EventHandler(this.actionsCombo_SelectedIndexChanged);
         // 
         // speechTextBox
         // 
         this.speechTextBox.Enabled = false;
         this.speechTextBox.Location = new System.Drawing.Point(8, 16);
         this.speechTextBox.Multiline = true;
         this.speechTextBox.Name = "speechTextBox";
         this.speechTextBox.Size = new System.Drawing.Size(280, 80);
         this.speechTextBox.TabIndex = 10;
         this.speechTextBox.Text = "";
         // 
         // speakButton
         // 
         this.speakButton.Enabled = false;
         this.speakButton.Location = new System.Drawing.Point(328, 24);
         this.speakButton.Name = "speakButton";
         this.speakButton.Size = new System.Drawing.Size(104, 32);
         this.speakButton.TabIndex = 9;
         this.speakButton.Text = "Speak";
         this.speakButton.Click += new System.EventHandler(this.speakButton_Click);
         // 
         // characterGroup
         // 
         this.characterGroup.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                     this.characterCombo,
                                                                                     this.locationTextBox});
         this.characterGroup.Location = new System.Drawing.Point(8, 104);
         this.characterGroup.Name = "characterGroup";
         this.characterGroup.Size = new System.Drawing.Size(440, 56);
         this.characterGroup.TabIndex = 8;
         this.characterGroup.TabStop = false;
         this.characterGroup.Text = "Charcter Name/Location";
         // 
         // characterCombo
         // 
         this.characterCombo.Enabled = false;
         this.characterCombo.Items.AddRange(new object[] {
                                                            "Genie",
                                                            "Merlin",
                                                            "Peedy",
                                                            "Robby"});
         this.characterCombo.Location = new System.Drawing.Point(304, 24);
         this.characterCombo.Name = "characterCombo";
         this.characterCombo.Size = new System.Drawing.Size(128, 21);
         this.characterCombo.TabIndex = 1;
         this.characterCombo.Text = "Select A Character";
         this.characterCombo.SelectedIndexChanged += new System.EventHandler(this.characterCombo_SelectedIndexChanged);
         // 
         // locationTextBox
         // 
         this.locationTextBox.Location = new System.Drawing.Point(16, 24);
         this.locationTextBox.Name = "locationTextBox";
         this.locationTextBox.Size = new System.Drawing.Size(272, 20);
         this.locationTextBox.TabIndex = 0;
         this.locationTextBox.Text = "C:\\WINNT\\msagent\\chars\\";
         this.locationTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.locationTextBox_KeyDown);
         // 
         // mainAgent
         // 
         this.mainAgent.Enabled = true;
         this.mainAgent.Location = new System.Drawing.Point(304, 24);
         this.mainAgent.Name = "mainAgent";
         this.mainAgent.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mainAgent.OcxState")));
         this.mainAgent.Size = new System.Drawing.Size(32, 32);
         this.mainAgent.TabIndex = 12;
         this.mainAgent.ClickEvent += new AxAgentObjects._AgentEvents_ClickEventHandler(this.mainAgent_ClickEvent);
         this.mainAgent.Command += new AxAgentObjects._AgentEvents_CommandEventHandler(this.mainAgent_Command);
         // 
         // Agent
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(448, 165);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.mainAgent,
                                                                      this.actionsCombo,
                                                                      this.speechTextBox,
                                                                      this.speakButton,
                                                                      this.characterGroup});
         this.Name = "Agent";
         this.Text = "Microsoft Agent";
         this.characterGroup.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.mainAgent)).EndInit();
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new Agent());
      }

      // KeyDown event handler for locationTextBox
      private void locationTextBox_KeyDown(
         object sender, System.Windows.Forms.KeyEventArgs e)
      {
         if ( e.KeyCode == Keys.Enter )
         {
            // set character location to text box value
            string location = locationTextBox.Text;

            // initialize the characters
            try
            {
               // load characters into agent object
               mainAgent.Characters.Load( "Genie",
                  location + "Genie.acs" );

               mainAgent.Characters.Load( "Merlin",
                  location + "Merlin.acs" );

               mainAgent.Characters.Load( "Peedy",
                  location + "Peedy.acs" );

               mainAgent.Characters.Load( "Robby",
                  location + "Robby.acs" );

               // disable TextBox for entering the location
               // and enable other controls
               locationTextBox.Enabled = false;
               speechTextBox.Enabled = true;
               speakButton.Enabled = true;
               characterCombo.Enabled = true;
               actionsCombo.Enabled = true;

               // set current character to Genie and show him
               speaker = mainAgent.Characters[ "Genie" ];

               // obtain an animation name list
               GetAnimationNames();
               speaker.Show( 0 );
            }
            catch( FileNotFoundException )
            {
               MessageBox.Show( "Invalid character location",
                  "Error", MessageBoxButtons.OK,
                  MessageBoxIcon.Error );
            }
         }
      
      } // end method locationTextBox_KeyDown

      private void speakButton_Click(
         object sender, System.EventArgs e)
      {
         // if textbox is empty, have the character ask
         // user to type the words into textbox, otherwise
         // have character say the words in textbox
         if ( speechTextBox.Text == "" )
            speaker.Speak(
               "Please, type the words you want me to speak",
               "" );
         else
            speaker.Speak( speechTextBox.Text, "" );

      } // end method speakButton_Click

      // click event for agent
      private void mainAgent_ClickEvent( object sender, 
         AxAgentObjects._AgentEvents_ClickEvent e )
      {
         speaker.Play( "Confused" );
         speaker.Speak( "Why are you poking me?", "" );
         speaker.Play( "RestPose" );
      
      } // end method mainAgent_ClickEvent

      // combobox changed event, switch active agent
      private void characterCombo_SelectedIndexChanged(
         object sender, System.EventArgs e )
      {
         ChangeCharacter( characterCombo.Text );
      
      } // end method characterCombo_SelectedIndexChanged

      private void ChangeCharacter( string name )
      {
         speaker.Hide( 0 );
         speaker = mainAgent.Characters[ name ];

         // regenerate animation name list
         GetAnimationNames();
         speaker.Show( 0 );

      } // end method ChangeCharacter

      // get animation names and store in arraylist
      private void GetAnimationNames()
      {
         // ensure thread safety
         lock( this )
         {

            // get animation names
            IEnumerator enumerator =
               mainAgent.Characters[
               speaker.Name ].AnimationNames.GetEnumerator();

            string voiceString;

            // clear actionsCombo
            actionsCombo.Items.Clear();
            speaker.Commands.RemoveAll();

            // copy enumeration to ArrayList
            while ( enumerator.MoveNext() )
            {
               //remove underscores in speech string
               voiceString = ( string )enumerator.Current;
               voiceString = 
                  voiceString.Replace( "_", "underscore" );

               actionsCombo.Items.Add( enumerator.Current );

               // add all animations as voice enabled commands
               speaker.Commands.Add( 
                  ( string )enumerator.Current,
                  enumerator.Current,
                  voiceString, true, false );
            }

            // add custom command
            speaker.Commands.Add( 
               "MoveToMouse", "MoveToMouse",
               "MoveToMouse", true, true );
         }

      } // end method GetAnimationNames

      // user selects new action
      private void actionsCombo_SelectedIndexChanged(
         object sender, System.EventArgs e )
      {
         speaker.StopAll( "Play" );
         speaker.Play( actionsCombo.Text );
         speaker.Play( "RestPose" );
      
      } // end method actionsCombo_SelectedIndexChanged

      // handles agent commands
      private void mainAgent_Command( object sender, 
         AxAgentObjects._AgentEvents_CommandEvent e )
      {
         // get UserInput object
         AgentObjects.IAgentCtlUserInput command =
            ( AgentObjects.IAgentCtlUserInput )e.userInput;

         // change character if user speaks character name
         if ( command.Voice == "Peedy" ||
            command.Voice == "Robby" ||
            command.Voice == "Merlin" ||
            command.Voice == "Genie" )
         {
            ChangeCharacter( command.Voice );

            return;
         }

         // send agent to mouse
         if ( command.Voice == "MoveToMouse" )
         {
            speaker.MoveTo( 
               Convert.ToInt16( Cursor.Position.X - 60 ),
               Convert.ToInt16( Cursor.Position.Y - 60 ), 5 );
            return;
         }

         // play new animation
         speaker.StopAll( "Play" );
         speaker.Play( command.Name );
      
      } // end method mainAgent_Command

   } // end class Agent
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