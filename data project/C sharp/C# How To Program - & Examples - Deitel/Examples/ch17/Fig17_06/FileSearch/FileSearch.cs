// Fig 17.6: FileSearch.cs
// Using regular expressions to determine file types.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Specialized;

namespace FileSearch
{
   public class FileSearchForm : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label directionsLabel;
      private System.Windows.Forms.Label directoryLabel;

      private System.Windows.Forms.Button searchButton;

      private System.Windows.Forms.TextBox outputTextBox;
      private System.Windows.Forms.TextBox inputTextBox;

      private System.ComponentModel.Container components = null;

      string currentDirectory = Directory.GetCurrentDirectory();
      string[] directoryList; // subdirectories
      string[] fileArray;

      // store extensions found and number found
      NameValueCollection found = new NameValueCollection();


         public FileSearchForm()
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
         Application.Run( new FileSearchForm() );
      }

		   #region Windows Form Designer generated code
         /// <summary>
         /// Required method for Designer support - do not modify
         /// the contents of this method with the code editor.
         /// </summary>
         private void InitializeComponent()
         {
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.directionsLabel = new System.Windows.Forms.Label();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputTextBox
            // 
            this.outputTextBox.AutoSize = false;
            this.outputTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.outputTextBox.Location = new System.Drawing.Point(18, 261);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(421, 197);
            this.outputTextBox.TabIndex = 9;
            this.outputTextBox.Text = "";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(18, 159);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(421, 20);
            this.inputTextBox.TabIndex = 8;
            this.inputTextBox.Text = "";
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(18, 205);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(421, 38);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search Directory";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // directionsLabel
            // 
            this.directionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.directionsLabel.Location = new System.Drawing.Point(18, 131);
            this.directionsLabel.Name = "directionsLabel";
            this.directionsLabel.Size = new System.Drawing.Size(412, 19);
            this.directionsLabel.TabIndex = 6;
            this.directionsLabel.Text = "Enter Path to Search:";
            // 
            // directoryLabel
            // 
            this.directoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.directoryLabel.Location = new System.Drawing.Point(18, 19);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(412, 93);
            this.directoryLabel.TabIndex = 5;
            this.directoryLabel.Text = "Current Directory:";
            // 
            // fileSearchForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(457, 472);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                        this.outputTextBox,
                                                                        this.inputTextBox,
                                                                        this.searchButton,
                                                                        this.directionsLabel,
                                                                        this.directoryLabel});
            this.Name = "fileSearchForm";
            this.Text = "Using Regular Expressions";
            this.ResumeLayout(false);

         }
		   #endregion

      // invoked when user types in text box
      private void inputTextBox_KeyDown(
         object sender, System.Windows.Forms.KeyEventArgs e )
      {
         // determine whether user pressed Enter
         if ( e.KeyCode == Keys.Enter )
            searchButton_Click( sender, e );
      
      } // end method inputTextBox_KeyDown

      // invoked when user clicks "Search Directory" button
      private void searchButton_Click(
         object sender, System.EventArgs e )
      {
         // check for user input; default is current directory
         if ( inputTextBox.Text != "" )
         {
            // verify that user input is valid durectory name
            if ( Directory.Exists( inputTextBox.Text ) )
            {
               currentDirectory = inputTextBox.Text;

               // reset input text box and update display
               directoryLabel.Text = "Current Directory:" + 
                  "\r\n" + currentDirectory;
            }
            else
            {
               // show error if user does not specify valid directory
               MessageBox.Show( "Invalid Directory", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
         }

         // clear text boxes
         inputTextBox.Text = "";
         outputTextBox.Text = "";

         // search directory
         SearchDirectory( currentDirectory );

         // summarize and print results
         foreach ( string current in found )
         {
            outputTextBox.Text += "* Found " + 
               found[ current ] + " " + current + " files.\r\n";
         }

         // clear output for new search
         found.Clear();
      
      } // end method searchButton_Click

      // search directory using regular expression
      private void SearchDirectory( string currentDirectory )
      {
         // for file name without directory path
         try
         {
            string fileName = "";

            // regular expression for extensions matching pattern
            Regex regularExpression = new Regex( 
               "[a-zA-Z0-9]+\\.(?<extension>\\w+)" );

            // stores regular-expression-match result
            Match matchResult;

            string fileExtension; // holds file extensions

            // number of files with given extension in directory
            int extensionCount;

            // get directories
            directoryList =
               Directory.GetDirectories( currentDirectory );

            // get list of files in current directory
            fileArray = Directory.GetFiles( currentDirectory );

            // iterate through list of files
            foreach ( string myFile in fileArray )
            {
               // remove directory path from file name
               fileName = myFile.Substring(
                  myFile.LastIndexOf( "\\" ) + 1 );

               // obtain result for regular-expression search
               matchResult = regularExpression.Match( fileName );

               // check for match
               if ( matchResult.Success )
                  fileExtension = 
                     matchResult.Result( "${extension}" );
               else
                  fileExtension = "[no extension]";

               // store value from container
               if ( found[ fileExtension ] == null )
                  found.Add( fileExtension, "1" );
               else
               {
                  extensionCount = Int32.Parse(
                     found[ fileExtension ] ) + 1;

                  found[ fileExtension ] = extensionCount.ToString();
               }

               // search for backup(.bak) files
               if ( fileExtension == "bak" )
               {
                  // prompt user to delete (.bak) file
                  DialogResult result =
                     MessageBox.Show( "Found backup file " +
                     fileName + ". Delete?", "Delete Backup",
                     MessageBoxButtons.YesNo, 
                     MessageBoxIcon.Question );

                  // delete file if user clicked 'yes'
                  if ( result == DialogResult.Yes )
                  {
                     File.Delete( myFile );

                     extensionCount = 
                        Int32.Parse( found[ "bak" ] ) - 1;

                     found[ "bak" ] = extensionCount.ToString();
                  }
               }
            }

            // recursive call to search files in subdirectory
            foreach ( string myDirectory in directoryList )
               SearchDirectory( myDirectory );
         }

            // handle exception if files have unauthorized access
         catch( UnauthorizedAccessException )
         {
            MessageBox.Show( "Some files may not be visible" +
               " due to permission settings", "Warning",
               MessageBoxButtons.OK, MessageBoxIcon.Information );
         }

      } // end method SearchDirectory

   } // end class FileSearchForm

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