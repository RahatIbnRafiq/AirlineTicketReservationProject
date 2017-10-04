// Fig. 21.21: Validation.aspx.cs
// Code-behind file for the form demonstrating validation controls.
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Validation : System.Web.UI.Page
{
   // Page_Load event handler executes when the page is loaded
   protected void Page_Load( object sender, EventArgs e )
   {
      // if this is not the first time the page is loading
      // (i.e., the user has already submitted form data)
      if ( IsPostBack )
      {
         // retrieve the values submitted by the user
         string name = Request.Form[ "nameTextBox" ];
         string email = Request.Form[ "emailTextBox" ];
         string phone = Request.Form[ "phoneTextBox" ];

         // create a table indicating the submitted values
         outputLabel.Text +=
            "<br />We received the following information:" +
            "<table style=\"background-color: yellow\">" +
            "<tr><td>Name: </td><td>" + name + "</td></tr>" +
            "<tr><td>E-mail address: </td><td>" + email + "</td></tr>" +
            "<tr><td>Phone number: </td><td>" + phone + "</td></tr>" +
            "<table>";

         outputLabel.Visible = true; // display the output message
      } // end if
   } // end method Page_Load
} // end class Validation

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