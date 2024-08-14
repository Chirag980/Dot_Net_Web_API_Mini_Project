<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assignment_RadTextBox.aspx.cs" Inherits="Registration_Form.Assignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>
            <telerik:RadTextBox ID="RadTextBox1" Runat="server" OnTextChanged="RadTextBox1_TextChanged" AutoPostBack="true" OnLoad="RadTextBox1_Load">
            </telerik:RadTextBox>

            <telerik:RadTextBox ID="RadTextBox2" Runat="server" OnTextChanged="RadTextBox2_TextChanged">
            </telerik:RadTextBox>
        </div>
    </form>
</body>
</html>
