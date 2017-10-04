// Fig. 6.12: CrapsGame.cs
// Simulating the game of Craps.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace CrapsGame
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class CrapsGame : System.Windows.Forms.Form
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      private System.Windows.Forms.Button rollButton;
      private System.Windows.Forms.Button playButton;

      int myPoint; // player's point value
      int myDie1;
      private System.Windows.Forms.PictureBox pointFirstDieImage;
      private System.Windows.Forms.Label statusLabel;
      private System.Windows.Forms.PictureBox firstDieImage;
      private System.Windows.Forms.PictureBox pointSecondDieImage;
      private System.Windows.Forms.PictureBox secondDieImage;
      private System.Windows.Forms.GroupBox pointGroupBox;  // value of first die
      int myDie2;  // value of second die

      // 
      public enum DiceNames
      {
         SNAKE_EYES = 2,
         TREY = 3,
         YO_LEVEN = 11,
         BOX_CARS = 12,
      }

      public CrapsGame()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();

         //
         // TODO: Add any constructor code after InitializeComponent call
         //
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
         this.pointFirstDieImage = new System.Windows.Forms.PictureBox();
         this.statusLabel = new System.Windows.Forms.Label();
         this.firstDieImage = new System.Windows.Forms.PictureBox();
         this.pointSecondDieImage = new System.Windows.Forms.PictureBox();
         this.secondDieImage = new System.Windows.Forms.PictureBox();
         this.pointGroupBox = new System.Windows.Forms.GroupBox();
         this.playButton = new System.Windows.Forms.Button();
         this.rollButton = new System.Windows.Forms.Button();
         this.pointGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // pointFirstDieImage
         // 
         this.pointFirstDieImage.Location = new System.Drawing.Point(16, 40);
         this.pointFirstDieImage.Name = "pointFirstDieImage";
         this.pointFirstDieImage.Size = new System.Drawing.Size(88, 72);
         this.pointFirstDieImage.TabIndex = 1;
         this.pointFirstDieImage.TabStop = false;
         // 
         // statusLabel
         // 
         this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.statusLabel.Location = new System.Drawing.Point(232, 160);
         this.statusLabel.Name = "statusLabel";
         this.statusLabel.Size = new System.Drawing.Size(88, 72);
         this.statusLabel.TabIndex = 3;
         // 
         // firstDieImage
         // 
         this.firstDieImage.Location = new System.Drawing.Point(24, 160);
         this.firstDieImage.Name = "firstDieImage";
         this.firstDieImage.Size = new System.Drawing.Size(88, 72);
         this.firstDieImage.TabIndex = 4;
         this.firstDieImage.TabStop = false;
         // 
         // pointSecondDieImage
         // 
         this.pointSecondDieImage.Location = new System.Drawing.Point(120, 40);
         this.pointSecondDieImage.Name = "pointSecondDieImage";
         this.pointSecondDieImage.Size = new System.Drawing.Size(88, 72);
         this.pointSecondDieImage.TabIndex = 6;
         this.pointSecondDieImage.TabStop = false;
         // 
         // secondDieImage
         // 
         this.secondDieImage.Location = new System.Drawing.Point(128, 160);
         this.secondDieImage.Name = "secondDieImage";
         this.secondDieImage.Size = new System.Drawing.Size(88, 72);
         this.secondDieImage.TabIndex = 5;
         this.secondDieImage.TabStop = false;
         // 
         // pointGroupBox
         // 
         this.pointGroupBox.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                    this.pointSecondDieImage,
                                                                                    this.pointFirstDieImage});
         this.pointGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.pointGroupBox.Location = new System.Drawing.Point(8, 16);
         this.pointGroupBox.Name = "pointGroupBox";
         this.pointGroupBox.Size = new System.Drawing.Size(224, 128);
         this.pointGroupBox.TabIndex = 0;
         this.pointGroupBox.TabStop = false;
         this.pointGroupBox.Text = "Point";
         // 
         // playButton
         // 
         this.playButton.Location = new System.Drawing.Point(240, 32);
         this.playButton.Name = "playButton";
         this.playButton.Size = new System.Drawing.Size(80, 40);
         this.playButton.TabIndex = 1;
         this.playButton.Text = "Play";
         this.playButton.Click += new System.EventHandler(this.playButton_Click);
         // 
         // rollButton
         // 
         this.rollButton.Enabled = false;
         this.rollButton.Location = new System.Drawing.Point(240, 96);
         this.rollButton.Name = "rollButton";
         this.rollButton.Size = new System.Drawing.Size(80, 40);
         this.rollButton.TabIndex = 2;
         this.rollButton.Text = "Roll";
         this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
         // 
         // CrapsGame
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(328, 245);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.secondDieImage,
                                                                      this.firstDieImage,
                                                                      this.statusLabel,
                                                                      this.rollButton,
                                                                      this.playButton,
                                                                      this.pointGroupBox});
         this.Name = "CrapsGame";
         this.Text = "CrapsGame";
         this.pointGroupBox.ResumeLayout(false);
         this.ResumeLayout(false);

      }
		#endregion

      // simulate next roll and result of that roll
      protected void rollButton_Click( 
         object sender, System.EventArgs e )
      {
         int sum = RollDice();

         if ( sum == myPoint )
         {
            statusLabel.Text = "You Win!!!";
            rollButton.Enabled = false;
            playButton.Enabled = true;
         }
         else
            if ( sum == 7 )
         {
            statusLabel.Text = "Sorry. You lose.";
            rollButton.Enabled = false;
            playButton.Enabled = true;
         }

      } // end rollButton_Click

      // simulate first roll and result of that roll
      protected void playButton_Click( 
         object sender, System.EventArgs e )
      {   
         pointGroupBox.Text = "Point";
         statusLabel.Text = "";
         pointFirstDieImage.Image = null;
         pointSecondDieImage.Image = null;

         myPoint = 0;
         int sum = RollDice();

         switch ( sum )
         {
            case 7:
            case ( int ) DiceNames.YO_LEVEN:   
               rollButton.Enabled = false;  // disable Roll button
               statusLabel.Text = "You Win!!!";
               break;

            case ( int ) DiceNames.SNAKE_EYES:
            case ( int ) DiceNames.TREY:
            case ( int ) DiceNames.BOX_CARS:
               rollButton.Enabled = false;      
               statusLabel.Text = "Sorry. You lose.";
               break;

            default:
               myPoint = sum;
               pointGroupBox.Text = "Point is " + sum;
               statusLabel.Text = "Roll Again";
               DisplayDie( pointFirstDieImage, myDie1 );
               DisplayDie( pointSecondDieImage, myDie2 );
               playButton.Enabled = false;
               rollButton.Enabled = true;
               break;

         } // end switch

      } // end playButton_Click

      // display an image for the specified face
      private void DisplayDie( PictureBox dieImage, int face )
      {
         dieImage.Image = Image.FromFile( 
            Directory.GetCurrentDirectory() + 
            "\\images\\die" + face + ".gif" );
      }

      // simulates rolling two dice
      private int RollDice()
      {
         int die1, die2, dieSum;
         Random randomNumber = new Random();

         die1 = randomNumber.Next( 1, 7 );
         die2 = randomNumber.Next( 1, 7 );

         DisplayDie( firstDieImage, die1 );
         DisplayDie( secondDieImage, die2 );

         myDie1 = die1;
         myDie2 = die2;
         dieSum = die1 + die2;
         return dieSum;

      } // end method RollDice

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new CrapsGame());
      }

   } // end of class CrapsGame

} // end of namespace CrapsGameSpace

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
