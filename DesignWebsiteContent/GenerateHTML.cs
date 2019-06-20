using DesignWebsiteContent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignWebsiteContent {
    public static class GenerateHTML {

        public static InputOutput GenerateOutput(this InputOutput model) {
            var result = model;
            string rawHTML = "";

            rawHTML += "<div class=\"rect\">\n";




            rawHTML += "</div>";

            result.Output = rawHTML;
            return result;
        }
    }
}
