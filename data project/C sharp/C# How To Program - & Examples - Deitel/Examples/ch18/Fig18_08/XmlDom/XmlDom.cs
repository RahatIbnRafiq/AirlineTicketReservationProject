// Fig. 18.8: XmlDom.cs
// Demonstrates DOM tree manipulation.

using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.CodeDom.Compiler;  // contains TempFileCollection

// Class XmlDom demonstrates the DOM
public class XmlDom : System.Windows.Forms.Form
{
   private System.Windows.Forms.Button buildButton;
   private System.Windows.Forms.Button printButton;
   private System.Windows.Forms.TreeView xmlTreeView;
   private System.Windows.Forms.TextBox consoleTextBox;
   private System.Windows.Forms.Button resetButton;
   private System.ComponentModel.Container components = null;

   private XmlDocument source; // reference to "XML document"

   // reference copy of source's "XML document"
   private XmlDocument copy;

   private TreeNode tree; // TreeNode reference

   public XmlDom()
   {
      InitializeComponent();
   
      // create XmlDocument and load letter.xml
      source = new XmlDocument();
      source.Load( "..\\..\\letter.xml" );
        
      // initialize references to null
      copy = null;
      tree = null;
   } // end XmlDom

      #region Windows Form Designer generated code
   /// <summary>
   /// Required method for Designer support - do not modify
   /// the contents of this method with the code editor.
   /// </summary>
   private void InitializeComponent()
   {
      this.resetButton = new System.Windows.Forms.Button();
      this.buildButton = new System.Windows.Forms.Button();
      this.xmlTreeView = new System.Windows.Forms.TreeView();
      this.consoleTextBox = new System.Windows.Forms.TextBox();
      this.printButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // resetButton
      // 
      this.resetButton.Enabled = false;
      this.resetButton.Location = new System.Drawing.Point(248, 8);
      this.resetButton.Name = "resetButton";
      this.resetButton.Size = new System.Drawing.Size(104, 23);
      this.resetButton.TabIndex = 4;
      this.resetButton.Text = "Reset";
      this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
      // 
      // buildButton
      // 
      this.buildButton.Location = new System.Drawing.Point(8, 8);
      this.buildButton.Name = "buildButton";
      this.buildButton.Size = new System.Drawing.Size(104, 23);
      this.buildButton.TabIndex = 0;
      this.buildButton.Text = "Build";
      this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
      // 
      // xmlTreeView
      // 
      this.xmlTreeView.ImageIndex = -1;
      this.xmlTreeView.Location = new System.Drawing.Point(8, 40);
      this.xmlTreeView.Name = "xmlTreeView";
      this.xmlTreeView.SelectedImageIndex = -1;
      this.xmlTreeView.Size = new System.Drawing.Size(344, 168);
      this.xmlTreeView.TabIndex = 2;
      // 
      // consoleTextBox
      // 
      this.consoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.consoleTextBox.Location = new System.Drawing.Point(8, 224);
      this.consoleTextBox.Multiline = true;
      this.consoleTextBox.Name = "consoleTextBox";
      this.consoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.consoleTextBox.Size = new System.Drawing.Size(344, 112);
      this.consoleTextBox.TabIndex = 3;
      this.consoleTextBox.Text = "";
      // 
      // printButton
      // 
      this.printButton.Enabled = false;
      this.printButton.Location = new System.Drawing.Point(128, 8);
      this.printButton.Name = "printButton";
      this.printButton.Size = new System.Drawing.Size(104, 23);
      this.printButton.TabIndex = 1;
      this.printButton.Text = "Print";
      this.printButton.Click += new System.EventHandler(this.printButton_Click);
      // 
      // XmlDom
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(360, 341);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                   this.resetButton,
                                                                   this.consoleTextBox,
                                                                   this.xmlTreeView,
                                                                   this.printButton,
                                                                   this.buildButton});
      this.Name = "XmlDom";
      this.Text = "XmlDom";
      this.ResumeLayout(false);

   }

   protected override void Dispose( bool disposing )
   {
      if ( disposing )
      {
         if (components != null) 
         {
            components.Dispose();
         }
      }
      base.Dispose( disposing );
   }
      #endregion

   [STAThread]
   static void Main() 
   {
      Application.Run( new XmlDom() );
   }

   // event handler for buildButton click event
   private void buildButton_Click( object sender, 
      System.EventArgs e )
   {
      // determine if copy has been built already
      if ( copy != null ) 
         return;  // document already exists
         
      // instantiate XmlDocument and TreeNode
      copy = new XmlDocument();
      tree = new TreeNode();

      // add root node name to TreeNode and add
      // TreeNode to TreeView control
      tree.Text = source.Name;      // assigns #root
      xmlTreeView.Nodes.Add( tree );

      // build node and tree hierarchy
      BuildTree( source, copy, tree );
      
      printButton.Enabled = true;
      resetButton.Enabled = true;
   } // end buildButton_Click
   
   // event handler for printButton click event
   private void printButton_Click( object sender, 
      System.EventArgs e )
   {
      // exit if copy does not reference an XmlDocument
      if ( copy == null )
         return;

      // create temporary XML file
      TempFileCollection file = new TempFileCollection();

      // create file that is deleted at program termination
      file.AddExtension( "xml", false );
      String[] filename = new String[ 1 ];
      file.CopyTo( filename, 0 );

      // write XML data to disk
      XmlTextWriter writer = new XmlTextWriter( filename[ 0 ], 
         System.Text.Encoding.UTF8 );
      copy.WriteTo( writer );
      writer.Close();
         
      // parse and load temporary XML document
      XmlTextReader reader = new XmlTextReader( filename[ 0 ] );

      // read, format and display data
      while( reader.Read() ) 
      {
         if ( reader.NodeType == XmlNodeType.EndElement )
            consoleTextBox.Text += "/";
          
         if ( reader.Name != String.Empty )
            consoleTextBox.Text += reader.Name + "\r\n";
            
         if ( reader.Value != String.Empty )
            consoleTextBox.Text += "\t" + reader.Value + 
               "\r\n";
      } // end while

      reader.Close();
   } // end printButton_Click

   // handle resetButton click event
   private void resetButton_Click( object sender, 
      System.EventArgs e )
   {
      // remove TreeView nodes
      if ( tree != null ) 
         xmlTreeView.Nodes.Remove( tree );

      xmlTreeView.Refresh(); // force TreeView update

      // delete XmlDocument and tree
      copy = null;
      tree = null;
         
      consoleTextBox.Text = "";  // clear text box
      
      printButton.Enabled = false;
      resetButton.Enabled = false;
   } // end resetButton_Click

   // construct DOM tree
   private void BuildTree( XmlNode xmlSourceNode, 
      XmlNode document, TreeNode treeNode )
   {
      // create XmlNodeReader to access XML document
      XmlNodeReader nodeReader = new XmlNodeReader( 
         xmlSourceNode );
         
      // represents current node in DOM tree
      XmlNode currentNode = null;

      // treeNode to add to existing tree
      TreeNode newNode = new TreeNode();

      // references modified node type for CreateNode
      XmlNodeType modifiedNodeType;

      while ( nodeReader.Read() )
      {
         // get current node type
         modifiedNodeType = nodeReader.NodeType;

         // check for EndElement, store as Element
         if ( modifiedNodeType == XmlNodeType.EndElement )
            modifiedNodeType = XmlNodeType.Element;

         // create node copy
         currentNode = copy.CreateNode( modifiedNodeType, 
            nodeReader.Name, nodeReader.NamespaceURI );

         // build tree based on node type
         switch ( nodeReader.NodeType )
         {
               // if Text node, add its value to tree
            case XmlNodeType.Text:
               newNode.Text = nodeReader.Value;
               treeNode.Nodes.Add( newNode );

               // append Text node value to currentNode data
               ( ( XmlText ) currentNode ).AppendData( 
                  nodeReader.Value );
               document.AppendChild( currentNode );
               break;

               // if EndElement, move up tree
            case XmlNodeType.EndElement:
               document = document.ParentNode;
               treeNode = treeNode.Parent;
               break;

               // if new element, add name and traverse tree
            case XmlNodeType.Element:

               // determine if element contains content
               if ( !nodeReader.IsEmptyElement )
               {
                  // assign node text, add newNode as child
                  newNode.Text = nodeReader.Name;
                  treeNode.Nodes.Add( newNode );

                  // set treeNode to last child
                  treeNode = newNode;
                
                  document.AppendChild( currentNode );
                  document = document.LastChild;
               }
               else // do not traverse empty elements
               {
                  // assign NodeType string to newNode
                  newNode.Text = 
                     nodeReader.NodeType.ToString();

                  treeNode.Nodes.Add( newNode );
                  document.AppendChild( currentNode );
               }

               break;
               
               // all other types, display node type
            default:
               newNode.Text = nodeReader.NodeType.ToString();
               treeNode.Nodes.Add( newNode );
               document.AppendChild( currentNode );
               break;
         }  // end switch

         newNode = new TreeNode();
      } // end while

      // update the TreeView control
      xmlTreeView.ExpandAll();
      xmlTreeView.Refresh();

   } // end BuildTree
} // end XmlDom
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