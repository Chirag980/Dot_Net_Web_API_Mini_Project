<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Register_Page.ascx.cs" Inherits="Registration_Form.Register_Page" %>

<!DOCTYPE html>

<link href="CSS/CStyleSheet.css" rel="stylesheet" />

<style>
    table {
        background-color: white;
        padding: 0px 0 0 8%;
        box-sizing: border-box;
        border-radius: 54px;
    }

    .design {
        border-radius: 14px;
    }

    table tr .validator {
        width: 200px;
    }
</style>
<h2>REGISTRATION</h2>
<br />
<br />
<div>
    <div>
        <center>
            <table>
                <tr>
                    <td>
                        <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>
                        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                            <AjaxSettings>
                                <telerik:AjaxSetting AjaxControlID="ConfigurationPanel1">
                                    <UpdatedControls>
                                        <telerik:AjaxUpdatedControl ControlID="DemoContainer1" LoadingPanelID="RadAjaxLoadingPanel1" />
                                        <telerik:AjaxUpdatedControl ControlID="ConfigurationPanel1" LoadingPanelID="RadAjaxLoadingPandel1" />
                                    </UpdatedControls>
                                </telerik:AjaxSetting>
                            </AjaxSettings>
                        </telerik:RadAjaxManager>
                        <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Skin="Default"></telerik:RadAjaxLoadingPanel>

                        <tr>
                            <%-- user Name --%>
                            <td>
                                <telerik:RadLabel ID="RadLabel1" runat="server"><b>UserName/Email:</b></telerik:RadLabel>
                            </td>
                            <td>
                                <telerik:RadTextBox ID="UserName" ValidationGroup="Register" CssClass="design" runat="server"></telerik:RadTextBox>
                            </td>
                            <td class="validator">
                                <asp:RequiredFieldValidator ValidationGroup="Register" ID="RequiredFieldValidator12" Display="Dynamic" runat="server" ErrorMessage="Please enter UserName*" ForeColor="Red" CssClass="validatorcss" ControlToValidate="UserName"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ValidationGroup="Register" ID="RegularExpressionValidator1" runat="server" Display="Dynamic" ControlToValidate="UserName" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="validatorcss" ErrorMessage="Invalid UserName/Email!" ForeColor="Red"></asp:RegularExpressionValidator>
                            </td>
                        </tr>


                <tr>
                    <%-- First Name --%>
                    <td>
                        <telerik:RadLabel ID="RadLabel2" runat="server"><b>First Name:</b></telerik:RadLabel>
                    </td>
                    <td>
                        <telerik:RadTextBox ID="FirstName" ValidationGroup="Register" CssClass="design" runat="server"></telerik:RadTextBox>
                    </td>
                    <td class="validator">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="Register" Display="Dynamic" runat="server" ErrorMessage="Please enter first name*" ForeColor="Red" ControlToValidate="FirstName"></asp:RequiredFieldValidator><br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ValidationGroup="Register" Display="Dynamic" ControlToValidate="FirstName" ValidationExpression="^[a-zA-Z ]+$" runat="server" ErrorMessage="Wrong First Name!" ForeColor="Red"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <%-- Last Name --%>
                    <td>
                        <telerik:RadLabel ID="RadLabel3" runat="server"><b>Last Name:</b></telerik:RadLabel>
                    </td>
                    <td>
                        <telerik:RadTextBox ID="LastName" ValidationGroup="Register" CssClass="design" runat="server"></telerik:RadTextBox>
                    </td>
                    <td class="validator">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="Register" runat="server" ErrorMessage="Enter Last Name*" ForeColor="Red" ControlToValidate="LastName" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ValidationGroup="Register" ControlToValidate="LastName" ValidationExpression="^([A-z][A-Za-z]*\s*[A-Za-z]*)$" runat="server" Display="Dynamic" ErrorMessage="Wrong Last Name!" ForeColor="Red"></asp:RegularExpressionValidator>
                    </td>
                </tr>

                <%-- This is Gender --%>
                <tr>
                    <td>
                        <telerik:RadLabel ID="RadLabel4" runat="server"><b>Gender:</b></telerik:RadLabel>
                        <%--<label for="Gender" style="color: white"><b>Gender:</b></label>--%>
                    </td>

                    <td>
                        <telerik:RadComboBox EmptyMessage="Select" ID="ddlGender" ValidationGroup="Register" CssClass="design" runat="server" DataTextField="GenderID" OnDataBinding="ddlGender_DataBinding" DataValueField="Gender" AppendDataBoundItems="True"></telerik:RadComboBox>
                    </td>
                    <td class="validator">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="Register" runat="server" ErrorMessage="Please choose your gender*" ForeColor="Red" Display="Dynamic" ControlToValidate="ddlGender"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <%-- This is the Password--%>
                <tr>
                    <td>
                        <telerik:RadLabel ID="RadLabel5" runat="server"><b>Password:</b></telerik:RadLabel>

                    </td>
                    <td>
                        <telerik:RadTextBox ID="Password" ValidationGroup="Register" TextMode="Password" CssClass="design" runat="server" OnLoad="Password_Load"></telerik:RadTextBox>
                    </td>
                    <td class="validator">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="Register" ControlToValidate="Password" CssClass="validators" runat="server" ErrorMessage="Password Required*" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                        <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator4" ControlToValidate="Password" runat="server" ErrorMessage="Enter valid Password!" ForeColor="Red" ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"></asp:RegularExpressionValidator>--%>
                    </td>
                </tr>
                <%-- This is the Confirm Password--%>
                <tr>
                    <td>
                        <telerik:RadLabel ID="RadLabel6" runat="server"><b>Confirm Password:</b></telerik:RadLabel>
                    </td>

                    <td>
                        <telerik:RadTextBox ID="ConfirmPassword" ValidationGroup="Register" TextMode="Password" CssClass="design" runat="server" OnLoad="ConfirmPassword_Load"></telerik:RadTextBox>
                    </td>
                    <td class="validator">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="Register" ControlToValidate="ConfirmPassword" runat="server" ErrorMessage="Enter Confirm Password*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ValidationGroup="Register" ControlToCompare="Password" ControlToValidate="ConfirmPassword" Display="Dynamic" ErrorMessage="Password does not match*" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <%-- This is Register button--%>
                <tr>
                    <td></td>
                    <td>
                        <br />
                        <br />
                        <telerik:RadButton ID="Register" ValidationGroup="Register" runat="server" Text="Register" ForeColor="Red" OnClick="Register_Click"></telerik:RadButton>
                        <%-- This is Cancel button --%>
                        <label for="Cancel" style="color: white"></label>
                        <telerik:RadButton ID="Cancel" ForeColor="Blue" runat="server" Text="Cancel" OnClick="Cancel_Click"></telerik:RadButton>
                    </td>
                </tr>
            </table>
        </center>
    </div>
</div>
