<%@ Page Title="" Language="C#" MasterPageFile="~/AnonymousSite.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="SellersGateWay.Views.SignIn" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="form">
    <asp:Label ID="lblEmailId" runat="server" Text="E-Mail ID" CssClass="label"></asp:Label>
    <asp:TextBox ID="txtEmailId" runat="server" CssClass="textbox"></asp:TextBox>
    <br />
    <asp:RequiredFieldValidator ID="RequiredEMailId" runat="server" ErrorMessage="Please enter your E-Mail Id" ControlToValidate="txtEmailId" CssClass="Validator"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="EmailIdValidator" runat="server" ErrorMessage="Enter correct E-Mail Id" ControlToValidate="txtEmailId" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="Validator"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="lblPassword" runat="server" Text="Password" CssClass="label"></asp:Label>
    <asp:TextBox ID="txtPassword" type="password" runat="server" CssClass="textbox"></asp:TextBox>
    <br />
    <asp:RequiredFieldValidator ID="RequiredPassword" runat="server" ErrorMessage="Please enter your Password" ControlToValidate="txtPassword" CssClass="Validator"></asp:RequiredFieldValidator>
         <br />
         <asp:Button ID="btnSubmit" runat="server" CssClass="button" OnClick="btnSubmit_Click" Text="Login" />
         <br />
         <asp:Button ID="btnReset" runat="server" CausesValidation="False" CssClass="button" OnClick="btnReset_Click" Text="Reset" type="reset" />
    </div>
</asp:Content>
