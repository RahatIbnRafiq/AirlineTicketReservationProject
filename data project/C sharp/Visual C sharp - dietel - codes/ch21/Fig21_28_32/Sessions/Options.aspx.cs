// Fig. 21.29: Options.aspx.cs
// Processes user's selection of a programming language
// by displaying links and writing a cookie to the user's machine.
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
public partial class Options : System.Web.UI.Page 
{
   // stores values to represent books as cookies
   private System.Collections.Hashtable books = 
      new System.Collections.Hashtable();

   //initializes the Hashtable of values to be stored as cookies 
   protected void Page_Init( object sender, EventArgs e )
   {
      books.Add( "Visual Basic 2005", "0-13-186900-0" );
      books.Add( "Visual C# 2005", "0-13-152523-9" );
      books.Add( "C", "0-13-142644-3" );
      books.Add( "C++", "0-13-185757-6" );
      books.Add( "Java", "0-13-148398-6" );
   } // end method Page_Init

   // if postback, hide form and display links to make additional
   // selections or view recommendations
   protected void Page_Load( object sender, EventArgs e )
   {
      if ( IsPostBack )
      {
         // user has submitted information, so display appropriate labels
         // and hyperlinks
         responseLabel.Visible = true;
         idLabel.Visible = true;
         timeoutLabel.Visible = true;
         languageLink.Visible = true;
         recommendationsLink.Visible = true;

         // hide other controls used to make language selection
         promptLabel.Visible = false;
         languageList.Visible = false;
         submitButton.Visible = false;

         // if the user made a selection, display it in responseLabel
         if ( languageList.SelectedItem != null )
            responseLabel.Text += " You selected " +
               languageList.SelectedItem.Text.ToString();
         else
            responseLabel.Text += " You did not select a language.";

         // display session ID
         idLabel.Text = "Your unique session ID is: " + Session.SessionID;

         // display the timeout
         timeoutLabel.Text = "Timeout: " + Session.Timeout + " minutes.";
      } // end if
   } // end method Page_Load

   // write a cookie to record the user's selection 
   protected void submitButton_Click( object sender, EventArgs e )
   {
      // if the user made a selection
      if ( languageList.SelectedItem != null )
      {
         string language = languageList.SelectedItem.ToString();

         // get ISBN number of book for the given language
         string ISBN = books[ language ].ToString();

         Session.Add( language, ISBN ); // add name/value pair to Session
      } // end if
   } // end method submitButton_Click
} // end class Options

/**************************************************************************
 * (C) Copyright 1992-2006 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
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
 *************************************************************************/