// Fig. 20.19: AdRotator.aspx.cs
// The code-behind file for a page that
// demonstrates the AdRotator class.

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

namespace AdRotatorTest
{
   /// <summary>
   /// page that demonstrates AdRotator
   /// </summary>
   public class AdRotator : System.Web.UI.Page
   {
      protected System.Web.UI.WebControls.AdRotator adRotator;
      protected System.Web.UI.WebControls.Label adRotatorLabel;
   
      private void Page_Load( object sender, System.EventArgs e )
      {
         // Put user code to initialize the page here
      }

      #region Web Form Designer generated code
      override protected void OnInit( EventArgs e )
      {
         //
         // CODEGEN: This call is required by the ASP.NET Web Form Designer.
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
         this.Load += new System.EventHandler( this.Page_Load );

      }
      #endregion

   } // end class AdRotator

} // end namespace AdRotatorTest

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