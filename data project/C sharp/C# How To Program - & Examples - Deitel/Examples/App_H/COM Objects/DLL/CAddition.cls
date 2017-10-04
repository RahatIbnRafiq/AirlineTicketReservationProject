VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CAddition"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True

' function adds two numbers and returns the result
Public Function AddFunction(value1 As Long, value2 As Long) As Long

   AddFunction = value1 + value2    ' return result

End Function

' *************************************************************
' * (C) Copyright 2002 by Deitel & Associates, Inc.           *
' *     and Prentice Hall.                                    *
' * All Rights Reserved.                                      *
' *                                                           *
' * DISCLAIMER: The authors and publisher of this book have   *
' * used their best efforts in preparing the book. These      *
' * efforts include the development, research, and testing of *
' * the theories and programs to determine their              *
' * effectiveness. The authors and publisher make no warranty *
' * of any kind, expressed or implied, with regard to these   *
' * programs or to the documentation contained in these books.*
' * The authors and publisher shall not be liable in any event*
' * for incidental or consequential damages in connection     *
' * with, or arising out of, the furnishing, performance, or  *
' * use of these programs.                                    *
' *************************************************************
