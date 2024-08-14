<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register_Form.aspx.cs" Inherits="Registration_Form.Register_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/CStyleSheet.css" rel="stylesheet" />
</head>
<body>
    <h2>REGISTRATION PAGE</h2>
    <form id="form1" runat="server">
        <div style="align-content: center">

            <table style="padding: 55px 0%; margin: -10px 13px 0px 502px;">
                <%--<table style="padding: 55px 0%;margin: -10px 13px 0px 502px;">--%>
                <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>
                
                <%-- This is the first name --%>
                <tr>
                    <td>
                        <span>
                            <label for="FirstName" style="color: white"><b>First Name:</b></label></span>
                    </td>

                    <td>
                        <br />
                        <telerik:RadTextBox ID="FirstName" runat="server" OnTextChanged="FirstName_TextChanged" AutoPostBack="true" OnLoad="FirstName_Load"></telerik:RadTextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="FirstName" runat="server" ErrorMessage="First Name Required*"></asp:RequiredFieldValidator><br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="FirstName" runat="server" ErrorMessage="First Name Length Must Be between 4 to 30 characters*" ValidationExpression="^[a-zA-Z]{4,30}$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <%-- This is the last name --%>
                <tr>
                    <td>
                        <label for="Last Name" style="color: white"><b>Last Name:</b></label>
                    </td>

                    <td>
                        <br />
                        <telerik:RadTextBox ID="LastName" runat="server" OnLoad="LastName_Load" AutoPostBack="true"></telerik:RadTextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="LastName" ErrorMessage="Last Name Required*"></asp:RequiredFieldValidator><br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="LastName" ErrorMessage="Last Name Length Must Be between 2 to 30 characters*" ValidationExpression="^[a-zA-Z]{2,30}$"> The character should be an Alphabets </asp:RegularExpressionValidator>
                    </td>
                </tr>
                <%-- emailid --%>
                <tr>
                    <td>
                        <label for="email" style="color: white"><b>Email:</b></label>
                    </td>

                    <td>
                        <telerik:RadTextBox ID="email" runat="server" AutoPostBack="true" OnTextChanged="email_TextChanged"></telerik:RadTextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="email" runat="server" ErrorMessage="Enter your Email ID*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Invalid Email-ID*" ControlToValidate="email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <%-- Mobile --%>
                <tr>
                    <td>
                        <label for="mobno" style="color: white"><b>Mobile No.:</b></label>
                    </td>

                    <td>
                        <telerik:RadTextBox ID="mobno" runat="server" AutoPostBack="true" OnTextChanged="mobno_TextChanged"></telerik:RadTextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="mobno" runat="server" ErrorMessage="Enter Mobile no"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="Invalid Number" ControlToValidate="mobno" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                

                
                <%-- CITY --%>
                <tr>
                <td>
                        <label for="city" style="color: white"><b>City:</b></label>
                    </td>
                <td>
                    <telerik:RadTextBox ID="city" runat="server"></telerik:RadTextBox>

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="city" ErrorMessage="City Name Mandatory"></asp:RequiredFieldValidator>

                </td>
       
            </tr>
                <%-- State --%>
                <tr>
                    <td>
                        <label for="State" style="color: white"><b>State:</b></label>
                    </td>
                    <td>
                        <span>
                            <telerik:RadComboBox ID="State" runat="server" DataTextField="State" DataValueField="StateID" OnDataBinding="State_DataBinding"></telerik:RadComboBox>
                        </span>
                    </td>

                </tr>
                <%-- Address --%>
                <tr>
                <td>
                        <label for="Address" style="color: white"><b>Address:</b></label>
                    </td>
                    <td>
                    <telerik:RadTextBox ID="address" runat="server"></telerik:RadTextBox>

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="address" ErrorMessage="Address is Mandatory"></asp:RequiredFieldValidator>

                </td>
       
            </tr>
                <%-- This is Gender --%>
                <tr>
                    <td>
                        <br />
                        <br />
                        <label for="Gender" style="color: white"><b>Gender:</b></label>
                    </td>

                    <td>
                        <br />
                        <%--<telerik:RadComboBox ID="ddlGender" runat="server" DataTextField="Gender" AutoPostBack="true" DataValueField="GenderID"></telerik:RadComboBox>--%>
                        <telerik:RadComboBox ID="ddlGender" runat="server" DataTextField="GenderID" OnDataBinding="ddlGender_DataBinding" AutoPostBack="true" DataValueField="Gender" AppendDataBoundItems="True"></telerik:RadComboBox>
                        <%--                            <telerik:RadComboBox ID="ddlGender" DataTextField="Gender" DataValueField="GenderID" runat="server"></telerik:RadComboBox>--%>
                    </td>
                </tr>
                <%-- This is the Password--%>
                <tr>
                    <td>
                        <label for="Password" style="color: white"><b>Password:</b></label>
                    </td>

                    <td>
                        <%--<telerik:RadTextBox TextMode="Password" ID="Password" runat="server" OnLoad="Password_Load"></telerik:RadTextBox>--%>
                        <telerik:RadTextBox ID="Password" TextMode="Password" runat="server" OnLoad="Password_Load"></telerik:RadTextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="Password" CssClass="validators" runat="server" ErrorMessage="Password Required*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" ControlToValidate="Password" runat="server" ErrorMessage="" ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <%-- This is the Confirm Password--%>
                <tr>
                    <td>
                        <br />
                        <label for="Confirm Password" style="color: white"><b>Confirm Password:</b></label>
                    </td>

                    <td>
                        <br />
                        <%--<telerik:RadTextBox TextMode="Password" ID="ConfirmPassword" runat="server" OnLoad="ConfirmPassword_Load"></telerik:RadTextBox>--%>
                        <telerik:RadTextBox ID="ConfirmPassword" TextMode="Password" runat="server" OnLoad="ConfirmPassword_Load"></telerik:RadTextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword" ErrorMessage="Password does not match*"></asp:CompareValidator>
                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="ConfirmPassword" runat="server" ErrorMessage="Password must be same*"></asp:RequiredFieldValidator>--%>
                    </td>
                </tr>
                
                <%-- This is Register button--%>
                <tr>
                    <td>
                        <label for="Register" style="color: white"></label>
                    </td>

                    <td>
                        <br />
                        <br />
                        <%--<telerik:RadButton ID="Register" runat="server" BackColor="Red" Text="Click here to Register" ForeColor="Red" OnClick="Register_Click"></telerik:RadButton>--%>
                        <telerik:RadButton ID="Register" runat="server" Text="Check here to Register" ForeColor="Red" OnClick="Register_Click"></telerik:RadButton>
                    </td>
                </tr>
                <%-- This is Cancel button --%>
                <tr>
                    <td>
                        <label for="Cancel" style="color: white"></label>
                    </td>
                    <td>
                        <%--<telerik:RadButton ID="Cancel" runat="server" Text="Cancel" ForeColor="Blue" OnClientClicked="return confirm('Are you sure')" OnClick="Cancel_Click"></telerik:RadButton>--%>
                        <telerik:RadButton ID="Cancel" runat="server" Text="Cancel" OnClick="Cancel_Click"></telerik:RadButton>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
