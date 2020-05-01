<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PageTourism.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <title> Contact </title>
    <link href="css/contact.css" rel="stylesheet" />
    <script src="js/contact.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
</head>
<body style="background-image:url('images/fond.jpg')";>
    <div id="main">
        <nav>
            <ul>
                <li><a href="Home.aspx"><%=navbar.About%></a></li>
                <li><a href="Gallery.aspx"><%=navbar.Pages%></a></li>
                <li><a href="Gallery.aspx"><%=navbar.Gallery%></a></li>
                <li><a href="Contact.aspx"><%=navbar.Blog%></a></li>
                <li><a href="Gallery.aspx"><%=navbar.Contact%></a></li>
            </ul>
        </nav>

        <div id="titleMenu">
            <span><%=titre.Title%></span>
        </div>

        <div class="container">
            <div style="text-align: center">
                <h2>Contact Us</h2>
                <p>MISCELLANEOUS INFORMATION: </p>
            </div>
            <div class="row">
                <div class="column">
                    <p>ADDRESS:</p>
                    <p>138 Atlantis Ln Kingsport Illinois 121154</p>
                    <br>
                    <p>PHONES:</p>
                    <p>800-2345-6789</p>
                    <p>800-2345-6789</p>
                    <br />
                    <p>EMAIL:</p>
                    <p>mail@demolink.com</p>
                    <p>Download information as vCard</p>
                </div>
                <form id="f1" runat="server">

                        <div>

                            <asp:TextBox ID="TxtTo" runat="server">to</asp:TextBox>

                            <asp:TextBox ID="txtSubject" runat="server">subject</asp:TextBox>

                            <asp:TextBox ID="txtMessage" runat="server" Height="313px" Width="474px">message</asp:TextBox>

                            <asp:Button ID="btnSend" runat="server" OnClick="btnSend_Click" Text="send" />

                        </div>

                    </form>
            </div>
        </div>

    </div>
</body>
</html>
