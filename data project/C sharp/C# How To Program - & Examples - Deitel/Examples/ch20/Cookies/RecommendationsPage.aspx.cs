// Fig 20.27: RecommendationsPage.aspx.cs
// Reading cookie data from the client.

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
   /// page displays cookie information and recommendations
   /// </summary>
   public class RecommendationsPage : System.Web.UI.Page
   {
      protected System.Web.UI.WebControls.ListBox booksListBox;
      protected System.Web.UI.WebControls.Label
         recommendationsLabel;

      // event handler for Load event
      private void Page_Load(
         object sender, System.EventArgs e )
      {
         // Put user code to initialize the page here

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
         
         // retrieve client's cookies
         HttpCookieCollection cookies = Request.Cookies;
         
         // if there are cookies other than the ID cookie, 
         // list appropriate books and ISBN numbers
         if ( cookies != null && cookies.Count != 1 )
            for ( int i = 1; i < cookies.Count; i++ )
               booksListBox.Items.Add(
                  cookies[ i ].Name + 
                  " How to Program. ISBN#: " +
                  cookies[ i ].Value );
                  
         // if no cookies besides ID, no options were
         // chosen, so no recommendations made
         else
         {
            recommendationsLabel.Text = "No Recommendations.";
            booksListBox.Items.Clear();
            booksListBox.Visible = false;
         }
         
      } // end method OnInit
      	
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {    
         this.Load += new System.EventHandler(this.Page_Load);

      } // end method InitializeComponent
      #endregion

   } // end class RecommendationsPage

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