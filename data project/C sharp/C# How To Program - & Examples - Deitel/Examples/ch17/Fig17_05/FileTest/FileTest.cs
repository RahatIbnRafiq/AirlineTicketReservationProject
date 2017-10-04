// Fig 17.5: FileTest.cs
// Using classes File and Directory.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace FileTest
{
   // displays contents of files and directories
   public class FileTestForm : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label directionsLabel;

      private System.Windows.Forms.TextBox outputTextBox;
      private System.Windows.Forms.TextBox inputTextBox;

      private System.ComponentModel.Container components = null;

      public FileTestForm()
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

      [STAThread]
      static void Main() 
      {
         Application.Run( new FileTestForm() );
      }

		#region Windows Form Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.outputTextBox = new System.Windows.Forms.TextBox();
         this.directionsLabel = new System.Windows.Forms.Label();
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // outputTextBox
         // 
         this.outputTextBox.AutoSize = false;
         this.outputTextBox.BackColor = System.Drawing.SystemColors.Control;
         this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.outputTextBox.Location = new System.Drawing.Point(18, 103);
         this.outputTextBox.Multiline = true;
         this.outputTextBox.Name = "outputTextBox";
         this.outputTextBox.ReadOnly = true;
         this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.outputTextBox.Size = new System.Drawing.Size(375, 327);
         this.outputTextBox.TabIndex = 4;
         this.outputTextBox.Text = "";
         // 
         // directionsLabel
         // 
         this.directionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.directionsLabel.Location = new System.Drawing.Point(18, 19);
         this.directionsLabel.Name = "directionsLabel";
         this.directionsLabel.Size = new System.Drawing.Size(375, 18);
         this.directionsLabel.TabIndex = 5;
         this.directionsLabel.Text = "Enter file or directory:";
         this.directionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // inputTextBox
         // 
         this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.inputTextBox.Location = new System.Drawing.Point(18, 56);
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.Size = new System.Drawing.Size(375, 23);
         this.inputTextBox.TabIndex = 3;
         this.inputTextBox.Text = "";
         this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
         // 
         // fileTestForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(420, 444);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.outputTextBox,
                                                                      this.directionsLabel,
                                                                      this.inputTextBox});
         this.Name = "fileTestForm";
         this.Text = "File Test";
         this.ResumeLayout(false);

      }
		#endregion

      // invoked when user presses key
      private void inputTextBox_KeyDown(
         object sender, System.Windows.Forms.KeyEventArgs e )
      {
         // determine whether user pressed Enter key
         if ( e.KeyCode == Keys.Enter )
         {
            string fileName; // name of file or directory

            // get user-specified file or directory
            fileName = inputTextBox.Text;

            // determine whether fileName is a file
            if ( File.Exists( fileName ) )
            {
               // get file's creation date, 
               // modification date, etc.
               outputTextBox.Text = GetInformation( fileName );

               // display file contents through StreamReader
               try
               {
                  // obtain reader and file contents
                  StreamReader stream = new StreamReader( fileName );
                  outputTextBox.Text += stream.ReadToEnd();
               }
                  // handle exception if StreamReader is unavailable
               catch( IOException )
               {
                  MessageBox.Show( "File Error", "File Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error );
               }
            }

               // determine whether fileName is a directory
            else if ( Directory.Exists( fileName ) )
            {
               // array for directories
               string[] directoryList;

               // get directory's creation date, 
               // modification date, etc.
               outputTextBox.Text = GetInformation( fileName );

               // obtain file/directory list of specified directory
               directoryList = Directory.GetDirectories( fileName );

               outputTextBox.Text += 
                  "\r\n\r\nDirectory contents:\r\n";

               // output directoryList contents
               for ( int i = 0; i < directoryList.Length; i++ )
                  outputTextBox.Text += directoryList[ i ] + "\r\n";
            }
            else
            {
               // notify user that neither file nor directory exists
               MessageBox.Show( inputTextBox.Text + 
                  " does not exist", "File Error", 
                  MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
         } // end if
   
      } // end method inputTextBox_KeyDown

      // get information on file or directory
      private string GetInformation( string fileName )
      {
         string information;

         // output that file or directory exists
         information = fileName + " exists\r\n\r\n";

         // output when file or directory was created
         information += "Created: " +
            File.GetCreationTime( fileName ) + "\r\n";

         // output when file or directory was last modified
         information += "Last modified: " +
            File.GetLastWriteTime( fileName ) + "\r\n";

         // output when file or directory was last accessed
         information += "Last accessed: " +
            File.GetLastAccessTime( fileName ) + "\r\n" + "\r\n";

         return information;

      } // end method GetInformation

   } // end class FileTestForm
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