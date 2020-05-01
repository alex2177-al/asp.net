<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gallery.aspx.cs" Inherits="PageTourism.WebForm1" %>
<%@ Import Namespace="PageTourism" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Gallery </title>
    <link href="css/gallery.css" rel="stylesheet" />
    <script type="text/javascript" src="js/gallery.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
</head>
<body style="background-image:url('images/fond.jpg')";>
    <div id="main">
        <script>
                $(document).ready(function () {
                    "use strict";

                    $(".popup img").click(function () {
                        var $src = $(this).attr("src");
                        $(".show").fadeIn();
                        $(".img-show img").attr("src", $src);
                    });

                    $("span, .overlay").click(function () {
                        $(".show").fadeOut("slow");
                    });

                });
            </script>
        <nav>
            <ul>
                <li><a href="Home.aspx"><%=navbar.About%></a></li>
                <li><a href="Gallery.aspx"><%=navbar.Pages%></a></li>
                <li><a href="Gallery.aspx"><%=navbar.Gallery%></a></li>
                <li><a href="Gallery.aspx"><%=navbar.Blog%></a></li>
                <li><a href="Contact.aspx"><%=navbar.Contact%></a></li>
            </ul>
        </nav>

        <div id="titleMenu">
            <span><%=titre.Title%></span>
        </div>

        <div id="GalleryBox"> 
            <br />
            <br />
            <span id="GalleryBoxtext"> Gallery </span>
            <br />
            <br />
            <div id="GalleryImages">
                <div class="popup">
                    <img onmouseover="transparence(this)" onmouseout="normalImg(this)" onclick="" src="<%=gallerieimage.images %>"  style="height:130px"; />
                    <img onmouseover="transparence(this)" onmouseout="normalImg(this)" onclick="" src="<%=gallerieimage.images2 %>"  style="height:130px"; />
                    <img onmouseover="transparence(this)" onmouseout="normalImg(this)" onclick="" src="<%=gallerieimage.images3 %>"  style="height:130px"; />
                    <img onmouseover="transparence(this)" onmouseout="normalImg(this)" onclick="" src="<%=gallerieimage.images4 %>"  style="height:130px"; />
                    <img onmouseover="transparence(this)" onmouseout="normalImg(this)" onclick="" src="<%=gallerieimage.images5 %>"  style="height:130px"; />
                    <img onmouseover="transparence(this)" onmouseout="normalImg(this)" onclick="" src="<%=gallerieimage.images6 %>"  style="height:130px"; />
                </div>
                <div class="show">
                    <div class="overlay"></div>
                    <div class="img-show">
                        <span>X</span>
                        <img src="">
                    </div>
                </div>
            </div>

        </div>
    </div>
    
</body>
</html>