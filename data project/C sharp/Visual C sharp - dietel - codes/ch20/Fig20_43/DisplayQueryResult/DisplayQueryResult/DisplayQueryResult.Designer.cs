namespace DisplayQueryResult
{
   partial class DisplayQueryResultForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( DisplayQueryResultForm ) );
         this.titlesBindingNavigator = new System.Windows.Forms.BindingNavigator( this.components );
         this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
         this.titlesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.titlesDataGridView = new System.Windows.Forms.DataGridView();
         this.queriesComboBox = new System.Windows.Forms.ComboBox();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.titlesBindingSource = new System.Windows.Forms.BindingSource( this.components );
         this.booksDataSet = new DisplayQueryResult.BooksDataSet();
         this.titlesTableAdapter = new DisplayQueryResult.BooksDataSetTableAdapters.TitlesTableAdapter();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.titlesBindingNavigator ) ).BeginInit();
         this.titlesBindingNavigator.SuspendLayout();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.titlesDataGridView ) ).BeginInit();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.titlesBindingSource ) ).BeginInit();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.booksDataSet ) ).BeginInit();
         this.SuspendLayout();
         // 
         // titlesBindingNavigator
         // 
         this.titlesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.titlesBindingNavigator.BindingSource = this.titlesBindingSource;
         this.titlesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.titlesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.titlesBindingNavigator.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
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
            this.titlesBindingNavigatorSaveItem} );
         this.titlesBindingNavigator.Location = new System.Drawing.Point( 0, 0 );
         this.titlesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.titlesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.titlesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.titlesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.titlesBindingNavigator.Name = "titlesBindingNavigator";
         this.titlesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.titlesBindingNavigator.Size = new System.Drawing.Size( 440, 25 );
         this.titlesBindingNavigator.TabIndex = 0;
         this.titlesBindingNavigator.Text = "bindingNavigator1";
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
         // titlesBindingNavigatorSaveItem
         // 
         this.titlesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.titlesBindingNavigatorSaveItem.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "titlesBindingNavigatorSaveItem.Image" ) ) );
         this.titlesBindingNavigatorSaveItem.Name = "titlesBindingNavigatorSaveItem";
         this.titlesBindingNavigatorSaveItem.Size = new System.Drawing.Size( 23, 22 );
         this.titlesBindingNavigatorSaveItem.Text = "Save Data";
         this.titlesBindingNavigatorSaveItem.Click += new System.EventHandler( this.titlesBindingNavigatorSaveItem_Click );
         // 
         // titlesDataGridView
         // 
         this.titlesDataGridView.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                     | System.Windows.Forms.AnchorStyles.Left )
                     | System.Windows.Forms.AnchorStyles.Right ) ) );
         this.titlesDataGridView.AutoGenerateColumns = false;
         this.titlesDataGridView.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4} );
         this.titlesDataGridView.DataSource = this.titlesBindingSource;
         this.titlesDataGridView.Location = new System.Drawing.Point( 0, 28 );
         this.titlesDataGridView.Name = "titlesDataGridView";
         this.titlesDataGridView.Size = new System.Drawing.Size( 445, 239 );
         this.titlesDataGridView.TabIndex = 1;
         // 
         // queriesComboBox
         // 
         this.queriesComboBox.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left )
                     | System.Windows.Forms.AnchorStyles.Right ) ) );
         this.queriesComboBox.FormattingEnabled = true;
         this.queriesComboBox.Items.AddRange( new object[] {
            "SELECT ISBN, Title, EditionNumber, Copyright FROM Titles",
            "SELECT ISBN, Title, EditionNumber, Copyright FROM Titles WHERE (Copyright = \'2006" +
                "\')",
            "SELECT ISBN, Title, EditionNumber, Copyright FROM Titles WHERE (Title LIKE \'%How " +
                "to Program\') ORDER BY Title"} );
         this.queriesComboBox.Location = new System.Drawing.Point( 0, 270 );
         this.queriesComboBox.Name = "queriesComboBox";
         this.queriesComboBox.Size = new System.Drawing.Size( 440, 21 );
         this.queriesComboBox.TabIndex = 2;
         this.queriesComboBox.SelectedIndexChanged += new System.EventHandler( this.queriesComboBox_SelectedIndexChanged );
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "ISBN";
         this.dataGridViewTextBoxColumn1.HeaderText = "ISBN";
         this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
         // 
         // dataGridViewTextBoxColumn2
         // 
         this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
         this.dataGridViewTextBoxColumn2.HeaderText = "Title";
         this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
         // 
         // dataGridViewTextBoxColumn3
         // 
         this.dataGridViewTextBoxColumn3.DataPropertyName = "EditionNumber";
         this.dataGridViewTextBoxColumn3.HeaderText = "EditionNumber";
         this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
         // 
         // dataGridViewTextBoxColumn4
         // 
         this.dataGridViewTextBoxColumn4.DataPropertyName = "Copyright";
         this.dataGridViewTextBoxColumn4.HeaderText = "Copyright";
         this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
         // 
         // titlesBindingSource
         // 
         this.titlesBindingSource.DataMember = "Titles";
         this.titlesBindingSource.DataSource = this.booksDataSet;
         // 
         // booksDataSet
         // 
         this.booksDataSet.DataSetName = "BooksDataSet";
         this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // titlesTableAdapter
         // 
         this.titlesTableAdapter.ClearBeforeFill = true;
         // 
         // DisplayQueryResultForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 440, 292 );
         this.Controls.Add( this.queriesComboBox );
         this.Controls.Add( this.titlesDataGridView );
         this.Controls.Add( this.titlesBindingNavigator );
         this.Name = "DisplayQueryResultForm";
         this.Text = "Display Query Result";
         this.Load += new System.EventHandler( this.DisplayQueryResultForm_Load );
         ( ( System.ComponentModel.ISupportInitialize ) ( this.titlesBindingNavigator ) ).EndInit();
         this.titlesBindingNavigator.ResumeLayout( false );
         this.titlesBindingNavigator.PerformLayout();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.titlesDataGridView ) ).EndInit();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.titlesBindingSource ) ).EndInit();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.booksDataSet ) ).EndInit();
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private BooksDataSet booksDataSet;
      private System.Windows.Forms.BindingSource titlesBindingSource;
      private DisplayQueryResult.BooksDataSetTableAdapters.TitlesTableAdapter titlesTableAdapter;
      private System.Windows.Forms.BindingNavigator titlesBindingNavigator;
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
      private System.Windows.Forms.ToolStripButton titlesBindingNavigatorSaveItem;
      private System.Windows.Forms.DataGridView titlesDataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
      private System.Windows.Forms.ComboBox queriesComboBox;
   }
}

