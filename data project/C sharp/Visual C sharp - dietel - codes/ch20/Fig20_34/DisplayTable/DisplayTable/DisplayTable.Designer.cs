namespace DisplayTable
{
   partial class DisplayTableForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( DisplayTableForm ) );
         this.booksDataSet = new DisplayTable.BooksDataSet();
         this.authorsBindingSource = new System.Windows.Forms.BindingSource( this.components );
         this.authorsTableAdapter = new DisplayTable.BooksDataSetTableAdapters.AuthorsTableAdapter();
         this.authorsBindingNavigator = new System.Windows.Forms.BindingNavigator( this.components );
         this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
         this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
         this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
         this.authorsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.authorsDataGridView = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.booksDataSet ) ).BeginInit();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.authorsBindingSource ) ).BeginInit();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.authorsBindingNavigator ) ).BeginInit();
         this.authorsBindingNavigator.SuspendLayout();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.authorsDataGridView ) ).BeginInit();
         this.SuspendLayout();
         // 
         // booksDataSet
         // 
         this.booksDataSet.DataSetName = "BooksDataSet";
         this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // authorsBindingSource
         // 
         this.authorsBindingSource.DataMember = "Authors";
         this.authorsBindingSource.DataSource = this.booksDataSet;
         // 
         // authorsTableAdapter
         // 
         this.authorsTableAdapter.ClearBeforeFill = true;
         // 
         // authorsBindingNavigator
         // 
         this.authorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.authorsBindingNavigator.BindingSource = this.authorsBindingSource;
         this.authorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.authorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.authorsBindingNavigator.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
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
            this.authorsBindingNavigatorSaveItem} );
         this.authorsBindingNavigator.Location = new System.Drawing.Point( 0, 0 );
         this.authorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.authorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.authorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.authorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.authorsBindingNavigator.Name = "authorsBindingNavigator";
         this.authorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.authorsBindingNavigator.Size = new System.Drawing.Size( 367, 25 );
         this.authorsBindingNavigator.TabIndex = 0;
         this.authorsBindingNavigator.Text = "bindingNavigator1";
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
         // bindingNavigatorCountItem
         // 
         this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
         this.bindingNavigatorCountItem.Size = new System.Drawing.Size( 36, 13 );
         this.bindingNavigatorCountItem.Text = "of {0}";
         this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
         // 
         // bindingNavigatorSeparator1
         // 
         this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
         this.bindingNavigatorSeparator1.Size = new System.Drawing.Size( 6, 6 );
         // 
         // bindingNavigatorMoveNextItem
         // 
         this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveNextItem.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "bindingNavigatorMoveNextItem.Image" ) ) );
         this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
         this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size( 23, 20 );
         this.bindingNavigatorMoveNextItem.Text = "Move next";
         // 
         // bindingNavigatorMoveLastItem
         // 
         this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveLastItem.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "bindingNavigatorMoveLastItem.Image" ) ) );
         this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
         this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size( 23, 20 );
         this.bindingNavigatorMoveLastItem.Text = "Move last";
         // 
         // bindingNavigatorSeparator2
         // 
         this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
         this.bindingNavigatorSeparator2.Size = new System.Drawing.Size( 6, 6 );
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
         // bindingNavigatorDeleteItem
         // 
         this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorDeleteItem.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "bindingNavigatorDeleteItem.Image" ) ) );
         this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
         this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size( 23, 20 );
         this.bindingNavigatorDeleteItem.Text = "Delete";
         // 
         // authorsBindingNavigatorSaveItem
         // 
         this.authorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.authorsBindingNavigatorSaveItem.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "authorsBindingNavigatorSaveItem.Image" ) ) );
         this.authorsBindingNavigatorSaveItem.Name = "authorsBindingNavigatorSaveItem";
         this.authorsBindingNavigatorSaveItem.Size = new System.Drawing.Size( 23, 23 );
         this.authorsBindingNavigatorSaveItem.Text = "Save Data";
         this.authorsBindingNavigatorSaveItem.Click += new System.EventHandler( this.authorsBindingNavigatorSaveItem_Click );
         // 
         // authorsDataGridView
         // 
         this.authorsDataGridView.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                     | System.Windows.Forms.AnchorStyles.Left )
                     | System.Windows.Forms.AnchorStyles.Right ) ) );
         this.authorsDataGridView.AutoGenerateColumns = false;
         this.authorsDataGridView.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3} );
         this.authorsDataGridView.DataSource = this.authorsBindingSource;
         this.authorsDataGridView.Location = new System.Drawing.Point( 0, 28 );
         this.authorsDataGridView.Name = "authorsDataGridView";
         this.authorsDataGridView.Size = new System.Drawing.Size( 367, 240 );
         this.authorsDataGridView.TabIndex = 1;
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "AuthorID";
         this.dataGridViewTextBoxColumn1.HeaderText = "AuthorID";
         this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
         this.dataGridViewTextBoxColumn1.ReadOnly = true;
         // 
         // dataGridViewTextBoxColumn2
         // 
         this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
         this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
         this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
         // 
         // dataGridViewTextBoxColumn3
         // 
         this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
         this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
         this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
         // 
         // DisplayTableForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 367, 268 );
         this.Controls.Add( this.authorsDataGridView );
         this.Controls.Add( this.authorsBindingNavigator );
         this.Name = "DisplayTableForm";
         this.Text = "Display Table";
         this.Load += new System.EventHandler( this.DisplayTableForm_Load );
         ( ( System.ComponentModel.ISupportInitialize ) ( this.booksDataSet ) ).EndInit();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.authorsBindingSource ) ).EndInit();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.authorsBindingNavigator ) ).EndInit();
         this.authorsBindingNavigator.ResumeLayout( false );
         this.authorsBindingNavigator.PerformLayout();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.authorsDataGridView ) ).EndInit();
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private BooksDataSet booksDataSet;
      private System.Windows.Forms.BindingSource authorsBindingSource;
      private DisplayTable.BooksDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
      private System.Windows.Forms.BindingNavigator authorsBindingNavigator;
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
      private System.Windows.Forms.ToolStripButton authorsBindingNavigatorSaveItem;
      private System.Windows.Forms.DataGridView authorsDataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
   }
}

