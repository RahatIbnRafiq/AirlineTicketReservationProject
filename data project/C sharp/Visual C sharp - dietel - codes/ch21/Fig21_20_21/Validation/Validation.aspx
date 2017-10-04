<%-- Fig. 21.20: Validation.aspx --%>
<%-- Form that demonstrates using validators to validate user input. --%>
<%@ Page Language="C#" AutoEventWireup="true" 
   CodeFile="Validation.aspx.cs" Inherits="Validation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" 
   "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
   <head id="Head1" runat="server">
      <title>Demonstrating Validation Controls</title>
   </head>
   <body>
      <form id="form1" runat="server">
         <div>
            Please fill out the following form.<br />
            <em>All fields are required and must 
               contain valid information.</em><br />
            <br />
            <table>
               <tr>
                  <td style="width: 100px" valign="top">Name:</td>
                  <td style="width: 450px" valign="top">
                     <asp:TextBox ID="nameTextBox" runat="server">
                     </asp:TextBox><br />
                     <asp:RequiredFieldValidator ID="nameInputValidator" 
                        runat="server" ControlToValidate="nameTextBox"
                        ErrorMessage="Please enter your name." 
                        Display="Dynamic"></asp:RequiredFieldValidator>
                  </td>
               </tr>
               <tr>
                  <td style="width: 100px; height: 64px;" valign="top">
                     E-mail address:</td>
                  <td style="width: 450px; height: 64px;" valign="top">
                     <asp:TextBox ID="emailTextBox" runat="server">
                     </asp:TextBox>
                     &nbsp;e.g., user@domain.com<br />
                     <asp:RequiredFieldValidator ID="emailInputValidator" 
                        runat="server" ControlToValidate="emailTextBox"
                        ErrorMessage="Please enter your e-mail address." 
                        Display="Dynamic"></asp:RequiredFieldValidator>
                     <asp:RegularExpressionValidator 
                        ID="emailFormatValidator" runat="server" 
                        ControlToValidate="emailTextBox" 
                        ErrorMessage="Please enter an e-mail address in a 
                        valid format." Display="Dynamic" 
                        ValidationExpression=
                        "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                     </asp:RegularExpressionValidator>
                  </td>
               </tr>
               <tr>
                  <td style="width: 100px" valign="top">Phone number:</td>
                  <td style="width: 450px" valign="top">
                     <asp:TextBox ID="phoneTextBox" runat="server">
                     </asp:TextBox>
                     &nbsp;e.g., (555) 555-1234<br />
                     <asp:RequiredFieldValidator ID="phoneInputValidator" 
                        runat="server" ControlToValidate="phoneTextBox"
                        ErrorMessage="Please enter your phone number." 
                        Display="Dynamic"></asp:RequiredFieldValidator>
                     <asp:RegularExpressionValidator 
                        ID="phoneFormatValidator" runat="server" 
                        ControlToValidate="phoneTextBox"
                        ErrorMessage="Please enter a phone number in a 
                        valid format." Display="Dynamic" 
                        ValidationExpression=
                        "((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">
                     </asp:RegularExpressionValidator>
                  </td>
               </tr>
            </table>
            <br />
            <asp:Button ID="submitButton" runat="server" Text="Submit" />
            <br /><br />
            <asp:Label ID="outputLabel" runat="server"
               Text="Thank you for your submission."
               Visible="False"></asp:Label>
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