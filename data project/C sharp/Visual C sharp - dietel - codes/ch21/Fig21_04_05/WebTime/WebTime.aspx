<%-- Fig. 21.4: WebTime.aspx --%>
<%-- A page that displays the current time in a Label. --%>
<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="WebTime.aspx.cs"
   Inherits="WebTime" EnableSessionState="False" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN"
   "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
   <head id="Head1" runat="server">
      <title>A Simple Web Form Example</title>
   </head>
   <body>
      <form id="form1" runat="server">
         <div>
            <h2>Current time on the Web server:</h2>
            <p>
               <asp:Label ID="timeLabel" runat="server" BackColor="Black"
                  Font-Size="XX-Large" ForeColor="Yellow"
                  EnableViewState="False"></asp:Label>
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