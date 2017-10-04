// Fig. 18.9: PathNavigator.cs
// Demonstrates Class XPathNavigator.

using System;
using System.Windows.Forms;
using System.Xml.XPath; // Contains XPathNavigator 

public class PathNavigator : System.Windows.Forms.Form
{
   private System.Windows.Forms.Button firstChildButton;
   private System.Windows.Forms.Button parentButton;
   private System.Windows.Forms.Button nextButton;
   private System.Windows.Forms.Button previousButton;
   private System.Windows.Forms.Button selectButton;
   private System.Windows.Forms.TreeView pathTreeViewer;
   private System.Windows.Forms.ComboBox selectComboBox;
   private System.ComponentModel.Container components = null;
   private System.Windows.Forms.TextBox selectTreeViewer;
   private System.Windows.Forms.GroupBox navigateBox;
   private System.Windows.Forms.GroupBox locateBox;

   // navigator to traverse document
   private XPathNavigator xpath;

   // references  document for use by XPathNavigator
   private XPathDocument document;

   // references TreeNode list used by TreeView control
   private TreeNode tree;

   public PathNavigator()
   {
      InitializeComponent();

      // load in XML document
      document = new XPathDocument( "..\\..\\sports.xml" );
      
      // create navigator
      xpath = document.CreateNavigator();
      
      // create root node for TreeNodes
      tree = new TreeNode();

      tree.Text = xpath.NodeType.ToString(); // #root
      pathTreeViewer.Nodes.Add( tree );      // add tree

      // update TreeView control
      pathTreeViewer.ExpandAll();
      pathTreeViewer.Refresh();
      pathTreeViewer.SelectedNode = tree;    // hightlight root
   } // end constructor

