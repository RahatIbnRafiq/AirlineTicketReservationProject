// Fig. 20.34: DisplayTable.cs
// Displays data from a database table in a DataGridView.
using System;
using System.Windows.Forms;

namespace DisplayTable
{
   public partial class DisplayTableForm : Form
   {
      public DisplayTableForm()
      {
         InitializeComponent();
      } // end constructor

      // Click event handler for the Save Button in the 
      // BindingNavigator saves the changes made to the data
      private void authorsBindingNavigatorSaveItem_Click( 
         object sender, EventArgs e )
      {
         this.Validate();
         this.authorsBindingSource.EndEdit();
         this.authorsTableAdapter.Update( this.booksDataSet.Authors );
      } // end method authorsBindingNavigatorSaveItem_Click

      // loads data into the booksDataSet.Authors table, 
      // which is then displayed in the DataGridView
      private void DisplayTableForm_Load( object sender, EventArgs e )
      {
         // TODO: This line of code loads data into the 
         // 'booksDataSet.Authors' table. You can move, or remove it, 
         // as needed.
         this.authorsTableAdapter.Fill( this.booksDataSet.Authors );
      } // end method DisplayTableForm_Load
   } // end class DisplayTableForm
} // end namespace DisplayTable


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
