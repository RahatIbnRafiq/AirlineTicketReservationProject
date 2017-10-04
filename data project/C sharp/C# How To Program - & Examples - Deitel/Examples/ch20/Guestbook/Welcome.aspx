<%@ Page language="c#" Codebehind="Welcome.aspx.cs"
   AutoEventWireup="false"
   Inherits="Guestbook.GuestBookForm" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
      <title>WebForm1</title><%-- Fig. 20.35: Welcome.aspx                              --%>
<%-- A Web Form demonstrating a guest book.                --%>
      <meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
      <meta name="CODE_LANGUAGE" Content="C#">
      <meta name="vs_defaultClientScript" content="JavaScript">
      <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>
   <body MS_POSITIONING="GridLayout">
      <form id="Form1" method="post" runat="server">
         <asp:DataGrid id="dataGrid" style="Z-INDEX: 101; 
            LEFT: 13px; 
            POSITION: absolute; 
            TOP: 301px" runat="server" Width="698px" HorizontalAlign="Left" 
            BorderColor="#E7E7FF" BorderWidth="1px" 
            GridLines="Horizontal" BackColor="White"
            DataSource="<%# dataView %>" BorderStyle="None"
            CellPadding="3">
            <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
            <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
            <ItemStyle HorizontalAlign="Left" ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
            <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
            <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
            <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
         </asp:DataGrid>
         <asp:Button id="clearButton" style="Z-INDEX: 111; 
            LEFT: 354px; 
            POSITION: absolute; 
            TOP: 262px" runat="server" Width="57px" Text="Clear"></asp:Button>
         <asp:Button id="submitButton" style="Z-INDEX: 110; 
            LEFT: 205px; 
            POSITION: absolute; 
            TOP: 264px" runat="server" Text="Submit"></asp:Button>
         <asp:TextBox id="messageTextBox" style="Z-INDEX: 109;
            LEFT: 111px;
            POSITION: absolute;
            TOP: 139px" runat="server" Width="427px" Height="107px" TextMode="MultiLine"></asp:TextBox>
         <asp:Label id="messageLabel" style="Z-INDEX: 108; 
            LEFT: 13px; 
            POSITION: absolute; 
            TOP: 149px" runat="server" Width="59px" Height="9px">
            Tell the world:</asp:Label>
         <asp:Label id="emailLabel" style="Z-INDEX: 107; 
            LEFT: 13px; 
            POSITION: absolute; 
            TOP: 91px" runat="server" Width="76px">Your e-mail address:
         </asp:Label>
         <asp:TextBox id="emailTextBox" style="Z-INDEX: 106; 
            LEFT: 111px; 
            POSITION: absolute; 
            TOP: 99px" runat="server" Width="428px"></asp:TextBox>
         <asp:Label id="nameLabel" style="Z-INDEX: 104; 
            LEFT: 13px; 
            POSITION: absolute; 
            TOP: 59px" runat="server" Width="84px">Your Name:</asp:Label>
         <asp:TextBox id="nameTextBox" style="Z-INDEX: 105; 
            LEFT: 111px; 
            POSITION: absolute; 
            TOP: 59px" runat="server" Width="428px"></asp:TextBox>
         <asp:Label id="promptLabel" style="Z-INDEX: 102; 
            LEFT: 13px; 
            POSITION: absolute; 
            TOP: 12px" runat="server" ForeColor="Blue" Font-Size="X-Large">
            Please
            leave a message in our guest book:</asp:Label>
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
