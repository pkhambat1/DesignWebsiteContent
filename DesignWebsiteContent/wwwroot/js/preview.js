// Global vars

var toggleVal = "initial";
var itemCount = 2;

// Being extremely nitpicky here
$(window).on("resize", function (event) {
    windowWidth = $(this).width();
    if ($(this).width() >= 992 && toggleVal === "uncollapsed") {
        console.log("if hit!");
        toggleVal = "stretchUncollapsed";
        navbarChange("stretchUncollapsed");
    } else if ($(this).width() < 992 && toggleVal === "stretchUncollapsed") {
        console.log("else if hit!");
        toggleVal = "uncollapsed";
        navbarChange("uncollapsed");
    }
});

$(function () {
    var elements = document.getElementsByClassName('typewrite');
    for (var i = 0; i < elements.length; i++) {
        var toRotate = elements[i].getAttribute('data-type');
        var period = elements[i].getAttribute('data-period');
        if (toRotate) {
            new TxtType(elements[i], JSON.parse(toRotate), period);
        }
    }
});

$(function () {
    $("#typing").typed({
        strings: ["", "", "", "", " coding . . . ", "", " drawing . . .", "", "writing . . .", "", " photography . . .", "", " math . . .", "", " cars . . .", "", " Apple keynotes . . .", "", " coding . . ."],
        typeSpeed: 0
    });
});

function navbarChange(toggleVal) {
    // if scrolled down
    if ($(this).scrollTop() > $('.fixed-top').height()) {
        $('#logo, .portfolio-navbar .navbar-nav .nav-link').css({ "color": "#212529" });
        $('.navbar-light').css("background", "#fff");
        $('.navbar-light').css("opacity", ".96");
        $('.portfolio-navbar.navbar').css("box-shadow", "0 4px 10px rgba(0,0,0,.15)");
        if (toggleVal === "uncollapsed") {
            $('.navbar-light').css("padding", "0px 5px 10px");
        } else {
            $('.navbar-light').css("padding", "0px 5px");
        }

        if (toggleVal === "collapsed" || toggleVal === "initial") {
            $('.portfolio-navbar.navbar').css("box-shadow", "0 4px 10px rgba(0,0,0,.15)");
        }
        // if on top 
    } else {
        $('#logo, .portfolio-navbar .navbar-nav .nav-link').css({ "font-size": "" });
        $('#logo, .portfolio-navbar .navbar-nav .nav-link').css({ "color": "" });
        $('.navbar-light').css({ "padding": "" });
        $('.navbar-light').css({ "background": "" });
        $('.navbar-light').css({ "opacity": "" });
        if (toggleVal === "collapsed" || toggleVal === "initial" || toggleVal === "stretchUncollapsed") {
            $('.portfolio-navbar.navbar').css({ "box-shadow": "" });
        } else {
            $('.portfolio-navbar.navbar').css("box-shadow", "0 4px 10px rgba(0,0,0,.15)");
        }
    }
}

// If scrolled
$(document).on('scroll', function () {
    navbarChange(toggleVal);
});

$(document).ready(function () {

    // If collapsed
    $('.navbar').on('hide.bs.collapse', function () {
        toggleVal = "collapsed";
        navbarChange("collapsed");
        console.log(toggleVal + " on col. call navbarChange(\"collapsed\")");
    });

    // If uncollapsed
    $('.navbar').on('show.bs.collapse', function () {
        toggleVal = "uncollapsed";
        navbarChange("uncollapsed");
        console.log(toggleVal + " on unc. call navbarChange(\"uncollapsed\")");
    });
});

$(document).on('ready', function () {
    loadCarousel();
    console.log('hello');
});

var loadCarousel = function () {
    $('.owl-carousel').owlCarousel({
        items: 1,
        margin: 0,
        autoHeight: true,
        mouseDrag: false,
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
    }).on("dragged.owl.carousel", function (event) {
        $('html,body').animate({ scrollTop: $(this).closest('.rect').offset().top - 80 }, 400);
    });

    var owl = $(".owl-carousel").data();
    console.log('owl = ' + owl);

};

$(document).ready(function () {
    $('.arrowbox, .owl-dots').css("opacity", "0");
    $('.rect').hover(function () {
        $(this).find('.arrowbox').css("opacity", ".4");
        $(this).find('.owl-dots').css("opacity", "1");
    },
        function () {
            $(this).find('.arrowbox').css("opacity", "0");
            $(this).find('.owl-dots').css("opacity", "0");
        });
});

$(document).ready(function () {
    $('.carousel-control-prev, .carousel-control-next, .owl-dots').on('click', function () {
        $('html,body').animate({ scrollTop: $(this).closest('.rect').offset().top - 80 }, 400);
    });
});

$(function () {
    slideCarousel();
});

var slideCarousel = function () {
    console.log('slideCarousel hit');
    $('.owl-carousel').on('translate.owl.carousel', function () {
        if ($(this).find('button.owl-prev').hasClass('disabled')) {
            $(this).find('.carousel-control-next').css("width", "100%");
        } else {
            $(this).find('.carousel-control-next').css({ "width": "45px" });
        }
    });
};





