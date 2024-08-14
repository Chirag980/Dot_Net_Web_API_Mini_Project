<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="EmployeeRecord.aspx.cs" Inherits="Registration_Form.EmployeeRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>
        <link href="CSS/CStyleSheet.css" rel="stylesheet" />

    <h2>EMPLOYEE RECORD</h2><br /><br />
    
        <telerik:RadLinkButton ID="RadLinkButton1" runat="server" OnLoad="RadLinkButton1_Load" NavigateUrl="AddEmployee.aspx" ForeColor="Blue" Text="Add Employee"></telerik:RadLinkButton>
    
    <div style="max-height:600px;margin: 25px 11px;width: 1334px;"">
        <telerik:RadGrid ID="RadGrid1" runat="server" OnNeedDataSource="RadGrid1_NeedDataSource" AutoGenerateColumns="false" AllowPaging="true" PageSize="50" AllowSorting="true" AllowCustomPaging="true" OnItemDataBound="RadGrid1_ItemDataBound" OnItemCommand="RadGrid1_ItemCommand" >
        <MasterTableView AutoGenerateColumns="false" DataKeyNames="EmployeeId">
            <Columns>
                
                <telerik:GridBoundColumn DataField="EmployeeId" UniqueName="EmployeeId" HeaderText="EmployeeId" ReadOnly="true"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="FirstName" UniqueName="FirstName" HeaderText="FirstName" ReadOnly="true"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="LastName" UniqueName="LastName" HeaderText="LastName" ReadOnly="true"></telerik:GridBoundColumn>
                <telerik:GridCalculatedColumn HeaderText="FullName" UniqueName="FullName" DataFields="FirstName, LastName" Expression='{0}+" "+{1}'></telerik:GridCalculatedColumn>
                <telerik:GridBoundColumn DataField="DateOfBirth" UniqueName="DateOfBirth" HeaderText="DateOfBirth" ReadOnly="true"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Address1" UniqueName="Address1" HeaderText="Address1" ReadOnly="true"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Address2" UniqueName="Address2" HeaderText="Address2" ReadOnly="true"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="City" UniqueName="City" HeaderText="City" ReadOnly="true"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="State" UniqueName="State" HeaderText="State" ReadOnly="true"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="pincode" UniqueName="pincode" HeaderText="pincode" ReadOnly="true"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Country" UniqueName="Country" HeaderText="Country" ReadOnly="true"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Designation" UniqueName="Designation" HeaderText="Designation" ReadOnly="true"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Technology" UniqueName="Technology" HeaderText="Technology" ReadOnly="true"></telerik:GridBoundColumn>


                <telerik:GridTemplateColumn>
                    <ItemTemplate>
                        <asp:LinkButton ID="btnEdit" CommandName="Edit" CommandArgument="Edit" runat="server">Edit</asp:LinkButton>
                    </ItemTemplate>
                </telerik:GridTemplateColumn>
                <telerik:GridTemplateColumn>
                    <ItemTemplate>
                        <asp:LinkButton ID="btnDelete" CommandArgument="Delete" OnClientClick="return confirm('Are you sure to delete record')" CommandName="Delete" runat="server">Delete</asp:LinkButton>               </script>
                    </ItemTemplate>
                </telerik:GridTemplateColumn>
            </Columns>
        </MasterTableView>
        </telerik:RadGrid>
    </div>
</asp:Content>
