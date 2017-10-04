// Fig 12.30: Painter.cs
// Using the mouse to draw on a form.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Painter
{
   /// <summary>
   /// creates a form as a drawing surface
   /// </summary>
   public class Painter : System.Windows.Forms.Form
   {
      bool shouldPaint = false; // whether to paint

      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      // default constructor
      public Painter()
      {
         InitializeComponent();
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
         // 
         // Painter
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(144, 133);
         this.Name = "Painter";
         this.Text = "Painter";

         // register event handlers
         this.MouseDown += 
            new System.Windows.Forms.MouseEventHandler(
            this.Painter_MouseDown );
         
         this.MouseUp += 
            new System.Windows.Forms.MouseEventHandler(
            this.Painter_MouseUp );
         
         this.MouseMove += 
            new System.Windows.Forms.MouseEventHandler(
            this.Painter_MouseMove );

      } // end method InitializeComponent

		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new Painter() );
      }

      // should paint after mouse button has been pressed
      private void Painter_MouseDown( 
         object sender, System.Windows.Forms.MouseEventArgs e )
      {
         shouldPaint = true;
      }

      // stop painting when mouse button released
      private void Painter_MouseUp( 
         object sender, System.Windows.Forms.MouseEventArgs e )
      {
         shouldPaint = false;
      }

      // draw circle whenever mouse button 
      // moves (and mouse is down)
      protected void Painter_MouseMove( 
         object sender, System.Windows.Forms.MouseEventArgs e )
      {
         if ( shouldPaint )
         {
            Graphics graphics = CreateGraphics();
            graphics.FillEllipse( 
               new SolidBrush( Color.BlueViolet ), 
               e.X, e.Y, 4, 4 );
         }

      } // end Painter_MouseMove

   } // end class Painter

} // end namespace Painter

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
