using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PageTourism
{

    public class Voyage
    {
        public string titre1 { get; set; }
        public string titre2 { get; set; }
        public string titre3 { get; set; }
        public string desc1 { get; set; }
        public string desc2 { get; set; }
        public string desc3 { get; set; }
        public string prix1 { get; set; }
        public string prix2 { get; set; }
        public string prix3 { get; set; }
        public string photo1 { get; set; }
        public string photo2 { get; set; }
        public string photo3 { get; set; }
        public string check1 { get; set; }
        public string check2 { get; set; }
        public string check3 { get; set; }

        public Voyage()
        {
            titre1 = "";
            titre2 = "";
            titre3 = "";
            desc1 = "";
            desc2 = "";
            desc3 = "";
            prix1 = "";
            prix2 = "";
            prix3 = "";
            photo1 = "";
            photo2 = "";
            photo3 = "";
            check1 = "";
            check2 = "";
            check3 = "";
        }

    }
    public class HomePageControl
    {
        public class navbar
        {
            public string Home { get; set; }
            public string About { get; set; }
            public string Pages { get; set; }
            public string Gallery { get; set; }
            public string Blog { get; set; }
            public string Contact { get; set; }
            public string loginadmin { get; set; }
            public string ajout { get; set; }
            public string modsup { get; set; }
            public string selection { get; set; }
            public string consulter { get; set; }


            public navbar()
            {
                Home = "";
                About = "";
                Pages = "";
                Gallery = "";
                Blog = "";
                Contact = "";
                loginadmin = "";
                ajout = "";
                modsup = "";
                selection = "";
                consulter = "";
            }


        }

        public class titre
        {
            public string Title { get; set; }

            public titre()
            {
                Title = "";
            }
        }
         
        public class Email
        {
            public string To { get; set; }
            public string Subject { get; set; }
            public string Message { get; set; }

        }
        public class exploreur
        {
            public string exploreLineOne;
            public string exploreLineTwo;

            public exploreur()
            {
                exploreLineOne = "";
                exploreLineTwo = "";
            }

        }

        public class basdepage
        {
            public string leftBox;
            public string middleBox;
            public string rightBox;
            public string leftboxTEXT;
            public string middleboxTEXT;
            public string rightTEXT;



            public basdepage()
            {
                leftBox = "";
                middleBox = "";
                rightBox = "";
                leftboxTEXT = "";
                middleboxTEXT = "";
                rightTEXT = "";
          
            }
        }

        public class image
        {
            public string img;
            public string backgroundImg;
            public string leftboxIMG;
            public string rightboxIMG;
            public string middleboxIMG;
            


            public image()
            {
                img = "";
                backgroundImg = "";
                leftboxIMG = "";
                rightboxIMG = "";
                middleboxIMG = "";
            }
        }

        public class gallerie
        {
            public string images = "";
            public string images2 = "";
            public string images3 = "";
            public string images4 = "";
            public string images5 = "";
            public string images6 = "";
            public string gallerytext = "";
           

            public gallerie()
            {
                images = "";
                images2 = "";
                images3 = "";
                images4 = "";
                images5 = "";
                images6 = "";
                gallerytext = "";

            }
        }
       
    }
}