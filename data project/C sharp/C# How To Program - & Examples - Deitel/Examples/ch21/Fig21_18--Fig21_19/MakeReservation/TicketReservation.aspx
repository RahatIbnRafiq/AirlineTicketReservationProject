<%@ Page language="c#" Codebehind="TicketReservation.aspx.cs" AutoEventWireup="false" Inherits="MakeReservation.TicketReservation" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
   <HEAD>
      <%-- Fig. 21.18: TicketReservation.aspx                   --%>
      <%-- A Web Form to allow users to select the kind of seat --%>
      <%-- they wish to reserve.                                --%>
      <meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
      <meta name="CODE_LANGUAGE" Content="C#">
      <meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
      <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
   </HEAD>
   <body MS_POSITIONING="GridLayout">
      <form id="MakeReservation" method="post" runat="server">
         <asp:DropDownList id="seatList" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 43px" runat="server" Width="105px" Height="22px">
            <asp:ListItem Value="Aisle">Aisle</asp:ListItem>
            <asp:ListItem Value="Middle">Middle</asp:ListItem>
            <asp:ListItem Value="Window">Window</asp:ListItem>
         </asp:DropDownList>
         <asp:DropDownList id="classList" style="Z-INDEX: 102; LEFT: 145px; POSITION: absolute; TOP: 43px" runat="server" Width="98px" Height="22px">
            <asp:ListItem Value="Economy">Economy</asp:ListItem>
            <asp:ListItem Value="First">First</asp:ListItem>
         </asp:DropDownList>
         <asp:Button id="reserveButton" style="Z-INDEX: 103; LEFT: 21px; POSITION: absolute; TOP: 83px" runat="server" Text="Reserve"></asp:Button>
         <asp:Label id="Label1" style="Z-INDEX: 104; LEFT: 17px; POSITION: absolute; TOP: 13px" runat="server">Please select the type of seat and class you wish to reserve:</asp:Label>
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
