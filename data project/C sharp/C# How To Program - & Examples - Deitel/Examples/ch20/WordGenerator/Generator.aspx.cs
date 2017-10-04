// Fig. 20.22: Generator.aspx.cs
// The code-behind file for a page that
// generates words from a phone number.

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

namespace WordGenerator
{
   /// <summary>
   /// page that computes all combinations of letters for first
   /// three digits and last four digits in phone number
   /// </summary>
   public class Generator : System.Web.UI.Page
   {
      protected System.Web.UI.WebControls.TextBox outputTextBox;
      protected System.Web.UI.WebControls.TextBox inputTextBox;
      protected System.Web.UI.WebControls.RegularExpressionValidator phoneNumberValidator;
      protected System.Web.UI.WebControls.RequiredFieldValidator phoneInputValidator;
      protected System.Web.UI.WebControls.Button submitButton;
      protected System.Web.UI.WebControls.Label promptLabel;
   
      private void Page_Load(object sender, System.EventArgs e)
      {
         // if page loaded due to a postback
         if ( IsPostBack )
         {
            outputTextBox.Text = "";

            // retrieve number and remove "-"
            string number = Request.Form[ "inputTextBox" ];
            number = number.Remove( 3, 1 );

            // generate words for first 3 digits
            outputTextBox.Text +=
               "Here are the words for \nthe first three digits:\n\n";
            ComputeWords( number.Substring( 0, 3 ), "" );
            outputTextBox.Text += "\n";

            // generate words for last 4 digits
            outputTextBox.Text +=
               "Here are the words for \nthe first four digits:\n\n";
            ComputeWords( number.Substring( 3 ), "" );

            outputTextBox.Visible = true;

         } // end if

      } // end method Page_Load

      #region Web Form Designer generated code
      override protected void OnInit(EventArgs e)
      {
         //
         // CODEGEN: This call is required by the ASP.NET Web Form Designer.
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
         this.Load += new System.EventHandler(this.Page_Load);

      } // end method InitializeComponent
      #endregion

      private void ComputeWords( string number, string temporaryWord )
      {
         if ( number == "" )
         {
            outputTextBox.Text += temporaryWord + "\n";
            return;
         }

         int current = Int32.Parse( number.Substring( 0, 1 ) );

         number = number.Remove( 0, 1 );

         switch ( current )
         {
            // 0 can be q or z
            case 0: 
               ComputeWords( number, temporaryWord + "q" );
               ComputeWords( number, temporaryWord + "z" );
               break;

            // 1 has no letters associated with it
            case 1: 
               ComputeWords( number, temporaryWord + " " );
               break;

            // 2 can be a, b or c
            case 2: 
               ComputeWords( number, temporaryWord + "a" );
               ComputeWords( number, temporaryWord + "b" );
               ComputeWords( number, temporaryWord + "c" );
               break;

            // 3 can be d, e or f
            case 3: 
               ComputeWords( number, temporaryWord + "d" );
               ComputeWords( number, temporaryWord + "e" );
               ComputeWords( number, temporaryWord + "f" );
               break;

            // 4 can be g, h or i
            case 4: 
               ComputeWords( number, temporaryWord + "g" );
               ComputeWords( number, temporaryWord + "h" );
               ComputeWords( number, temporaryWord + "i" );
               break;

            // 5 can be j, k or l
            case 5: 
               ComputeWords( number, temporaryWord + "j" );
               ComputeWords( number, temporaryWord + "k" );
               ComputeWords( number, temporaryWord + "l" );
               break;

            // 6 can be m, n or o
            case 6: 
               ComputeWords( number, temporaryWord + "m" );
               ComputeWords( number, temporaryWord + "n" );
               ComputeWords( number, temporaryWord + "o" );
               break;

            // 7 can be p, r or s
            case 7: 
               ComputeWords( number, temporaryWord + "p" );
               ComputeWords( number, temporaryWord + "r" );
               ComputeWords( number, temporaryWord + "s" );
               break;

            // 8 can be t, u or v
            case 8: 
               ComputeWords( number, temporaryWord + "t" );
               ComputeWords( number, temporaryWord + "u" );
               ComputeWords( number, temporaryWord + "v" );
               break;

            // 9 can be w, x or y
            case 9: 
               ComputeWords( number, temporaryWord + "w" );
               ComputeWords( number, temporaryWord + "x" );
               ComputeWords( number, temporaryWord + "y" );
               break;

         } // end switch

      } // end method ComputeWords

   } // end class Generator

} // end WordGenerator

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
