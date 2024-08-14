<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assignment_RADLISTBOX.aspx.cs" Inherits="Registration_Form.Assignment_RADLISTBOX" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>
            <label>RadTextBox1</label><br />
            <telerik:RadListBox RenderMode="Lightweight" ID="RadListBox1" Height="200px" Width="230px" ButtonSettings-AreaHeight="35px" runat="server" OnSelectedIndexChanged="country_SelectedIndexChanged" SelectionMode="Multiple">
                <Items>
                    <telerik:RadListBoxItem Text="India"></telerik:RadListBoxItem>
                    <telerik:RadListBoxItem Text="Indonesia"></telerik:RadListBoxItem>
                    <telerik:RadListBoxItem Text="Kenya"></telerik:RadListBoxItem>
                    <telerik:RadListBoxItem Text="New Zealand"></telerik:RadListBoxItem>
                    <telerik:RadListBoxItem Text="South Africa"></telerik:RadListBoxItem>
                    <telerik:RadListBoxItem Text="USA"></telerik:RadListBoxItem>
                </Items>
            </telerik:RadListBox><br />
                        <label>RadTextBox2</label><br />

            <telerik:RadListBox ID="RadListBox2" runat="server" Height="200px" Width="230px" ButtonSettings-AreaHeight="35px" SelectionMode="Multiple"></telerik:RadListBox>
        <br />
            <telerik:RadButton ID="RadButton1" runat="server" OnClick="RadButton1_Click" Text=">"></telerik:RadButton><br />
            <telerik:RadButton ID="RadButton2" runat="server" Text=">>" OnClick="RadButton2_Click"></telerik:RadButton><br />
            <telerik:RadButton ID="RadButton3" runat="server" OnClick="RadButton3_Click" Text="<"></telerik:RadButton><br />
            <telerik:RadButton ID="RadButton4" runat="server" OnClick="RadButton4_Click" Text="<<"></telerik:RadButton>
            
            
        </div>
    </form>
</body>
</html>
