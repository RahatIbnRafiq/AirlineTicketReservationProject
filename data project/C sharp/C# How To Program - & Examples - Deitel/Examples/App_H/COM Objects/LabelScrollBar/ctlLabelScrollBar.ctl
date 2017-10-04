VERSION 5.00
Begin VB.UserControl LabelScrollbar 
   ClientHeight    =   270
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   3630
   ScaleHeight     =   18
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   242
   Begin VB.HScrollBar hsbScroll 
      Height          =   255
      Left            =   720
      TabIndex        =   0
      Top             =   0
      Value           =   2
      Width           =   2895
   End
   Begin VB.Label lblDisplay 
      BorderStyle     =   1  'Fixed Single
      Height          =   255
      Left            =   0
      TabIndex        =   1
      Top             =   0
      Width           =   615
   End
End
Attribute VB_Name = "LabelScrollbar"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
' Fig. 17.10
' LabelScroll ActiveX control

Option Explicit
Public Event Change()

''''''''''''''''''''''''''''''''''''''
' Event procedures for UserControl   '
''''''''''''''''''''''''''''''''''''''
Private Sub UserControl_InitProperties()

   With hsbScroll
      .Max = 32767
      .Min = 0
      .value = (CLng(.Min) + .Max) / 2
      .SmallChange = 1
      .LargeChange = 5
   End With
   
   lblDisplay.Caption = hsbScroll.value
End Sub
  
Private Sub UserControl_ReadProperties(PropBag As PropertyBag)
   
   With hsbScroll
      .Min = PropBag.ReadProperty("Min", 0)
      .Max = PropBag.ReadProperty("Max", 32767)
      .LargeChange = PropBag.ReadProperty("LargeChange", 5)
      .SmallChange = PropBag.ReadProperty("SmallChange", 1)
   End With
   
   lblDisplay.Caption = PropBag.ReadProperty("Caption", _
                                  (hsbScroll.Min + hsbScroll.Max) \ 2)
End Sub

Private Sub UserControl_WriteProperties(PropBag As PropertyBag)

   Call PropBag.WriteProperty("Value", hsbScroll.value, _
                               (hsbScroll.Min + hsbScroll.Max) \ 2)
   Call PropBag.WriteProperty("Caption", hsbScroll.value, _
                               (hsbScroll.Min + hsbScroll.Max) \ 2)

   Call PropBag.WriteProperty("Min", hsbScroll.Min, 0)
   Call PropBag.WriteProperty("Max", hsbScroll.Max, 32767)
   Call PropBag.WriteProperty("SmallChange", _
                               hsbScroll.SmallChange, 1)
   Call PropBag.WriteProperty("LargeChange", _
                               hsbScroll.LargeChange, 5)
End Sub

Private Sub UserControl_Resize()

   With hsbScroll
      .Left = lblDisplay.Width
      .Width = ScaleWidth - hsbScroll.Left
      .Height = ScaleHeight
   End With
   
   lblDisplay.Height = ScaleHeight
End Sub

''''''''''''''''''''''''''''''''''''''
' Event procedures for hsbScroll     '
''''''''''''''''''''''''''''''''''''''
Private Sub hsbScroll_Change()
   lblDisplay.Caption = hsbScroll.value
   RaiseEvent Change
End Sub

''''''''''''''''''''''''''''''''''''''
' Property methods for hsbScroll     '
''''''''''''''''''''''''''''''''''''''
Public Property Get value() As Long
   value = hsbScroll.value
End Property

Public Property Let value(ByVal v As Long)
   hsbScroll.value = v
   Call UserControl.PropertyChanged("Value")
End Property

Public Property Get Max() As Integer
   Max = hsbScroll.Max
End Property

Public Property Let Max(ByVal m As Integer)
   hsbScroll.Max = m
   
   value = (CLng(hsbScroll.Min) + hsbScroll.Max) \ 2
   Call UserControl.PropertyChanged("Max")
End Property

Public Property Get Min() As Integer
   Min = hsbScroll.Min
End Property

Public Property Let Min(ByVal m As Integer)

   hsbScroll.Min = m
   value = (CLng(hsbScroll.Min) + hsbScroll.Max) \ 2

   Call UserControl.PropertyChanged("Min")
End Property

Public Property Get LargeChange() As Integer
   LargeChange = hsbScroll.LargeChange
End Property

Public Property Let LargeChange(ByVal c As Integer)
   hsbScroll.LargeChange = c
   Call UserControl.PropertyChanged("LargeChange")
End Property

Public Property Get SmallChange() As Integer
   SmallChange = hsbScroll.SmallChange
End Property

Public Property Let SmallChange(ByVal c As Integer)
   hsbScroll.SmallChange = c
   Call UserControl.PropertyChanged("SmallChange")
End Property

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
