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

namespace WebControls
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public class WebForm1 : System.Web.UI.Page
	{
      protected System.Web.UI.WebControls.Label welcomeLabel;
      protected System.Web.UI.WebControls.Image operatingImage;
      protected System.Web.UI.WebControls.Image publicationImage;
      protected System.Web.UI.WebControls.Image userImage;
      protected System.Web.UI.WebControls.TextBox emailTextBox;
      protected System.Web.UI.WebControls.TextBox firstTextBox;
      protected System.Web.UI.WebControls.TextBox lastTextBox;
      protected System.Web.UI.WebControls.TextBox phoneTextBox;
      protected System.Web.UI.WebControls.RadioButtonList operatingRadioButtonList;
      protected System.Web.UI.WebControls.HyperLink booksHyperLink;
      protected System.Web.UI.WebControls.DropDownList booksDropDownList;
      protected System.Web.UI.WebControls.Image phoneImage;
      protected System.Web.UI.WebControls.Image emailImage;
      protected System.Web.UI.WebControls.Image lastImage;
      protected System.Web.UI.WebControls.Image firstImage;
      protected System.Web.UI.WebControls.Button registerButton;
      protected System.Web.UI.WebControls.Label bookLabel;
      protected System.Web.UI.WebControls.Label fillLabel;
      protected System.Web.UI.WebControls.Label phoneLabel;
      protected System.Web.UI.WebControls.Label operatingLabel;
      protected System.Web.UI.WebControls.Label registerLabel;
   
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
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
         this.Load += new System.EventHandler(this.Page_Load);

      }
		#endregion
	}
}
