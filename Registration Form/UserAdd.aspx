<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="UserAdd.aspx.cs" Inherits="Registration_Form.UserAdd1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="CSS/CStyleSheet.css" rel="stylesheet" />
    <h2>ADD USER</h2>
        <center><div>
            <table>
                <tr>
                    <td>UserName/Email:</td>
                    <td>
                        <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>
                        <telerik:RadTextBox ID="Email" OnLoad="Email_Load" OnTextChanged="Email_TextChanged" runat="server"></telerik:RadTextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter UserName/Email*" ControlToValidate="Email" OnLoad="RequiredFieldValidator1_Load"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter Correct Email*" ControlToValidate="Email"></asp:RegularExpressionValidator>
                        <asp:RangeValidator ID="RangeValidator1" MinimumValue="5" MaximumValue="50" runat="server" ErrorMessage="Must be in range" ControlToValidate="Email"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td>First Name:</td>
                    <td>
                        <telerik:RadTextBox ID="FirstName" OnLoad="FirstName_Load" OnTextChanged="FirstName_TextChanged" runat="server"></telerik:RadTextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="First Name required*" ControlToValidate="FirstName"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Must be in alphabet" ControlToValidate="FirstName"></asp:RegularExpressionValidator>
                        <asp:RangeValidator ID="RangeValidator2" ControlToValidate="FirstName" runat="server" MaximumValue="8" MinimumValue="3" ErrorMessage="Must be in range"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td>Last Name:</td>
                    <td>
                        <telerik:RadTextBox ID="LastName" OnLoad="LastName_Load" runat="server"></telerik:RadTextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Last Name required*" ControlToValidate="LastName"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Must be in alphabet" ControlToValidate="LastName"></asp:RegularExpressionValidator>
                        <asp:RangeValidator ID="RangeValidator3" runat="server" MaximumValue="8" MinimumValue="3" ControlToValidate="LastName" ErrorMessage="RangeValidator"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td>Gender:</td>
                    <td>
                        <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="gen" OnCheckedChanged="RadioButton1_CheckedChanged" />
                        <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="gen" OnCheckedChanged="RadioButton2_CheckedChanged" />
                        <asp:RadioButton ID="RadioButton3" runat="server" Text="Others" GroupName="gen" OnCheckedChanged="RadioButton3_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td>States:</td>
                    <td>
                        <telerik:RadComboBox ID="ddlState" DataTextField="State" DataValueField="StateID" ForeColor="Blue" runat="server"></telerik:RadComboBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <telerik:RadButton ID="Add" OnClick="Add_Click" runat="server" Text="Add" ForeColor="Red"></telerik:RadButton><br />
                    </td>
                </tr>
            </table>
        </div>
</center>
</asp:Content>
