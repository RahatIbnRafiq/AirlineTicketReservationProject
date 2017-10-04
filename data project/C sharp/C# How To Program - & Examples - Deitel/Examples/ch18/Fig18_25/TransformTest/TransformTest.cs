// Fig. 18.25: TransformTest.cs
// Applying a style sheet to an XML document.

using System;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.IO;

// Transforms XML document with style sheet
public class TransformTest : System.Windows.Forms.Form
{
   private System.Windows.Forms.TextBox consoleTextBox;
   private System.Windows.Forms.Button transformButton;
   private System.ComponentModel.Container components = null;

   private XmlDocument document;     // Xml document root
   private XPathNavigator navigator; // navigate document
   private XslTransform transformer; // transform document
   private StringWriter output;      // display document

   public TransformTest()
   {
      InitializeComponent();

      // load XML data
      document = new XmlDocument();
      document.Load( "..\\..\\sports.xml" );

      // create navigator
      navigator = document.CreateNavigator();

      // load style sheet
      transformer = new XslTransform();
      transformer.Load( "..\\..\\sports.xsl" );      
   }  // end constructor

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
   private void InitializeComponent()
   {
      this.consoleTextBox = new System.Windows.Forms.TextBox();
      this.transformButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // consoleTextBox
      // 
      this.consoleTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
      this.consoleTextBox.Location = new System.Drawing.Point(8, 48);
      this.consoleTextBox.Multiline = true;
      this.consoleTextBox.Name = "consoleTextBox";
      this.consoleTextBox.ReadOnly = true;
      this.consoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.consoleTextBox.Size = new System.Drawing.Size(280, 216);
      this.consoleTextBox.TabIndex = 0;
      this.consoleTextBox.Text = "";
      // 
      // transformButton
      // 
      this.transformButton.Location = new System.Drawing.Point(8, 8);
      this.transformButton.Name = "transformButton";
      this.transformButton.Size = new System.Drawing.Size(280, 23);
      this.transformButton.TabIndex = 1;
      this.transformButton.Text = "Transform XML";
      this.transformButton.Click += new System.EventHandler(this.transformButton_Click);
      // 
      // TransformTest
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(292, 273);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                   this.transformButton,
                                                                   this.consoleTextBox});
      this.Name = "TransformTest";
      this.Text = "TransformTest";
      this.ResumeLayout(false);

   }
		#endregion


   [STAThread]
   static void Main() 
   {
      Application.Run( new TransformTest() );
   }  // end Main

   // transformButton click event
   private void transformButton_Click( object sender, 
      System.EventArgs e )
   {           
      // transform XML data
      output = new StringWriter();
      transformer.Transform( navigator, null, output );
         
      // display transformation in text box
      consoleTextBox.Text = output.ToString();

      // write transformation result to disk
      FileStream stream = new FileStream( "..\\..\\sports.html", 
         FileMode.Create );
      StreamWriter writer = new StreamWriter( stream );
      writer.Write( output.ToString() );

      // close streams
      writer.Close();
      output.Close();
   }  // end transformButton_Click
}     // end TransformTest


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