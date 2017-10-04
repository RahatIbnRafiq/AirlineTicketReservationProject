// Fig. 6.10: RollDie.cs
// Using random number generation to simulate dice rolling.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;   // enables reading data from files

namespace csphtp1.ch06.fig06_09
{
   /// <summary>
   /// form simulates the rolling of 12 dice,
   /// and displays them
   /// </summary>
   public class RollDie : System.Windows.Forms.Form
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      private System.Windows.Forms.Button rollButton;

      private System.Windows.Forms.Label dieLabel2;
      private System.Windows.Forms.Label dieLabel1;
      private System.Windows.Forms.Label dieLabel3;
      private System.Windows.Forms.Label dieLabel4;

      private Random randomNumber = new Random();

      public RollDie()
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
         this.dieLabel3 = new System.Windows.Forms.Label();
         this.dieLabel4 = new System.Windows.Forms.Label();
         this.dieLabel1 = new System.Windows.Forms.Label();
         this.dieLabel2 = new System.Windows.Forms.Label();
         this.rollButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // dieLabel3
         // 
         this.dieLabel3.Location = new System.Drawing.Point(15, 104);
         this.dieLabel3.Name = "dieLabel3";
         this.dieLabel3.Size = new System.Drawing.Size(72, 64);
         this.dieLabel3.TabIndex = 4;
         // 
         // dieLabel4
         // 
         this.dieLabel4.Location = new System.Drawing.Point(111, 104);
         this.dieLabel4.Name = "dieLabel4";
         this.dieLabel4.Size = new System.Drawing.Size(72, 64);
         this.dieLabel4.TabIndex = 5;
         // 
         // dieLabel1
         // 
         this.dieLabel1.Location = new System.Drawing.Point(15, 16);
         this.dieLabel1.Name = "dieLabel1";
         this.dieLabel1.Size = new System.Drawing.Size(72, 64);
         this.dieLabel1.TabIndex = 0;
         // 
         // dieLabel2
         // 
         this.dieLabel2.Location = new System.Drawing.Point(111, 16);
         this.dieLabel2.Name = "dieLabel2";
         this.dieLabel2.Size = new System.Drawing.Size(72, 64);
         this.dieLabel2.TabIndex = 1;
         // 
         // rollButton
         // 
         this.rollButton.Location = new System.Drawing.Point(39, 182);
         this.rollButton.Name = "rollButton";
         this.rollButton.Size = new System.Drawing.Size(120, 48);
         this.rollButton.TabIndex = 12;
         this.rollButton.Text = "Roll";
         this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
         // 
         // RollDie
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(199, 244);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.rollButton,
                                                                      this.dieLabel4,
                                                                      this.dieLabel3,
                                                                      this.dieLabel2,
                                                                      this.dieLabel1});
         this.Name = "RollDie";
         this.Text = "RollDie";
         this.ResumeLayout(false);

      }
		#endregion

      // method called when rollButton clicked,
      // passes labels to another method
      protected void rollButton_Click( 
         object sender, System.EventArgs e )
      {
         // pass the labels to a method that will
         // randomly assign a face to each die
         DisplayDie( dieLabel1 );
         DisplayDie( dieLabel2 );
         DisplayDie( dieLabel3 );
         DisplayDie( dieLabel4 );

      } // end rollButton_Click

      // determines image to be displayed by current die
      public void DisplayDie( Label dieLabel )
      {
         int face = randomNumber.Next( 1, 7 );
      
         // displays image specified by filename
         dieLabel.Image = Image.FromFile( 
            Directory.GetCurrentDirectory() + 
            "\\images\\die" + face +".gif" );
      }
   
      /// <summary>
      /// main entry point for application
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new RollDie() );
      }

   } // end class RollDie

} // end namespace csphtp1.ch06.fig06_09

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
