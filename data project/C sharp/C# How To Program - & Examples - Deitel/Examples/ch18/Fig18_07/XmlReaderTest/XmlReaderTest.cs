// Fig. 18.7: XmlReaderTest.cs
// Reading an XML document.

using System;
using System.Windows.Forms;
using System.Xml;

public class XmlReaderTest : System.Windows.Forms.Form
{
   private System.Windows.Forms.TextBox outputTextBox;
   private System.ComponentModel.Container components = null;

   public XmlReaderTest()
   {
      InitializeComponent();

      // reference to "XML document"
      XmlDocument document = new XmlDocument();
      document.Load( "..\\..\\article.xml" );

      // create XmlNodeReader for document
      XmlNodeReader reader = new XmlNodeReader( document );
			
      // show form before outputTextBox is populated
      this.Show();

      // tree depth is -1, no indentation
      int depth = -1;

      // display each node's content
      while ( reader.Read() )
      {
         switch ( reader.NodeType )
         {
               // if Element, display its name  
            case XmlNodeType.Element:

               // increase tab depth
               depth++;
               TabOutput( depth );
               outputTextBox.Text += "<" + reader.Name + ">" + 
                  "\r\n";

               // if empty element, decrease depth
               if ( reader.IsEmptyElement )
                  depth--;

               break;

               // if Comment, display it
            case XmlNodeType.Comment:
               TabOutput( depth );
               outputTextBox.Text += 
                  "<!--" + reader.Value + "-->\r\n";
               break;

               // if Text, display it
            case XmlNodeType.Text:
               TabOutput( depth );
               outputTextBox.Text += "\t" + reader.Value + 
                  "\r\n";
               break;

               // if XML declaration, display it
            case XmlNodeType.XmlDeclaration:
               TabOutput( depth );
               outputTextBox.Text += "<?" + reader.Name + " " 
                  + reader.Value + " ?>\r\n";
               break;
            
               // if EndElement, display it and decrement depth
            case XmlNodeType.EndElement:     
               TabOutput( depth );
               outputTextBox.Text += "</" + reader.Name
                  + ">\r\n";
               depth--;    
               break;	
         } // end switch statement
      } // end while loop
   } // End XmlReaderTest constructor

   // insert tabs
   private void TabOutput( int number )
   {
      for ( int i = 0; i < number; i++ )
         outputTextBox.Text += "\t";
   } // end TabOutput

		#region Windows Form Designer generated code
   /// <summary>
   /// Required method for Designer support - do not modify
   /// the contents of this method with the code editor.
   /// </summary>
   private void InitializeComponent()
   {
      this.outputTextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // outputTextBox
      // 
      this.outputTextBox.BackColor = System.Drawing.Color.Honeydew;
      this.outputTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.outputTextBox.Location = new System.Drawing.Point(8, 8);
      this.outputTextBox.Multiline = true;
      this.outputTextBox.Name = "outputTextBox";
      this.outputTextBox.ReadOnly = true;
      this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.outputTextBox.Size = new System.Drawing.Size(384, 376);
      this.outputTextBox.TabIndex = 1;
      this.outputTextBox.Text = "";
      this.outputTextBox.WordWrap = false;
      // 
      // XmlReaderTest
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(400, 389);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                   this.outputTextBox});
      this.Name = "XmlReaderTest";
      this.Text = "XmlReaderTest";
      this.ResumeLayout(false);

   }

      
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

		#endregion

   [STAThread]
   static void Main() 
   {
      Application.Run( new XmlReaderTest() );
   } // end main
} // end XmlReaderTest

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