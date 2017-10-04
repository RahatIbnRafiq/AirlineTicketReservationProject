namespace AddressBook
{
   partial class AddressBookForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
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
         this.components = new System.ComponentModel.Container();
         System.Windows.Forms.Label addressIDLabel;
         System.Windows.Forms.Label firstNameLabel;
         System.Windows.Forms.Label lastNameLabel;
         System.Windows.Forms.Label emailLabel;
         System.Windows.Forms.Label phoneNumberLabel;
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( AddressBookForm ) );
         this.addressesBindingNavigator = new System.Windows.Forms.BindingNavigator( this.components );
         this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
         this.addressesBindingSource = new System.Windows.Forms.BindingSource( this.components );
         this.addressBookDataSet = new AddressBook.AddressBookDataSet();
         this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
         this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
         this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.addressesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.addressIDTextBox = new System.Windows.Forms.TextBox();
         this.firstNameTextBox = new System.Windows.Forms.TextBox();
         this.lastNameTextBox = new System.Windows.Forms.TextBox();
         this.emailTextBox = new System.Windows.Forms.TextBox();
         this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
         this.findButton = new System.Windows.Forms.Button();
         this.findTextBox = new System.Windows.Forms.TextBox();
         this.findLabel = new System.Windows.Forms.Label();
         this.findGroupBox = new System.Windows.Forms.GroupBox();
         this.browseAllButton = new System.Windows.Forms.Button();
         this.addressesTableAdapter = new AddressBook.AddressBookDataSetTableAdapters.AddressesTableAdapter();
         addressIDLabel = new System.Windows.Forms.Label();
         firstNameLabel = new System.Windows.Forms.Label();
         lastNameLabel = new System.Windows.Forms.Label();
         emailLabel = new System.Windows.Forms.Label();
         phoneNumberLabel = new System.Windows.Forms.Label();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.addressesBindingNavigator ) ).BeginInit();
         this.addressesBindingNavigator.SuspendLayout();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.addressesBindingSource ) ).BeginInit();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.addressBookDataSet ) ).BeginInit();
         this.findGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // addressIDLabel
         // 
         addressIDLabel.AutoSize = true;
         addressIDLabel.Location = new System.Drawing.Point( 53, 47 );
         addressIDLabel.Name = "addressIDLabel";
         addressIDLabel.Size = new System.Drawing.Size( 62, 13 );
         addressIDLabel.TabIndex = 1;
         addressIDLabel.Text = "Address ID:";
         // 
         // firstNameLabel
         // 
         firstNameLabel.AutoSize = true;
         firstNameLabel.Location = new System.Drawing.Point( 53, 73 );
         firstNameLabel.Name = "firstNameLabel";
         firstNameLabel.Size = new System.Drawing.Size( 60, 13 );
         firstNameLabel.TabIndex = 3;
         firstNameLabel.Text = "First Name:";
         // 
         // lastNameLabel
         // 
         lastNameLabel.AutoSize = true;
         lastNameLabel.Location = new System.Drawing.Point( 53, 99 );
         lastNameLabel.Name = "lastNameLabel";
         lastNameLabel.Size = new System.Drawing.Size( 61, 13 );
         lastNameLabel.TabIndex = 5;
         lastNameLabel.Text = "Last Name:";
         // 
         // emailLabel
         // 
         emailLabel.AutoSize = true;
         emailLabel.Location = new System.Drawing.Point( 53, 125 );
         emailLabel.Name = "emailLabel";
         emailLabel.Size = new System.Drawing.Size( 35, 13 );
         emailLabel.TabIndex = 7;
         emailLabel.Text = "Email:";
         // 
         // phoneNumberLabel
         // 
         phoneNumberLabel.AutoSize = true;
         phoneNumberLabel.Location = new System.Drawing.Point( 53, 151 );
         phoneNumberLabel.Name = "phoneNumberLabel";
         phoneNumberLabel.Size = new System.Drawing.Size( 81, 13 );
         phoneNumberLabel.TabIndex = 9;
         phoneNumberLabel.Text = "Phone Number:";
         // 
         // addressesBindingNavigator
         // 
         this.addressesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.addressesBindingNavigator.BindingSource = this.addressesBindingSource;
         this.addressesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.addressesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.addressesBindingNavigator.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.addressesBindingNavigatorSaveItem} );
         this.addressesBindingNavigator.Location = new System.Drawing.Point( 0, 0 );
         this.addressesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.addressesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.addressesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.addressesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.addressesBindingNavigator.Name = "addressesBindingNavigator";
         this.addressesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.addressesBindingNavigator.Size = new System.Drawing.Size( 292, 25 );
         this.addressesBindingNavigator.TabIndex = 0;
         this.addressesBindingNavigator.Text = "bindingNavigator1";
         // 
         // bindingNavigatorAddNewItem
         // 
         this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorAddNewItem.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "bindingNavigatorAddNewItem.Image" ) ) );
         this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
         this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size( 23, 22 );
         this.bindingNavigatorAddNewItem.Text = "Add new";
         // 
         // addressesBindingSource
         // 
         this.addressesBindingSource.DataMember = "Addresses";
         this.addressesBindingSource.DataSource = this.addressBookDataSet;
         // 
         // addressBookDataSet
         // 
         this.addressBookDataSet.DataSetName = "AddressBookDataSet";
         this.addressBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // bindingNavigatorCountItem
         // 
         this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
         this.bindingNavigatorCountItem.Size = new System.Drawing.Size( 36, 22 );
         this.bindingNavigatorCountItem.Text = "of {0}";
         this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
         // 
         // bindingNavigatorDeleteItem
         // 
         this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorDeleteItem.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "bindingNavigatorDeleteItem.Image" ) ) );
         this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
         this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size( 23, 22 );
         this.bindingNavigatorDeleteItem.Text = "Delete";
         // 
         // bindingNavigatorMoveFirstItem
         // 
         this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveFirstItem.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "bindingNavigatorMoveFirstItem.Image" ) ) );
         this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
         this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size( 23, 22 );
         this.bindingNavigatorMoveFirstItem.Text = "Move first";
         // 
         // bindingNavigatorMovePreviousItem
         // 
         this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMovePreviousItem.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "bindingNavigatorMovePreviousItem.Image" ) ) );
         this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
         this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size( 23, 22 );
         this.bindingNavigatorMovePreviousItem.Text = "Move previous";
         // 
         // bindingNavigatorSeparator
         // 
         this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
         this.bindingNavigatorSeparator.Size = new System.Drawing.Size( 6, 25 );
         // 
         // bindingNavigatorPositionItem
         // 
         this.bindingNavigatorPositionItem.AccessibleName = "Position";
         this.bindingNavigatorPositionItem.AutoSize = false;
         this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
         this.bindingNavigatorPositionItem.Size = new System.Drawing.Size( 50, 21 );
         this.bindingNavigatorPositionItem.Text = "0";
         this.bindingNavigatorPositionItem.ToolTipText = "Current position";
         // 
         // bindingNavigatorSeparator1
         // 
         this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
         this.bindingNavigatorSeparator1.Size = new System.Drawing.Size( 6, 25 );
         // 
         // bindingNavigatorMoveNextItem
         // 
         this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveNextItem.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "bindingNavigatorMoveNextItem.Image" ) ) );
         this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
         this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size( 23, 22 );
         this.bindingNavigatorMoveNextItem.Text = "Move next";
         // 
         // bindingNavigatorMoveLastItem
         // 
         this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveLastItem.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "bindingNavigatorMoveLastItem.Image" ) ) );
         this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
         this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size( 23, 22 );
         this.bindingNavigatorMoveLastItem.Text = "Move last";
         // 
         // bindingNavigatorSeparator2
         // 
         this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
         this.bindingNavigatorSeparator2.Size = new System.Drawing.Size( 6, 25 );
         // 
         // addressesBindingNavigatorSaveItem
         // 
         this.addressesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.addressesBindingNavigatorSaveItem.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "addressesBindingNavigatorSaveItem.Image" ) ) );
         this.addressesBindingNavigatorSaveItem.Name = "addressesBindingNavigatorSaveItem";
         this.addressesBindingNavigatorSaveItem.Size = new System.Drawing.Size( 23, 22 );
         this.addressesBindingNavigatorSaveItem.Text = "Save Data";
         this.addressesBindingNavigatorSaveItem.Click += new System.EventHandler( this.addressesBindingNavigatorSaveItem_Click );
         // 
         // addressIDTextBox
         // 
         this.addressIDTextBox.DataBindings.Add( new System.Windows.Forms.Binding( "Text", this.addressesBindingSource, "AddressID", true ) );
         this.addressIDTextBox.Location = new System.Drawing.Point( 140, 44 );
         this.addressIDTextBox.Name = "addressIDTextBox";
         this.addressIDTextBox.ReadOnly = true;
         this.addressIDTextBox.Size = new System.Drawing.Size( 100, 20 );
         this.addressIDTextBox.TabIndex = 2;
         // 
         // firstNameTextBox
         // 
         this.firstNameTextBox.DataBindings.Add( new System.Windows.Forms.Binding( "Text", this.addressesBindingSource, "FirstName", true ) );
         this.firstNameTextBox.Location = new System.Drawing.Point( 140, 70 );
         this.firstNameTextBox.Name = "firstNameTextBox";
         this.firstNameTextBox.Size = new System.Drawing.Size( 100, 20 );
         this.firstNameTextBox.TabIndex = 4;
         // 
         // lastNameTextBox
         // 
         this.lastNameTextBox.DataBindings.Add( new System.Windows.Forms.Binding( "Text", this.addressesBindingSource, "LastName", true ) );
         this.lastNameTextBox.Location = new System.Drawing.Point( 140, 96 );
         this.lastNameTextBox.Name = "lastNameTextBox";
         this.lastNameTextBox.Size = new System.Drawing.Size( 100, 20 );
         this.lastNameTextBox.TabIndex = 6;
         // 
         // emailTextBox
         // 
         this.emailTextBox.DataBindings.Add( new System.Windows.Forms.Binding( "Text", this.addressesBindingSource, "Email", true ) );
         this.emailTextBox.Location = new System.Drawing.Point( 140, 122 );
         this.emailTextBox.Name = "emailTextBox";
         this.emailTextBox.Size = new System.Drawing.Size( 100, 20 );
         this.emailTextBox.TabIndex = 8;
         // 
         // phoneNumberTextBox
         // 
         this.phoneNumberTextBox.DataBindings.Add( new System.Windows.Forms.Binding( "Text", this.addressesBindingSource, "PhoneNumber", true ) );
         this.phoneNumberTextBox.Location = new System.Drawing.Point( 140, 148 );
         this.phoneNumberTextBox.Name = "phoneNumberTextBox";
         this.phoneNumberTextBox.Size = new System.Drawing.Size( 100, 20 );
         this.phoneNumberTextBox.TabIndex = 10;
         // 
         // findButton
         // 
         this.findButton.Location = new System.Drawing.Point( 181, 16 );
         this.findButton.Name = "findButton";
         this.findButton.Size = new System.Drawing.Size( 75, 23 );
         this.findButton.TabIndex = 2;
         this.findButton.Text = "Find";
         this.findButton.Click += new System.EventHandler( this.findButton_Click );
         // 
         // findTextBox
         // 
         this.findTextBox.Location = new System.Drawing.Point( 73, 17 );
         this.findTextBox.Name = "findTextBox";
         this.findTextBox.Size = new System.Drawing.Size( 100, 20 );
         this.findTextBox.TabIndex = 1;
         // 
         // findLabel
         // 
         this.findLabel.AutoSize = true;
         this.findLabel.Location = new System.Drawing.Point( 9, 21 );
         this.findLabel.Name = "findLabel";
         this.findLabel.Size = new System.Drawing.Size( 61, 13 );
         this.findLabel.TabIndex = 0;
         this.findLabel.Text = "Last Name:";
         // 
         // findGroupBox
         // 
         this.findGroupBox.Controls.Add( this.findLabel );
         this.findGroupBox.Controls.Add( this.findTextBox );
         this.findGroupBox.Controls.Add( this.findButton );
         this.findGroupBox.Location = new System.Drawing.Point( 13, 178 );
         this.findGroupBox.Name = "findGroupBox";
         this.findGroupBox.Size = new System.Drawing.Size( 267, 47 );
         this.findGroupBox.TabIndex = 16;
         this.findGroupBox.TabStop = false;
         this.findGroupBox.Text = "Find an entry by last name";
         // 
         // browseAllButton
         // 
         this.browseAllButton.Location = new System.Drawing.Point( 85, 232 );
         this.browseAllButton.Name = "browseAllButton";
         this.browseAllButton.Size = new System.Drawing.Size( 122, 23 );
         this.browseAllButton.TabIndex = 17;
         this.browseAllButton.Text = "Browse All Entries";
         this.browseAllButton.Click += new System.EventHandler( this.browseAllButton_Click );
         // 
         // addressesTableAdapter
         // 
         this.addressesTableAdapter.ClearBeforeFill = true;
         // 
         // AddressBookForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 292, 262 );
         this.Controls.Add( this.browseAllButton );
         this.Controls.Add( this.findGroupBox );
         this.Controls.Add( addressIDLabel );
         this.Controls.Add( this.addressIDTextBox );
         this.Controls.Add( firstNameLabel );
         this.Controls.Add( this.firstNameTextBox );
         this.Controls.Add( lastNameLabel );
         this.Controls.Add( this.lastNameTextBox );
         this.Controls.Add( emailLabel );
         this.Controls.Add( this.emailTextBox );
         this.Controls.Add( phoneNumberLabel );
         this.Controls.Add( this.phoneNumberTextBox );
         this.Controls.Add( this.addressesBindingNavigator );
         this.Name = "AddressBookForm";
         this.Text = "Address Book";
         this.Load += new System.EventHandler( this.AddressBookForm_Load );
         ( ( System.ComponentModel.ISupportInitialize ) ( this.addressesBindingNavigator ) ).EndInit();
         this.addressesBindingNavigator.ResumeLayout( false );
         this.addressesBindingNavigator.PerformLayout();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.addressesBindingSource ) ).EndInit();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.addressBookDataSet ) ).EndInit();
         this.findGroupBox.ResumeLayout( false );
         this.findGroupBox.PerformLayout();
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private AddressBookDataSet addressBookDataSet;
      private System.Windows.Forms.BindingSource addressesBindingSource;
      private AddressBook.AddressBookDataSetTableAdapters.AddressesTableAdapter addressesTableAdapter;
      private System.Windows.Forms.BindingNavigator addressesBindingNavigator;
      private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
      private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
      private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
      private System.Windows.Forms.ToolStripButton addressesBindingNavigatorSaveItem;
      private System.Windows.Forms.TextBox addressIDTextBox;
      private System.Windows.Forms.TextBox firstNameTextBox;
      private System.Windows.Forms.TextBox lastNameTextBox;
      private System.Windows.Forms.TextBox emailTextBox;
      private System.Windows.Forms.TextBox phoneNumberTextBox;
      private System.Windows.Forms.Button findButton;
      private System.Windows.Forms.TextBox findTextBox;
      private System.Windows.Forms.Label findLabel;
      private System.Windows.Forms.GroupBox findGroupBox;
      private System.Windows.Forms.Button browseAllButton;

   }
}

