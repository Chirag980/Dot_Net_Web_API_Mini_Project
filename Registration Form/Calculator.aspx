<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Registration_Form.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
            <Scripts>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js">
                </asp:ScriptReference>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js">
                </asp:ScriptReference>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js">
                </asp:ScriptReference>
            </Scripts>
        </telerik:RadScriptManager>
        <h2>Calculator</h2>
        <div>

            Enter First Number<br />
            <telerik:RadTextBox ID="RadTextBox2" Runat="server">
            </telerik:RadTextBox>
            <br />
            <br />
            Enter Second Number<br />
            <telerik:RadTextBox ID="RadTextBox1" Runat="server">
            </telerik:RadTextBox>
            <br />
            <br />
            <br />
            <br />
            <telerik:RadButton ID="ADD" runat="server" OnClick="RadButton1_Click" Text="ADDITION(+)">
            </telerik:RadButton><br />
            <telerik:RadButton ID="SUB" runat="server" OnClick="RadButton2_Click" Text="SUBTRACT(-)">
            </telerik:RadButton><br />
            <telerik:RadButton ID="MUL" runat="server" OnClick="RadButton3_Click"  Text="Multiply(X)">
            </telerik:RadButton><br />
            <telerik:RadButton ID="DIV" runat="server" OnClick="RadButton4_Click" Text="Divide(/)">
            </telerik:RadButton><br />
            <br />
            <br />
            Result<br />
            <telerik:RadTextBox ID="RadTextBox3" Runat="server">
            </telerik:RadTextBox>

        </div>
    </form>
</body>
</html>
