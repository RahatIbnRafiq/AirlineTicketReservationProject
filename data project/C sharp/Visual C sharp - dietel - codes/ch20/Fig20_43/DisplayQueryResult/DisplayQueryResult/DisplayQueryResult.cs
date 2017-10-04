// Fig. 20.43: DisplayQueryResult.cs
// Displays the result of a user-selected query in a DataGridView.
using System;
using System.Windows.Forms;

namespace DisplayQueryResult
{
   public partial class DisplayQueryResultForm : Form
   {
      public DisplayQueryResultForm()
      {
         InitializeComponent();
      } // end DisplayQueryResultForm constructor

      // Click event handler for the Save Button in the 
      // BindingNavigator saves the changes made to the data
      private void titlesBindingNavigatorSaveItem_Click( 
         object sender, EventArgs e )
      {
         this.Validate();
         this.titlesBindingSource.EndEdit();
         this.titlesTableAdapter.Update( this.booksDataSet.Titles );
      } // end method titlesBindingNavigatorSaveItem_Click

      // loads data into the booksDataSet.Titles table, 
      // which is then displayed in the DataGridView
      private void DisplayQueryResultForm_Load( 
         object sender, EventArgs e )
      {
         // TODO: This line of code loads data into the 
         // 'booksDataSet.Titles' table. You can move, or remove it, 
         // as needed.
         this.titlesTableAdapter.Fill( this.booksDataSet.Titles );

         // set the ComboBox to show the default query that
         // selects all books from the Titles table
         queriesComboBox.SelectedIndex = 0;
      } // end method DisplayQueryResultForm_Load

      // loads data into the booksDataSet.Titles table based on
      // user-selected query
      private void queriesComboBox_SelectedIndexChanged( 
         object sender, EventArgs e )
      {
         // fill the Titles DataTable with
         // the result of the selected query
         switch ( queriesComboBox.SelectedIndex )
         {
            case 0: // all books
               titlesTableAdapter.Fill( booksDataSet.Titles );
               break;
            case 1: // books with copyright year 2006
               titlesTableAdapter.FillWithCopyright2006(
                  booksDataSet.Titles );
               break;
            case 2: // How to Program books, sorted by Title
               titlesTableAdapter.FillWithHowToProgramBooks(
                  booksDataSet.Titles );
               break;
         } // end switch
      } // end method queriesComboBox_SelectedIndexChanged
   } // end class DisplayQueryResultForm
} // end namespace DisplayQueryResult


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