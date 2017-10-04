// Fig. 20.44: AddressBook.cs
// Allows users to manipulate an address book.
using System;
using System.Windows.Forms;

namespace AddressBook
{
   public partial class AddressBookForm : Form
   {
      public AddressBookForm()
      {
         InitializeComponent();
      } // end AddressBookForm constructor

      // Click event handler for the Save Button in the 
      // BindingNavigator saves the changes made to the data
      private void addressesBindingNavigatorSaveItem_Click( 
         object sender, EventArgs e )
      {
         this.Validate();
         this.addressesBindingSource.EndEdit();
         this.addressesTableAdapter.Update( 
            this.addressBookDataSet.Addresses );
      } // end method bindingNavigatorSaveItem_Click

      // loads data into the addressBookDataSet.Addresses table
      private void AddressBookForm_Load( object sender, EventArgs e )
      {
         // TODO: This line of code loads data into the 
         // 'addressBookDataSet.Addresses' table. You can move, 
         // or remove it, as needed.
         this.addressesTableAdapter.Fill( 
            this.addressBookDataSet.Addresses );
      } // end method AddressBookForm_Load

      // loads data for the rows with the specified last name
      // into the addressBookDataSet.Addresses table
      private void findButton_Click( object sender, EventArgs e )
      {
         // fill the DataSet's DataTable with only rows
         // containing the user-specified last name
         addressesTableAdapter.FillByLastName(
            addressBookDataSet.Addresses, findTextBox.Text );
      } // end method findButton_Click

      // reloads addressBookDataSet.Addresses with all rows
      private void browseAllButton_Click( object sender, EventArgs e )
      {
         // fill the DataSet's DataTable with all rows in the database
         addressesTableAdapter.Fill( addressBookDataSet.Addresses );

         findTextBox.Text = ""; // clear Find TextBox
      } // end method browseAllButton_Click
   } // end class AddressBookForm
} // end namespace AddressBook


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
