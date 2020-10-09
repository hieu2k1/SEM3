<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="ShoppingMall.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="border:1px solid black">
                <tr>
                    <td colspan="2">
                        <h2>User Registration</h2>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Email</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Width="100px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" 
                            runat="server" ErrorMessage="Email is required"
                            ForeColor="Red" ControlToValidate="txtEmail" Display="Dynamic"
                            Text="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" 
                            runat="server" ErrorMessage="Invalid Email Format" ControlToValidate="txtEmail"
                            ForeColor="Red" Text="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>User Name</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server" Width="100px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserName"
                            runat="server" ErrorMessage="Username is required" ForeColor="Red"
                            ControlToValidate="txtUserName"
                            Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Password</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" Width="100px" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword"
                            runat="server" ErrorMessage="Password is required"
                            ForeColor="Red" ControlToValidate="txtPassword"
                            Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Confirm Password</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtConfirmPassword" runat="server" Width="100px"
                            TextMode="Password"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidatorConfirmPassword" runat="server"
                            ErrorMessage="Password and ComfirmPassword must match"
                            ForeColor="Red" ControlToValidate="txtConfirmPassword" 
                            ControlToCompare="txtPassword" Display="Dynamic" Operator="Equal" Type="String" Text="*"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSubmit" runat="server" Text="Save" OnClick="btnSubmit_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"  HeaderText="Page Error"/>
                    </td>
                </tr>
                <tr>
                    <td colspan="2"><b><asp:Label ID="lblStatus" runat="server" Text=""></asp:Label> </b>        </td>
                </tr>

               
            </table>
        </div>
    </form>
</body>
</html>
