<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Registration_Form.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                </td>
                    <td></td>
            </tr>
        </table>
    </div>
    <div>
            <link href="CSS/CStyleSheet.css" rel="stylesheet" />

        <br /><br />
        <h2>HOME PAGE</h2>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="false" OnNeedDataSource="RadGrid1_NeedDataSource" AllowSorting="true" AllowPaging="true" AllowCustomPaging="true">
            <MasterTableView AutoGenerateColumns="false" DataKeyNames="UserID">
                <Columns>
                    <telerik:GridBoundColumn HeaderText="User ID" DataField="UserID" DataType="System.Int32" ReadOnly="true" UniqueName="UserID"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn HeaderText="First Name" DataField="firstname"  ReadOnly="True" UniqueName="firstname"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn HeaderText="Last Name" DataField="lastname" ReadOnly="True" UniqueName="lastname"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn HeaderText="E-mail Address" DataField="email" ReadOnly="True" UniqueName="email"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn HeaderText="Mobile Number" DataField="mobile" ReadOnly="True" UniqueName="mobile"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn HeaderText="City" DataField="city" ReadOnly="True" UniqueName="city"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn HeaderText="State" DataField="State" ReadOnly="true" UniqueName="State"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn HeaderText="Address" DataField="address" ReadOnly="True" UniqueName="address"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn HeaderText="Gender" DataField="Gender" ReadOnly="true" UniqueName="Gender"></telerik:GridBoundColumn>
                    
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>
    </div>
</asp:Content>
