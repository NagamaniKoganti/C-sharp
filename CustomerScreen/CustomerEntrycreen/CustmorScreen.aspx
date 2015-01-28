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
        <br />
        <br />
        <asp:Label ID="LblCountry" runat="server" Text="Country Name"></asp:Label>
        <asp:DropDownList ID="DdlCountry" runat="server">
            <asp:ListItem>India</asp:ListItem>
            <asp:ListItem>UK</asp:ListItem>
            <asp:ListItem>USA</asp:ListItem>
            <asp:ListItem>Singapore</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:RadioButton ID="RadioMale" runat="server" Text="Male" GroupName="Gender"/><asp:RadioButton ID="RadioFemale" runat="server" Text="Female" GroupName="Gender" />
        <br />
        <br />
        <asp:CheckBox ID="CheckBoxRead" runat="server" Text="Reading" /><asp:CheckBox ID="CheckBoxWrite" runat="server" Text="Writing" /><asp:CheckBox ID="CheckBoxPaint" runat="server"  Text="Painting"/>
        <br />
        <br />
        <asp:RadioButton ID="RadioMarried" runat="server" Text ="Married" GroupName="Status" /><asp:RadioButton ID="RadioUnmarried" runat="server" Text ="Unmarried" GroupName="Status" />
        <br />
        <br />
        <asp:Button ID="BtnInsert" runat="server" Text="INSERT" OnClick="BtnInsert_Click" /><asp:Button ID="BtnUpdate" runat="server" Text="UPDATE" /><asp:Button ID="BtnDelete" runat="server" Text="DELETE" /><br /><br />
        <asp:GridView ID="GridViewCustomerDetails" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnSelectedIndexChanged="GridViewCustomerDetails_SelectedIndexChanged">
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>
