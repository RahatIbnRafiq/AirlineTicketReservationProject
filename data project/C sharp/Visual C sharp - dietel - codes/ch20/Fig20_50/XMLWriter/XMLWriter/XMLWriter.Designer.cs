namespace XMLWriter
{
   partial class XMLWriterForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( XMLWriterForm ) );
         this.baseballDataSet = new XMLWriter.BaseballDataSet();
         this.playersBindingSource = new System.Windows.Forms.BindingSource( this.components );
         this.playersTableAdapter = new XMLWriter.BaseballDataSetTableAdapters.PlayersTableAdapter();
         this.playersBindingNavigator = new System.Windows.Forms.BindingNavigator( this.components );
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
         this.playersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.playersDataGridView = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.outputTextBox = new System.Windows.Forms.TextBox();
         this.writeButton = new System.Windows.Forms.Button();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.baseballDataSet ) ).BeginInit();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.playersBindingSource ) ).BeginInit();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.playersBindingNavigator ) ).BeginInit();
         this.playersBindingNavigator.SuspendLayout();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.playersDataGridView ) ).BeginInit();
         this.SuspendLayout();
         // 
         // baseballDataSet
         // 
         this.baseballDataSet.DataSetName = "BaseballDataSet";
         this.baseballDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // playersBindingSource
         // 
         this.playersBindingSource.DataMember = "Players";
         this.playersBindingSource.DataSource = this.baseballDataSet;
         // 
         // playersTableAdapter
         // 
         this.playersTableAdapter.ClearBeforeFill = true;
         // 
         // playersBindingNavigator
         // 
         this.playersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.playersBindingNavigator.BindingSource = this.playersBindingSource;
         this.playersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.playersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.playersBindingNavigator.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
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
            this.playersBindingNavigatorSaveItem} );
         this.playersBindingNavigator.Location = new System.Drawing.Point( 0, 0 );
         this.playersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.playersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.playersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.playersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.playersBindingNavigator.Name = "playersBindingNavigator";
         this.playersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.playersBindingNavigator.Size = new System.Drawing.Size( 444, 25 );
         this.playersBindingNavigator.TabIndex = 0;
         this.playersBindingNavigator.Text = "bindingNavigator1";
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
         // playersBindingNavigatorSaveItem
         // 
         this.playersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.playersBindingNavigatorSaveItem.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "playersBindingNavigatorSaveItem.Image" ) ) );
         this.playersBindingNavigatorSaveItem.Name = "playersBindingNavigatorSaveItem";
         this.playersBindingNavigatorSaveItem.Size = new System.Drawing.Size( 23, 23 );
         this.playersBindingNavigatorSaveItem.Text = "Save Data";
         this.playersBindingNavigatorSaveItem.Click += new System.EventHandler( this.playersBindingNavigatorSaveItem_Click );
         // 
         // playersDataGridView
         // 
         this.playersDataGridView.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                     | System.Windows.Forms.AnchorStyles.Right ) ) );
         this.playersDataGridView.AutoGenerateColumns = false;
         this.playersDataGridView.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4} );
         this.playersDataGridView.DataSource = this.playersBindingSource;
         this.playersDataGridView.Location = new System.Drawing.Point( 0, 25 );
         this.playersDataGridView.Name = "playersDataGridView";
         this.playersDataGridView.Size = new System.Drawing.Size( 444, 138 );
         this.playersDataGridView.TabIndex = 1;
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "PlayerID";
         this.dataGridViewTextBoxColumn1.HeaderText = "PlayerID";
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
         // dataGridViewTextBoxColumn4
         // 
         this.dataGridViewTextBoxColumn4.DataPropertyName = "BattingAverage";
         this.dataGridViewTextBoxColumn4.HeaderText = "BattingAverage";
         this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
         // 
         // outputTextBox
         // 
         this.outputTextBox.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                     | System.Windows.Forms.AnchorStyles.Left )
                     | System.Windows.Forms.AnchorStyles.Right ) ) );
         this.outputTextBox.Location = new System.Drawing.Point( 0, 210 );
         this.outputTextBox.Multiline = true;
         this.outputTextBox.Name = "outputTextBox";
         this.outputTextBox.ReadOnly = true;
         this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.outputTextBox.Size = new System.Drawing.Size( 444, 104 );
         this.outputTextBox.TabIndex = 5;
         // 
         // writeButton
         // 
         this.writeButton.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F );
         this.writeButton.Location = new System.Drawing.Point( 126, 172 );
         this.writeButton.Name = "writeButton";
         this.writeButton.Size = new System.Drawing.Size( 193, 31 );
         this.writeButton.TabIndex = 4;
         this.writeButton.Text = "Write to XML";
         this.writeButton.Click += new System.EventHandler( this.writeButton_Click );
         // 
         // XMLWriterForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 444, 314 );
         this.Controls.Add( this.outputTextBox );
         this.Controls.Add( this.writeButton );
         this.Controls.Add( this.playersDataGridView );
         this.Controls.Add( this.playersBindingNavigator );
         this.Name = "XMLWriterForm";
         this.Text = "XML Writer";
         this.Load += new System.EventHandler( this.XMLWriterForm_Load );
         ( ( System.ComponentModel.ISupportInitialize ) ( this.baseballDataSet ) ).EndInit();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.playersBindingSource ) ).EndInit();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.playersBindingNavigator ) ).EndInit();
         this.playersBindingNavigator.ResumeLayout( false );
         this.playersBindingNavigator.PerformLayout();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.playersDataGridView ) ).EndInit();
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private BaseballDataSet baseballDataSet;
      private System.Windows.Forms.BindingSource playersBindingSource;
      private XMLWriter.BaseballDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
      private System.Windows.Forms.BindingNavigator playersBindingNavigator;
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
      private System.Windows.Forms.ToolStripButton playersBindingNavigatorSaveItem;
      private System.Windows.Forms.DataGridView playersDataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
      private System.Windows.Forms.TextBox outputTextBox;
      private System.Windows.Forms.Button writeButton;
   }
}

