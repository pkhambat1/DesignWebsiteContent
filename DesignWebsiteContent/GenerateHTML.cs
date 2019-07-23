using DesignWebsiteContent.Models;

namespace DesignWebsiteContent {
    public static class GenerateHTML {

        public static InputOutput GenerateOutput(this InputOutput model) {
            var result = model;
            string filePath = model.ContentCarousel.FilePath;
            string thumbnailImgSrc = filePath + "/" + model.ContentCarousel.Thumbnail;
            string title = model.ContentCarousel.Title;
            string caption = model.ContentCarousel.Caption;


            string rawHTML = "";
            rawHTML += "<div class=\"rect\">\n\t<div class=\"owl-carousel owl-theme\">\n\t\t<div class=\"item pl-1 pr-1\">\n\t\t\t<img src=\"img/" + thumbnailImgSrc + "\">\n\t\t</div>\n";
            rawHTML += "\t\t<div class=\"item\">\n\t\t\t<div class=\"textDescription titleCaption\">\n\t\t\t\t<span><strong>" + title + "</strong></span><br />\n\t\t\t\t<p>" + caption + "</p>\n\t\t\t</div>\n\t\t</div>\n";

            // For each slide
            for(int i = 0; i < model.ContentCarousel.Slides.Count; i++) {
                rawHTML += "\t<div class=\"item\">\n";
                // For each slide input
                for(int j = 0; j < model.ContentCarousel.Slides[i].Inputs.Count; j++) {

                    if(model.ContentCarousel.Slides[i].Inputs[j].Type == "Image") {
                        rawHTML += "\t\t<div class=\"pl-1 pr-1 mb-2\">\n\t\t\t<img src=\"img/" + filePath + "/" + model.ContentCarousel.Slides[i].Inputs[j].Name + "\">\n\t\t</div>\n";
                    } else if(model.ContentCarousel.Slides[i].Inputs[j].Type == "TextBox") {
                        rawHTML += "\t\t<div class=\"textDescription mb-2\">\n";
                        rawHTML += "\t\t\t<p>" + model.ContentCarousel.Slides[i].Inputs[j].Name + "</p>\n";
                        rawHTML += "\t\t</div>\n";
                    }
                }
                rawHTML += "\t</div>\n";
            }


            rawHTML += "</div>\n";

            result.Output = rawHTML;
            return result;
        }
    }
}