<%-- Fig. 20.40: Authors.aspx                               --%>
<%-- This page allows a user to chose an author and display --%>
<%-- that author's books.                                   --%>

<%@ Page language="c#" Codebehind="Authors.aspx.cs" AutoEventWireup="false" Inherits="Database.Authors" %>
<%@ Register TagPrefix="Header" TagName="ImageHeader" Src="ImageHeader.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
   <HEAD>
      <title>Authors</title>
      <meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
      <meta name="CODE_LANGUAGE" Content="C#">
      <meta name="vs_defaultClientScript" content="JavaScript">
      <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
   </HEAD>
   <body MS_POSITIONING="GridLayout" bgColor="#ffebff">
      <form id="Authors" method="post" runat="server">
         <asp:DropDownList id="nameList" style="Z-INDEX: 103; LEFT: 90px; POSITION: absolute; TOP: 157px" runat="server" Width="158px" Height="22px"></asp:DropDownList>
         <Header:ImageHeader id="Head1" runat="server"></Header:ImageHeader>
         <asp:Label id="Label2" style="Z-INDEX: 102; LEFT: 28px; POSITION: absolute; TOP: 157px" runat="server" Width="48px" Height="22px">Authors:</asp:Label>
         <asp:Button id="Button1" style="Z-INDEX: 104; LEFT: 29px; POSITION: absolute; TOP: 188px" runat="server" Width="78px" Text="Select"></asp:Button>
         <asp:Label id="Label3" style="Z-INDEX: 105; LEFT: 19px; POSITION: absolute; TOP: 127px" runat="server" Width="210px" Visible="False">You chose </asp:Label>
         <asp:DataGrid id="dataGrid" style="Z-INDEX: 106; LEFT: 12px; POSITION: absolute; TOP: 151px" runat="server" Height="23px" Width="700px" ForeColor="Black" AllowPaging="True" DataSource="<%# dataView1 %>" Visible="False" AllowSorting="True">
            <EditItemStyle BackColor="White"></EditItemStyle>
            <AlternatingItemStyle ForeColor="Black" BackColor="LightGoldenrodYellow"></AlternatingItemStyle>
            <ItemStyle BackColor="White"></ItemStyle>
            <HeaderStyle BackColor="LightGreen"></HeaderStyle>
            <PagerStyle NextPageText="Next &amp;gt;" PrevPageText="&amp;lt; Previous"></PagerStyle>
         </asp:DataGrid>
      </form>
   </body>
</HTML>

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
