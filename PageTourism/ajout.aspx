<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ajout.aspx.cs" Inherits="PageTourism.ajout" %>

<!DOCTYPE html>

<html>
 <head runat="server">
      <title> Ajout voyage </title>
    <link href="css/contact.css" rel="stylesheet" />
    <script src="js/contact.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
</head>
<body style="background-image:url('images/admin.jpg')";>
    <div id="main">
        <form id="f1" runat="server">
        <header>Creer</header>
        <label>Titre</label>
        <asp:TextBox ID="t3" runat="server"></asp:TextBox>
        <label>Description</label>
        <asp:TextBox ID="t4" runat="server"></asp:TextBox>
        <label>Prix</label>
        <asp:TextBox ID="t5" runat="server"></asp:TextBox>
        <label>Photo</label>
         <asp:FileUpload ID="up1" runat="server" />
        <br /> 
        <asp:Button ID="b2" runat="server" Text="Creer" OnClick="b2_Click" />
        <br /> 
        <asp:label ID="l2" runat="server" Text=""></asp:label>
        <br />
    </form>

</div>


        

    
</body>
</html>
