// Fig 20.30: OptionsPage.aspx.cs
// A listing of programming languages,
// choice is stored in page’s Session object.

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

namespace Sessions
{
   /// <summary>
   /// page contains language options in a RadioButtonList
   /// will add cookie to store user's choice
   /// </summary>
   public class OptionsPage : System.Web.UI.Page
   {
      protected System.Web.UI.WebControls.Label promptLabel;
      protected System.Web.UI.WebControls.Label welcomeLabel;
      protected System.Web.UI.WebControls.Label idLabel;
      protected System.Web.UI.WebControls.Label timeoutLabel;

      protected System.Web.UI.WebControls.HyperLink
         languageLink;
      protected System.Web.UI.WebControls.HyperLink
         recommendationsLink;

      protected System.Web.UI.WebControls.RadioButtonList
         languageList;
      protected System.Web.UI.WebControls.Button submitButton;

      private Hashtable books = new Hashtable();
   
      // event handler for Load event
      private void Page_Load( 
         object sender, System.EventArgs e )
      {
         // if page is loaded due to postback, load session
         // information, hide language options from user
         if ( IsPostBack )
         {
            // display components that contain session information
            welcomeLabel.Visible = true;
            languageLink.Visible = true;
            recommendationsLink.Visible = true;

            // hide components
            submitButton.Visible = false;
            promptLabel.Visible = false;
            languageList.Visible = false;

            // set labels to display Session information
            if ( languageList.SelectedItem != null )
               welcomeLabel.Text += 
                  languageList.SelectedItem.ToString() + ".";
            else
               welcomeLabel.Text += "no language.";

            idLabel.Text += "Your unique session ID is: " + 
               Session.SessionID;

            timeoutLabel.Text += "Timeout: " + Session.Timeout + 
               " minutes";
            
         } // end if

      } // end method Page_Load

      #region Web Form Designer generated code
      override protected void OnInit( EventArgs e )
      {
         // add values to Hashtable
         books.Add( "C#", "0-13-062221-4" );
         books.Add( "C++", "0-13-089571-7" );
         books.Add( "C", "0-13-089572-5" );
         books.Add( "Python", "0-13-092361-3" );
         books.Add( "Visual Basic .NET", "0-13-456955-5" );

         //
         // CODEGEN: This call is required
         // by the ASP.NET Web Form Designer.
         //
         InitializeComponent();
         base.OnInit( e );
      }
	
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {    
         this.submitButton.Click += new System.EventHandler(
            this.submitButton_Click );
         this.Load += new System.EventHandler(
            this.Page_Load );

      }
      #endregion

      // when user clicks Submit button,
      // store user's choice in session object
      private void submitButton_Click(
         object sender, System.EventArgs e )
      {
         if ( languageList.SelectedItem != null )
         {
            string language =
               languageList.SelectedItem.ToString();
            string ISBN = books[ language ].ToString();

            // store in session as name-value pair
            // name is language chosen, value is
            // ISBN number for corresponding book
            Session.Add( language, ISBN );

         } // end if

      } // end method submitBotton_Click

   } // end class OptionsPage

} // end namespace Sessions

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