<%@ Register TagPrefix="Header" TagName="ImageHeader" Src="ImageHeader.ascx" %>
<%@ Page language="c#" Codebehind="Login.aspx.cs" AutoEventWireup="false" Inherits="Database.Login" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm1</title>
                <%-- Fig. 20.37: Login.aspx                 --%>
		<%-- A page that allows the user to log in. --%>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout" bgColor="#ffebff">
		<form id="Form1" method="post" runat="server">
			<asp:label id="nameLabel" style="Z-INDEX: 101; LEFT: 15px; POSITION: absolute; TOP: 188px" runat="server">Name</asp:label>
			<asp:label id="promptLabel" style="Z-INDEX: 108; LEFT: 15px; POSITION: absolute; TOP: 145px" runat="server">Please select your name and enter your password to log in:</asp:label>
			<asp:customvalidator id="invalidPasswordValidator" style="Z-INDEX: 107; LEFT: 262px; POSITION: absolute; TOP: 221px" runat="server" ControlToValidate="passwordTextBox" Font-Bold="True" ForeColor="DarkCyan" ErrorMessage="Invalid password!"></asp:customvalidator>
			<asp:requiredfieldvalidator id="requiredPasswordValidator" style="Z-INDEX: 106; LEFT: 262px; POSITION: absolute; TOP: 221px" runat="server" ControlToValidate="passwordTextBox" Font-Bold="True" ForeColor="DarkCyan" ErrorMessage="Please enter a password!"></asp:requiredfieldvalidator>
			<asp:dropdownlist id="nameList" style="Z-INDEX: 105; LEFT: 92px; POSITION: absolute; TOP: 185px" runat="server" Width="154px"></asp:dropdownlist>
			<asp:button id="submitButton" style="Z-INDEX: 104; LEFT: 92px; POSITION: absolute; TOP: 263px" runat="server" Text="Submit"></asp:button>
			<asp:textbox id="passwordTextBox" style="Z-INDEX: 103; LEFT: 92px; POSITION: absolute; TOP: 221px" runat="server" TextMode="Password"></asp:textbox>
			<asp:label id="passwordLabel" style="Z-INDEX: 102; LEFT: 15px; POSITION: absolute; TOP: 220px" runat="server">Password</asp:label>
			<Header:ImageHeader id="ImageHeader1" runat="server"></Header:ImageHeader>
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