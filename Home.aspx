<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Web_Configartion_Practice.Home" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Marks: 
            <asp:TextBox ID="txtMarks" runat="server"></asp:TextBox>
            <asp:Button ID="btnCheck" runat="server" Text="Check Pass/Fail" OnClick="btnCheck_Click" />
            <br /><br />
            <asp:Label ID="lblResult" runat="server" ForeColor="Blue"></asp:Label>
            <hr />
            <asp:Button ID="btnShow" runat="server" Text="Show Products" OnClick="btnShow_Click" />
            <br /><br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
    </form>
</body>
</html>
