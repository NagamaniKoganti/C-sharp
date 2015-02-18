<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustmorScreen.aspx.cs" Inherits="CustomerEntrycreen.CustmorScreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LblCustname" runat="server" Text="Customer Name"></asp:Label>
        <asp:TextBox ID="TxtCustName" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LblCountry" runat="server" Text="Country Name"></asp:Label>
        <asp:DropDownList ID="DdlCountry" runat="server" OnSelectedIndexChanged="DdlCountry_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <asp:RadioButton ID="RadioMale" runat="server" Text="Male" GroupName="Gender"/><asp:RadioButton ID="RadioFemale" runat="server" Text="Female" GroupName="Gender" /><br />
        <asp:Panel ID="Panel1" runat="server"></asp:Panel>
        <asp:RadioButton ID="RadioMarried" runat="server" Text ="Married" GroupName="Status" /><asp:RadioButton ID="RadioUnmarried" runat="server" Text ="Unmarried" GroupName="Status" />
        <br />
        <br />
        <asp:Button ID="BtnInsert" runat="server" Text="INSERT" OnClick="BtnInsert_Click" style="height: 26px" /><asp:Button ID="BtnUpdate" runat="server" Text="UPDATE" OnClick="BtnUpdate_Click" /><asp:Button ID="BtnDelete" runat="server" Text="DELETE" OnClick="BtnDelete_Click" /><br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>


    </div>
    </form>
</body>
</html>
