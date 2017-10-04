// Fig. 21.15: Blackjack.cs
// Blackjack game that uses the Blackjack Web service.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;   
using System.Net;

namespace Game 
{
   // game that uses Blackjack Web Service
   public class Blackjack : System.Windows.Forms.Form
   {
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.PictureBox pictureBox2;
      private System.Windows.Forms.PictureBox pictureBox3;
      private System.Windows.Forms.PictureBox pictureBox4;
      private System.Windows.Forms.PictureBox pictureBox5;
      private System.Windows.Forms.PictureBox pictureBox6;
      private System.Windows.Forms.PictureBox pictureBox7;
      private System.Windows.Forms.PictureBox pictureBox8;
      private System.Windows.Forms.PictureBox pictureBox9;
      private System.Windows.Forms.PictureBox pictureBox10;
      private System.Windows.Forms.PictureBox pictureBox11;
      private System.Windows.Forms.PictureBox pictureBox12;
      private System.Windows.Forms.PictureBox pictureBox13;
      private System.Windows.Forms.PictureBox pictureBox14;
      private System.Windows.Forms.PictureBox pictureBox15;
      private System.Windows.Forms.PictureBox pictureBox16;
      private System.Windows.Forms.PictureBox pictureBox17;
      private System.Windows.Forms.PictureBox pictureBox18;
      private System.Windows.Forms.PictureBox pictureBox19;
      private System.Windows.Forms.PictureBox pictureBox20;
      private System.Windows.Forms.PictureBox pictureBox21;
      private System.Windows.Forms.PictureBox pictureBox22;

      private System.Windows.Forms.Button dealButton;
      private System.Windows.Forms.Button hitButton;
      private System.Windows.Forms.Button stayButton;
   
      private System.ComponentModel.Container components = null;

      private localhost.BlackjackService dealer;
      private string dealersCards, playersCards;
      private ArrayList cardBoxes;
      private int playerCard, dealerCard;

      // labels displaying game status, dealer and player
      private System.Windows.Forms.Label dealerLabel;
      private System.Windows.Forms.Label playerLabel;
      private System.Windows.Forms.Label statusLabel;

      public enum GameStatus : 
         int { PUSH, LOSE, WIN, BLACKJACK };

      public Blackjack()
      {
         InitializeComponent();

         dealer = new localhost.BlackjackService();

         // allow session state
         dealer.CookieContainer = new CookieContainer();

         cardBoxes = new ArrayList();

         // put PictureBoxes into cardBoxes
         cardBoxes.Add( pictureBox1 );
         cardBoxes.Add( pictureBox2 );
         cardBoxes.Add( pictureBox3 );
         cardBoxes.Add( pictureBox4 );
         cardBoxes.Add( pictureBox5 );
         cardBoxes.Add( pictureBox6 );
         cardBoxes.Add( pictureBox7 );
         cardBoxes.Add( pictureBox8 );
         cardBoxes.Add( pictureBox9 );
         cardBoxes.Add( pictureBox10 );
         cardBoxes.Add( pictureBox11 );
         cardBoxes.Add( pictureBox12 );
         cardBoxes.Add( pictureBox13 );
         cardBoxes.Add( pictureBox14 );
         cardBoxes.Add( pictureBox15 );
         cardBoxes.Add( pictureBox16 );
         cardBoxes.Add( pictureBox17 );
         cardBoxes.Add( pictureBox18 );
         cardBoxes.Add( pictureBox19 );
         cardBoxes.Add( pictureBox20 );
         cardBoxes.Add( pictureBox21 );
         cardBoxes.Add( pictureBox22 );

      } // end method Blackjack

