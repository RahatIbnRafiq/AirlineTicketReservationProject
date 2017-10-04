// Fig. 21.41: Guestbook.aspx.cs
// Code-behind file that defines event handlers for the guestbook.
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Guestbook : System.Web.UI.Page 
{
   // Submit Button adds a new guestbook entry to the database,
   // clears the form and displays the updated list of guestbook entries
   protected void submitButton_Click( object sender, EventArgs e )
   {
      // create a date parameter to store the current date
      System.Web.UI.WebControls.Parameter date =
         new System.Web.UI.WebControls.Parameter(
         "Date", TypeCode.String, DateTime.Now.ToShortDateString() );

      // set the @Date parameter to the date parameter
      messagesSqlDataSource.InsertParameters.RemoveAt( 0 );
      messagesSqlDataSource.InsertParameters.Add( date );

      // execute an INSERT SQL statement to add a new row to the 
      // Messages table in the Guestbook database that contains the
      // current date and the user's name, e-mail address and message
      messagesSqlDataSource.Insert();

      // clear the TextBoxes
      nameTextBox.Text = "";
      emailTextBox.Text = "";
      messageTextBox.Text = "";
      
      // update the GridView with the new database table contents
      messagesGridView.DataBind();
   } // end method submitButton_Click

   // Clear Button clears the Web Form's TextBoxes
   protected void clearButton_Click( object sender, EventArgs e )
   {
      nameTextBox.Text = "";
      emailTextBox.Text = "";
      messageTextBox.Text = "";
   } // end method clearButton_Click
} // end class Guestbook

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