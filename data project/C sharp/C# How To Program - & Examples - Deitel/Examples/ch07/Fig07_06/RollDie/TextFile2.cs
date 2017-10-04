// Fig. 7.7: RollDie.cs
// Rolling 12 dice.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

public class RollDie : System.Windows.Forms.Form
{
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
   private System.ComponentModel.Container components = null;

   Random r = new Random();
   int[] frequency = new int[ 7 ];

   public RollDie()
   {
      InitializeComponent();
   }

   // Visual Studio.NET generated code

   [STAThread]
   static void Main() 
   {
      Application.Run( new RollDie() );
   }

   private void rollButton_Click( object sender, 
      System.EventArgs e )
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

      double total = frequency[ 1 ] + frequency[ 2 ] + 
         frequency[ 3 ] + frequency[ 4 ] + 
         frequency[ 5 ] + frequency[ 6 ];

      displayTextBox.Text = "Face\tFrequency\tPercent\n";

      for ( int x = 1; x < frequency.Length; x++ )
      {
         displayTextBox.Text += x + "\t" +
            frequency[ x ] + "\t\t" + String.Format( "{0:N}",
            frequency[ x ] / total * 100 ) + "%\n";
      }
   } // end method Main

   public void DisplayDie( Label dieLabel )
   {
      int face = 1 + r.Next( 6 );

      dieLabel.Image = Image.FromFile(
         Directory.GetCurrentDirectory() +
         "\\images\\die" + face + ".gif" );

      frequency[ face ]++;
   }
} // end class RollDie