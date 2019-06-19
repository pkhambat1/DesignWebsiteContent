using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesignWebsiteContent.Models {
    [Display(Name ="Content Carousel")]
    public class ContentCarousel {
        public string FilePath { get; set; }

        public ThumbnailSlidePair ThumbnailSlidePair { get; set; }
        public List<SlidePair> Slides { get; set; }
    }
}
