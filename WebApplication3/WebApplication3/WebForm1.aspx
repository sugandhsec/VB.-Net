<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <p>
        select state</p>
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>maharsahtra</asp:ListItem>
        <asp:ListItem>gujarat</asp:ListItem>
        <asp:ListItem>jammu</asp:ListItem>
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList2" runat="server">
    </asp:DropDownList>
    <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
    <br />
    select food<asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" 
        Rows="5" SelectionMode="Multiple">
        <asp:ListItem>idli</asp:ListItem>
        <asp:ListItem>dhosa</asp:ListItem>
        <asp:ListItem>punjabi</asp:ListItem>
        <asp:ListItem>chinese</asp:ListItem>
        <asp:ListItem>sandwich</asp:ListItem>
    </asp:ListBox>
    <asp:ListBox ID="ListBox2" runat="server" Rows="5" SelectionMode="Multiple">
        <asp:ListItem>100</asp:ListItem>
        <asp:ListItem>500</asp:ListItem>
        <asp:ListItem>200</asp:ListItem>
        <asp:ListItem>40</asp:ListItem>
        <asp:ListItem>50</asp:ListItem>
    </asp:ListBox>
    <p>
        total<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <asp:Button ID="Button1" runat="server" Text="total" />
    <br />
    <br />
    <asp:Image ID="Image1" runat="server" />
    <br />
    <asp:CheckBoxList ID="chklstboxlang" runat="server" AutoPostBack="True" 
        Width="119px">
        <asp:ListItem>hindi</asp:ListItem>
        <asp:ListItem>gujarati</asp:ListItem>
        <asp:ListItem>english</asp:ListItem>
        <asp:ListItem>marathi</asp:ListItem>
        <asp:ListItem>punjabi</asp:ListItem>
    </asp:CheckBoxList>
    <p>
        <asp:ListBox ID="lstboxlang" runat="server" Width="154px"></asp:ListBox>
    </p>
    <p style="width: 86px">
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
            <asp:ListItem>FY</asp:ListItem>
            <asp:ListItem>SY</asp:ListItem>
            <asp:ListItem>TY</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <asp:BulletedList ID="BulletedList1" runat="server" BulletStyle="Disc" 
        DisplayMode="HyperLink">
        <asp:ListItem>UNIX</asp:ListItem>
        <asp:ListItem>PHP</asp:ListItem>
        <asp:ListItem>NT</asp:ListItem>
        <asp:ListItem>OS</asp:ListItem>
        <asp:ListItem>ASP</asp:ListItem>
    </asp:BulletedList>
    <p>
        &nbsp;</p>
    </form>
</body>
</html>