      #region Windows Form Designer generated code
      
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

      
   /// <summary>
   /// Required method for Designer support - do not modify
   /// the contents of this method with the code editor.
   /// </summary>
   /// 
   private void InitializeComponent()
   {
      this.selectButton = new System.Windows.Forms.Button();
      this.nextButton = new System.Windows.Forms.Button();
      this.parentButton = new System.Windows.Forms.Button();
      this.firstChildButton = new System.Windows.Forms.Button();
      this.pathTreeViewer = new System.Windows.Forms.TreeView();
      this.previousButton = new System.Windows.Forms.Button();
      this.selectComboBox = new System.Windows.Forms.ComboBox();
      this.navigateBox = new System.Windows.Forms.GroupBox();
      this.locateBox = new System.Windows.Forms.GroupBox();
      this.selectTreeViewer = new System.Windows.Forms.TextBox();
      this.navigateBox.SuspendLayout();
      this.locateBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // selectButton
      // 
      this.selectButton.Location = new System.Drawing.Point(8, 24);
      this.selectButton.Name = "selectButton";
      this.selectButton.Size = new System.Drawing.Size(80, 23);
      this.selectButton.TabIndex = 9;
      this.selectButton.Text = "Select";
      this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
      // 
      // nextButton
      // 
      this.nextButton.Location = new System.Drawing.Point(48, 88);
      this.nextButton.Name = "nextButton";
      this.nextButton.Size = new System.Drawing.Size(80, 23);
      this.nextButton.TabIndex = 3;
      this.nextButton.Text = "Next";
      this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
      // 
      // parentButton
      // 
      this.parentButton.Location = new System.Drawing.Point(8, 56);
      this.parentButton.Name = "parentButton";
      this.parentButton.Size = new System.Drawing.Size(80, 23);
      this.parentButton.TabIndex = 2;
      this.parentButton.Text = "Parent";
      this.parentButton.Click += new System.EventHandler(this.parentButton_Click);
      // 
      // firstChildButton
      // 
      this.firstChildButton.Location = new System.Drawing.Point(96, 56);
      this.firstChildButton.Name = "firstChildButton";
      this.firstChildButton.Size = new System.Drawing.Size(80, 24);
      this.firstChildButton.TabIndex = 1;
      this.firstChildButton.Text = "First Child";
      this.firstChildButton.Click += new System.EventHandler(this.firstChildButton_Click);
      // 
      // pathTreeViewer
      // 
      this.pathTreeViewer.FullRowSelect = true;
      this.pathTreeViewer.HideSelection = false;
      this.pathTreeViewer.ImageIndex = -1;
      this.pathTreeViewer.Location = new System.Drawing.Point(8, 264);
      this.pathTreeViewer.Name = "pathTreeViewer";
      this.pathTreeViewer.SelectedImageIndex = -1;
      this.pathTreeViewer.Size = new System.Drawing.Size(328, 144);
      this.pathTreeViewer.TabIndex = 13;
      // 
      // previousButton
      // 
      this.previousButton.Location = new System.Drawing.Point(48, 24);
      this.previousButton.Name = "previousButton";
      this.previousButton.Size = new System.Drawing.Size(80, 23);
      this.previousButton.TabIndex = 7;
      this.previousButton.Text = "Previous";
      this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
      // 
      // selectComboBox
      // 
      this.selectComboBox.DropDownWidth = 240;
      this.selectComboBox.Items.AddRange(new object[] {
                                                         "/sports",
                                                         "/sports/game/name",
                                                         "/sports/game/paragraph",
                                                         "/sports/game[name=\'Cricket\']"});
      this.selectComboBox.Location = new System.Drawing.Point(96, 24);
      this.selectComboBox.Name = "selectComboBox";
      this.selectComboBox.Size = new System.Drawing.Size(240, 21);
      this.selectComboBox.TabIndex = 14;
      // 
      // navigateBox
      // 
      this.navigateBox.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                               this.firstChildButton,
                                                                               this.parentButton,
                                                                               this.previousButton,
                                                                               this.nextButton});
      this.navigateBox.Location = new System.Drawing.Point(80, 136);
      this.navigateBox.Name = "navigateBox";
      this.navigateBox.Size = new System.Drawing.Size(184, 120);
      this.navigateBox.TabIndex = 16;
      this.navigateBox.TabStop = false;
      this.navigateBox.Text = "Navigation Controls";
      // 
      // locateBox
      // 
      this.locateBox.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                             this.selectTreeViewer,
                                                                             this.selectComboBox,
                                                                             this.selectButton});
      this.locateBox.Location = new System.Drawing.Point(8, 8);
      this.locateBox.Name = "locateBox";
      this.locateBox.Size = new System.Drawing.Size(336, 128);
      this.locateBox.TabIndex = 17;
      this.locateBox.TabStop = false;
      this.locateBox.Text = "Locate Element";
      // 
      // selectTreeViewer
      // 
      this.selectTreeViewer.BackColor = System.Drawing.Color.Honeydew;
      this.selectTreeViewer.Location = new System.Drawing.Point(16, 56);
      this.selectTreeViewer.Multiline = true;
      this.selectTreeViewer.Name = "selectTreeViewer";
      this.selectTreeViewer.ReadOnly = true;
      this.selectTreeViewer.Size = new System.Drawing.Size(304, 64);
      this.selectTreeViewer.TabIndex = 15;
      this.selectTreeViewer.Text = "";
      // 
      // PathNavigator
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(352, 413);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                   this.locateBox,
                                                                   this.navigateBox,
                                                                   this.pathTreeViewer});
      this.Name = "PathNavigator";
      this.Text = "PathNavigator";
      this.navigateBox.ResumeLayout(false);
      this.locateBox.ResumeLayout(false);
      this.ResumeLayout(false);

   }
      #endregion

   [STAThread]
   static void Main() 
   {
      Application.Run( new PathNavigator() );
   }

   // traverse to first child
   private void firstChildButton_Click( object sender, 
      System.EventArgs e )
   {
      TreeNode newTreeNode;

      // move to first child
      if ( xpath.MoveToFirstChild() )
      {
         newTreeNode = new TreeNode(); // create new node
         
         // set node's Text property to either 
         // navigator's name or value
         DetermineType( newTreeNode, xpath );

         // add node to TreeNode node list
         tree.Nodes.Add( newTreeNode ); 
         tree = newTreeNode; // assign tree newTreeNode
            
         // update TreeView control
         pathTreeViewer.ExpandAll();
         pathTreeViewer.Refresh();
         pathTreeViewer.SelectedNode = tree;
      }
      else // node has no children
         MessageBox.Show( "Current Node has no children.", 
            "", MessageBoxButtons.OK,
            MessageBoxIcon.Information );
   }

   // traverse to node's parent on parentButton click event
   private void parentButton_Click( object sender, 
      System.EventArgs e )
   {
      // move to parent
      if ( xpath.MoveToParent() ) 
      {
         tree = tree.Parent;

         // get number of child nodes, not including sub trees
         int count = tree.GetNodeCount( false );
         
         // remove all children
         tree.Nodes.Clear();

         // update TreeView control
         pathTreeViewer.ExpandAll();
         pathTreeViewer.Refresh();
         pathTreeViewer.SelectedNode = tree;
      }
      else // if node has no parent (root node)
         MessageBox.Show( "Current node has no parent.", "",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information );
   }

   // find next sibling on nextButton click event
   private void nextButton_Click( object sender, 
      System.EventArgs e )
   {
      TreeNode newTreeNode = null, newNode = null;

      // move to next sibling
      if ( xpath.MoveToNext() ) 
      {
         newTreeNode = tree.Parent; // get parent node
         
         newNode = new TreeNode(); // create new node
         DetermineType( newNode, xpath );
         newTreeNode.Nodes.Add( newNode );

         // set current position for display
         tree = newNode;

         // update TreeView control
         pathTreeViewer.ExpandAll();
         pathTreeViewer.Refresh();
         pathTreeViewer.SelectedNode = tree;
      }
      else // node has no additional siblings
         MessageBox.Show( "Current node is last sibling.", 
            "", MessageBoxButtons.OK,
            MessageBoxIcon.Information );
   } // end nextButton_Click

   // get previous sibling on previousButton click
   private void previousButton_Click( object sender, 
      System.EventArgs e )
   {
      TreeNode parentTreeNode = null;

      // move to previous sibling
      if ( xpath.MoveToPrevious() )
      {
         parentTreeNode = tree.Parent; // get parent node
            
         // delete current node           
         parentTreeNode.Nodes.Remove( tree );
           
         // move to previous node
         tree = parentTreeNode.LastNode;
            
         // update TreeView control
         pathTreeViewer.ExpandAll();
         pathTreeViewer.Refresh();
         pathTreeViewer.SelectedNode = tree;
      }
      else // if current node has no previous siblings
         MessageBox.Show( "Current node is first sibling.",
            "", MessageBoxButtons.OK,
            MessageBoxIcon.Information );
   } // end previousButton_Click

   // process selectButton click event
   private void selectButton_Click( object sender, 
      System.EventArgs e )
   {
      XPathNodeIterator iterator; // enables node iteration

      // get specified node from ComboBox
      try
      {
         iterator = xpath.Select( selectComboBox.Text );
         DisplayIterator( iterator ); // print selection
      }

         // catch invalid expressions
      catch ( System.ArgumentException argumentException ) 
      {
         MessageBox.Show( argumentException.Message, 
            "Error", MessageBoxButtons.OK,
            MessageBoxIcon.Error );
      }
   } // end selectButton_Click

   // print values for XPathNodeIterator
   private void DisplayIterator( XPathNodeIterator iterator ) 
   {
      selectTreeViewer.Text = "";

      // prints selected node's values
      while ( iterator.MoveNext() )
         selectTreeViewer.Text += 
            iterator.Current.Value.Trim()
            + "\r\n";
   } // end DisplayIterator
      
   // determine if TreeNode should display current node 
   // name or value
   private void DetermineType( TreeNode node, 
      XPathNavigator xPath ) 
   {
      // determine NodeType
      switch ( xPath.NodeType ) 
      {
            // if Element, get its name
         case XPathNodeType.Element: 

            // get current node name, and remove whitespace
            node.Text = xPath.Name.Trim();
            break;
      
            // obtain node values
         default: 

            // get current node value and remove whitespace
            node.Text = xPath.Value.Trim();
            break;

      } // end switch
   } // end DetermineType
} // end PathNavigator


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