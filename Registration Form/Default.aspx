<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        FIRST NAME-&gt;<asp:TextBox ID="txtfname" runat="server" style="margin-right: 9px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LAST NAME-&gt;<asp:TextBox 
            ID="txtlname" runat="server" style="margin-right: 9px"></asp:TextBox>
    </p>
    <p>
        ADDRESS-&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtadd" runat="server" style="margin-right: 9px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CITY-&gt;<asp:TextBox 
            ID="txtcity" runat="server" style="margin-right: 9px"></asp:TextBox>
    </p>
    <p>
        GENDER-&gt;<asp:RadioButton ID="rbtnmal" runat="server" GroupName="gender" 
            Text="Male" />
        <asp:RadioButton ID="rbtnfem" runat="server" GroupName="gender" Text="Female" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        HOBBIES-&gt;<asp:CheckBox ID="chkb1" runat="server" Text="Reading" />
        <asp:CheckBox ID="chkb2" runat="server" Text="Writing" />
        <asp:CheckBox ID="chkb3" runat="server" Text="Swimming" />
    </p>
    <p>
        MOBILE NO-&gt;<asp:TextBox ID="txtmob" runat="server" style="margin-right: 9px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DATE OF BIRTH-&gt;<asp:TextBox 
            ID="txtdob" runat="server" style="margin-right: 9px"></asp:TextBox>
    </p>
    <asp:Button ID="btnsub" runat="server" Text="Submit" Width="207px" />
    <p>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblfnameh" runat="server"></asp:Label>
&nbsp;<asp:Label ID="lblfnamev" runat="server"></asp:Label>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbllnameh" runat="server"></asp:Label>
&nbsp;<asp:Label ID="lbllnamev" runat="server"></asp:Label>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbladdh" runat="server"></asp:Label>
&nbsp;<asp:Label ID="lbladdv" runat="server"></asp:Label>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblcityh" runat="server"></asp:Label>
&nbsp;<asp:Label ID="lblcityv" runat="server"></asp:Label>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblgenh" runat="server"></asp:Label>
&nbsp;<asp:Label ID="lblgenv" runat="server"></asp:Label>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblhobh" runat="server"></asp:Label>
&nbsp;<asp:Label ID="lblhobv" runat="server"></asp:Label>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblmobh" runat="server"></asp:Label>
&nbsp;<asp:Label ID="lblmobv" runat="server"></asp:Label>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbldobh" runat="server"></asp:Label>
&nbsp;<asp:Label ID="lbldobv" runat="server"></asp:Label>
    </p>
    </form>
</body>
</html>
