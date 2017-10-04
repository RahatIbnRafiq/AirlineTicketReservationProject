<%@ Page language="c#" Codebehind="WebControls.aspx.cs" AutoEventWireup="false" Inherits="WebControls.WebForm1" EnableSessionState="False" enableViewState="False"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
   <HEAD>
      <title>WebForm1</title><%-- Fig. 20.17: WebControls.aspx        --%>
      <%-- Demonstrating some Web controls. --%>
      <meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
      <meta name="CODE_LANGUAGE" Content="C#">
      <meta name="vs_defaultClientScript" content="JavaScript">
      <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
   </HEAD>
   <body MS_POSITIONING="GridLayout">
      <form id="Form1" method="post" runat="server">
         <asp:Label id="welcomeLabel" style="Z-INDEX: 101; LEFT: 21px; POSITION: absolute; TOP: 17px" runat="server" Font-Bold="True" Font-Size="Medium">This is a sample registration form.</asp:Label>
         <asp:Image id="operatingImage" style="Z-INDEX: 121; LEFT: 21px; POSITION: absolute; TOP: 371px" runat="server" ImageUrl="images/os.png"></asp:Image>
         <asp:Image id="publicationImage" style="Z-INDEX: 120; LEFT: 21px; POSITION: absolute; TOP: 245px" runat="server" ImageUrl="images/downloads.png"></asp:Image>
         <asp:Image id="userImage" style="Z-INDEX: 119; LEFT: 21px; POSITION: absolute; TOP: 91px" runat="server" ImageUrl="images/user.png"></asp:Image>
         <asp:TextBox id="emailTextBox" style="Z-INDEX: 118; LEFT: 95px; POSITION: absolute; TOP: 161px" runat="server"></asp:TextBox>
         <asp:TextBox id="firstTextBox" style="Z-INDEX: 117; LEFT: 95px; POSITION: absolute; TOP: 127px" runat="server"></asp:TextBox>
         <asp:TextBox id="lastTextBox" style="Z-INDEX: 116; LEFT: 341px; POSITION: absolute; TOP: 127px" runat="server"></asp:TextBox>
         <asp:TextBox id="phoneTextBox" style="Z-INDEX: 115; LEFT: 341px; POSITION: absolute; TOP: 161px" runat="server"></asp:TextBox>
         <asp:RadioButtonList id="operatingRadioButtonList" style="Z-INDEX: 114; LEFT: 21px; POSITION: absolute; TOP: 409px" runat="server">
            <asp:ListItem Value="Windows NT">Windows NT</asp:ListItem>
            <asp:ListItem Value="Windows 2000">Windows 2000</asp:ListItem>
            <asp:ListItem Value="Windows XP">Windows XP</asp:ListItem>
            <asp:ListItem Value="Linux">Linux</asp:ListItem>
            <asp:ListItem Value="Other">Other</asp:ListItem>
         </asp:RadioButtonList>
         <asp:HyperLink id="booksHyperLink" style="Z-INDEX: 113; LEFT: 21px; POSITION: absolute; TOP: 316px" runat="server" NavigateUrl="http://www.deitel.com">Click here to view more information about our books.</asp:HyperLink>
         <asp:DropDownList id="booksDropDownList" style="Z-INDEX: 112; LEFT: 21px; POSITION: absolute; TOP: 282px" runat="server">
            <asp:ListItem Value="XML How to Program 1e">XML How to Program 1e</asp:ListItem>
            <asp:ListItem Value="C# How to Program 1e">C# How to Program 1e</asp:ListItem>
            <asp:ListItem Value="Visual Basic .NET How to Program 2e">Visual Basic .NET How to Program 2e</asp:ListItem>
            <asp:ListItem Value="C++ How to Program 3e">C++ How to Program 3e</asp:ListItem>
         </asp:DropDownList>
         <asp:Image id="phoneImage" style="Z-INDEX: 111; LEFT: 266px; POSITION: absolute; TOP: 161px" runat="server" ImageUrl="images/phone.png"></asp:Image>
         <asp:Image id="emailImage" style="Z-INDEX: 110; LEFT: 21px; POSITION: absolute; TOP: 161px" runat="server" ImageUrl="images/email.png"></asp:Image>
         <asp:Image id="lastImage" style="Z-INDEX: 109; LEFT: 266px; POSITION: absolute; TOP: 127px" runat="server" ImageUrl="images/lname.png"></asp:Image>
         <asp:Image id="firstImage" style="Z-INDEX: 108; LEFT: 21px; POSITION: absolute; TOP: 127px" runat="server" ImageUrl="images/fname.png"></asp:Image>
         <asp:Button id="registerButton" style="Z-INDEX: 107; LEFT: 21px; POSITION: absolute; TOP: 547px" runat="server" Text="Register"></asp:Button>
         <asp:Label id="bookLabel" style="Z-INDEX: 106; LEFT: 216px; POSITION: absolute; TOP: 245px" runat="server" ForeColor="DarkCyan">Which book would you like information about?</asp:Label>
         <asp:Label id="fillLabel" style="Z-INDEX: 105; LEFT: 218px; POSITION: absolute; TOP: 91px" runat="server" ForeColor="DarkCyan">Please fill out the fields below.</asp:Label>
         <asp:Label id="phoneLabel" style="Z-INDEX: 104; LEFT: 266px; POSITION: absolute; TOP: 198px" runat="server">Must be in the form (555)555-5555.</asp:Label>
         <asp:Label id="operatingLabel" style="Z-INDEX: 103; LEFT: 220px; POSITION: absolute; TOP: 371px" runat="server" Height="9px" ForeColor="DarkCyan">Which operating system are you using?</asp:Label>
         <asp:Label id="registerLabel" style="Z-INDEX: 102; LEFT: 21px; POSITION: absolute; TOP: 46px" runat="server" Font-Italic="True">Please fill in all fields and click Register.</asp:Label>
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
