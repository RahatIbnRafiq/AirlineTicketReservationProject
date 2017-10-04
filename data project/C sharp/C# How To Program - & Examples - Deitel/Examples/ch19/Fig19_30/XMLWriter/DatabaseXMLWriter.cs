// Fig. 19.30 XMLWriter.cs
// Demonstrates generating XML from an ADO.NET DataSet

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WritingXML
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class DatabaseXMLWriter : System.Windows.Forms.Form
   {
      private System.Data.OleDb.OleDbDataAdapter playersDataAdapter;
      private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
      private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
      private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
      private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
      private System.Data.DataSet playersDataSet;
      private System.Windows.Forms.DataGrid playersDataGrid;
      private System.Windows.Forms.Button writeButton;
      private System.Windows.Forms.TextBox outputTextBox;
      private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
      private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
      private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
      private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
      private System.Data.OleDb.OleDbConnection baseballConnection;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public DatabaseXMLWriter()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();

         // open database connection
         baseballConnection.Open();

         // fill DataSet with data from OleDbDataAdapter
         playersDataAdapter.Fill( playersDataSet, "Players" );

         // bind DataGrid to DataSet
         playersDataGrid.SetDataBinding( playersDataSet, "Players" );

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
         this.playersDataAdapter = new System.Data.OleDb.OleDbDataAdapter();
         this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
         this.playersDataSet = new System.Data.DataSet();
         this.playersDataGrid = new System.Windows.Forms.DataGrid();
         this.writeButton = new System.Windows.Forms.Button();
         this.outputTextBox = new System.Windows.Forms.TextBox();
         this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
         this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
         this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
         this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
         this.baseballConnection = new System.Data.OleDb.OleDbConnection();
         ((System.ComponentModel.ISupportInitialize)(this.playersDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.playersDataGrid)).BeginInit();
         this.SuspendLayout();
         // 
         // playersDataAdapter
         // 
         this.playersDataAdapter.DeleteCommand = this.oleDbDeleteCommand2;
         this.playersDataAdapter.InsertCommand = this.oleDbInsertCommand2;
         this.playersDataAdapter.SelectCommand = this.oleDbSelectCommand2;
         this.playersDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                     new System.Data.Common.DataTableMapping("Table", "Players", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                               new System.Data.Common.DataColumnMapping("firstName", "firstName"),
                                                                                                                                                                                                               new System.Data.Common.DataColumnMapping("lastName", "lastName"),
                                                                                                                                                                                                               new System.Data.Common.DataColumnMapping("battingAverage", "battingAverage"),
                                                                                                                                                                                                               new System.Data.Common.DataColumnMapping("playerID", "playerID")})});
         this.playersDataAdapter.UpdateCommand = this.oleDbUpdateCommand2;
         // 
         // oleDbDeleteCommand1
         // 
         this.oleDbDeleteCommand1.CommandText = "DELETE FROM Players WHERE (playerID = ?) AND (battingAverage = ? OR ? IS NULL AND" +
            " battingAverage IS NULL) AND (firstName = ? OR ? IS NULL AND firstName IS NULL) " +
            "AND (lastName = ? OR ? IS NULL AND lastName IS NULL)";
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_playerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "playerID", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_battingAverage", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "battingAverage", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_battingAverage1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "battingAverage", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstName", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstName", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastName", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastName", System.Data.DataRowVersion.Original, null));
         // 
         // oleDbInsertCommand1
         // 
         this.oleDbInsertCommand1.CommandText = "INSERT INTO Players(firstName, lastName, battingAverage) VALUES (?, ?, ?)";
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("firstName", System.Data.OleDb.OleDbType.VarWChar, 50, "firstName"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("lastName", System.Data.OleDb.OleDbType.VarWChar, 50, "lastName"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("battingAverage", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "battingAverage", System.Data.DataRowVersion.Current, null));
         // 
         // oleDbSelectCommand1
         // 
         this.oleDbSelectCommand1.CommandText = "SELECT firstName, lastName, battingAverage, playerID FROM Players";
         // 
         // oleDbUpdateCommand1
         // 
         this.oleDbUpdateCommand1.CommandText = @"UPDATE Players SET firstName = ?, lastName = ?, battingAverage = ?, playerID = ? WHERE (playerID = ?) AND (battingAverage = ? OR ? IS NULL AND battingAverage IS NULL) AND (firstName = ? OR ? IS NULL AND firstName IS NULL) AND (lastName = ? OR ? IS NULL AND lastName IS NULL)";
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("firstName", System.Data.OleDb.OleDbType.VarWChar, 50, "firstName"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("lastName", System.Data.OleDb.OleDbType.VarWChar, 50, "lastName"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("battingAverage", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "battingAverage", System.Data.DataRowVersion.Current, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("playerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "playerID", System.Data.DataRowVersion.Current, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_playerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "playerID", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_battingAverage", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "battingAverage", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_battingAverage1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "battingAverage", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstName", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstName", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastName", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastName", System.Data.DataRowVersion.Original, null));
         // 
         // playersDataSet
         // 
         this.playersDataSet.DataSetName = "NewDataSet";
         this.playersDataSet.Locale = new System.Globalization.CultureInfo("en-US");
         // 
         // playersDataGrid
         // 
         this.playersDataGrid.DataMember = "";
         this.playersDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
         this.playersDataGrid.Location = new System.Drawing.Point(8, 40);
         this.playersDataGrid.Name = "playersDataGrid";
         this.playersDataGrid.Size = new System.Drawing.Size(312, 168);
         this.playersDataGrid.TabIndex = 0;
         // 
         // writeButton
         // 
         this.writeButton.Location = new System.Drawing.Point(60, 8);
         this.writeButton.Name = "writeButton";
         this.writeButton.Size = new System.Drawing.Size(208, 24);
         this.writeButton.TabIndex = 1;
         this.writeButton.Text = "Write to XML";
         this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
         // 
         // outputTextBox
         // 
         this.outputTextBox.BackColor = System.Drawing.SystemColors.Window;
         this.outputTextBox.Location = new System.Drawing.Point(8, 216);
         this.outputTextBox.Multiline = true;
         this.outputTextBox.Name = "outputTextBox";
         this.outputTextBox.ReadOnly = true;
         this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.outputTextBox.Size = new System.Drawing.Size(312, 96);
         this.outputTextBox.TabIndex = 2;
         this.outputTextBox.Text = "";
         // 
         // oleDbSelectCommand2
         // 
         this.oleDbSelectCommand2.CommandText = "SELECT firstName, lastName, battingAverage, playerID FROM Players";
         this.oleDbSelectCommand2.Connection = this.baseballConnection;
         // 
         // oleDbInsertCommand2
         // 
         this.oleDbInsertCommand2.CommandText = "INSERT INTO Players(firstName, lastName, battingAverage) VALUES (?, ?, ?)";
         this.oleDbInsertCommand2.Connection = this.baseballConnection;
         this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("firstName", System.Data.OleDb.OleDbType.VarWChar, 50, "firstName"));
         this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("lastName", System.Data.OleDb.OleDbType.VarWChar, 50, "lastName"));
         this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("battingAverage", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "battingAverage", System.Data.DataRowVersion.Current, null));
         // 
         // oleDbUpdateCommand2
         // 
         this.oleDbUpdateCommand2.CommandText = @"UPDATE Players SET firstName = ?, lastName = ?, battingAverage = ? WHERE (playerID = ?) AND (battingAverage = ? OR ? IS NULL AND battingAverage IS NULL) AND (firstName = ? OR ? IS NULL AND firstName IS NULL) AND (lastName = ? OR ? IS NULL AND lastName IS NULL)";
         this.oleDbUpdateCommand2.Connection = this.baseballConnection;
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("firstName", System.Data.OleDb.OleDbType.VarWChar, 50, "firstName"));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("lastName", System.Data.OleDb.OleDbType.VarWChar, 50, "lastName"));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("battingAverage", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "battingAverage", System.Data.DataRowVersion.Current, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_playerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "playerID", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_battingAverage", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "battingAverage", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_battingAverage1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "battingAverage", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstName", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstName", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastName", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastName", System.Data.DataRowVersion.Original, null));
         // 
         // oleDbDeleteCommand2
         // 
         this.oleDbDeleteCommand2.CommandText = "DELETE FROM Players WHERE (playerID = ?) AND (battingAverage = ? OR ? IS NULL AND" +
            " battingAverage IS NULL) AND (firstName = ? OR ? IS NULL AND firstName IS NULL) " +
            "AND (lastName = ? OR ? IS NULL AND lastName IS NULL)";
         this.oleDbDeleteCommand2.Connection = this.baseballConnection;
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_playerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "playerID", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_battingAverage", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "battingAverage", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_battingAverage1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "battingAverage", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstName", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstName", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastName", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastName", System.Data.DataRowVersion.Original, null));
         // 
         // baseballConnection
         // 
         this.baseballConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\books\2001\csphtp1\csphtp1_examples\ch19\Fig19_30\XMLWriter\Baseball.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=0;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
         // 
         // XMLWriter
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(328, 325);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.outputTextBox,
                                                                      this.writeButton,
                                                                      this.playersDataGrid});
         this.Name = "XMLWriter";
         this.Text = "XMLWriter";
         ((System.ComponentModel.ISupportInitialize)(this.playersDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.playersDataGrid)).EndInit();
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new DatabaseXMLWriter());
      }

      // write XML representation of DataSet when button clicked
      private void writeButton_Click(object sender, System.EventArgs e)
      {
         // write XML representation of DataSet to file
         playersDataSet.WriteXml( "Players.xml" );

         // display XML in TextBox
         outputTextBox.Text += "Writing the following XML:\n\n" +
            playersDataSet.GetXml() + "\n\n";

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