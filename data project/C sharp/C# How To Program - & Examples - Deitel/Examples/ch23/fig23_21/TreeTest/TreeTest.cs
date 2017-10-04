// Fig. 23.21: TreeTest.java
// This program tests class Tree.

using System;
using BinaryTreeLibrary2;

namespace TreeTest
{
   // class TreeTest definition
   public class TreeTest 
   {
      // test class Tree
      static void Main( string[] args )
      {
         int[] intArray = { 8, 2, 4, 3, 1, 7, 5, 6 };
         double[] doubleArray = 
            { 8.8, 2.2, 4.4, 3.3, 1.1, 7.7, 5.5, 6.6 };
         string[] stringArray = { "eight", "two", "four", 
                                   "three", "one", "seven", "five", "six" };

         // create int Tree
         Tree intTree = new Tree();
         PopulateTree( intArray, intTree, "intTree" );
         TraverseTree( intTree, "intTree" );

         // create double Tree
         Tree doubleTree = new Tree();
         PopulateTree( doubleArray, doubleTree, "doubleTree" );
         TraverseTree( doubleTree, "doubleTree" );

         // create string Tree
         Tree stringTree = new Tree();
         PopulateTree( stringArray, stringTree, "stringTree" );
         TraverseTree( stringTree, "stringTree" );
      }

      // populate Tree with array elements
      static void PopulateTree( 
         Array array, Tree tree, string name )
      {
         Console.WriteLine( "\nInserting into " + name + ":" );

         foreach ( IComparable data in array ) 
         {
            Console.Write( data + " " );
            tree.InsertNode( data );
         }
      }

      // insert perform traversals
      static void TraverseTree( Tree tree, string treeType )
      {
         // perform preorder traversal of tree
         Console.WriteLine( 
            "\n\nPreorder traversal of " + treeType );
         tree.PreorderTraversal();

         // perform inorder traversal of tree
         Console.WriteLine( 
            "\n\nInorder traversal of " + treeType );
         tree.InorderTraversal();

         // perform postorder traversal of tree
         Console.WriteLine( 
            "\n\nPostorder traversal of " + treeType );
         tree.PostorderTraversal();
         Console.WriteLine( "\n" );
      }

   }  // end class TreeTest
}

/**************************************************************************
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
 *************************************************************************/