<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginadmin.aspx.cs" Inherits="PageTourism.loginadmin" %>

<!DOCTYPE html>

<html>
    <head runat="server">
      <title>Login Admin </title>
    <link href="css/contact.css" rel="stylesheet" />
    <script src="js/contact.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
</head>

<body>
    <div id="main">
    <form id="f1" runat="server">
        <header>Login</header>
        <label>Username<span>*</span></label>
        <asp:TextBox ID="t1" runat="server"></asp:TextBox>
        <label>Password <span>*</span></label>
        <asp:TextBox ID="t2" runat="server"></asp:TextBox>
        <br /> 
        <asp:Button ID="b1" runat="server" Text="Login" OnClick="b1_Click" />
        <br /> 
        <asp:label ID="l1" runat="server" Text=""></asp:label>
        <br />
    </form>
        </div>
</body>




</html>
