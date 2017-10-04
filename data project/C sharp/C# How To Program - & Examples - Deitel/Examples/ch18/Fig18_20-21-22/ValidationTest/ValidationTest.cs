// Fig. 18.20: ValidationTest.cs
// Validating XML documents against Schemas.

using System;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;  // contains Schema classes

// determines XML document Schema validity
public class ValidationTest : System.Windows.Forms.Form
{
   private System.Windows.Forms.ComboBox filesComboBox;
   private System.Windows.Forms.Button validateButton;
   private System.Windows.Forms.Label consoleLabel;
   private System.ComponentModel.Container components = null;

   private XmlSchemaCollection schemas;   //Schemas
   private bool valid;                    // validation result

   public ValidationTest()
   {
      InitializeComponent();
		   
      valid = true;  // assume document is valid

      // get Schema(s) for validation
      schemas = new XmlSchemaCollection();
      schemas.Add( "book", "book.xdr" );
      schemas.Add( "http://www.deitel.com/booklist", "book.xsd" );
      
   } // end constructor

      #region Windows Form Designer generated code
      
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

      
   /// <summary>
   /// Required method for Designer support - do not modify
   /// the contents of this method with the code editor.
   /// </summary>
   private void InitializeComponent()
   {
      this.validateButton = new System.Windows.Forms.Button();
      this.consoleLabel = new System.Windows.Forms.Label();
      this.filesComboBox = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // validateButton
      // 
      this.validateButton.Location = new System.Drawing.Point(8, 48);
      this.validateButton.Name = "validateButton";
      this.validateButton.Size = new System.Drawing.Size(272, 23);
      this.validateButton.TabIndex = 1;
      this.validateButton.Text = "Validate";
      this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
      // 
      // consoleLabel
      // 
      this.consoleLabel.BackColor = System.Drawing.Color.Honeydew;
      this.consoleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.consoleLabel.Location = new System.Drawing.Point(8, 88);
      this.consoleLabel.Name = "consoleLabel";
      this.consoleLabel.Size = new System.Drawing.Size(272, 64);
      this.consoleLabel.TabIndex = 2;
      // 
      // filesComboBox
      // 
      this.filesComboBox.DropDownWidth = 272;
      this.filesComboBox.Items.AddRange(new object[] {
                                                        "bookxsd.xml",
                                                        "bookxdr.xml",
                                                        "bookxsdfail.xml",
                                                        "bookxdrfail.xml"});
      this.filesComboBox.Location = new System.Drawing.Point(8, 8);
      this.filesComboBox.Name = "filesComboBox";
      this.filesComboBox.Size = new System.Drawing.Size(272, 21);
      this.filesComboBox.TabIndex = 0;
      // 
      // ValidationTest
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(292, 157);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                   this.consoleLabel,
                                                                   this.validateButton,
                                                                   this.filesComboBox});
      this.Name = "ValidationTest";
      this.Text = "ValidationTest";
      this.ResumeLayout(false);

   }
      #endregion

   [STAThread]
   static void Main() 
   {
      Application.Run( new ValidationTest() );
   } // end Main

   // handle validateButton click event
   private void validateButton_Click( object sender, 
      System.EventArgs e )
   {
      // get XML document
      XmlTextReader reader = 
         new XmlTextReader( filesComboBox.Text );

      // get validator
      XmlValidatingReader validator =
         new XmlValidatingReader( reader );

      // assign Schema(s)
      validator.Schemas.Add( schemas );

      // set validation type
      validator.ValidationType = ValidationType.Auto;

      // register event handler for validation error(s)
      validator.ValidationEventHandler += 
         new ValidationEventHandler( ValidationError );
         
      // validate document node-by-node
      while ( validator.Read() ) ; // empty body

      // check validation result
      if ( valid )
         consoleLabel.Text = "Document is valid";

      valid = true; // reset variable

      // close reader stream
      validator.Close();
   }  // end validateButton_Click
	   
   // event handler for validation error
   private void ValidationError( object sender, 
      ValidationEventArgs arguments ) 
   {
      consoleLabel.Text = arguments.Message;
      valid = false; // validation failed
   } // end ValidationError
} // end ValidationTest


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
