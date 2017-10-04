<%@ Page language="c#" Codebehind="OptionsPage.aspx.cs"
   AutoEventWireup="false"
   Inherits="Cookies.OptionsPage" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>RecommendationsPage</title>
		<%-- Fig. 20.24: OptionsPage.aspx                          --%>
		<%-- This ASPX page allows the user to choose a language.  --%>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="RecommendationsPage" method="post" runat="server">
			<P>
				<asp:Label id="promptLabel" runat="server" Font-Bold="True">Select a programming language:
            </asp:Label>
				<asp:Label id="welcomeLabel" runat="server" Font-Bold="True" Visible="False">
               Welcome to Cookies! You selected 
            </asp:Label></P>
			<P>
				<asp:RadioButtonList id="languageList" runat="server">
					<asp:ListItem Value="C#">C#</asp:ListItem>
					<asp:ListItem Value="C++">C++</asp:ListItem>
					<asp:ListItem Value="C">C</asp:ListItem>
					<asp:ListItem Value="Python">Python</asp:ListItem>
					<asp:ListItem Value="Visual Basic .NET">Visual Basic .NET</asp:ListItem>
				</asp:RadioButtonList></P>
			<P>
				<asp:Button id="submitButton" runat="server" Text="Submit"></asp:Button></P>
			<P>
				<asp:HyperLink id="languageLink" runat="server" NavigateUrl="OptionsPage.aspx" Visible="False">
               Click here to choose another language.
            </asp:HyperLink></P>
			<P>
				<asp:HyperLink id="recommendationsLink" runat="server" NavigateUrl="RecommendationsPage.aspx" Visible="False">Click here to get book recommendations.
            </asp:HyperLink></P>
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