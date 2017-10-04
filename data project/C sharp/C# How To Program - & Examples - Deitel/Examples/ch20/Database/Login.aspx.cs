// Fig. 20.39: Login.aspx.cs
// The code-behind file for the page that logs the user in.

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
using System.Web.Security;

namespace Database
{
   /// <summary>
   /// allows users to log in
   /// </summary>
   public class Login : System.Web.UI.Page
   {
      protected System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
      protected System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
      protected System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
      protected System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
      protected System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
      protected System.Data.OleDb.OleDbConnection oleDbConnection1;

      protected System.Web.UI.WebControls.Label passwordLabel;
      protected System.Web.UI.WebControls.Label nameLabel;
      protected System.Web.UI.WebControls.Label promptLabel;
      protected System.Web.UI.WebControls.DropDownList nameList;
      protected System.Web.UI.WebControls.Button submitButton;
      protected System.Web.UI.WebControls.RequiredFieldValidator requiredPasswordValidator;
      protected System.Web.UI.WebControls.CustomValidator invalidPasswordValidator;
      protected System.Web.UI.WebControls.TextBox passwordTextBox;

      protected System.Data.OleDb.OleDbDataReader dataReader;
   
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

         // if page loads due to postback, process information
         // otherwise, the page is loading for the first time, so
         // do nothing
         if ( !IsPostBack )
         {
            // open database connection
            oleDbConnection1.Open();

            // execute query
            dataReader = 
               oleDbDataAdapter1.SelectCommand.ExecuteReader();

            // while we can read a row from query result,
            // add first item to drop-down list
            while ( dataReader.Read() )
               nameList.Items.Add( dataReader.GetString( 0 ) );

            // close database connection
            oleDbConnection1.Close();
         }

      } // end method OnInit
		
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {    
         this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
         this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
         this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
         this.invalidPasswordValidator.ServerValidate += new System.Web.UI.WebControls.ServerValidateEventHandler(this.invalidPasswordValidator_ServerValidate);
         // 
         // oleDbDataAdapter1
         // 
         this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
         this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
         this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
         this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                    new System.Data.Common.DataTableMapping("Table", "Users", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                            new System.Data.Common.DataColumnMapping("loginID", "loginID")})});
         this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
         // 
         // oleDbDeleteCommand1
         // 
         this.oleDbDeleteCommand1.CommandText = "DELETE FROM Users WHERE (loginID = ?)";
         this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_loginID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "loginID", System.Data.DataRowVersion.Original, null));
         // 
         // oleDbConnection1
         // 
         this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Inetpub\wwwroot\Database\login.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
         // 
         // oleDbInsertCommand1
         // 
         this.oleDbInsertCommand1.CommandText = "INSERT INTO Users(loginID) VALUES (?)";
         this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("loginID", System.Data.OleDb.OleDbType.VarWChar, 50, "loginID"));
         // 
         // oleDbSelectCommand1
         // 
         this.oleDbSelectCommand1.CommandText = "SELECT loginID FROM Users";
         this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
         // 
         // oleDbUpdateCommand1
         // 
         this.oleDbUpdateCommand1.CommandText = "UPDATE Users SET loginID = ? WHERE (loginID = ?)";
         this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("loginID", System.Data.OleDb.OleDbType.VarWChar, 50, "loginID"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_loginID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "loginID", System.Data.DataRowVersion.Original, null));
         this.Load += new System.EventHandler(this.Page_Load);

      }
		#endregion

      // validate user name and password
      private void invalidPasswordValidator_ServerValidate(
         object source, 
         System.Web.UI.WebControls.ServerValidateEventArgs args )
      {
         // open database connection
         oleDbConnection1.Open();

         // set select command to find password of username from drop-down list
         oleDbDataAdapter1.SelectCommand.CommandText =
            "SELECT * FROM Users WHERE loginID = '" +
            Request.Form[ "nameList" ].ToString() + "'";

         dataReader =
            oleDbDataAdapter1.SelectCommand.ExecuteReader();

         dataReader.Read();

         // if password user provided is correct create an
         // authentication ticket for this user and redirect
         // user to Authors.aspx; otherwise set IsValid to false
         if ( args.Value == dataReader.GetString( 1 ) )
         {
            FormsAuthentication.SetAuthCookie(
               Request.Form[ "namelist" ], false );
            Session.Add(
               "name", Request.Form[ "nameList" ].ToString() );
            Response.Redirect( "Authors.aspx" );
         }
         else
            args.IsValid = false;

         // close database connection
         oleDbConnection1.Close();

      } // end method invalidPasswordValidator_ServerValidate

   } // end class Login

} // end namespace Database

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
