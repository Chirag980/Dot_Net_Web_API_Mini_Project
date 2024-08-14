<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="Registration_Form.AddUser" %>
<%@ Register Src="~/Register_Page.ascx" TagPrefix="uc1" TagName="Register_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:Register_Page runat="server" ID="Register_Page" />
        </div>
    </form>
</body>
</html>
