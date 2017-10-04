// Fig. 19.28: DisplayQueryResults.cs
// Displays the contents of the authors database.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DisplayQueryResults
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class DisplayQueryResults : System.Windows.Forms.Form
   {
      private System.Data.DataSet dataSet1;
      private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
      private System.Windows.Forms.TextBox queryTextBox;
      private System.Windows.Forms.Button submitButton;
      private System.Windows.Forms.DataGrid dataGrid1;
      private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
      private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
      private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
      private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
      private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
      private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
      private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
      private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
      private System.Data.OleDb.OleDbConnection oleDbConnection1;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public DisplayQueryResults()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();

         //
         // TODO: Add any constructor code after InitializeComponent call
         //
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if( disposing )
         {
            if (components != null) 
            {
               components.Dispose();
            }
         }
         base.Dispose( disposing );
      }

		#region Windows Form Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.dataSet1 = new System.Data.DataSet();
         this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
         this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
         this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
         this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
         this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
         this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
         this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
         this.queryTextBox = new System.Windows.Forms.TextBox();
         this.submitButton = new System.Windows.Forms.Button();
         this.dataGrid1 = new System.Windows.Forms.DataGrid();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
         this.SuspendLayout();
         // 
         // dataSet1
         // 
         this.dataSet1.DataSetName = "NewDataSet";
         this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
         // 
         // oleDbDataAdapter1
         // 
         this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand2;
         this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand2;
         this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand2;
         this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                    new System.Data.Common.DataTableMapping("Table", "Authors", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                              new System.Data.Common.DataColumnMapping("authorID", "authorID"),
                                                                                                                                                                                                              new System.Data.Common.DataColumnMapping("firstName", "firstName"),
                                                                                                                                                                                                              new System.Data.Common.DataColumnMapping("lastName", "lastName")})});
         this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand2;
         // 
         // oleDbDeleteCommand2
         // 
         this.oleDbDeleteCommand2.CommandText = "DELETE FROM Authors WHERE (authorID = ?) AND (firstName = ? OR ? IS NULL AND firs" +
            "tName IS NULL) AND (lastName = ? OR ? IS NULL AND lastName IS NULL)";
         this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_authorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "authorID", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstName", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstName", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastName", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastName", System.Data.DataRowVersion.Original, null));
         // 
         // oleDbConnection1
         // 
         this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Documents and Settings\lomeli\Desktop\Current Project\chapter19\ch19\Books.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
         //this.oleDbConnection1.InfoMessage += new System.Data.OleDb.OleDbInfoMessageEventHandler(this.oleDbConnection1_InfoMessage);
         // 
         // oleDbInsertCommand2
         // 
         this.oleDbInsertCommand2.CommandText = "INSERT INTO Authors(firstName, lastName) VALUES (?, ?)";
         this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
         this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("firstName", System.Data.OleDb.OleDbType.VarWChar, 50, "firstName"));
         this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("lastName", System.Data.OleDb.OleDbType.VarWChar, 50, "lastName"));
         // 
         // oleDbSelectCommand2
         // 
         this.oleDbSelectCommand2.CommandText = "SELECT authorID, firstName, lastName FROM Authors";
         this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
         // 
         // oleDbUpdateCommand2
         // 
         this.oleDbUpdateCommand2.CommandText = "UPDATE Authors SET firstName = ?, lastName = ? WHERE (authorID = ?) AND (firstNam" +
            "e = ? OR ? IS NULL AND firstName IS NULL) AND (lastName = ? OR ? IS NULL AND las" +
            "tName IS NULL)";
         this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("firstName", System.Data.OleDb.OleDbType.VarWChar, 50, "firstName"));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("lastName", System.Data.OleDb.OleDbType.VarWChar, 50, "lastName"));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_authorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "authorID", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstName", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstName", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastName", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastName", System.Data.DataRowVersion.Original, null));
         // 
         // oleDbDeleteCommand1
         // 
         this.oleDbDeleteCommand1.CommandText = "DELETE FROM Authors WHERE (authorID = ?) AND (firstName = ? OR ? IS NULL AND firs" +
            "tName IS NULL) AND (lastName = ? OR ? IS NULL AND lastName IS NULL)";
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_authorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "authorID", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstName", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstName", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastName", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastName", System.Data.DataRowVersion.Original, null));
         // 
         // oleDbInsertCommand1
         // 
         this.oleDbInsertCommand1.CommandText = "INSERT INTO Authors(firstName, lastName) VALUES (?, ?)";
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("firstName", System.Data.OleDb.OleDbType.VarWChar, 50, "firstName"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("lastName", System.Data.OleDb.OleDbType.VarWChar, 50, "lastName"));
         // 
         // oleDbSelectCommand1
         // 
         this.oleDbSelectCommand1.CommandText = "SELECT authorID, firstName, lastName FROM Authors";
         // 
         // oleDbUpdateCommand1
         // 
         this.oleDbUpdateCommand1.CommandText = "UPDATE Authors SET firstName = ?, lastName = ? WHERE (authorID = ?) AND (firstNam" +
            "e = ? OR ? IS NULL AND firstName IS NULL) AND (lastName = ? OR ? IS NULL AND las" +
            "tName IS NULL)";
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("firstName", System.Data.OleDb.OleDbType.VarWChar, 50, "firstName"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("lastName", System.Data.OleDb.OleDbType.VarWChar, 50, "lastName"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_authorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "authorID", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstName", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstName", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastName", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastName", System.Data.DataRowVersion.Original, null));
         // 
         // queryTextBox
         // 
         this.queryTextBox.Location = new System.Drawing.Point(8, 8);
         this.queryTextBox.Multiline = true;
         this.queryTextBox.Name = "queryTextBox";
         this.queryTextBox.Size = new System.Drawing.Size(312, 64);
         this.queryTextBox.TabIndex = 0;
         this.queryTextBox.Text = "";
         // 
         // submitButton
         // 
         this.submitButton.Location = new System.Drawing.Point(8, 80);
         this.submitButton.Name = "submitButton";
         this.submitButton.Size = new System.Drawing.Size(312, 24);
         this.submitButton.TabIndex = 1;
         this.submitButton.Text = "Submit Query";
         this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
         // 
         // dataGrid1
         // 
         this.dataGrid1.DataMember = "";
         this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
         this.dataGrid1.Location = new System.Drawing.Point(8, 112);
         this.dataGrid1.Name = "dataGrid1";
         this.dataGrid1.Size = new System.Drawing.Size(312, 184);
         this.dataGrid1.TabIndex = 2;
         // 
         // DisplayQueryResults
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(328, 301);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.dataGrid1,
                                                                      this.submitButton,
                                                                      this.queryTextBox});
         this.Name = "DisplayQueryResults";
         this.Text = "DisplayQueryResults";
         ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
         this.ResumeLayout(false);

      }   // end of InitializeComponent
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new DisplayQueryResults());
      }

      // perform SQL query on data
      private void submitButton_Click(object sender, System.EventArgs e)
      {
         try
         {
            // set the text of the SQL query to what the user typed
            // in
            oleDbDataAdapter1.SelectCommand.CommandText =
               queryTextBox.Text;

            // clear the DataSet from the previous operation
            dataSet1.Clear();

            // Fill the data set with the information that results
            // from the SQL query
            oleDbDataAdapter1.Fill( dataSet1, "Authors" );

            // Bind the DataGrid to the contents of the DatSet
            dataGrid1.SetDataBinding( dataSet1, "Authors" );
         }
      
         catch ( System.Data.OleDb.OleDbException oleException )
         {
            MessageBox.Show( "Invalid query" );
         }
      
      }

   }
}

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

