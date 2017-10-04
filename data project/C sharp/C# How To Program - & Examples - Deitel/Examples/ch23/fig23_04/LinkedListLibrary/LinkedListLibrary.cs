// Fig. 23.4: LinkedListLibrary.cs
// Class ListNode and class List definitions.

using System;

namespace LinkedListLibrary
{
   // class to represent one node in a list
   class ListNode
   {
      private object data;
      private ListNode next;

      // constructor to create ListNode that refers to dataValue
      // and is last node in list
      public ListNode( object dataValue ) 
         : this( dataValue, null )
      {
      }
      
      // constructor to create ListNode that refers to dataValue
      // and refers to next ListNode in List
      public ListNode( object dataValue, ListNode nextNode )
      {
         data = dataValue;  
         next = nextNode;    
      }
      
      // property Next
      public ListNode Next
      {
         get
         {
            return next;
         }

         set
         {
            next = value;
         }
      }

      // property Data
      public object Data
      {
         get
         {
            return data;
         }
      }   

   } // end class ListNode

   // class List definition
   public class List
   {
      private ListNode firstNode;
      private ListNode lastNode;
      private string name;     // string like "list" to display

      // construct empty List with specified name
      public List( string listName )
      {
         name = listName;
         firstNode = lastNode = null;
      }
      
      // construct empty List with "list" as its name
      public List() : this( "list" )
      { 
      }
   
      // Insert object at front of List. If List is empty, 
      // firstNode and lastNode will refer to same object.
      // Otherwise, firstNode refers to new node.
      public void InsertAtFront( object insertItem )
      {
         lock ( this )
         {
            if ( IsEmpty() )
               firstNode = lastNode = 
                  new ListNode( insertItem );
            else
               firstNode = 
                  new ListNode( insertItem, firstNode );
         }
      }

      // Insert object at end of List. If List is empty, 
      // firstNode and lastNode will refer to same object.
      // Otherwise, lastNode's Next property refers to new node.
      public void InsertAtBack( object insertItem )
      {
         lock ( this )
         {
            if ( IsEmpty() )
               firstNode = lastNode = 
                  new ListNode( insertItem );
         
            else
               lastNode = lastNode.Next = 
                  new ListNode( insertItem );
         }
      }

      // remove first node from List
      public object RemoveFromFront()
      {
         lock ( this )
         {
            if ( IsEmpty() )
               throw new EmptyListException( name );
         
            object removeItem = firstNode.Data;   // retrieve data

            // reset firstNode and lastNode references
            if ( firstNode == lastNode )
               firstNode = lastNode = null;
         
            else 
               firstNode = firstNode.Next;
         
            return removeItem;  // return removed data
         }
      }

      // remove last node from List
      public object RemoveFromBack()
      {
         lock ( this )
         {
            if ( IsEmpty() )
               throw new EmptyListException( name );

            object removeItem = lastNode.Data;   // retrieve data

            // reset firstNode and lastNode references
            if ( firstNode == lastNode )
               firstNode = lastNode = null;
         
            else 
            {
               ListNode current = firstNode;

               // loop while current node is not lastNode
               while ( current.Next != lastNode )   
                  current = current.Next;    // move to next node

               // current is new lastNode
               lastNode = current;
               current.Next = null;
            }
 
            return removeItem;  // return removed data
         }
      }

      // return true if List is empty
      public bool IsEmpty()
      {
         lock ( this )
         {
            return firstNode == null;
         }
      }

      // output List contents
      public void Print()
      {
         lock ( this )
         {
            if ( IsEmpty() ) 
            {
               Console.WriteLine( "Empty " + name );
               return;
            }

            Console.Write( "The " + name + " is: " );

            ListNode current = firstNode;
        
            // output current node data while not at end of list
            while ( current != null ) 
            {
               Console.Write( current.Data + " " );
               current = current.Next;
            }

            Console.WriteLine( "\n" );
         }
      }

   } // end class List

   // class EmptyListException definition
   public class EmptyListException : ApplicationException
   {
      public EmptyListException( string name )
         : base( "The " + name + " is empty" )
      {
      }

   } // end class EmptyListException

} // end namespace LinkedListLibrary

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
  
 
