// Fig.13.42: ClockUserControl.cs
//User-defined control with a timer and a label.

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace ClockExample
{
   /// <summary>
   /// Summary description for ClockUserControl.
   /// </summary>
   public class ClockUserControl 
      : System.Windows.Forms.UserControl
   {
      private System.Windows.Forms.Timer clockTimer;
      private System.Windows.Forms.Label displayLabel;
      private System.ComponentModel.IContainer components;

      public ClockUserControl()
      {
         // This call is required by the Windows.Forms Form Designer.
         InitializeComponent();
      }

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
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

		#region Component Designer generated code
      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.clockTimer = new System.Windows.Forms.Timer(this.components);
         this.displayLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // clockTimer
         // 
         this.clockTimer.Enabled = true;
         this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
         // 
         // displayLabel
         // 
         this.displayLabel.BackColor = System.Drawing.Color.White;
         this.displayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.displayLabel.Name = "displayLabel";
         this.displayLabel.Size = new System.Drawing.Size(150, 72);
         this.displayLabel.TabIndex = 1;
         this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // ClockUserControl
         // 
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.displayLabel});
         this.Name = "ClockUserControl";
         this.Size = new System.Drawing.Size(150, 72);
         this.ResumeLayout(false);

      }
		#endregion

      // update label at every tick
      private void clockTimer_Tick(
         object sender, System.EventArgs e )
      {
         // get current time (Now), convert to string
         displayLabel.Text = DateTime.Now.ToLongTimeString();
      
      } // end method clockTimer_Tick

   } // end class ClockUserControl
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
