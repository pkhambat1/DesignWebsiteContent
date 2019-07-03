using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesignWebsiteContent.Models {
    [Display(Name = "Content Carousel")]
    public class ContentCarousel {
        [Display(Name = "Images File Path")]
        public string FilePath { get; set; }
        public string Thumbnail { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public List<Slide> Slides { get; set; }
    }
}
