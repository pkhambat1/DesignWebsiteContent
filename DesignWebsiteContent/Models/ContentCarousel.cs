using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignWebsiteContent.Models {
    public class ContentCarousel {
        public ThumbnailSlidePair ThumbnailSlidePair { get; set; }
        public List<SlidePair> Slides { get; set; }
    }
}
