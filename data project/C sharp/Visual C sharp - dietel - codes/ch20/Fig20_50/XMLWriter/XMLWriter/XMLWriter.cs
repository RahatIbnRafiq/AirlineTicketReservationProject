// Fig. 20.50: XMLWriter.cs
// Demonstrates generating XML from an ADO.NET DataSet.
using System;
using System.Windows.Forms;

namespace XMLWriter
{
   public partial class XMLWriterForm : Form
   {
      public XMLWriterForm()
      {
         InitializeComponent();
      } // end XMLWriterForm constructor

      // Click event handler for the Save Button in the 
      // BindingNavigator saves the changes made to the data
      private void playersBindingNavigatorSaveItem_Click( 
         object sender, EventArgs e )
      {
         this.Validate();
         this.playersBindingSource.EndEdit();
         this.playersTableAdapter.Update( this.baseballDataSet.Players );
      } // end method bindingNavigatorSaveItem_Click

      // loads data into the baseballDataSet.Players table
      private void XMLWriterForm_Load( object sender, EventArgs e )
      {
         // TODO: This line of code loads data into the 
         // 'baseballDataSet.Players' table. You can move, 
         // or remove it, as needed.
         this.playersTableAdapter.Fill( this.baseballDataSet.Players );
      }

      // write XML representation of DataSet when Button clicked
      private void writeButton_Click( object sender, EventArgs e )
      {
         // set the namespace for this DataSet
         // and the resulting XML document
         baseballDataSet.Namespace = "http://www.deitel.com/baseball";

         // write XML representation of DataSet to a file
         baseballDataSet.WriteXml( "Players.xml" );

         // display XML representation in TextBox
         outputTextBox.Text += "Writing the following XML:\r\n" +
            baseballDataSet.GetXml() + "\r\n";
      } // end method writeButton_Click
   } // end class XMLWriterForm
} // end namespace XMLWriter


/**************************************************************************
 * (C) Copyright 1992-2006 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
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
 *************************************************************************/
