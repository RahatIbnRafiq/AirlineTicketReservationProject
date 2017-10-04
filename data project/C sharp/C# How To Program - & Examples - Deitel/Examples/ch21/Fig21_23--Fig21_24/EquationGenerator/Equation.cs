// Fig. 21.23: Equation.cs
// Class Equation that contains
// information about an equation.

using System;

public class Equation
{
   private int left, right, result;
   private string operation;
   
   // required default constructor
   public Equation() : this( 0, 0, "+" )
   {
   }

   // constructor for class Equation
   public Equation( int leftValue, int rightValue, 
      string operationType )
   {
      Left = leftValue;
      Right = rightValue;
      Operation = operationType;

      switch ( operationType )
      {
         case "+": 
            Result = Left + Right;
            break;
         case "-":
            Result = Left - Right;
            break;
         case "*": 
            Result = Left * Right;
            break;
      }
   }

   public override string ToString()
   {         
      return Left.ToString() + " " + Operation + " " + 
         Right.ToString() + " = " + Result.ToString();
   }

   // property returning string representing
   // left-hand side
   public string LeftHandSide
   {
      get
      {
         return Left.ToString() + " " + Operation + " " +
            Right.ToString();
      }

      set
      {
      }
   }

   // property returning string representing
   // right-hand side
   public string RightHandSide
   {
      get
      {
         return Result.ToString();
      }

      set
      {
      }
   }

   // left operand get and set property
   public int Left
   {
      get
      {
         return left;
      }

      set
      {
         left = value;
      }
   }

   // right operand get and set property
   public int Right
   {
      get
      {
         return right;
      }

      set
      {
         right = value;
      }
   }

   // get and set property of result of applying
   // operation to left and right operands
   public int Result
   {         
      get
      {
         return result;
      }

      set
      {
         result = value;
      }
   }

   // get and set property for operation
   public string Operation
   {
      get
      {
         return operation;
      }

      set
      {
         operation = value;
      }
   }

} // end class Equation

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