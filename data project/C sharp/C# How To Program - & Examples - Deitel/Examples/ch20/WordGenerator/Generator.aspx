<%@ Page language="c#" Codebehind="Generator.aspx.cs" AutoEventWireup="false" Inherits="WordGenerator.Generator" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
   <HEAD>
      <title>WebForm1</title><%-- Fig. 20.21: Generator.aspx                      --%>
      <%-- A Web Form demonstrating the use of validators. --%>
      <meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
      <meta name="CODE_LANGUAGE" Content="C#">
      <meta name="vs_defaultClientScript" content="JavaScript">
      <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
   </HEAD>
   <body MS_POSITIONING="GridLayout">
      <form id="Form1" method="post" runat="server">
         <asp:Label id="promptLabel" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 23px" runat="server">Please enter a phone number in the form 555-4567:</asp:Label>
         <asp:RegularExpressionValidator id="phoneNumberValidator" style="Z-INDEX: 106; LEFT: 217px; POSITION: absolute; TOP: 73px" runat="server" ErrorMessage="The phone number must be in the form 555-4567." ControlToValidate="inputTextBox" ValidationExpression="^\d{3}-\d{4}$"></asp:RegularExpressionValidator>
         <asp:RequiredFieldValidator id="phoneInputValidator" style="Z-INDEX: 105; LEFT: 217px; POSITION: absolute; TOP: 47px" runat="server" ErrorMessage="Please enter a phone number." ControlToValidate="inputTextBox"></asp:RequiredFieldValidator>
         <asp:TextBox id="outputTextBox" style="Z-INDEX: 104; LEFT: 16px; POSITION: absolute; TOP: 146px" runat="server" Visible="False" TextMode="MultiLine" Height="198px" Width="227px" Font-Bold="True" Font-Names="Courier New"></asp:TextBox>
         <asp:Button id="submitButton" style="Z-INDEX: 103; LEFT: 16px; POSITION: absolute; TOP: 86px" runat="server" Text="Submit"></asp:Button>
         <asp:TextBox id="inputTextBox" style="Z-INDEX: 102; LEFT: 16px; POSITION: absolute; TOP: 52px" runat="server"></asp:TextBox>
      </form>
      <%--
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
--%>
   </body>
</HTML>
