// Fig. 10.25: BubbleSortForm.cs
// Demonstrates bubble sort using delegates to determine
// the sort order.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

public class BubbleSortForm : System.Windows.Forms.Form
{
   private System.Windows.Forms.TextBox originalTextBox;
   private System.Windows.Forms.TextBox sortedTextBox;
   private System.Windows.Forms.Button createButton;
   private System.Windows.Forms.Button ascendingButton;
   private System.Windows.Forms.Button descendingButton;
   private System.Windows.Forms.Label originalLabel;
   private System.Windows.Forms.Label sortedLabel;

   private int[] elementArray = new int[ 10 ];

   // create randomly generated set of numbers to sort
   private void createButton_Click( object sender, 
      System.EventArgs e )
   {
      // clear TextBoxes
      originalTextBox.Clear();
      sortedTextBox.Clear();

      // create random-number generator
      Random randomNumber = new Random();

      // populate elementArray with random integers
      for ( int i = 0; i < elementArray.Length; i++ )
      {
         elementArray[ i ] = randomNumber.Next( 100 );
         originalTextBox.Text += elementArray[ i ] + "\r\n";
      }
   } 
 
   // delegate implementation for ascending sort
   private bool SortAscending( int element1, int element2 )
   {
      return element1 > element2;
   }

   // sort randomly generated numbers in ascending order
   private void ascendingButton_Click( object sender, 
      System.EventArgs e )
   {
      // sort array, passing delegate for SortAscending
      DelegateBubbleSort.SortArray( elementArray, 
         new DelegateBubbleSort.Comparator( 
            SortAscending ) );

      DisplayResults();      
   }

   // delegate implementation for descending sort
   private bool SortDescending( int element1, int element2 )
   {
      return element1 < element2;
   }  
   
   // sort randomly generating numbers in descending order
   private void descendingButton_Click( object sender, 
      System.EventArgs e)
   {
      // sort array, passing delegate for SortDescending
      DelegateBubbleSort.SortArray( elementArray, 
         new DelegateBubbleSort.Comparator( 
            SortDescending ) );

      DisplayResults();       
   }   

   // display the sorted array in sortedTextBox
   private void DisplayResults()
   {
      sortedTextBox.Clear();

      foreach ( int element in elementArray )
         sortedTextBox.Text += element + "\r\n";
   }

   // main entry point for application
   public static void Main( string[] args )
   {
      Application.Run( new BubbleSortForm() );
   }
}
