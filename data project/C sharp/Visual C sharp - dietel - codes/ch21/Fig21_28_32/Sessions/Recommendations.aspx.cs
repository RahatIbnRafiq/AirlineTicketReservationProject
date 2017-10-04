// Fig. 21.32: Recommendations.aspx.cs
// Creates book recommendations based on a session object.
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Recommendations : System.Web.UI.Page
{
   // read cookies and populate ListBox with any book recommendations
   protected void Page_Init( object sender, EventArgs e )
   {
      // stores a key name found in the Session object
      string keyName;

      // determine whether Session contains any information
      if ( Session.Count != 0 )
      {
         for ( int i = 0; i < Session.Count; i++ )
         {
            keyName = Session.Keys[ i ]; // store current key name

            // use current key to display one
            // of session's name-value pairs
            booksListBox.Items.Add( keyName +
               " How to Program. ISBN#: " + 
               Session[ keyName ].ToString() );
         } // end for
      } // end if
      else
      {
         // if there are no session items, no language was chosen, so
         // display appropriate message and clear and hide booksListBox
         recommendationsLabel.Text = "No Recommendations";
         booksListBox.Items.Clear();
         booksListBox.Visible = false;
   
         // modify languageLink because no language was selected
         languageLink.Text = "Click here to choose a language";
      } // end else
   } // end method Page_Init
} // end class Recommendations

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