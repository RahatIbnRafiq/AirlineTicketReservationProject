// Fig. H.4: LabelScrollbar.cs
// deomstrates ActiveX component usage in .NET.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using AxDeitel;

namespace FigH_04
{
   // Demonstrates ActiveX LabelScrollBar control
   public class LabelScrollTest : System.Windows.Forms.Form
   {
      private System.Windows.Forms.PictureBox pbColorBox;
      private AxDeitel.AxLabelScrollbar redScrollBar;
      private AxDeitel.AxLabelScrollbar blueScrollBar;
      private AxDeitel.AxLabelScrollbar greenScrollBar;
      
      /// Required designer variable.
      private System.ComponentModel.Container components = null;

      public LabelScrollTest()
      {
         InitializeComponent();
         
         // setup LabelScrollbar properties
         SetupRGBTitleScrollbar( redScrollBar );
         SetupRGBTitleScrollbar( blueScrollBar );
         SetupRGBTitleScrollbar( greenScrollBar );

         // initialize PictureBox back color
         pbColorBox.BackColor = Color.FromArgb( 
            redScrollBar.value, greenScrollBar.value, 
            blueScrollBar.value );
			
      } // end constructor
      
      // initialize LabelScrollBar properties
      private void SetupRGBTitleScrollbar(
         AxLabelScrollbar scrollBar )
      {
         scrollBar.Min = 0;             // minimum value
         scrollBar.Max = 255;           // maximum value
         scrollBar.LargeChange = 10;    // large change value
         scrollBar.SmallChange = 1;     // small change value

      } // end method SetupRGBTitleScrollBar

		#region Windows Form Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(LabelScrollTest));
         this.pbColorBox = new System.Windows.Forms.PictureBox();
         this.redScrollBar = new AxDeitel.AxLabelScrollbar();
         this.blueScrollBar = new AxDeitel.AxLabelScrollbar();
         this.greenScrollBar = new AxDeitel.AxLabelScrollbar();
         ((System.ComponentModel.ISupportInitialize)(this.redScrollBar)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.blueScrollBar)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.greenScrollBar)).BeginInit();
         this.SuspendLayout();
         // 
         // pbColorBox
         // 
         this.pbColorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pbColorBox.Location = new System.Drawing.Point(264, 8);
         this.pbColorBox.Name = "pbColorBox";
         this.pbColorBox.Size = new System.Drawing.Size(128, 72);
         this.pbColorBox.TabIndex = 3;
         this.pbColorBox.TabStop = false;
         // 
         // redScrollBar
         // 
         this.redScrollBar.Enabled = true;
         this.redScrollBar.Location = new System.Drawing.Point(8, 8);
         this.redScrollBar.Name = "redScrollBar";
         this.redScrollBar.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("redScrollBar.OcxState")));
         this.redScrollBar.Size = new System.Drawing.Size(242, 18);
         this.redScrollBar.TabIndex = 4;
         this.redScrollBar.Change += new System.EventHandler(this.scrollbar_Change);
         // 
         // blueScrollBar
         // 
         this.blueScrollBar.Enabled = true;
         this.blueScrollBar.Location = new System.Drawing.Point(8, 32);
         this.blueScrollBar.Name = "blueScrollBar";
         this.blueScrollBar.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("blueScrollBar.OcxState")));
         this.blueScrollBar.Size = new System.Drawing.Size(242, 18);
         this.blueScrollBar.TabIndex = 5;
         this.blueScrollBar.Change += new System.EventHandler(this.scrollbar_Change);
         // 
         // greenScrollBar
         // 
         this.greenScrollBar.Enabled = true;
         this.greenScrollBar.Location = new System.Drawing.Point(8, 56);
         this.greenScrollBar.Name = "greenScrollBar";
         this.greenScrollBar.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("greenScrollBar.OcxState")));
         this.greenScrollBar.Size = new System.Drawing.Size(242, 18);
         this.greenScrollBar.TabIndex = 6;
         this.greenScrollBar.Change += new System.EventHandler(this.scrollbar_Change);
         // 
         // LabelScrollTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(408, 93);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.greenScrollBar,
                                                                      this.blueScrollBar,
                                                                      this.redScrollBar,
                                                                      this.pbColorBox});
         this.Name = "LabelScrollTest";
         this.Text = "LabelScrollbar";
         ((System.ComponentModel.ISupportInitialize)(this.redScrollBar)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.blueScrollBar)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.greenScrollBar)).EndInit();
         this.ResumeLayout(false);

      }
      /// Clean up any resources being used.
      protected override void Dispose( bool disposing )
      {
         if( disposing )
         {
            if(components != null)
            {
               components.Dispose();
            }
         }
         base.Dispose( disposing );
      }
		#endregion
		
      [STAThread]
      static void Main()
      {
         Application.Run( new LabelScrollTest() );
      }

      // handles scrollbar changed event
      private void scrollbar_Change( object sender, 
         System.EventArgs e )
      {
         pbColorBox.BackColor = Color.FromArgb( 
            redScrollBar.value, greenScrollBar.value, 
            blueScrollBar.value );
      } // end method scrollbar_Change
   } // end class LabelScrollTest
} // end namespace FigH_04

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