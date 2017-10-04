// ClockExample.cs
// Windows Form containing a CClockUserControl object.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ClockExample
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class clockForm : System.Windows.Forms.Form
   {
      private ClockExample.ClockUserControl 
         myClockUserControl;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private 
         System.ComponentModel.Container components = null;

      public clockForm()
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
         this.myClockUserControl = new ClockExample.ClockUserControl();
         this.SuspendLayout();
         // 
         // myClockUserControl
         // 
         this.myClockUserControl.Location = new System.Drawing.Point(24, 24);
         this.myClockUserControl.Name = "myClockUserControl";
         this.myClockUserControl.Size = new System.Drawing.Size(96, 48);
         this.myClockUserControl.TabIndex = 0;
         // 
         // clockForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(144, 93);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.myClockUserControl});
         this.Name = "clockForm";
         this.Text = "Clock";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new clockForm());
      }
   }
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
