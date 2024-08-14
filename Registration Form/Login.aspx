<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Registration_Form.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/CStyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="color: white"><b>Login</b></h2>
            <div class="imgcontainer">
            </div>
            <div class="loginbox" style="text-align: center">
                <table>
                    <tr>
                        <td>
                            <img src="Images/login_icon.jpg" alt="Login image" class="auto-style1" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="UserName" style="color: black"><b>UserName:</b></label>
                        </td>
                        <td>
                            <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>
                            <telerik:RadTextBox ID="username" runat="server"></telerik:RadTextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter UserName*" Display="Dynamic" ForeColor="#f00000" ControlToValidate="UserName"></asp:RequiredFieldValidator><br/><br/>
                            <%--                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="UserName" ErrorMessage="User Name" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>--%>
                
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="Password" style="color: black" cssclass="lblpass"><b>Password:</b></label>
                        </td>
                        <td>
                            <telerik:RadTextBox ID="password" TextMode="Password" runat="server"></telerik:RadTextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Display="Dynamic" ForeColor="Red" runat="server" ControlToValidate="Password" CssClass="validators" ErrorMessage="Enter Password*"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <center>
                                <br/><br/><telerik:RadButton ID="LoginBt" runat="server" Text="LOGIN" ForeColor="Blue" OnClick="LoginBt_Click" Width="100px"></telerik:RadButton>
                            </center>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <center>
                                <br/><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AddUser.aspx" ForeColor="blue">REGISTER</asp:HyperLink>
                            </center>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
