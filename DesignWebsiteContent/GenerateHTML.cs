using DesignWebsiteContent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignWebsiteContent
{
    public static class GenerateHTML
    {

        public static InputOutput GenerateOutput(this InputOutput model) {
            var result = model;
            string filePath = model.ContentCarousel.FilePath;
            string thumbnail = model.ContentCarousel.Thumbnail;
            string thumbnailImgSrc = filePath + "/" + thumbnail;
            string title = model.ContentCarousel.Title;
            string caption = model.ContentCarousel.Caption;


            string rawHTML = "";
            rawHTML += "<div class=\"rect\">\n\t<div class=\"owl-carousel owl-theme\">\n\t\t<div class=\"item pl-1 pr-1\">\n\t\t\t<img src=\"img/" + thumbnailImgSrc + "\">\n\t\t</div>\n";
            rawHTML += "\t\t<div class=\"item\">\n\t\t\t<div class=\"textDescription titleCaption\">\n\t\t\t\t<span><strong>" + title + "</strong></span><br />\n\t\t\t\t<p>" + caption + "</p>\n\t\t\t</div>\n\t\t</div>\n";

            //for(int i = 0; i < model.ContentCarousel.Slides.Count; i++) {
            //    rawHTML += "\t\t<div class=\"item pl-1 pr-1\">\n\t\t\t<img src=\"img/" + filePath + "/" + model.ContentCarousel.Slides[i].Image + "\">\n\t\t</div>\n";
            //    rawHTML += "\t\t<div class=\"item\">\n";
            //    rawHTML += "\t\t\t<div class=\"textDescription mb-2\">\n";
            //    rawHTML += "\t\t\t\t<p>" + model.ContentCarousel.Slides[i].TextBox + "</p>\n";
            //    rawHTML += "\t\t\t</div>\n";
            //    rawHTML += "\t\t</div>\n";
            //    rawHTML += "\t\t<div class=\"item pl-1 pr-1\">\n\t\t\t<img src=\"img/" + filePath + "/" + model.ContentCarousel.Slides[i].Image + "\">\n\t\t</div>\n";
            //    rawHTML += "\t\t<div class=\"item\">\n";
            //    rawHTML += "\t\t\t<div class=\"textDescription mb-2\">\n";
            //    rawHTML += "\t\t\t\t<p>" + model.ContentCarousel.Slides[i].TextBox + "</p>\n";
            //    rawHTML += "\t\t\t</div>\n";
            //    rawHTML += "\t\t</div>\n";
            //}

            rawHTML += "\t</div>\n</div>\n";

            result.Output = rawHTML;
            return result;
        }
    }
}
