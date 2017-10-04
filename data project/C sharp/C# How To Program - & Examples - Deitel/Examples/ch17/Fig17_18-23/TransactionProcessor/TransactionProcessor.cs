// Fig. 17.19: TransactionProcessor.cs
// MDI parent for transaction-processor application.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TransactionProcessor
{
   public class TransactionProcessorForm 
      : System.Windows.Forms.Form
   {
      private System.ComponentModel.Container components = null;
      private System.Windows.Forms.MdiClient MdiClient1;

      // reference to StartDialog
      private StartDialogForm startDialog;

      // constructor
      public TransactionProcessorForm()
      {
         // required for Windows Form Designer support
         InitializeComponent();

         startDialog = new StartDialogForm();
         startDialog.MdiParent = this;
         startDialog.Show();
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
         this.MdiClient1 = new System.Windows.Forms.MdiClient();
         this.SuspendLayout();
         //
         //MdiClient1
         //
         this.MdiClient1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.MdiClient1.Name = "MdiClient1";
         this.MdiClient1.TabIndex = 0;
         // 
         // transactionProcessorForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
         this.ClientSize = new System.Drawing.Size(675, 397);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {this.MdiClient1});
         this.IsMdiContainer = true;
         this.Name = "transactionProcessorForm";
         this.Text = "Transaction Processor";
         this.ResumeLayout(false);
      }
	   #endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new TransactionProcessorForm() );
      }

   } // end class transactionProcessorForm
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