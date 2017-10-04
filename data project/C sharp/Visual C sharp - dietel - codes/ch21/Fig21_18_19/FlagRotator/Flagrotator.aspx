<%-- Fig. 21.18: FlagRotator.aspx --%>
<%-- A Web Form that displays flags using an AdRotator control. --%>
<%@ Page Language="C#" AutoEventWireup="false"
  CodeFile="Flagrotator.aspx.cs" Inherits="FlagRotator"
  EnableSessionState="False" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN"
   "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
   <head id="Head1" runat="server">
      <title>Flag Rotator</title>
   </head>
   <body background="Images/background.png">
      <form id="form1" runat="server">
         <div>
            <h3>AdRotator Example</h3>
            <p>
               <asp:AdRotator ID="countryRotator" runat="server" 
                  DataSourceID="adXmlDataSource" 
                  EnableViewState="False" />
               <asp:XmlDataSource ID="adXmlDataSource" runat="server" 
                  DataFile="~/App_Data/AdRotatorInformation.xml">
               </asp:XmlDataSource>
            </p>
         </div>
      </form>
   </body>
</html>

<!-- 
 ************************************************************************** 
 * (C) Copyright 1992-2006 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
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
-->