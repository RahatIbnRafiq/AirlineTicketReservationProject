<%-- Fig. 20.18: AdRotator.aspx                    --%>
<%-- A Web Form that demonstrates class AdRotator. --%>

<%@ Page language="c#" Codebehind="AdRotator.aspx.cs" AutoEventWireup="false" Inherits="AdRotatorTest.AdRotator" EnableSessionState="False" enableViewState="False"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
   <HEAD>
      <title>WebForm1</title>
      <meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
      <meta name="CODE_LANGUAGE" Content="C#">
      <meta name="vs_defaultClientScript" content="JavaScript">
      <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
   </HEAD>
   <body MS_POSITIONING="GridLayout" background="images/background.png">
      <form id="Form1" method="post" runat="server">
         <asp:AdRotator id="adRotator" style="Z-INDEX: 101; LEFT: 17px; POSITION: absolute; TOP: 69px" runat="server" Width="86px" Height="60px" AdvertisementFile="AdRotatorInformation.xml"></asp:AdRotator>
         <asp:Label id="adRotatorLabel" style="Z-INDEX: 102; LEFT: 17px; POSITION: absolute; TOP: 26px" runat="server" Font-Size="Large">AdRotator Example</asp:Label>&nbsp;
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
