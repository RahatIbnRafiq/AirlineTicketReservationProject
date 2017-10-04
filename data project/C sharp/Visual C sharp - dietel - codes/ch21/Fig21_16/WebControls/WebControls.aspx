<%-- Fig. 21.16: WebControls.aspx --%>
<%-- Registration form that demonstrates Web controls. --%>
<%@ Page Language="C#" AutoEventWireup="true"
  CodeFile="WebControls.aspx.cs" Inherits="WebControls"
  EnableSessionState="False" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN"
   "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
   <head id="Head1" runat="server">
      <title>Web Controls Demonstration</title>
   </head>
   <body>
      <form id="form1" runat="server">
         <div>
            <h3>This is a sample registration form.</h3>
            <p><em>Please fill in all fields and click Register.</em></p>
            <p>
               <asp:Image ID="UserInformationImage" runat="server"
                  ImageUrl="~/Images/user.png" EnableViewState="False" />
               &nbsp;
               <span style="color: teal">
                  Please fill out the fields below.</span>
            </p>
            <table>
               <tr>
                  <td style="width: 230px; height: 21px" valign="top">
                     <asp:Image ID="FirstNameImage" runat="server"
                        ImageUrl="~/Images/fname.png"
                        EnableViewState="False" />
                     <asp:TextBox ID="FirstNameTextBox" runat="server"
                        EnableViewState="False"></asp:TextBox>
                  </td>
                  <td style="width: 231px; height: 21px" valign="top">
                     <asp:Image ID="LastNameImage" runat="server"
                        ImageUrl="~/Images/lname.png"
                        EnableViewState="False" />
                     <asp:TextBox ID="LastNameTextBox" runat="server"
                        EnableViewState="False"></asp:TextBox>
                  </td>
               </tr>
               <tr>
                  <td style="width: 230px" valign="top">
                     <asp:Image ID="EmailImage" runat="server" 
                        ImageUrl="~/Images/email.png"
                        EnableViewState="False" />
                     <asp:TextBox ID="EmailTextBox" runat="server" 
                        EnableViewState="False"></asp:TextBox>
                  </td>
                  <td style="width: 231px" valign="top">
                     <asp:Image ID="PhoneImage" runat="server" 
                         ImageUrl="~/Images/phone.png"
                        EnableViewState="False" />
                     <asp:TextBox ID="PhoneTextBox" runat="server" 
                        EnableViewState="False"></asp:TextBox>
                     Must be in the form (555) 555-5555.
                  </td>
               </tr>
            </table>
            <p>
               <asp:Image ID="PublicationsImage" runat="server" 
                  ImageUrl="~/Images/publications.png" 
                  EnableViewState="False" />
               &nbsp;
               <span style="color: teal">
                  Which book would you like information about?</span>
            </p>
            <p>
               <asp:DropDownList ID="BooksDropDownList" runat="server"
                  EnableViewState="False">
                  <asp:ListItem>Visual Basic 2005 How to Program 3e
                     </asp:ListItem>
                  <asp:ListItem>Visual C# 2005 How to Program 2e
                     </asp:ListItem>
                  <asp:ListItem>Java How to Program 6e</asp:ListItem>
                  <asp:ListItem>C++ How to Program 5e</asp:ListItem>
                  <asp:ListItem>XML How to Program 1e</asp:ListItem>
               </asp:DropDownList>
            </p>
            <p>
               <asp:HyperLink ID="BooksHyperLink" runat="server" 
                  NavigateUrl="http://www.deitel.com" Target="_blank"
                  EnableViewState="False">
                  Click here to view more information about our books
               </asp:HyperLink>
            </p>
            <p>
               <asp:Image ID="OSImage" runat="server" 
                  ImageUrl="~/Images/os.png"
                  EnableViewState="False"/>
               &nbsp;
               <span style="color: teal">
                  Which operating system are you using?</span>
            </p>
            <p>
               <asp:RadioButtonList ID="OperatingSystemRadioButtonList"
                  runat="server" EnableViewState="False">
                  <asp:ListItem>Windows XP</asp:ListItem>
                  <asp:ListItem>Windows 2000</asp:ListItem>
                  <asp:ListItem>Windows NT</asp:ListItem>
                  <asp:ListItem>Linux</asp:ListItem>
                  <asp:ListItem>Other</asp:ListItem>
               </asp:RadioButtonList>
            </p>
            <p>
               <asp:Button ID="RegisterButton" runat="server"
                  Text="Register" EnableViewState="False" />
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