      #region Windows Form Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.hitButton = new System.Windows.Forms.Button();
         this.pictureBox3 = new System.Windows.Forms.PictureBox();
         this.pictureBox2 = new System.Windows.Forms.PictureBox();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.pictureBox7 = new System.Windows.Forms.PictureBox();
         this.pictureBox6 = new System.Windows.Forms.PictureBox();
         this.pictureBox5 = new System.Windows.Forms.PictureBox();
         this.pictureBox4 = new System.Windows.Forms.PictureBox();
         this.pictureBox9 = new System.Windows.Forms.PictureBox();
         this.pictureBox8 = new System.Windows.Forms.PictureBox();
         this.pictureBox12 = new System.Windows.Forms.PictureBox();
         this.pictureBox13 = new System.Windows.Forms.PictureBox();
         this.pictureBox10 = new System.Windows.Forms.PictureBox();
         this.pictureBox11 = new System.Windows.Forms.PictureBox();
         this.pictureBox16 = new System.Windows.Forms.PictureBox();
         this.pictureBox17 = new System.Windows.Forms.PictureBox();
         this.pictureBox14 = new System.Windows.Forms.PictureBox();
         this.pictureBox15 = new System.Windows.Forms.PictureBox();
         this.dealButton = new System.Windows.Forms.Button();
         this.pictureBox18 = new System.Windows.Forms.PictureBox();
         this.pictureBox19 = new System.Windows.Forms.PictureBox();
         this.pictureBox21 = new System.Windows.Forms.PictureBox();
         this.pictureBox20 = new System.Windows.Forms.PictureBox();
         this.pictureBox22 = new System.Windows.Forms.PictureBox();
         this.stayButton = new System.Windows.Forms.Button();
         this.statusLabel = new System.Windows.Forms.Label();
         this.dealerLabel = new System.Windows.Forms.Label();
         this.playerLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // hitButton
         // 
         this.hitButton.BackColor = System.Drawing.Color.Green;
         this.hitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.hitButton.ForeColor = System.Drawing.Color.White;
         this.hitButton.Location = new System.Drawing.Point(560, 112);
         this.hitButton.Name = "hitButton";
         this.hitButton.Size = new System.Drawing.Size(112, 56);
         this.hitButton.TabIndex = 2;
         this.hitButton.Text = "Hit";
         this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
         // 
         // pictureBox3
         // 
         this.pictureBox3.BackColor = System.Drawing.Color.Green;
         this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox3.Location = new System.Drawing.Point(192, 56);
         this.pictureBox3.Name = "pictureBox3";
         this.pictureBox3.Size = new System.Drawing.Size(70, 90);
         this.pictureBox3.TabIndex = 0;
         this.pictureBox3.TabStop = false;
         // 
         // pictureBox2
         // 
         this.pictureBox2.BackColor = System.Drawing.Color.Green;
         this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox2.Location = new System.Drawing.Point(104, 56);
         this.pictureBox2.Name = "pictureBox2";
         this.pictureBox2.Size = new System.Drawing.Size(70, 90);
         this.pictureBox2.TabIndex = 0;
         this.pictureBox2.TabStop = false;
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackColor = System.Drawing.Color.Green;
         this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox1.Location = new System.Drawing.Point(16, 56);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(70, 90);
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // pictureBox7
         // 
         this.pictureBox7.BackColor = System.Drawing.Color.Green;
         this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox7.Location = new System.Drawing.Point(104, 168);
         this.pictureBox7.Name = "pictureBox7";
         this.pictureBox7.Size = new System.Drawing.Size(70, 90);
         this.pictureBox7.TabIndex = 0;
         this.pictureBox7.TabStop = false;
         // 
         // pictureBox6
         // 
         this.pictureBox6.BackColor = System.Drawing.Color.Green;
         this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox6.Location = new System.Drawing.Point(456, 56);
         this.pictureBox6.Name = "pictureBox6";
         this.pictureBox6.Size = new System.Drawing.Size(70, 90);
         this.pictureBox6.TabIndex = 0;
         this.pictureBox6.TabStop = false;
         // 
         // pictureBox5
         // 
         this.pictureBox5.BackColor = System.Drawing.Color.Green;
         this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox5.Location = new System.Drawing.Point(368, 56);
         this.pictureBox5.Name = "pictureBox5";
         this.pictureBox5.Size = new System.Drawing.Size(70, 90);
         this.pictureBox5.TabIndex = 0;
         this.pictureBox5.TabStop = false;
         // 
         // pictureBox4
         // 
         this.pictureBox4.BackColor = System.Drawing.Color.Green;
         this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox4.Location = new System.Drawing.Point(280, 56);
         this.pictureBox4.Name = "pictureBox4";
         this.pictureBox4.Size = new System.Drawing.Size(70, 90);
         this.pictureBox4.TabIndex = 0;
         this.pictureBox4.TabStop = false;
         // 
         // pictureBox9
         // 
         this.pictureBox9.BackColor = System.Drawing.Color.Green;
         this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox9.Location = new System.Drawing.Point(192, 168);
         this.pictureBox9.Name = "pictureBox9";
         this.pictureBox9.Size = new System.Drawing.Size(70, 90);
         this.pictureBox9.TabIndex = 0;
         this.pictureBox9.TabStop = false;
         // 
         // pictureBox8
         // 
         this.pictureBox8.BackColor = System.Drawing.Color.Green;
         this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox8.Location = new System.Drawing.Point(16, 168);
         this.pictureBox8.Name = "pictureBox8";
         this.pictureBox8.Size = new System.Drawing.Size(70, 90);
         this.pictureBox8.TabIndex = 0;
         this.pictureBox8.TabStop = false;
         // 
         // pictureBox12
         // 
         this.pictureBox12.BackColor = System.Drawing.Color.Green;
         this.pictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox12.Location = new System.Drawing.Point(16, 336);
         this.pictureBox12.Name = "pictureBox12";
         this.pictureBox12.Size = new System.Drawing.Size(70, 90);
         this.pictureBox12.TabIndex = 0;
         this.pictureBox12.TabStop = false;
         // 
         // pictureBox13
         // 
         this.pictureBox13.BackColor = System.Drawing.Color.Green;
         this.pictureBox13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox13.Location = new System.Drawing.Point(104, 336);
         this.pictureBox13.Name = "pictureBox13";
         this.pictureBox13.Size = new System.Drawing.Size(70, 90);
         this.pictureBox13.TabIndex = 0;
         this.pictureBox13.TabStop = false;
         // 
         // pictureBox10
         // 
         this.pictureBox10.BackColor = System.Drawing.Color.Green;
         this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox10.Location = new System.Drawing.Point(280, 168);
         this.pictureBox10.Name = "pictureBox10";
         this.pictureBox10.Size = new System.Drawing.Size(70, 90);
         this.pictureBox10.TabIndex = 0;
         this.pictureBox10.TabStop = false;
         // 
         // pictureBox11
         // 
         this.pictureBox11.BackColor = System.Drawing.Color.Green;
         this.pictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox11.Location = new System.Drawing.Point(368, 168);
         this.pictureBox11.Name = "pictureBox11";
         this.pictureBox11.Size = new System.Drawing.Size(70, 90);
         this.pictureBox11.TabIndex = 0;
         this.pictureBox11.TabStop = false;
         // 
         // pictureBox16
         // 
         this.pictureBox16.BackColor = System.Drawing.Color.Green;
         this.pictureBox16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox16.Location = new System.Drawing.Point(368, 336);
         this.pictureBox16.Name = "pictureBox16";
         this.pictureBox16.Size = new System.Drawing.Size(70, 90);
         this.pictureBox16.TabIndex = 0;
         this.pictureBox16.TabStop = false;
         // 
         // pictureBox17
         // 
         this.pictureBox17.BackColor = System.Drawing.Color.Green;
         this.pictureBox17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox17.Location = new System.Drawing.Point(16, 448);
         this.pictureBox17.Name = "pictureBox17";
         this.pictureBox17.Size = new System.Drawing.Size(70, 90);
         this.pictureBox17.TabIndex = 0;
         this.pictureBox17.TabStop = false;
         // 
         // pictureBox14
         // 
         this.pictureBox14.BackColor = System.Drawing.Color.Green;
         this.pictureBox14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox14.Location = new System.Drawing.Point(192, 336);
         this.pictureBox14.Name = "pictureBox14";
         this.pictureBox14.Size = new System.Drawing.Size(70, 90);
         this.pictureBox14.TabIndex = 0;
         this.pictureBox14.TabStop = false;
         // 
         // pictureBox15
         // 
         this.pictureBox15.BackColor = System.Drawing.Color.Green;
         this.pictureBox15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox15.Location = new System.Drawing.Point(280, 336);
         this.pictureBox15.Name = "pictureBox15";
         this.pictureBox15.Size = new System.Drawing.Size(70, 90);
         this.pictureBox15.TabIndex = 0;
         this.pictureBox15.TabStop = false;
         // 
         // dealButton
         // 
         this.dealButton.BackColor = System.Drawing.Color.Green;
         this.dealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.dealButton.ForeColor = System.Drawing.Color.White;
         this.dealButton.Location = new System.Drawing.Point(560, 40);
         this.dealButton.Name = "dealButton";
         this.dealButton.Size = new System.Drawing.Size(112, 56);
         this.dealButton.TabIndex = 1;
         this.dealButton.Text = "Deal";
         this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
         // 
         // pictureBox18
         // 
         this.pictureBox18.BackColor = System.Drawing.Color.Green;
         this.pictureBox18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox18.Location = new System.Drawing.Point(104, 448);
         this.pictureBox18.Name = "pictureBox18";
         this.pictureBox18.Size = new System.Drawing.Size(70, 90);
         this.pictureBox18.TabIndex = 0;
         this.pictureBox18.TabStop = false;
         // 
         // pictureBox19
         // 
         this.pictureBox19.BackColor = System.Drawing.Color.Green;
         this.pictureBox19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox19.Location = new System.Drawing.Point(192, 448);
         this.pictureBox19.Name = "pictureBox19";
         this.pictureBox19.Size = new System.Drawing.Size(70, 90);
         this.pictureBox19.TabIndex = 0;
         this.pictureBox19.TabStop = false;
         // 
         // pictureBox21
         // 
         this.pictureBox21.BackColor = System.Drawing.Color.Green;
         this.pictureBox21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox21.Location = new System.Drawing.Point(368, 448);
         this.pictureBox21.Name = "pictureBox21";
         this.pictureBox21.Size = new System.Drawing.Size(70, 90);
         this.pictureBox21.TabIndex = 0;
         this.pictureBox21.TabStop = false;
         // 
         // pictureBox20
         // 
         this.pictureBox20.BackColor = System.Drawing.Color.Green;
         this.pictureBox20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox20.Location = new System.Drawing.Point(280, 448);
         this.pictureBox20.Name = "pictureBox20";
         this.pictureBox20.Size = new System.Drawing.Size(70, 90);
         this.pictureBox20.TabIndex = 0;
         this.pictureBox20.TabStop = false;
         // 
         // pictureBox22
         // 
         this.pictureBox22.BackColor = System.Drawing.Color.Green;
         this.pictureBox22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox22.Location = new System.Drawing.Point(456, 448);
         this.pictureBox22.Name = "pictureBox22";
         this.pictureBox22.Size = new System.Drawing.Size(70, 90);
         this.pictureBox22.TabIndex = 0;
         this.pictureBox22.TabStop = false;
         // 
         // stayButton
         // 
         this.stayButton.BackColor = System.Drawing.Color.Green;
         this.stayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.stayButton.ForeColor = System.Drawing.Color.White;
         this.stayButton.Location = new System.Drawing.Point(560, 184);
         this.stayButton.Name = "stayButton";
         this.stayButton.Size = new System.Drawing.Size(112, 56);
         this.stayButton.TabIndex = 3;
         this.stayButton.Text = "Stay";
         this.stayButton.Click += new System.EventHandler(this.stayButton_Click);
         // 
         // statusLabel
         // 
         this.statusLabel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.statusLabel.ForeColor = System.Drawing.Color.Red;
         this.statusLabel.Location = new System.Drawing.Point(528, 280);
         this.statusLabel.Name = "statusLabel";
         this.statusLabel.Size = new System.Drawing.Size(160, 72);
         this.statusLabel.TabIndex = 4;
         // 
         // dealerLabel
         // 
         this.dealerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.dealerLabel.ForeColor = System.Drawing.Color.White;
         this.dealerLabel.Location = new System.Drawing.Point(16, 16);
         this.dealerLabel.Name = "dealerLabel";
         this.dealerLabel.Size = new System.Drawing.Size(184, 32);
         this.dealerLabel.TabIndex = 5;
         this.dealerLabel.Text = "Dealer\'s Cards";
         // 
         // playerLabel
         // 
         this.playerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.playerLabel.ForeColor = System.Drawing.Color.White;
         this.playerLabel.Location = new System.Drawing.Point(16, 296);
         this.playerLabel.Name = "playerLabel";
         this.playerLabel.Size = new System.Drawing.Size(184, 32);
         this.playerLabel.TabIndex = 6;
         this.playerLabel.Text = "Player\'s Cards";
         // 
         // Blackjack
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.BackColor = System.Drawing.Color.Green;
         this.ClientSize = new System.Drawing.Size(704, 557);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.playerLabel,
                                                                      this.dealerLabel,
                                                                      this.statusLabel,
                                                                      this.stayButton,
                                                                      this.hitButton,
                                                                      this.dealButton,
                                                                      this.pictureBox12,
                                                                      this.pictureBox13,
                                                                      this.pictureBox14,
                                                                      this.pictureBox15,
                                                                      this.pictureBox16,
                                                                      this.pictureBox17,
                                                                      this.pictureBox18,
                                                                      this.pictureBox19,
                                                                      this.pictureBox20,
                                                                      this.pictureBox21,
                                                                      this.pictureBox22,
                                                                      this.pictureBox7,
                                                                      this.pictureBox8,
                                                                      this.pictureBox9,
                                                                      this.pictureBox10,
                                                                      this.pictureBox11,
                                                                      this.pictureBox5,
                                                                      this.pictureBox6,
                                                                      this.pictureBox3,
                                                                      this.pictureBox4,
                                                                      this.pictureBox2,
                                                                      this.pictureBox1});
         this.Name = "Blackjack";
         this.Text = "Blackjack";
         this.ResumeLayout(false);

      }
		   #endregion

      [STAThread]
      static void Main() 
      {
         Application.Run( new Blackjack() );

      } // end Main

      // deals cards to dealer while dealer's total is 
      // less than 17, then computes value of each hand 
      // and determines winner
      protected void stayButton_Click( 
         object sender, System.EventArgs e )
      {
         stayButton.Enabled = false;
         hitButton.Enabled = false;
         dealButton.Enabled = true;
         DealerPlay();
      }

      // process dealers turn
      private void DealerPlay()
      {
         // while value of dealer's hand is below 17,
         // dealer must take cards
         while ( dealer.CountCards( dealersCards ) < 17 )
         {
            dealersCards += "\t" + dealer.DealCard();
            DisplayCard( dealerCard, "" );
            dealerCard++;
            MessageBox.Show( "Dealer takes a card" );
         }      

         int dealersTotal = dealer.CountCards( dealersCards );
         int playersTotal = dealer.CountCards( playersCards );

         // if dealer busted, player wins
         if ( dealersTotal > 21 )
         {         
            GameOver( GameStatus.WIN );
            return;
         }

         // if dealer and player have not exceeded 21,
         // higher score wins; equal scores is a push.
         if ( dealersTotal > playersTotal )
            GameOver( GameStatus.LOSE );
         else if ( playersTotal > dealersTotal )
            GameOver( GameStatus.WIN );
         else
            GameOver( GameStatus.PUSH );

      } // end method DealerPlay

      // deal another card to player
      protected void hitButton_Click( 
         object sender, System.EventArgs e )
      {
         // get player another card
         string card = dealer.DealCard();
         playersCards += "\t" + card;
         DisplayCard( playerCard, card );
         playerCard++;

         int total = dealer.CountCards( playersCards );

         // if player exceeds 21, house wins
         if ( total > 21 )
            GameOver( GameStatus.LOSE );

         // if player has 21, they cannot take more cards
         // the dealer plays
         if ( total == 21 ) 
         {
            hitButton.Enabled = false;
            DealerPlay();
         }

      } // end method hitButton_Click

      // deal two cards each to dealer and player
      protected void dealButton_Click( 
         object sender, System.EventArgs e )
      {
         string card;

         // clear card images
         foreach ( PictureBox cardImage in cardBoxes )
            cardImage.Image = null;

         // clear status from previous game
         statusLabel.Text = "";

         // shuffle cards
         dealer.Shuffle();

         // deal two cards to player
         playersCards = dealer.DealCard();
         DisplayCard( 11, playersCards );
         card = dealer.DealCard();
         DisplayCard( 12, card );      
         playersCards += "\t" + card;

         // deal two cards to dealer, only display face
         // of first card
         dealersCards = dealer.DealCard() ;
         DisplayCard( 0, dealersCards );
         card = dealer.DealCard();
         DisplayCard( 1, "" );
         dealersCards += "\t" + card;

         stayButton.Enabled = true;
         hitButton.Enabled = true;
         dealButton.Enabled = false;

         int dealersTotal = dealer.CountCards( dealersCards );
         int playersTotal = dealer.CountCards( playersCards );

         // if hands equal 21, it is a push
         if ( dealersTotal == playersTotal && 
            dealersTotal == 21 )
            GameOver( GameStatus.PUSH );

         // if player has 21 player wins with blackjack
         else if ( playersTotal == 21 )
            GameOver( GameStatus.BLACKJACK );

         // if dealer has 21, dealer wins
         else if ( dealersTotal == 21 )
            GameOver( GameStatus.LOSE );

         dealerCard = 2;
         playerCard = 13; 

      } // end method dealButton_Click

      // displays card represented by cardValue in
      // PictureBox with number card
      public void DisplayCard( int card, string cardValue )
      {
         // retrieve appropriate PictureBox from ArrayList
         PictureBox displayBox = ( PictureBox ) cardBoxes[ card ];

         // if string representing card is empty,
         // set displayBox to display back of card
         if ( cardValue == "" )
         {         
            displayBox.Image = 
               Image.FromFile( "blackjack_images\\cardback.png" );
            return;
         }

         // retrieve face value of card from cardValue
         int faceNumber = Int32.Parse( cardValue.Substring( 0,
            cardValue.IndexOf( " " ) ) );

         string face = faceNumber.ToString();

         // retrieve the suit of the card from cardValue
         string suit = cardValue.Substring( 
            cardValue.IndexOf( " " ) + 1 );      

         char suitLetter;

         // determine if suit is other than clubs
         switch ( Convert.ToInt32( suit ) )
         {
            // suit is clubs
            case 0:
               suitLetter = 'c';
               break;
        
            // suit is diamonds
            case 1: 
               suitLetter = 'd';
               break;

            // suit is hearts
            case 2: 
               suitLetter = 'h';
               break;

            // else suit is spades
            default: 
               suitLetter = 's';
               break;
         }

         // set displayBox to display appropriate image
         displayBox.Image = Image.FromFile( 
            "blackjack_images\\" + face + suitLetter + ".png"  );

      } // end method DisplayCard

      // displays all player cards and shows 
      // appropriate game status message
      public void GameOver( GameStatus winner )
      {
         char[] tab = { '\t' };      
         string[] cards = dealersCards.Split( tab );

         for ( int i = 0; i < cards.Length; i++ )
            DisplayCard(  i, cards[ i ] );

         // push
         if ( winner == GameStatus.PUSH )
            statusLabel.Text = "It's a tie!";

         // player loses
         else if ( winner == GameStatus.LOSE )
            statusLabel.Text = "You Lose Try Again!";

         // player wins
         else if ( winner == GameStatus.WIN )
            statusLabel.Text = "You Win!";

         // player has won with blackjack
         else
            statusLabel.Text = "BlackJack!";

         stayButton.Enabled = false;
         hitButton.Enabled = false;
         dealButton.Enabled = true;

      } // end method GameOver

   } // end class Blackjack
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
