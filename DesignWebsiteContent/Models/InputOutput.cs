using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesignWebsiteContent.Models {
    public class InputOutput {
        public ContentCarousel ContentCarousel { get; set; }
        public string Output { get; set; }
    }

    public class ContentCarousel {
        public string FilePath { get; set; }
        public string Thumbnail { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public List<Slide> Slides { get; set; }
    }

    public class Slide {
        public List<Input> Inputs { get; set; }
    }

    public class Input {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
