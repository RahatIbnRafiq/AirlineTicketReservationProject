// Fig. 23.20: BinaryTreeLibrary2.cs
// Definition of class TreeNode and class Tree for IComparable
// objects.

using System;

namespace BinaryTreeLibrary2
{
   // class TreeNode definition
   class TreeNode 
   {
      private TreeNode leftNode;   
      private IComparable data;        
      private TreeNode rightNode;  

      // initialize data and make this a leaf node
      public TreeNode( IComparable nodeData )
      { 
         data = nodeData;              
         leftNode = rightNode = null;  // node has no children
      }
      
      // LeftNode property
      public TreeNode LeftNode 
      {
         get 
         {
            return leftNode;
         }
         
         set
         {
            leftNode = value;
         }
      }
      
      // Data property
      public IComparable Data
      {
         get 
         {
            return data;
         }

         set 
         {
            data = value;
         }
      }
      
      // RightNode property
      public TreeNode RightNode 
      {
         get 
         {
            return rightNode;
         }
         
         set
         {
            rightNode = value;
         }
      }
      

      // insert TreeNode into Tree that contains nodes;
      // ignore duplicate values
      public void Insert( IComparable insertValue )
      {
         // insert in left subtree
         if ( insertValue.CompareTo( data ) < 0 ) 
         {
            // insert new TreeNode
            if ( leftNode == null )
               leftNode = new TreeNode( insertValue );

               // continue traversing left subtree
            else
               leftNode.Insert( insertValue );
         }

            // insert in right subtree
         else if ( insertValue.CompareTo( data ) > 0 ) 
         {
            // insert new TreeNode
            if ( rightNode == null )
               rightNode = new TreeNode( insertValue );

               // continue traversing right subtree
            else
               rightNode.Insert( insertValue );
         }

      }  // end method Insert

   }  // end class TreeNode

   // class Tree definition
   public class Tree 
   {
      private TreeNode root;

      // construct an empty Tree of integers
      public Tree() 
      { 
         root = null; 
      }

      // Insert a new node in the binary search tree.
      // If the root node is null, create the root node here.
      // Otherwise, call the insert method of class TreeNode.
      public void InsertNode( IComparable insertValue )
      {
         lock ( this ) 
         {                          
            if ( root == null )
               root = new TreeNode( insertValue );

            else
               root.Insert( insertValue );
         }
      }

      // begin preorder traversal
      public void PreorderTraversal()
      { 
         lock ( this ) 
         {
            PreorderHelper( root ); 
         }
      }

      // recursive method to perform preorder traversal
      private void PreorderHelper( TreeNode node )
      {
         if ( node == null )
            return;

         // output node data
         Console.Write( node.Data + " " );  

         // traverse left subtree
         PreorderHelper( node.LeftNode );     

         // traverse right subtree
         PreorderHelper( node.RightNode );     
      }

      // begin inorder traversal
      public void InorderTraversal()
      { 
         lock ( this ) 
         {
            InorderHelper( root ); 
         }
      }

      // recursive method to perform inorder traversal
      private void InorderHelper( TreeNode node )
      {
         if ( node == null )
            return;

         // traverse left subtree
         InorderHelper( node.LeftNode );

         // output node data
         Console.Write( node.Data + " " );

         // traverse right subtree
         InorderHelper( node.RightNode );
      }

      // begin postorder traversal
      public void PostorderTraversal()
      { 
         lock ( this ) 
         {
            PostorderHelper( root ); 
         }
      }

      // recursive method to perform postorder traversal
      private void PostorderHelper( TreeNode node )
      {
         if ( node == null )
            return;

         // traverse left subtree
         PostorderHelper( node.LeftNode );

         // traverse right subtree
         PostorderHelper( node.RightNode );

         // output node data
         Console.Write( node.Data + " " );
      }

   }  // end class Tree
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
