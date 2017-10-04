// Fig. 20.33: RecommendationsPage.aspx
// Reading session data from the user.

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
   /// page displaying session information and recommendations
   /// </summary>
   public class RecommendationsPage : System.Web.UI.Page
   {
      protected System.Web.UI.WebControls.ListBox booksListBox;
      
      protected System.Web.UI.WebControls.Label 
         recommendationsLabel;

      // event handler for load event
      private void Page_Load(
         object sender, System.EventArgs e )
      {
         // Put user code to initialize the page here

      } // end method Page_Load

      // event handler for Init event
      #region Web Form Designer generated code
      override protected void OnInit( EventArgs e )
      {
         //
         // CODEGEN: This call is required
         // by the ASP.NET Web Form Designer.
         //
         InitializeComponent();
         base.OnInit( e );

         // determine if Session contains information
         if ( Session != null )
         {
            // iterate through Session values,
            // display in ListBox
            for ( int i = 0; i < Session.Count; i++ )
            {
               // store current key in sessionName
               string keyName = Session.Keys[ i ];

               // use current key to display
               // Session's name/value pairs
               booksListBox.Items.Add( keyName +
                  " How to Program. ISBN#: " +
                  Session[ keyName ] );

            } // end for

         }
         else
         {
            recommendationsLabel.Text = "No Recommendations";
            booksListBox.Visible = false;
         }

      } // end method OnInit

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {    
         this.Load += new System.EventHandler(
            this.Page_Load );

      } // end method InitializeComponent

      #endregion

   } // end class RecommendationsPage

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