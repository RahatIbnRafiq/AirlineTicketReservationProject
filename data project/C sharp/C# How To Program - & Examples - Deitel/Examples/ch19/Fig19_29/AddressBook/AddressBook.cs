// Fig. 19.29: AddressBook.cs
// Using SQL statements to manipulate a database.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace AddressBook
{
   /// <summary>
   /// Summary description for AddressBook.
   /// </summary>
   public class AddressBook : System.Windows.Forms.Form
   {
      private System.Windows.Forms.TextBox faxTextBox;
      private System.Windows.Forms.TextBox homeTextBox;
      private System.Windows.Forms.TextBox firstTextBox;
      private System.Windows.Forms.TextBox stateTextBox;
      private System.Windows.Forms.TextBox idTextBox;
      private System.Windows.Forms.TextBox lastTextBox;
      private System.Windows.Forms.TextBox postalTextBox;
      private System.Windows.Forms.TextBox addressTextBox;
      private System.Windows.Forms.TextBox cityTextBox;
      private System.Windows.Forms.TextBox countryTextBox;
      private System.Windows.Forms.TextBox emailTextBox;
      private System.Data.DataSet dataSet1;
      private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
      private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
      private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
      private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
      private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
      private System.Windows.Forms.TextBox statusTextBox;
      private System.Windows.Forms.Label addressLabel;
      private System.Windows.Forms.Label cityLabel;
      private System.Windows.Forms.Label stateLabel;
      private System.Windows.Forms.Label idLabel;
      private System.Windows.Forms.Label firstLabel;
      private System.Windows.Forms.Label lastLabel;
      private System.Windows.Forms.Label postalLabel;
      private System.Windows.Forms.Label countryLabel;
      private System.Windows.Forms.Label emailLabel;
      private System.Windows.Forms.Button clearButton;
      private System.Windows.Forms.Button helpButton;
      private System.Windows.Forms.Button findButton;
      private System.Windows.Forms.Button addButton;
      private System.Windows.Forms.Button updateButton;
      private System.Windows.Forms.Label faxLabel;
      private System.Windows.Forms.Label homeLabel;
      private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
      private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
      private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
      private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
      private System.Data.OleDb.OleDbConnection oleDbConnection1;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public AddressBook()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();

         //
         // TODO: Add any constructor code after InitializeComponent call
         //
         oleDbConnection1.Open();
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
         this.countryLabel = new System.Windows.Forms.Label();
         this.emailLabel = new System.Windows.Forms.Label();
         this.addressLabel = new System.Windows.Forms.Label();
         this.cityLabel = new System.Windows.Forms.Label();
         this.stateLabel = new System.Windows.Forms.Label();
         this.faxTextBox = new System.Windows.Forms.TextBox();
         this.homeTextBox = new System.Windows.Forms.TextBox();
         this.idLabel = new System.Windows.Forms.Label();
         this.firstLabel = new System.Windows.Forms.Label();
         this.lastLabel = new System.Windows.Forms.Label();
         this.firstTextBox = new System.Windows.Forms.TextBox();
         this.stateTextBox = new System.Windows.Forms.TextBox();
         this.clearButton = new System.Windows.Forms.Button();
         this.helpButton = new System.Windows.Forms.Button();
         this.idTextBox = new System.Windows.Forms.TextBox();
         this.lastTextBox = new System.Windows.Forms.TextBox();
         this.findButton = new System.Windows.Forms.Button();
         this.addButton = new System.Windows.Forms.Button();
         this.updateButton = new System.Windows.Forms.Button();
         this.postalTextBox = new System.Windows.Forms.TextBox();
         this.addressTextBox = new System.Windows.Forms.TextBox();
         this.cityTextBox = new System.Windows.Forms.TextBox();
         this.postalLabel = new System.Windows.Forms.Label();
         this.countryTextBox = new System.Windows.Forms.TextBox();
         this.emailTextBox = new System.Windows.Forms.TextBox();
         this.faxLabel = new System.Windows.Forms.Label();
         this.homeLabel = new System.Windows.Forms.Label();
         this.statusTextBox = new System.Windows.Forms.TextBox();
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
         ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
         this.SuspendLayout();
         // 
         // countryLabel
         // 
         this.countryLabel.Location = new System.Drawing.Point(16, 264);
         this.countryLabel.Name = "countryLabel";
         this.countryLabel.Size = new System.Drawing.Size(152, 16);
         this.countryLabel.TabIndex = 6;
         this.countryLabel.Text = "Country:";
         this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // emailLabel
         // 
         this.emailLabel.Location = new System.Drawing.Point(16, 296);
         this.emailLabel.Name = "emailLabel";
         this.emailLabel.Size = new System.Drawing.Size(152, 16);
         this.emailLabel.TabIndex = 6;
         this.emailLabel.Text = "Email:";
         this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // addressLabel
         // 
         this.addressLabel.Location = new System.Drawing.Point(16, 136);
         this.addressLabel.Name = "addressLabel";
         this.addressLabel.Size = new System.Drawing.Size(152, 16);
         this.addressLabel.TabIndex = 6;
         this.addressLabel.Text = "Address:";
         this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // cityLabel
         // 
         this.cityLabel.Location = new System.Drawing.Point(16, 168);
         this.cityLabel.Name = "cityLabel";
         this.cityLabel.Size = new System.Drawing.Size(152, 16);
         this.cityLabel.TabIndex = 6;
         this.cityLabel.Text = "City:";
         this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // stateLabel
         // 
         this.stateLabel.Location = new System.Drawing.Point(16, 200);
         this.stateLabel.Name = "stateLabel";
         this.stateLabel.Size = new System.Drawing.Size(152, 16);
         this.stateLabel.TabIndex = 6;
         this.stateLabel.Text = "State/Province:";
         this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // faxTextBox
         // 
         this.faxTextBox.Location = new System.Drawing.Point(184, 360);
         this.faxTextBox.Name = "faxTextBox";
         this.faxTextBox.Size = new System.Drawing.Size(176, 20);
         this.faxTextBox.TabIndex = 5;
         this.faxTextBox.Text = "";
         // 
         // homeTextBox
         // 
         this.homeTextBox.Location = new System.Drawing.Point(184, 328);
         this.homeTextBox.Name = "homeTextBox";
         this.homeTextBox.Size = new System.Drawing.Size(176, 20);
         this.homeTextBox.TabIndex = 5;
         this.homeTextBox.Text = "";
         // 
         // idLabel
         // 
         this.idLabel.Location = new System.Drawing.Point(16, 40);
         this.idLabel.Name = "idLabel";
         this.idLabel.Size = new System.Drawing.Size(152, 16);
         this.idLabel.TabIndex = 6;
         this.idLabel.Text = "ID Number:";
         this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // firstLabel
         // 
         this.firstLabel.Location = new System.Drawing.Point(16, 72);
         this.firstLabel.Name = "firstLabel";
         this.firstLabel.Size = new System.Drawing.Size(152, 16);
         this.firstLabel.TabIndex = 6;
         this.firstLabel.Text = "First name:";
         this.firstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // lastLabel
         // 
         this.lastLabel.Location = new System.Drawing.Point(16, 104);
         this.lastLabel.Name = "lastLabel";
         this.lastLabel.Size = new System.Drawing.Size(152, 16);
         this.lastLabel.TabIndex = 6;
         this.lastLabel.Text = "Last Name:";
         this.lastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // firstTextBox
         // 
         this.firstTextBox.Location = new System.Drawing.Point(184, 72);
         this.firstTextBox.Name = "firstTextBox";
         this.firstTextBox.Size = new System.Drawing.Size(176, 20);
         this.firstTextBox.TabIndex = 5;
         this.firstTextBox.Text = "";
         // 
         // stateTextBox
         // 
         this.stateTextBox.Location = new System.Drawing.Point(184, 200);
         this.stateTextBox.Name = "stateTextBox";
         this.stateTextBox.Size = new System.Drawing.Size(176, 20);
         this.stateTextBox.TabIndex = 5;
         this.stateTextBox.Text = "";
         // 
         // clearButton
         // 
         this.clearButton.Location = new System.Drawing.Point(224, 0);
         this.clearButton.Name = "clearButton";
         this.clearButton.Size = new System.Drawing.Size(80, 24);
         this.clearButton.TabIndex = 3;
         this.clearButton.Text = "Clear";
         this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
         // 
         // helpButton
         // 
         this.helpButton.Location = new System.Drawing.Point(304, 0);
         this.helpButton.Name = "helpButton";
         this.helpButton.Size = new System.Drawing.Size(80, 24);
         this.helpButton.TabIndex = 4;
         this.helpButton.Text = "Help";
         this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
         // 
         // idTextBox
         // 
         this.idTextBox.Location = new System.Drawing.Point(184, 40);
         this.idTextBox.Name = "idTextBox";
         this.idTextBox.ReadOnly = true;
         this.idTextBox.Size = new System.Drawing.Size(176, 20);
         this.idTextBox.TabIndex = 5;
         this.idTextBox.Text = "";
         // 
         // lastTextBox
         // 
         this.lastTextBox.Location = new System.Drawing.Point(184, 104);
         this.lastTextBox.Name = "lastTextBox";
         this.lastTextBox.Size = new System.Drawing.Size(176, 20);
         this.lastTextBox.TabIndex = 5;
         this.lastTextBox.Text = "";
         // 
         // findButton
         // 
         this.findButton.Name = "findButton";
         this.findButton.Size = new System.Drawing.Size(72, 24);
         this.findButton.TabIndex = 0;
         this.findButton.Text = "Find";
         this.findButton.Click += new System.EventHandler(this.findButton_Click);
         // 
         // addButton
         // 
         this.addButton.Location = new System.Drawing.Point(72, 0);
         this.addButton.Name = "addButton";
         this.addButton.Size = new System.Drawing.Size(80, 24);
         this.addButton.TabIndex = 1;
         this.addButton.Text = "Add";
         this.addButton.Click += new System.EventHandler(this.addButton_Click);
         // 
         // updateButton
         // 
         this.updateButton.Location = new System.Drawing.Point(152, 0);
         this.updateButton.Name = "updateButton";
         this.updateButton.Size = new System.Drawing.Size(72, 24);
         this.updateButton.TabIndex = 2;
         this.updateButton.Text = "Update";
         this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
         // 
         // postalTextBox
         // 
         this.postalTextBox.Location = new System.Drawing.Point(184, 232);
         this.postalTextBox.Name = "postalTextBox";
         this.postalTextBox.Size = new System.Drawing.Size(176, 20);
         this.postalTextBox.TabIndex = 5;
         this.postalTextBox.Text = "";
         // 
         // addressTextBox
         // 
         this.addressTextBox.Location = new System.Drawing.Point(184, 136);
         this.addressTextBox.Name = "addressTextBox";
         this.addressTextBox.Size = new System.Drawing.Size(176, 20);
         this.addressTextBox.TabIndex = 5;
         this.addressTextBox.Text = "";
         // 
         // cityTextBox
         // 
         this.cityTextBox.Location = new System.Drawing.Point(184, 168);
         this.cityTextBox.Name = "cityTextBox";
         this.cityTextBox.Size = new System.Drawing.Size(176, 20);
         this.cityTextBox.TabIndex = 5;
         this.cityTextBox.Text = "";
         // 
         // postalLabel
         // 
         this.postalLabel.Location = new System.Drawing.Point(16, 232);
         this.postalLabel.Name = "postalLabel";
         this.postalLabel.Size = new System.Drawing.Size(152, 16);
         this.postalLabel.TabIndex = 6;
         this.postalLabel.Text = "Postal Code:";
         this.postalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // countryTextBox
         // 
         this.countryTextBox.Location = new System.Drawing.Point(184, 264);
         this.countryTextBox.Name = "countryTextBox";
         this.countryTextBox.Size = new System.Drawing.Size(176, 20);
         this.countryTextBox.TabIndex = 5;
         this.countryTextBox.Text = "";
         // 
         // emailTextBox
         // 
         this.emailTextBox.Location = new System.Drawing.Point(184, 296);
         this.emailTextBox.Name = "emailTextBox";
         this.emailTextBox.Size = new System.Drawing.Size(176, 20);
         this.emailTextBox.TabIndex = 5;
         this.emailTextBox.Text = "";
         // 
         // faxLabel
         // 
         this.faxLabel.Location = new System.Drawing.Point(16, 360);
         this.faxLabel.Name = "faxLabel";
         this.faxLabel.Size = new System.Drawing.Size(152, 16);
         this.faxLabel.TabIndex = 6;
         this.faxLabel.Text = "Fax Number:";
         this.faxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // homeLabel
         // 
         this.homeLabel.Location = new System.Drawing.Point(16, 328);
         this.homeLabel.Name = "homeLabel";
         this.homeLabel.Size = new System.Drawing.Size(152, 16);
         this.homeLabel.TabIndex = 6;
         this.homeLabel.Text = "Home Phone:";
         this.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // statusTextBox
         // 
         this.statusTextBox.Location = new System.Drawing.Point(16, 400);
         this.statusTextBox.Multiline = true;
         this.statusTextBox.Name = "statusTextBox";
         this.statusTextBox.ReadOnly = true;
         this.statusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.statusTextBox.Size = new System.Drawing.Size(344, 120);
         this.statusTextBox.TabIndex = 7;
         this.statusTextBox.Text = "";
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
                                                                                                    new System.Data.Common.DataTableMapping("Table", "addresses", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("address", "address"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("city", "city"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("country", "country"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("emailaddress", "emailaddress"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("faxnumber", "faxnumber"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("firstname", "firstname"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("homephone", "homephone"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("id", "id"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("lastname", "lastname"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("postalcode", "postalcode"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("stateorprovince", "stateorprovince")})});
         this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand2;
         // 
         // oleDbDeleteCommand2
         // 
         this.oleDbDeleteCommand2.CommandText = @"DELETE FROM addresses WHERE (id = ?) AND (address = ? OR ? IS NULL AND address IS NULL) AND (city = ? OR ? IS NULL AND city IS NULL) AND (country = ? OR ? IS NULL AND country IS NULL) AND (emailaddress = ? OR ? IS NULL AND emailaddress IS NULL) AND (faxnumber = ? OR ? IS NULL AND faxnumber IS NULL) AND (firstname = ? OR ? IS NULL AND firstname IS NULL) AND (homephone = ? OR ? IS NULL AND homephone IS NULL) AND (lastname = ? OR ? IS NULL AND lastname IS NULL) AND (postalcode = ? OR ? IS NULL AND postalcode IS NULL) AND (stateorprovince = ? OR ? IS NULL AND stateorprovince IS NULL)";
         this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "address", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "address", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_city", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "city", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_city1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "city", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_country", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "country", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_country1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "country", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_emailaddress", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "emailaddress", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_emailaddress1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "emailaddress", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_faxnumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "faxnumber", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_faxnumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "faxnumber", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstname", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstname", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstname1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstname", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_homephone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "homephone", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_homephone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "homephone", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastname", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastname", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastname1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastname", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_postalcode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "postalcode", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_postalcode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "postalcode", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_stateorprovince", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "stateorprovince", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_stateorprovince1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "stateorprovince", System.Data.DataRowVersion.Original, null));
         // 
         // oleDbConnection1
         // 
         this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Documents and Settings\lomeli\Desktop\Current Project\chapter19\ch19\Fig19_29\AddressBook\AddressBook.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
         // 
         // oleDbInsertCommand2
         // 
         this.oleDbInsertCommand2.CommandText = "INSERT INTO addresses(address, city, country, emailaddress, faxnumber, firstname," +
            " homephone, lastname, postalcode, stateorprovince) VALUES (?, ?, ?, ?, ?, ?, ?, " +
            "?, ?, ?)";
         this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
         this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("address", System.Data.OleDb.OleDbType.VarWChar, 50, "address"));
         this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("city", System.Data.OleDb.OleDbType.VarWChar, 50, "city"));
         this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("country", System.Data.OleDb.OleDbType.VarWChar, 50, "country"));
         this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("emailaddress", System.Data.OleDb.OleDbType.VarWChar, 50, "emailaddress"));
         this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("faxnumber", System.Data.OleDb.OleDbType.VarWChar, 50, "faxnumber"));
         this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("firstname", System.Data.OleDb.OleDbType.VarWChar, 50, "firstname"));
         this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("homephone", System.Data.OleDb.OleDbType.VarWChar, 50, "homephone"));
         this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("lastname", System.Data.OleDb.OleDbType.VarWChar, 50, "lastname"));
         this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("postalcode", System.Data.OleDb.OleDbType.VarWChar, 50, "postalcode"));
         this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("stateorprovince", System.Data.OleDb.OleDbType.VarWChar, 50, "stateorprovince"));
         // 
         // oleDbSelectCommand2
         // 
         this.oleDbSelectCommand2.CommandText = "SELECT address, city, country, emailaddress, faxnumber, firstname, homephone, id," +
            " lastname, postalcode, stateorprovince FROM addresses";
         this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
         // 
         // oleDbUpdateCommand2
         // 
         this.oleDbUpdateCommand2.CommandText = @"UPDATE addresses SET address = ?, city = ?, country = ?, emailaddress = ?, faxnumber = ?, firstname = ?, homephone = ?, lastname = ?, postalcode = ?, stateorprovince = ? WHERE (id = ?) AND (address = ? OR ? IS NULL AND address IS NULL) AND (city = ? OR ? IS NULL AND city IS NULL) AND (country = ? OR ? IS NULL AND country IS NULL) AND (emailaddress = ? OR ? IS NULL AND emailaddress IS NULL) AND (faxnumber = ? OR ? IS NULL AND faxnumber IS NULL) AND (firstname = ? OR ? IS NULL AND firstname IS NULL) AND (homephone = ? OR ? IS NULL AND homephone IS NULL) AND (lastname = ? OR ? IS NULL AND lastname IS NULL) AND (postalcode = ? OR ? IS NULL AND postalcode IS NULL) AND (stateorprovince = ? OR ? IS NULL AND stateorprovince IS NULL)";
         this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("address", System.Data.OleDb.OleDbType.VarWChar, 50, "address"));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("city", System.Data.OleDb.OleDbType.VarWChar, 50, "city"));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("country", System.Data.OleDb.OleDbType.VarWChar, 50, "country"));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("emailaddress", System.Data.OleDb.OleDbType.VarWChar, 50, "emailaddress"));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("faxnumber", System.Data.OleDb.OleDbType.VarWChar, 50, "faxnumber"));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("firstname", System.Data.OleDb.OleDbType.VarWChar, 50, "firstname"));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("homephone", System.Data.OleDb.OleDbType.VarWChar, 50, "homephone"));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("lastname", System.Data.OleDb.OleDbType.VarWChar, 50, "lastname"));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("postalcode", System.Data.OleDb.OleDbType.VarWChar, 50, "postalcode"));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("stateorprovince", System.Data.OleDb.OleDbType.VarWChar, 50, "stateorprovince"));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "address", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "address", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_city", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "city", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_city1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "city", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_country", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "country", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_country1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "country", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_emailaddress", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "emailaddress", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_emailaddress1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "emailaddress", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_faxnumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "faxnumber", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_faxnumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "faxnumber", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstname", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstname", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstname1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstname", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_homephone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "homephone", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_homephone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "homephone", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastname", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastname", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastname1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastname", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_postalcode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "postalcode", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_postalcode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "postalcode", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_stateorprovince", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "stateorprovince", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_stateorprovince1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "stateorprovince", System.Data.DataRowVersion.Original, null));
         // 
         // oleDbDeleteCommand1
         // 
         this.oleDbDeleteCommand1.CommandText = "DELETE FROM addresses WHERE (id = ?) AND (address = ?) AND (city = ?) AND (countr" +
            "y = ?) AND (emailaddress = ?) AND (faxnumber = ?) AND (firstname = ?) AND (homep" +
            "hone = ?) AND (lastname = ?) AND (postalcode = ?) AND (stateorprovince = ?)";
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("id", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("address", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "address", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("city", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "city", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("country", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "country", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("emailaddress", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "emailaddress", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("faxnumber", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "faxnumber", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("firstname", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstname", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("homephone", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "homephone", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("lastname", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastname", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("postalcode", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "postalcode", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("stateorprovince", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "stateorprovince", System.Data.DataRowVersion.Original, null));
         // 
         // oleDbInsertCommand1
         // 
         this.oleDbInsertCommand1.CommandText = @"INSERT INTO addresses(address, city, country, emailaddress, faxnumber, firstname, homephone, id, lastname, postalcode, stateorprovince) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?); SELECT address, city, country, emailaddress, faxnumber, firstname, homephone, id, lastname, postalcode, stateorprovince FROM addresses WHERE (id = ?)";
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("address", System.Data.OleDb.OleDbType.Char, 50, "address"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("city", System.Data.OleDb.OleDbType.Char, 50, "city"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("country", System.Data.OleDb.OleDbType.Char, 50, "country"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("emailaddress", System.Data.OleDb.OleDbType.Char, 50, "emailaddress"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("faxnumber", System.Data.OleDb.OleDbType.Char, 50, "faxnumber"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("firstname", System.Data.OleDb.OleDbType.Char, 50, "firstname"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("homephone", System.Data.OleDb.OleDbType.Char, 50, "homephone"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("id", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Current, null));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("lastname", System.Data.OleDb.OleDbType.Char, 50, "lastname"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("postalcode", System.Data.OleDb.OleDbType.Char, 50, "postalcode"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("stateorprovince", System.Data.OleDb.OleDbType.Char, 50, "stateorprovince"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Select_id", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Current, null));
         // 
         // oleDbSelectCommand1
         // 
         this.oleDbSelectCommand1.CommandText = "SELECT address, city, country, emailaddress, faxnumber, firstname, homephone, id," +
            " lastname, postalcode, stateorprovince FROM addresses";
         // 
         // oleDbUpdateCommand1
         // 
         this.oleDbUpdateCommand1.CommandText = @"UPDATE addresses SET address = ?, city = ?, country = ?, emailaddress = ?, faxnumber = ?, firstname = ?, homephone = ?, id = ?, lastname = ?, postalcode = ?, stateorprovince = ? WHERE (id = ?) AND (address = ?) AND (city = ?) AND (country = ?) AND (emailaddress = ?) AND (faxnumber = ?) AND (firstname = ?) AND (homephone = ?) AND (lastname = ?) AND (postalcode = ?) AND (stateorprovince = ?); SELECT address, city, country, emailaddress, faxnumber, firstname, homephone, id, lastname, postalcode, stateorprovince FROM addresses WHERE (id = ?)";
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("address", System.Data.OleDb.OleDbType.Char, 50, "address"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("city", System.Data.OleDb.OleDbType.Char, 50, "city"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("country", System.Data.OleDb.OleDbType.Char, 50, "country"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("emailaddress", System.Data.OleDb.OleDbType.Char, 50, "emailaddress"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("faxnumber", System.Data.OleDb.OleDbType.Char, 50, "faxnumber"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("firstname", System.Data.OleDb.OleDbType.Char, 50, "firstname"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("homephone", System.Data.OleDb.OleDbType.Char, 50, "homephone"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("id", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Current, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("lastname", System.Data.OleDb.OleDbType.Char, 50, "lastname"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("postalcode", System.Data.OleDb.OleDbType.Char, 50, "postalcode"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("stateorprovince", System.Data.OleDb.OleDbType.Char, 50, "stateorprovince"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_address", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "address", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_city", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "city", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_country", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "country", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_emailaddress", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "emailaddress", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_faxnumber", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "faxnumber", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_firstname", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "firstname", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_homephone", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "homephone", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lastname", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lastname", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_postalcode", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "postalcode", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_stateorprovince", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "stateorprovince", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Select_id", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Current, null));
         // 
         // AddressBook
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(384, 533);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.statusTextBox,
                                                                      this.faxLabel,
                                                                      this.homeLabel,
                                                                      this.emailLabel,
                                                                      this.countryLabel,
                                                                      this.postalLabel,
                                                                      this.stateLabel,
                                                                      this.cityLabel,
                                                                      this.addressLabel,
                                                                      this.lastLabel,
                                                                      this.firstLabel,
                                                                      this.idLabel,
                                                                      this.faxTextBox,
                                                                      this.homeTextBox,
                                                                      this.emailTextBox,
                                                                      this.countryTextBox,
                                                                      this.postalTextBox,
                                                                      this.stateTextBox,
                                                                      this.cityTextBox,
                                                                      this.addressTextBox,
                                                                      this.lastTextBox,
                                                                      this.firstTextBox,
                                                                      this.idTextBox,
                                                                      this.helpButton,
                                                                      this.clearButton,
                                                                      this.updateButton,
                                                                      this.addButton,
                                                                      this.findButton});
         this.Name = "AddressBook";
         this.Text = "AddressBook";
         ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
         this.ResumeLayout(false);

      } // end of InitializeComponent
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new AddressBook());
      }

      private void findButton_Click(object sender, System.EventArgs e)
      {
         try
         {
            if ( lastTextBox.Text != "" )
            {  
               // clear the DataSet from the last operation
               dataSet1.Clear();

               // create SQL query to find the contact with the
               // specified last name
               oleDbDataAdapter1.SelectCommand.CommandText = 
                  "SELECT * FROM addresses WHERE lastname = '" +
                  lastTextBox.Text + "'";

               // fill dataSet1 with the rows resulting from the
               // query
               oleDbDataAdapter1.Fill( dataSet1 );

               // display information
               Display( dataSet1 );
               statusTextBox.Text += "\r\nQuery successful\r\n";
            }
         
            else
               lastTextBox.Text = 
                  "Enter last name here then press Find";
         }
      
         catch ( System.Data.OleDb.OleDbException oleException )
         {
            Console.WriteLine( oleException.StackTrace );
            statusTextBox.Text += oleException.ToString();
         }
      
         catch ( InvalidOperationException invalidException )
         {
            MessageBox.Show( invalidException.Message );
         }
      
      }  // end of findButton_Click

      private void addButton_Click(object sender, System.EventArgs e)
      {
         try
         {
            if ( lastTextBox.Text != "" && firstTextBox.Text != "" )
            {
               // create the SQL query to insert a row
               oleDbDataAdapter1.InsertCommand.CommandText = 
                  "INSERT INTO addresses (" +
                  "firstname, lastname, address, city, " +
                  "stateorprovince, postalcode, country, " +
                  "emailaddress, homephone, faxnumber" + 
                  ") VALUES ('" +
                  firstTextBox.Text + "', '" +
                  lastTextBox.Text + "', '" +
                  addressTextBox.Text + "', '" +
                  cityTextBox.Text + "', '" +
                  stateTextBox.Text + "', '" +
                  postalTextBox.Text + "', '" +
                  countryTextBox.Text + "', '" +
                  emailTextBox.Text + "', '" +
                  homeTextBox.Text + "', '" +
                  faxTextBox.Text + "')";

               // notify the user the query is being sent
               statusTextBox.Text += "\r\nSending query: " +
                  oleDbDataAdapter1.InsertCommand.CommandText +
                  "\r\n" ;

               // send query
               oleDbDataAdapter1.InsertCommand.ExecuteNonQuery();

               statusTextBox.Text += "\r\nQuery successful\r\n";
            }
         
            else
               statusTextBox.Text += "\r\nEnter at least first " +
                  "and last name then press Add\r\n";
         }
      
         catch ( System.Data.OleDb.OleDbException oleException )
         {
            Console.WriteLine( oleException.StackTrace );
            statusTextBox.Text += oleException.ToString();
         }
      
      }  // end of addButton_Click

      private void updateButton_Click(object sender, System.EventArgs e)
      {
         try
         {
            // make sure the user has already found the record
            // he or she wishes to update
            if ( idTextBox.Text != "" )
            {
               // set the SQL query to update all the fields in
               // the table where the id number matches the id
               // in idTextBox
               oleDbDataAdapter1.UpdateCommand.CommandText =
                  "UPDATE addresses SET " +
                  "firstname ='" + firstTextBox.Text +
                  "', lastname='" + lastTextBox.Text +
                  "', address='" + addressTextBox.Text +
                  "', city='" + cityTextBox.Text +
                  "', stateorprovince='" + stateTextBox.Text +
                  "', postalcode='" + postalTextBox.Text +
                  "', country='" + countryTextBox.Text +
                  "', emailaddress='" + emailTextBox.Text +
                  "', homephone='" + homeTextBox.Text +
                  "', faxnumber='" + faxTextBox.Text +
                  "' WHERE id=" + idTextBox.Text;

               // notify the user the query is being set
               statusTextBox.Text += "\r\nSending query: " +
                  oleDbDataAdapter1.UpdateCommand.CommandText +
                  "\r\n";

               // execute query
               oleDbDataAdapter1.UpdateCommand.ExecuteNonQuery();

               statusTextBox.Text += "\r\nQuery successful\r\n";
            }
         
            else
               statusTextBox.Text += "\r\nYou may only update " +
                  "an existing record. Use Find to locate the" +
                  "record, then modify the information and " +
                  "press Update.\r\n";
         }
      
         catch ( System.Data.OleDb.OleDbException oleException )
         {
            Console.WriteLine( oleException.StackTrace );
            statusTextBox.Text += oleException.ToString();
         }
      
      } // end of updateButton_Click

      private void clearButton_Click(object sender, System.EventArgs e)
      {
         idTextBox.Clear();
         ClearTextBoxes();
      }

      private void helpButton_Click(object sender, System.EventArgs e)
      {
         statusTextBox.AppendText( 
            "\r\nClick Find to locate a record\r\n" +
            "Click Add to insert a new record.\r\n" +
            "Click Update to update the information in a record "
            + "\r\nClick Clear to empty the textboxes" );
      }
	   
      public void Display( DataSet dataSet )
      {
         try
         {   
            // get the first DataTable - there will always be one
            DataTable dataTable = dataSet.Tables[ 0 ];
         
            if ( dataTable.Rows.Count != 0 )
            {
               int recordNumber = (int)dataTable.Rows[ 0 ][ 0 ];

               idTextBox.Text = recordNumber.ToString();
               firstTextBox.Text = 
                  (string)dataTable.Rows[ 0 ][ 1 ];
               lastTextBox.Text = (
                  string)dataTable.Rows[ 0 ][ 2 ];
               addressTextBox.Text = 
                  (string)dataTable.Rows[ 0 ][ 3 ];
               cityTextBox.Text =
                  (string)dataTable.Rows[ 0 ][ 4 ];
               stateTextBox.Text =
                  (string)dataTable.Rows[ 0 ][ 5 ];
               postalTextBox.Text =
                  (string)dataTable.Rows[ 0 ][ 6 ];
               countryTextBox.Text =
                  (string)dataTable.Rows[ 0 ][ 7 ];
               emailTextBox.Text =
                  (string)dataTable.Rows[ 0 ][ 8 ];
               homeTextBox.Text =
                  (string)dataTable.Rows[ 0 ][ 9 ];
               faxTextBox.Text =
                  (string)dataTable.Rows[ 0 ][ 10 ];
            }
         
            else
               statusTextBox.Text += "\r\nNo record found\r\n";
         }
      
         catch( System.Data.OleDb.OleDbException oleException )
         {
            Console.WriteLine( oleException.StackTrace );
            statusTextBox.Text += oleException.ToString();
         }
      
      } // end of Display

      public void ClearTextBoxes()
      {
         firstTextBox.Clear();
         lastTextBox.Clear();
         addressTextBox.Clear();
         cityTextBox.Clear();
         stateTextBox.Clear();
         postalTextBox.Clear();
         countryTextBox.Clear();
         emailTextBox.Clear();
         homeTextBox.Clear();
         faxTextBox.Clear();
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
