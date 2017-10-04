// Fig. 6.11: RollDie2.cs
// Rolling 12 dice with frequency chart.   
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace csphtp1.ch06.fig06_10
{
   /// <summary>
   /// displays the different dice and frequency information
   /// </summary>
   public class RollDie2 : System.Windows.Forms.Form
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      private System.Windows.Forms.Button rollButton;

      private System.Windows.Forms.RichTextBox displayTextBox;

      private System.Windows.Forms.Label dieLabel1;
      private System.Windows.Forms.Label dieLabel2;
      private System.Windows.Forms.Label dieLabel3;
      private System.Windows.Forms.Label dieLabel4;
      private System.Windows.Forms.Label dieLabel5;
      private System.Windows.Forms.Label dieLabel6;
      private System.Windows.Forms.Label dieLabel7;
      private System.Windows.Forms.Label dieLabel8;
      private System.Windows.Forms.Label dieLabel9;
      private System.Windows.Forms.Label dieLabel10;
      private System.Windows.Forms.Label dieLabel11;
      private System.Windows.Forms.Label dieLabel12;

      private Random randomNumber = new Random();

      private int ones, twos, threes, fours, fives, sixes;
  
      public RollDie2()
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
         this.dieLabel10 = new System.Windows.Forms.Label();
         this.dieLabel4 = new System.Windows.Forms.Label();
         this.dieLabel5 = new System.Windows.Forms.Label();
         this.dieLabel6 = new System.Windows.Forms.Label();
         this.dieLabel7 = new System.Windows.Forms.Label();
         this.dieLabel1 = new System.Windows.Forms.Label();
         this.dieLabel2 = new System.Windows.Forms.Label();
         this.dieLabel3 = new System.Windows.Forms.Label();
         this.displayTextBox = new System.Windows.Forms.RichTextBox();
         this.dieLabel8 = new System.Windows.Forms.Label();
         this.dieLabel9 = new System.Windows.Forms.Label();
         this.rollButton = new System.Windows.Forms.Button();
         this.dieLabel12 = new System.Windows.Forms.Label();
         this.dieLabel11 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // dieLabel10
         // 
         this.dieLabel10.Location = new System.Drawing.Point(200, 72);
         this.dieLabel10.Name = "dieLabel10";
         this.dieLabel10.Size = new System.Drawing.Size(56, 48);
         this.dieLabel10.TabIndex = 2;
         // 
         // dieLabel4
         // 
         this.dieLabel4.Location = new System.Drawing.Point(200, 16);
         this.dieLabel4.Name = "dieLabel4";
         this.dieLabel4.Size = new System.Drawing.Size(56, 48);
         this.dieLabel4.TabIndex = 2;
         // 
         // dieLabel5
         // 
         this.dieLabel5.Location = new System.Drawing.Point(264, 16);
         this.dieLabel5.Name = "dieLabel5";
         this.dieLabel5.Size = new System.Drawing.Size(56, 48);
         this.dieLabel5.TabIndex = 2;
         // 
         // dieLabel6
         // 
         this.dieLabel6.Location = new System.Drawing.Point(328, 16);
         this.dieLabel6.Name = "dieLabel6";
         this.dieLabel6.Size = new System.Drawing.Size(56, 48);
         this.dieLabel6.TabIndex = 2;
         // 
         // dieLabel7
         // 
         this.dieLabel7.Location = new System.Drawing.Point(8, 72);
         this.dieLabel7.Name = "dieLabel7";
         this.dieLabel7.Size = new System.Drawing.Size(56, 48);
         this.dieLabel7.TabIndex = 2;
         // 
         // dieLabel1
         // 
         this.dieLabel1.Location = new System.Drawing.Point(8, 16);
         this.dieLabel1.Name = "dieLabel1";
         this.dieLabel1.Size = new System.Drawing.Size(56, 48);
         this.dieLabel1.TabIndex = 2;
         // 
         // dieLabel2
         // 
         this.dieLabel2.Location = new System.Drawing.Point(72, 16);
         this.dieLabel2.Name = "dieLabel2";
         this.dieLabel2.Size = new System.Drawing.Size(56, 48);
         this.dieLabel2.TabIndex = 2;
         // 
         // dieLabel3
         // 
         this.dieLabel3.Location = new System.Drawing.Point(136, 16);
         this.dieLabel3.Name = "dieLabel3";
         this.dieLabel3.Size = new System.Drawing.Size(56, 48);
         this.dieLabel3.TabIndex = 2;
         // 
         // displayTextBox
         // 
         this.displayTextBox.Location = new System.Drawing.Point(8, 160);
         this.displayTextBox.Name = "displayTextBox";
         this.displayTextBox.Size = new System.Drawing.Size(376, 96);
         this.displayTextBox.TabIndex = 0;
         this.displayTextBox.Text = "";
         // 
         // dieLabel8
         // 
         this.dieLabel8.Location = new System.Drawing.Point(72, 72);
         this.dieLabel8.Name = "dieLabel8";
         this.dieLabel8.Size = new System.Drawing.Size(56, 48);
         this.dieLabel8.TabIndex = 2;
         // 
         // dieLabel9
         // 
         this.dieLabel9.Location = new System.Drawing.Point(136, 72);
         this.dieLabel9.Name = "dieLabel9";
         this.dieLabel9.Size = new System.Drawing.Size(56, 48);
         this.dieLabel9.TabIndex = 2;
         // 
         // rollButton
         // 
         this.rollButton.Location = new System.Drawing.Point(132, 128);
         this.rollButton.Name = "rollButton";
         this.rollButton.Size = new System.Drawing.Size(128, 24);
         this.rollButton.TabIndex = 1;
         this.rollButton.Text = "Roll";
         this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
         // 
         // dieLabel12
         // 
         this.dieLabel12.Location = new System.Drawing.Point(328, 72);
         this.dieLabel12.Name = "dieLabel12";
         this.dieLabel12.Size = new System.Drawing.Size(56, 48);
         this.dieLabel12.TabIndex = 2;
         // 
         // dieLabel11
         // 
         this.dieLabel11.Location = new System.Drawing.Point(264, 72);
         this.dieLabel11.Name = "dieLabel11";
         this.dieLabel11.Size = new System.Drawing.Size(56, 48);
         this.dieLabel11.TabIndex = 2;
         // 
         // RollDie2
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(392, 261);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.dieLabel11,
                                                                      this.dieLabel10,
                                                                      this.dieLabel12,
                                                                      this.dieLabel9,
                                                                      this.dieLabel7,
                                                                      this.dieLabel6,
                                                                      this.dieLabel8,
                                                                      this.dieLabel5,
                                                                      this.dieLabel4,
                                                                      this.dieLabel3,
                                                                      this.dieLabel2,
                                                                      this.dieLabel1,
                                                                      this.rollButton,
                                                                      this.displayTextBox});
         this.Name = "RollDie2";
         this.Text = "RollDie";
         this.ResumeLayout(false);

      } // end of method InitializeComponent

      #endregion
         
      // simulates roll by calling DisplayDie for
      // each label and displaying the results
      protected void rollButton_Click( 
         object sender, System.EventArgs e )
      {
         // pass the labels to a method that will
         // randomly assign a face to each die
         DisplayDie( dieLabel1 );
         DisplayDie( dieLabel2 );
         DisplayDie( dieLabel3 );
         DisplayDie( dieLabel4 );
         DisplayDie( dieLabel5 );
         DisplayDie( dieLabel6 );
         DisplayDie( dieLabel7 );
         DisplayDie( dieLabel8 );
         DisplayDie( dieLabel9 );
         DisplayDie( dieLabel10 );
         DisplayDie( dieLabel11 );
         DisplayDie( dieLabel12 );

         double total = ones + twos + threes + fours + fives + sixes;      

         // display the current frequency values
         displayTextBox.Text = "Face\t\tFrequency\tPercent\n1\t\t" + 
            ones + "\t\t" +
            String.Format( "{0:F2}", ones / total * 100 ) +
            "%\n2\t\t" + twos + "\t\t" + 
            String.Format( "{0:F2}", twos / total * 100 ) + 
            "%\n3\t\t" + threes + "\t\t" + 
            String.Format( "{0:F2}", threes / total * 100 ) + 
            "%\n4\t\t" + fours + "\t\t" + 
            String.Format( "{0:F2}", fours / total * 100 ) +
            "%\n5\t\t" + fives + "\t\t" + 
            String.Format( "{0:F2}", fives / total * 100 ) +
            "%\n6\t\t" + sixes + "\t\t" + 
            String.Format( "{0:F2}", sixes / total * 100 ) + "%";

      } // end rollButton_Click

      // display the current die, and modify frequency values
      public void DisplayDie( Label dieLabel )
      {
         int face = randomNumber.Next( 1, 7 );
      
         dieLabel.Image = Image.FromFile( 
            Directory.GetCurrentDirectory() + 
            "\\images\\die" + face +".gif" );

         // add one to frequency of current face
         switch ( face )
         {
            case 1: 
               ones++;
               break;
        
            case 2: 
               twos++;
               break;
        
            case 3: 
               threes++;
               break;
        
            case 4: 
               fours++;
               break;
        
            case 5: 
               fives++;
               break;
        
            case 6: 
               sixes++;
               break;

         } // end switch

      } // end DisplayDie
       
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new RollDie2() );
      } 

   } // end of class RollDie2

} // end of namespace csphtp1.ch06.fig06_10

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

