<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PageTourism.WebForm1" %>
<%@ Import Namespace="PageTourism" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Home </title>
    <link href="css/acceuil.css" rel="stylesheet" />
</head>
<body style="background-image:url('images/fond.jpg')";>
    
        
            <div id="main">
                <nav>
                    <ul>
                        <li><a href="Home.aspx"><%=navbar.About%></a></li>
                        <li><a href="Gallery.aspx"><%=navbar.Pages%></a></li>
                        <li><a href="Gallery.aspx"><%=navbar.Gallery%></a></li>
                        <li><a href="Gallery.aspx"><%=navbar.Blog%></a></li>
                        <li><a href="Contact.aspx"><%=navbar.Contact%></a></li>
                        <li><a href="loginadmin.aspx"><%=navbar.loginadmin%></a></li>
                    </ul>
                </nav>

                <div id="titleMenu">
                    <span><%=titre.Title%></span>
                </div>

                <div id="explorer">
                    <img class="elephant" src="images/lion.jpg" style="width: 100%;position:relative;" />
                    <p class="Pex1"><%=exploreur.exploreLineOne %></p>
                    <p class="Pex2"><%=exploreur.exploreLineTwo %></p>
                    <div id="littlebox">
                      <div id="tinyboxleft">
                        <p><%=Voya.titre1%></p>
                    </div>

                    <div id="tinyboxmiddle">
                        <p><%=Voya.titre2%></p>
                    </div>

                    <div id="tinyboxright">
                        <p><%=Voya.titre3%></p>
                    </div>
                </div>
                    </div>

            

                <div id="bottompage">
                    <div id="box1">
                        <div id="allo">
                         <a href="inscription.aspx"><img class="left" src="images/<%=Voya.photo1 %>" style="width: 100%;height:100%;" /></a>
                        </div>
                        
                        <p><%=Voya.desc1 %></p>
                        <p><%=Voya.prix1 %></p>
                    </div>
                    <div id="box2">
                        <div id="allo">
                             <a href="inscription.aspx"><img class="middle" src="images/<%=Voya.photo2 %>" style="width: 100%;height:100%;" /></a>
                        </div>
                     
                        <p><%=Voya.desc2 %></p>
                        <p><%=Voya.prix2 %></p>
                    </div>
                    <div id="box3">
                        <div id="allo">
                           <a href="inscription.aspx"> <img class="right" src="images/<%=Voya.photo3 %> " style="width: 100%;height:100%;" /></a>
                        </div>
                        <p><%=Voya.titre3 %></p>
                        <p><%=Voya.desc3 %></p>
                        <p><%=Voya.prix3 %></p>
                    </div>
                </div>

            </div>
    
</body>
</html>
