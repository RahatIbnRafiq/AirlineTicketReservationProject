// Fig. 20.36: Welcome.aspx.cs
// The code-behind file for the guest book page.

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.IO;

namespace Guestbook
{
   /// <summary>
   /// allows user to leave messages
   /// </summary>
   public class GuestBookForm : System.Web.UI.Page
   {
      protected System.Web.UI.WebControls.Label promptLabel;
      protected System.Web.UI.WebControls.Label nameLabel;
      protected System.Web.UI.WebControls.Label emailLabel;
      protected System.Web.UI.WebControls.Label messageLabel;

      protected System.Web.UI.WebControls.DataGrid dataGrid;

      protected System.Web.UI.WebControls.Button submitButton;
      protected System.Web.UI.WebControls.Button clearButton;

      protected System.Web.UI.WebControls.TextBox nameTextBox;
      protected System.Web.UI.WebControls.TextBox
         emailTextBox;
      protected System.Web.UI.WebControls.TextBox
         messageTextBox;

      protected System.Data.DataView dataView;
   
      // handle Page's Load event
      private void Page_Load(
         object sender, System.EventArgs e )
      {
         dataView = new DataView( new DataTable() );

      } // end method Page_Load

      #region Web Form Designer generated code
      override protected void OnInit( EventArgs e )
      {
         //
         // CODEGEN: This call is required
         // by the ASP.NET Web Form Designer.
         //
         InitializeComponent();
         base.OnInit( e );

      } // end method OnInit
		
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {    
         this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
         this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
         this.Load += new System.EventHandler(this.Page_Load);

      }
      #endregion

      // places all the messages in the guest book into a
      // table; messages are separated by horizontal rules
      public void FillMessageTable()
      {
         DataTable table = dataView.Table;
         table.Columns.Add( "Date" );
         table.Columns.Add( "First Name" );
         table.Columns.Add( "e-mail" );
         table.Columns.Add( "Message" );

         // open guest book file for reading
         StreamReader reader = new StreamReader( 
            Request.PhysicalApplicationPath +
            "guestbook.txt" );

         char[] separator = { '\t' };

         // read in line from file
         string message = reader.ReadLine();

         while ( message != null )
         {
            // split the string into its four parts
            string[] parts = message.Split( separator );

            // load data into table
            table.LoadDataRow( parts, true );

            // read in one line from file
            message = reader.ReadLine();
         }

         // update grid
         dataGrid.DataSource = table;
         dataGrid.DataBind();
         
         reader.Close();

      } // end method FillMessageTable

      // add user's entry to guest book
      private void submitButton_Click(
         object sender, System.EventArgs e )
      {
         // open stream for appending to file
         StreamWriter guestbook = 
            new StreamWriter( Request.PhysicalApplicationPath + 
            "guestbook.txt", true ); 
                  
         // write new message to file
         guestbook.WriteLine( 
            DateTime.Now.Date.ToString().Substring( 0, 10 ) + 
            "\t" + nameTextBox.Text + "\t" + emailTextBox.Text
            + "\t" + messageTextBox.Text );
         
         // clear textboxes and close stream
         nameTextBox.Text = "";
         emailTextBox.Text = "";
         messageTextBox.Text = "";
         guestbook.Close();

         FillMessageTable();
      } // end method submitButton_Click

      // clear all text boxes
      private void clearButton_Click(
         object sender, System.EventArgs e )
      {
         nameTextBox.Text = "";
         emailTextBox.Text = "";
         messageTextBox.Text = "";

      } // end method clearButton_Click

   } // end class GuestBookForm

} // end namespace Guestbook

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
