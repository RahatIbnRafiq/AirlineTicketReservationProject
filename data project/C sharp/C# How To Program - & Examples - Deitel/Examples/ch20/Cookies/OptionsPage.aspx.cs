// Fig. 20.25: OptionPage.aspx.cs
// A listing of program languages that the user can choose from.

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

namespace Cookies
{
   /// <summary>
   /// page contains language options in a RadioButtonList,
   /// will add a cookie to store their choice
   /// </summary>
   public class OptionsPage : System.Web.UI.Page
   {
      protected System.Web.UI.WebControls.Label promptLabel;
      protected System.Web.UI.WebControls.Label welcomeLabel;

      protected System.Web.UI.WebControls.RadioButtonList
         languageList;

      protected System.Web.UI.WebControls.HyperLink
         languageLink;
      protected System.Web.UI.WebControls.HyperLink
         recommendationsLink;

      protected System.Web.UI.WebControls.Button
         submitButton;

      private Hashtable books = new Hashtable();

      // event handler for Load event
      private void Page_Load(
         object sender, System.EventArgs e )
      {
         if ( IsPostBack )
         {
            // if postback has occurred, user has submitted
            // information, so display welcome message
            // and appropriate hyperlinks
            welcomeLabel.Visible = true;
            languageLink.Visible = true;
            recommendationsLink.Visible = true;

            // hide option information
            submitButton.Visible = false;
            promptLabel.Visible = false;
            languageList.Visible = false;

            // notify user of what they have chosen
            if ( languageList.SelectedItem != null )
               welcomeLabel.Text += 
                  languageList.SelectedItem.ToString() + ".";
            else
               welcomeLabel.Text += "no language.";

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
         // CODEGEN: This call is required by
         // the ASP.NET Web Form Designer.
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
         this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
         this.Load += new System.EventHandler(this.Page_Load);

      }
      #endregion

      // when user clicks Submit button
      // create cookie to store user's choice
      private void submitButton_Click(
         object sender, System.EventArgs e )
      {
         // if choice was made by user
         if ( languageList.SelectedItem != null )
         {
            string language = 
               languageList.SelectedItem.ToString();

            string ISBN = books[ language ].ToString();

            // create cookie, name-value pair is
            // language chosen and ISBN number from Hashtable
            HttpCookie cookie = new HttpCookie(
               language, ISBN );

            // add cookie to response, 
            // thus placing it on user's machine
            Response.Cookies.Add( cookie );

         } // end if

      } // end method submitButton_Click

   } // end class OptionsPage

} // end namespace Cookies

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