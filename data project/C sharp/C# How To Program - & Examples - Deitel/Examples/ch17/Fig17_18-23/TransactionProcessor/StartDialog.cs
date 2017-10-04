// Fig. 17.20: StartDialog.cs
// Initial dialog box displayed to user. Provides buttons for 
// creating/opening file and for adding, updating and removing
// records from file.

// C# namespaces
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

// Deitel namespaces
using BankLibrary;

namespace TransactionProcessor
{

   public delegate void MyDelegate();

   public class StartDialogForm : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Button updateButton;
      private System.Windows.Forms.Button newButton;
      private System.Windows.Forms.Button deleteButton;
      private System.Windows.Forms.Button openButton;

      private System.ComponentModel.Container components = null;

      // reference to dialog box for adding record
      private NewDialogForm newDialog;

      // reference to dialog box for updating record
      private UpdateDialogForm updateDialog;

      // reference to dialog box for removing record
      private DeleteDialogForm deleteDialog;

      // reference to object that handles transactions
      private Transaction transactionProxy;

      public StartDialogForm()
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
            if(components != null)
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
         this.updateButton = new System.Windows.Forms.Button();
         this.newButton = new System.Windows.Forms.Button();
         this.deleteButton = new System.Windows.Forms.Button();
         this.openButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // updateButton
         // 
         this.updateButton.Enabled = false;
         this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
         this.updateButton.Location = new System.Drawing.Point(16, 110);
         this.updateButton.Name = "updateButton";
         this.updateButton.Size = new System.Drawing.Size(150, 40);
         this.updateButton.TabIndex = 4;
         this.updateButton.Text = "Update Record";
         this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
         // 
         // newButton
         // 
         this.newButton.Enabled = false;
         this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
         this.newButton.Location = new System.Drawing.Point(16, 60);
         this.newButton.Name = "newButton";
         this.newButton.Size = new System.Drawing.Size(150, 40);
         this.newButton.TabIndex = 5;
         this.newButton.Text = "New Record";
         this.newButton.Click += new System.EventHandler(this.newButton_Click);
         // 
         // deleteButton
         // 
         this.deleteButton.Enabled = false;
         this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
         this.deleteButton.Location = new System.Drawing.Point(16, 160);
         this.deleteButton.Name = "deleteButton";
         this.deleteButton.Size = new System.Drawing.Size(150, 40);
         this.deleteButton.TabIndex = 6;
         this.deleteButton.Text = "Delete Record";
         this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
         // 
         // openButton
         // 
         this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
         this.openButton.Location = new System.Drawing.Point(16, 10);
         this.openButton.Name = "openButton";
         this.openButton.Size = new System.Drawing.Size(150, 40);
         this.openButton.TabIndex = 7;
         this.openButton.Text = "New/Open File";
         this.openButton.Click += new System.EventHandler(this.openButton_Click);
         // 
         // StartDialogForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
         this.ClientSize = new System.Drawing.Size(184, 215);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.updateButton,
                                                                      this.newButton,
                                                                      this.deleteButton,
                                                                      this.openButton});
         this.Name = "StartDialogForm";
         this.Text = "Start Dialog";
         this.ResumeLayout(false);

      }
		#endregion

      // invoked when user clicks New/Open File button
      private void openButton_Click(
         object sender, System.EventArgs e )
      {
         // create dialog box enabling user to create or open file
         OpenFileDialog fileChooser = new OpenFileDialog();
         DialogResult result;
         string fileName;
      
         // enable user to create file if file does not exist
         fileChooser.Title = "Create File / Open File";
         fileChooser.CheckFileExists = false;

         // show dialog box to user
         result = fileChooser.ShowDialog();

         // exit event handler if user clicked Cancel
         if ( result == DialogResult.Cancel )
            return;

         // get file name from user
         fileName = fileChooser.FileName;

         // show error if user specified invalid file
         if ( fileName == "" || fileName == null )
            MessageBox.Show( "Invalid File Name", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error );

         // open or create file if user specified valid file
         else
         {
            // create Transaction with specified file
            transactionProxy = new Transaction();
            transactionProxy.OpenFile( fileName );

            // enable GUI buttons except for New/Open File button
            newButton.Enabled = true;
            updateButton.Enabled = true;
            deleteButton.Enabled = true;
            openButton.Enabled = false;

            // instantiate dialog box for creating records
            newDialog = new NewDialogForm( transactionProxy,
               new MyDelegate( ShowStartDialog ) );

            // instantiate dialog box for updating records
            updateDialog = new UpdateDialogForm( transactionProxy,
               new MyDelegate( ShowStartDialog ) );

            // instantiate dialog box for removing records
            deleteDialog = new DeleteDialogForm( transactionProxy,
               new MyDelegate( ShowStartDialog ) );

            // set StartDialog as MdiParent for dialog boxes
            newDialog.MdiParent = this.MdiParent;
            updateDialog.MdiParent = this.MdiParent;
            deleteDialog.MdiParent = this.MdiParent;
         }

      } // end method openButton_Click

      // invoked when user clicks New Record button
      private void newButton_Click(
         object sender, System.EventArgs e )
      {
         Hide(); // hide StartDialog
         newDialog.Show(); // show NewDialog

      } // end method newButton_Click

      private void updateButton_Click(
         object sender, System.EventArgs e )
      {
         Hide(); // hide StartDialog
         updateDialog.Show(); // show UpdateDialog

      } // end method updateButton_Click

      private void deleteButton_Click(
         object sender, System.EventArgs e )
      {
         Hide(); // hide StartDialog
         deleteDialog.Show(); // show DeleteDialog

      } // end method deleteButton_Click

      protected void ShowStartDialog()
      {
         Show();
      }

   } // end class StartDialogForm
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