<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="UserRecords.aspx.cs" Inherits="Registration_Form.UserRecords" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2><strong class="newStyle1">USER RECORDS</strong></h2>    <br />
            <link href="CSS/CStyleSheet.css" rel="stylesheet" />
    <center>
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
        <%--<h2>USER RECORD: </h2>--%>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <telerik:RadGrid ID="RadGrid2" runat="server" AutoGenerateColumns="false" OnNeedDataSource="RadGrid2_NeedDataSource" AllowSorting="true" AllowPaging="true" AllowCustomPaging="true">
            <MasterTableView AutoGenerateColumns="false" DataKeyNames="UserID">
                <Columns>
                    <telerik:GridBoundColumn HeaderText="User ID" DataField="UserID" DataType="System.Int32" ReadOnly="true" UniqueName="UserID"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn HeaderText="UserName" DataField="UserName" ReadOnly="true" UniqueName="UserName"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn HeaderText="First Name" DataField="firstname"  ReadOnly="True" UniqueName="firstname"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn HeaderText="Last Name" DataField="lastname" ReadOnly="True" UniqueName="lastname"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn HeaderText="Gender" DataField="Gender" ReadOnly="true" UniqueName="Gender"></telerik:GridBoundColumn>
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>
        
    </div>
    </center>
    
</asp:Content>
