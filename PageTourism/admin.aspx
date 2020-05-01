<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="PageTourism.admin" %>
<%@ Import Namespace="PageTourism" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Home </title>
    <link href="css/acceuil.css" rel="stylesheet" />
</head>
<body style="background-image:url('images/admin.jpg')";>
    
        
            <div id="main">
                <nav>
                    <ul>
                        <li><a href="ajout.aspx"><%=navbar.ajout%></a></li>
                        <li><a href="modsup.aspx"><%=navbar.modsup%></a></li>
                        <li><a href="consulter.aspx"><%=navbar.consulter%></a></li>    
                    </ul>
                </nav>


                
</body>
</html>