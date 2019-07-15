$(document).ready(() => {
    loadCarousel();
    scrollCarousel();
    slideCarousel();
});

var scrollCarousel = () => {
    $('.carousel-control-prev, .carousel-control-next, .owl-dots').on('click', function () {
        $('html,body').animate({ scrollTop: $(this).closest('.rect').offset().top - 80 }, 400);
    });
};

var hideOwlNav = () => {
    $('.arrowbox, .owl-dots').css("opacity", "0");
    $('.rect').hover(function () {
        $(this).find('.arrowbox').css("opacity", ".4");
        $(this).find('.owl-dots').css("opacity", "1");
    },
        function () {
            $(this).find('.arrowbox').css("opacity", "0");
            $(this).find('.owl-dots').css("opacity", "0");
        });
};

var loadCarousel = () => {
    $('.owl-carousel').owlCarousel({
        items: 1,
        margin: 0,
        slideBy: 2,
        autoHeight: true,
        autoHeightClass: 'owl-height',
        mouseDrag: true,
        autoplay: false,
        nav: true,
        lazyLoad: true,
        responsiveClass: true,
        responsive: {
            0: {
                items: 1
            },
            768: {
                items: 2
            }
        },
        navText: ["<div class=\"carousel-control-prev\" role=\"button\" data-slide=\"prev\"><div class=\"arrowbox\"><i class=\"fa fa-angle-left align-middle mt-4 mb-4 \"></i></div><span class=\"sr-only\">Previous</span></div>",
            "<div class=\"carousel-control-next\" role=\"button\" data-slide=\"next\"><div class=\"arrowbox\"><i class=\"fa fa-angle-right align-middle mt-4 mb-4 \"></i></div><span class=\"sr-only\">Next</span></div>"]
    }).on("dragged.owl.carousel", function () {
        $('html,body').animate({ scrollTop: $(this).closest('.rect').offset().top - 80 }, 400);
    });

};


var slideCarousel = () => {
    $('.owl-carousel').on('translate.owl.carousel', function () {
        if ($(this).find('button.owl-prev').hasClass('disabled')) {

            // revert to right arrow control dimensions
            $(this).find('.carousel-control-next').css({ "width": "" });
            $(this).find('.carousel-control-next').css({ "bottom": "" });
            $(this).find('.carousel-control-next').css({ "top": "" });
            $(this).find('.arrowbox').css({ "opacity": "" });
            $(this).find('.owl-dots').css({ "opacity": "" });
            // Revert arrowbox to hidden
            $(this).closest('.rect').hover(function () {
                $(this).find('.arrowbox').css({ "opacity": "" });
                $(this).find('.owl-dots').css({ "opacity": "" });
            });

            // Hover has previous effect
            $(this).closest('.rect:hover').css({ "top": "" });
            $(this).closest('.rect:hover').css({ "box-shadow": "" });

        } else {
            // Expand right arrow control
            $(this).find('.carousel-control-next').css("width", "45px");
            $(this).find('.carousel-control-next').css("bottom", "20px");
            $(this).find('.carousel-control-next').css("top", "0");
            $(this).find('.arrowbox').css("opacity", ".4");
            $(this).find('.owl-dots').css("opacity", "1");

            // Unide arrowbox and owldots
            $(this).closest('.rect').hover(function () {
                console.log('hovaa');
                $(this).find('.arrowbox').css("opacity", ".4");
                $(this).find('.owl-dots').css("opacity", "1");
            },
                function () {
                    $(this).find('.arrowbox').css({ "opacity": "" });
                    $(this).find('.owl-dots').css({ "opacity": "" });
                });
            // Hover has 0 effect
            $(this).closest('.rect:hover').css("top", "0");
            $(this).closest('.rect:hover').css("box-shadow", "0px 2px 7px 2px rgba(0,0,0,.15)");

        }
    });
};


$(function () {
    $('.scroll-down').click(function () {
        $('html, body').animate({ scrollTop: $('.scrollTo').offset().top }, 'slow');
        return false;
    });
});