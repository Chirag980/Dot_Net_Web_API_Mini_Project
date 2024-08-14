<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="Registration_Form.ADD_Employee1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .background{
        border-radius: 5%;
    }
        table{
            border-collapse: collapse;
                border-radius: 6%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="CSS/CStyleSheet.css" rel="stylesheet" />

    <h2>ADD EMPLOYEE</h2>
    <br />
    <br />
    <div>
        <div>
                <div style="padding:0px 22%;">
                    <div style="padding: 0 0 0 25%; border-radius: 76px;background-color: white; margin-bottom:50px;">
                <table>
                    <tr>
                        <td>
                            <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>
                            <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                <AjaxSettings>
                                    <telerik:AjaxSetting AjaxControlID="ConfigurationPanel1">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="DemoContainer1" LoadingPanelID="RadAjaxLoadingPanel1" />
                                            <telerik:AjaxUpdatedControl ControlID="ConfigurationPanel1" LoadingPanelID="RadAjaxLoadingPanel1" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                </AjaxSettings>
                            </telerik:RadAjaxManager>
                            <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Skin="Default"></telerik:RadAjaxLoadingPanel>
                        <tr>
                            <%-- First Name --%>
                            <td>
                                <telerik:RadLabel ID="RadLabel2" runat="server"><b>First Name* :</b></telerik:RadLabel>
                            </td>
                            <td>
                                <telerik:RadTextBox ID="FirstName" runat="server"></telerik:RadTextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Display="Dynamic" runat="server" ErrorMessage="Please enter first name*" ForeColor="Red" ControlToValidate="FirstName"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ValidationExpression="^([A-z][A-Za-z]*\s*[A-Za-z]*)$" ControlToValidate="FirstName" runat="server" Display="Dynamic" ErrorMessage="Wrong First Name*" ForeColor="Red"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                    <tr>
                        <%-- Last Name --%>
                        <td>
                            <telerik:RadLabel ID="RadLabel3" runat="server"><b>Last Name* :</b></telerik:RadLabel>
                        </td>
                        <td>
                            <telerik:RadTextBox ID="LastName" runat="server"></telerik:RadTextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Display="Dynamic" runat="server" ErrorMessage="Enter Last Name*" ForeColor="Red" ControlToValidate="LastName"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ValidationExpression="^([A-z][A-Za-z]*\s*[A-Za-z]*)$" ControlToValidate="LastName" runat="server" Display="Dynamic" ErrorMessage="Wrong Last Name*" ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <%-- DOB --%>
                        <td>
                            <telerik:RadLabel ID="RadLabel4" runat="server"><b>Date of Birth* :</b></telerik:RadLabel>
                        </td>
                        <td>
                            <telerik:RadDatePicker RenderMode="Lightweight" ID="RadDatePicker1" MaxDate="11-14-2022" runat="server">
                                <%--<DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MM/yyyy"></DateInput>--%>
                            </telerik:RadDatePicker>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" Display="Dynamic" runat="server" ErrorMessage="Enter your DOB*" ForeColor="Red" ControlToValidate="RadDatePicker1">
                            </asp:RequiredFieldValidator>
                        </td>

                    </tr>
                    <tr>
                        <%-- Address --%>
                        <td>
                            <telerik:RadLabel ID="RadLabel11" runat="server"><b>Address 1* :</b></telerik:RadLabel>
                        </td>
                        <td>
                            <telerik:RadTextBox ID="address1" runat="server"></telerik:RadTextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" Display="Dynamic" runat="server" ErrorMessage="Enter your Address*" ForeColor="Red" ControlToValidate="address1"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <telerik:RadLabel ID="RadLabel12" runat="server"><b>Address 2 :</b></telerik:RadLabel>
                        </td>
                        <td>
                            <telerik:RadTextBox ID="address2" runat="server"></telerik:RadTextBox>
                            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator8" Display="Dynamic" runat="server" ErrorMessage="Enter Address-2*" ForeColor="Red" ControlToValidate="address2"></asp:RequiredFieldValidator>--%>
                        </td>

                    </tr>
                    <tr>
                        <%-- City --%>
                        <td>
                            <telerik:RadLabel ID="RadLabel5" runat="server"><b>City* :</b></telerik:RadLabel>
                        </td>
                        <td>
                            <telerik:RadTextBox ID="city" runat="server"></telerik:RadTextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" Display="Dynamic" runat="server" ForeColor="Red" ErrorMessage="Enter your City*" ControlToValidate="city"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" ValidationExpression="^([A-z][A-Za-z]*\s*[A-Za-z]*)$" ControlToValidate="city" runat="server" Display="Dynamic" ErrorMessage="Wrong City Name*" ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <%-- State --%>
                        <td>
                            <telerik:RadLabel ID="RadLabel6" runat="server"><b>State* :</b></telerik:RadLabel>
                        </td>
                        <td>
                            <telerik:RadTextBox ID="State" runat="server"></telerik:RadTextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" Display="Dynamic" runat="server" ErrorMessage="Enter your State*" ForeColor="Red" ControlToValidate="State"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" Display="Dynamic" ValidationExpression="^([A-z][A-Za-z]*\s*[A-Za-z]*)$" ErrorMessage="State Name Should Be Alphabet*" ForeColor="Red" ControlToValidate="State"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <%-- Pincode --%>
                        <td>
                            <telerik:RadLabel ID="RadLabel7" runat="server"><b>Pin Code* :</b></telerik:RadLabel>
                        </td>
                        <td>
                            <telerik:RadNumericTextBox ID="pincode" MaxLength="6" runat="server">
                                <NumberFormat GroupSeparator="" DecimalDigits="0" AllowRounding="true" KeepNotRoundedValue="false" />
                            </telerik:RadNumericTextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" Display="Dynamic" runat="server" ErrorMessage="Enter your Pin-Code*" ForeColor="Red" ControlToValidate="pincode"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ForeColor="Red" Display="Dynamic" runat="server" ControlToValidate="pincode" ValidationExpression="[0-9]{6}" ErrorMessage="Not a Valid Zip Code*"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <%-- Country=======RadComboBox --%>

                        <td>
                            <telerik:RadLabel ID="RadLabel8" runat="server"><b>Country* :</b></telerik:RadLabel>
                        </td>
                        <td>
                            <div class="demo-container size-narrow" id="DemoContainer1" runat="server">
                                <div class="wrapper">
                                    <telerik:RadComboBox ID="country" EmptyMessage="Select" ForeColor="Blue" DataTextField="Country_Name" DataValueField="Country_Id" AppendDataBoundItems="true" runat="server"></telerik:RadComboBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" Display="Dynamic" runat="server" ControlToValidate="country" ErrorMessage="Please Select your Country*" ForeColor="Red"></asp:RequiredFieldValidator>

                                </div>
                            </div>


                        </td>
                    </tr>
                    <tr>
                        <%-- Designation====RadComboBox --%>
                        <td>
                            <telerik:RadLabel ID="RadLabel9" runat="server"><b>Designation* :</b></telerik:RadLabel>
                        </td>
                        <td>
                            <telerik:RadComboBox ID="Designation" EmptyMessage="Select" ForeColor="Blue" AppendDataBoundItems="true" runat="server">
                                <Items>
                                    <telerik:RadComboBoxItem Text="Software Developer" Value="1" Enabled="true" />
                                    <telerik:RadComboBoxItem Text="QA" Value="2" Enabled="true" />
                                </Items>
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" Display="Dynamic" ControlToValidate="Designation" runat="server" ErrorMessage="Please select your Designation*" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <%-- Technology=========RadComboBox --%>
                        <td>
                            <telerik:RadLabel ID="RadLabel10" runat="server"><b>Technology* :</b></telerik:RadLabel>
                        </td>
                        <td>
                            <telerik:RadComboBox ID="Technology" EmptyMessage="Select" ForeColor="Blue" runat="server">
                                <Items>
                                    <telerik:RadComboBoxItem Text="ASP.NET" Value="1" Enabled="true" />
                                    <telerik:RadComboBoxItem Text=".NET API" Value="2" Enabled="true" />
                                </Items>
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" Display="Dynamic" runat="server" ControlToValidate="Technology" ErrorMessage="Please select Technology*" ForeColor="Red"></asp:RequiredFieldValidator>

                            

                        </td>
                    </tr>
                    <tr>
                        <%-- Submit --%>
                        
                        <%-- Cancel --%>
                        <td colspan="2" style="padding:20px 20%">
                            <telerik:RadButton ID="Submit" ForeColor="Blue"  runat="server" Text="Submit" OnClick="Submit_Click"></telerik:RadButton>
                            &nbsp
                            <telerik:RadButton ID="Cancel" runat="server" ForeColor="Red" Text="Cancel" OnClick="Cancel_Click"></telerik:RadButton>
                            <br />
                        </td>
                    </tr>
                </table>
                        </div>
                    </div>
        </div>

    </div>
</asp:Content>
