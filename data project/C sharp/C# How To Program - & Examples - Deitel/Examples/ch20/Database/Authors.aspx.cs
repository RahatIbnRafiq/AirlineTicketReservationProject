// Fig. 20.41: Authors.aspx.cs
// The code-behind file for a page that allows a user to chose an
// author and then view that author's books.

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

namespace Database
{
   /// <summary>
   /// Let user pick and author, then display that author's books
   /// </summary>
   public class Authors : System.Web.UI.Page
   {
      protected System.Web.UI.WebControls.DropDownList nameList;
      protected System.Web.UI.WebControls.Label Label2;
      protected System.Web.UI.WebControls.Button Button1;
      protected System.Web.UI.WebControls.Label Label3;
      protected System.Web.UI.WebControls.DataGrid dataGrid;

      protected System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
      protected System.Data.OleDb.OleDbConnection oleDbConnection1;
      protected System.Data.OleDb.OleDbDataReader dataReader;
   
      protected System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
      protected System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
      protected System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
      protected System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;

      protected System.Data.DataTable dataTable1 = new DataTable();
      protected System.Data.DataView dataView1;

      protected static string sortString = "Title";
   
      // on a page load
      private void Page_Load(object sender, System.EventArgs e)
      {
         // test if the page was loaded due to a post back
         if ( !IsPostBack )
         {
            // open database connection
            try 
            {
               oleDbConnection1.Open();
             
               // execute query
               dataReader = oleDbDataAdapter1.SelectCommand.ExecuteReader();

               // while we can read a row from the result of the 
               // query, add the first item to the dropdown list
               while ( dataReader.Read() )
                  nameList.Items.Add( dataReader.GetString( 0 ) + " " +
                     dataReader.GetString( 1 ) );
            }
               // if database cannot be found
            catch(System.Data.OleDb.OleDbException)
            {
               Label3.Text = "Server Error: Unable to load database!";
            
            }
            finally // close database connection 
            {
               oleDbConnection1.Close();
            }
         }
         else
         { 
            // set some controls to be invisible
            nameList.Visible = false;
            Button1.Visible = false;
            Label2.Visible = false;

            // set other controls to be visible
            Label3.Visible = true;
            dataGrid.Visible = true;

            // add the author name to the label
            Label3.Text = "You Chose " + nameList.SelectedItem + ".";
            int authorID = nameList.SelectedIndex + 1;
            
            try
            {
               // open database connection
               oleDbConnection1.Open();

               // grab the title, ISBN and publisher name for each book
               oleDbDataAdapter1.SelectCommand.CommandText = 
                  "SELECT Titles.Title, Titles.ISBN, " +
                  "Publishers.PublisherName FROM AuthorISBN " + 
                  "INNER JOIN Titles ON AuthorISBN.ISBN = " + 
                  "Titles.ISBN, Publishers WHERE " +
                  "(AuthorISBN.AuthorID = " + authorID + ")";
            
               // fill dataview with results
               oleDbDataAdapter1.Fill(dataTable1);
               dataView1 = new DataView( dataTable1 );
               dataView1.Sort = sortString;
               dataGrid.DataBind(); // bind grid to data source
            }
               // if database cannot be found
            catch(System.Data.OleDb.OleDbException)
            {
               Label3.Text = "Server Error: Unable to load database!";
            
            }
            finally // close database connection 
            {
               oleDbConnection1.Close();
            }
         }

      } // end method Page_Load

      // on a new page
      private void OnNewPage( object sender, 
         DataGridPageChangedEventArgs e )
      {
         // set current page to next page
         dataGrid.CurrentPageIndex = e.NewPageIndex;

         dataView1.Sort = sortString;
         dataGrid.DataBind(); // rebind data

      } // end method OnNewPage

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
         this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
         this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
         this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
         this.dataView1 = new System.Data.DataView();
         ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
         this.dataGrid.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.OnNewPage);
         this.dataGrid.SortCommand += new System.Web.UI.WebControls.DataGridSortCommandEventHandler(this.dataGrid_SortCommand);
         // 
         // oleDbDataAdapter1
         // 
         this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
         this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
         this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
         this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                    new System.Data.Common.DataTableMapping("Table", "Authors", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                              new System.Data.Common.DataColumnMapping("firstName", "firstName"),
                                                                                                                                                                                                              new System.Data.Common.DataColumnMapping("lastName", "lastName")})});
         this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
         // 
         // oleDbDeleteCommand1
         // 
         this.oleDbDeleteCommand1.CommandText = "DELETE FROM Authors WHERE (authorID = ?) AND (firstName = ? OR ? IS NULL AND firs" +
            "tName IS NULL) AND (lastName = ? OR ? IS NULL AND lastName IS NULL)";
         this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_authorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "authorID", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstName", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstName", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastName", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastName", System.Data.DataRowVersion.Original, null));
         // 
         // oleDbConnection1
         // 
         this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Inetpub\wwwroot\Database\Books.mdb;Mode=Read;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=0;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
         // 
         // oleDbInsertCommand1
         // 
         this.oleDbInsertCommand1.CommandText = "INSERT INTO Authors(firstName, lastName) VALUES (?, ?)";
         this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("firstName", System.Data.OleDb.OleDbType.VarWChar, 50, "firstName"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("lastName", System.Data.OleDb.OleDbType.VarWChar, 50, "lastName"));
         // 
         // oleDbSelectCommand1
         // 
         this.oleDbSelectCommand1.CommandText = "SELECT firstName, lastName, authorID FROM Authors";
         this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
         // 
         // oleDbUpdateCommand1
         // 
         this.oleDbUpdateCommand1.CommandText = "UPDATE Authors SET firstName = ?, lastName = ?, authorID = ? WHERE (authorID = ?)" +
            " AND (firstName = ? OR ? IS NULL AND firstName IS NULL) AND (lastName = ? OR ? I" +
            "S NULL AND lastName IS NULL)";
         this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("firstName", System.Data.OleDb.OleDbType.VarWChar, 50, "firstName"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("lastName", System.Data.OleDb.OleDbType.VarWChar, 50, "lastName"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("authorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "authorID", System.Data.DataRowVersion.Current, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_authorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "authorID", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstName", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstName", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastName", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastName", System.Data.DataRowVersion.Original, null));
         this.Load += new System.EventHandler(this.Page_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();

      }
		#endregion

      // handles Sort event
      private void dataGrid_SortCommand(object source, 
         System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
      {
         // get table to sort
         sortString = e.SortExpression.ToString();
         dataView1.Sort = sortString; // sort
         dataGrid.DataBind(); // rebind data

      } // end method dataGrid_SortCommand

   } // end class Authors

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