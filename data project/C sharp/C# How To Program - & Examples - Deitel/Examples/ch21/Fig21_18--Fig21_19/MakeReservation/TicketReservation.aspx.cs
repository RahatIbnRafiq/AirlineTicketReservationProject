// Fig. 21.19: TicketReservation.aspx.cs
// Making a Reservation using a Web Service.

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

namespace MakeReservation
{
   // allows visitors to select seat type to reserve, and
   // then make reservation
   public class TicketReservation : System.Web.UI.Page
   {
      protected System.Web.UI.WebControls.DropDownList 
         seatList;
      protected System.Web.UI.WebControls.DropDownList 
         classList;

      protected System.Web.UI.WebControls.Button 
         reserveButton;
      protected System.Web.UI.WebControls.Label Label1;

      private localhost.Reservation agent =
         new localhost.Reservation();

      private void Page_Load( 
         object sender, System.EventArgs e )
      {
         if ( IsPostBack )
         {
            seatList.Visible = false;
            classList.Visible = false;
            reserveButton.Visible = false;
            Label1.Visible = false;
         }
      }

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
         this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
         this.Load += new System.EventHandler(this.Page_Load);

      }
		#endregion

      // calls Web Service to try to reserve specified seat
      public void reserveButton_Click ( 
         object sender, System.EventArgs e )
      {        
         // if Web-service method returned true, signal success
         if ( agent.Reserve( seatList.SelectedItem.Text, 
            classList.SelectedItem.Text ) )
            Response.Write( "Your reservation has been made." 
               + "  Thank you." );

            // Web-service method returned false, so signal failure
         else
            Response.Write( "This seat is not available, " +
               "please hit the back button on your browser " +
               "and try again." );

      } // end method reserveButton_Click

   } // end class TicketReservation

} // end namespace MakeReservation


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