
$(document).ready(function () {
    $('#generate').unbind().on('click', submitGenerateHTML);
    $('#refresh').unbind().on('click', submitRefreshPreview);
});

var submitGenerateHTML = function () {
    var filePath = $('.filePath').val();
    var title = $('.titleValue').val();
    var caption = $('.caption').val();
    var thumbnail = $('.thumbnail').val();

    var headers = [];
    var textValues = [];
    var images = [];

    $('.header').each(function () {
        headers.push($(this).val());
    });
    $('.textValue').each(function () {
        textValues.push($(this).val());
    });
    $('.image').each(function () {
        images.push($(this).val());
    });

    var thumbnailSlidePair = {
        Thumbnail: thumbnail,
        TitleBox: {
            Title: title,
            Caption: caption
        }
    };

    var leftSlides = [];
    var rightSlides = [];

    for (var i = 0; i < images.length; i++) {
        var slide = {
            Image: images[i],
            TextBox: {
                Header: headers[i],
                Text: textValues[i]
            }
        };

        if (i % 2 === 0) {
            leftSlides.push(slide);
        } else {
            rightSlides.push(slide);
        }
    }

    var slidePairs = [];

    for (var j = 0; j < leftSlides.length; j++) {
        slidePairs.push({
            LeftSlide: leftSlides[j],
            RightSlide: rightSlides[j]
        });
    }

    var inputOutputModel = {
        ContentCarousel: {
            FilePath: filePath,
            ThumbnailSlidePair: thumbnailSlidePair,
            SlidePairs: slidePairs
        },
        Output: ''
    };
    generateHTML(inputOutputModel);
};

var submitRefreshPreview = function () {
    $('.preview').html($('#output').val());
    loadCarousel();
    slideCarousel();
    hideOwlNav();
};

var generateHTML = function (inputOutputModel) {
    console.log('generateHTML');
    $.ajax({
        type: "POST",
        url: "/Home/GenerateJSON",
        data: inputOutputModel,
        success: function (d) {
            $('#output').val(d.output);
            slideCarousel();
            submitRefreshPreview();
        },
        error: function (err) { }
    });
};

$(function () {
    $('#copy').click(function () {
        $('#output').focus();
        $('#output').select();
        document.execCommand('copy');
        $(".copied").text("Copied to clipboard").show().fadeOut(1200);
    });
});

$(document).ready(function () {
    copyFileName();
});

var copyFileName = function () {
    $('input[type="file"]').change(function (e) {
        var fileName = e.target.files[0].name;
        $(this).parent().find('input[type="text"]#LeftSlide_Image,\
                                input[type="text"]#RightSlide_Image,\
                                input[type="text"]#ContentCarousel_ThumbnailSlidePair_Thumbnail').val(fileName);
    });
};

$(document).ready(function () {
    $('#addSlidePair').click(function () {
        console.log('yeeehaw');
        var rawHTML = "";
        rawHTML += "<div class=\"row\">\n";
        rawHTML += "<div class=\"col-md-6 col-12\">\n<div class=\"form-group\">\n<label for=\"LeftSlide_Image\">Image</label>\n<div class=\"LeftSlide.Image\">\n<input type=\"file\" class=\"form-control-file\">\n<div class=\"input-group mb-2\">\n<div class=\"input-group-prepend\">\n<div class=\"input-group-text\">/</div></div>\n<input class=\"form-control image\" disabled=\"True\" id=\"LeftSlide_Image\" name=\"LeftSlide.Image\" type=\"text\" value=\"\"></div>\n</div>\n<label for=\"LeftSlide_TextBox_Header\">Header</label>\n<input class=\"form-control header\" id=\"LeftSlide_TextBox_Header\" name=\"LeftSlide.TextBox.Header\" type=\"text\" value=\"\">\n<label for=\"LeftSlide_TextBox_Text\">Text</label>\n<textarea class=\"form-control textValue\" id=\"LeftSlide_TextBox_Text\" name=\"LeftSlide.TextBox.Text\" rows=\"5\"></textarea>\n</div>\n</div>";
        rawHTML += "<div class=\"col-md-6 col-12\">\n<div class=\"form-group\">\n<label for=\"RightSlide_Image\">Image</label>\n<div class=\"RightSlide.Image\">\n<input type=\"file\" class=\"form-control-file\">\n<div class=\"input-group mb-2\">\n<div class=\"input-group-prepend\">\n<div class=\"input-group-text\">/</div>\n</div>\n<input class=\"form-control image\" disabled=\"True\" id=\"RightSlide_Image\" name=\"RightSlide.Image\" type=\"text\" value=\"\">\n</div>\n</div>\n<label for=\"RightSlide_TextBox_Header\">Header</label>\n<input class=\"form-control header\" id=\"RightSlide_TextBox_Header\" name=\"RightSlide.TextBox.Header\" type=\"text\" value=\"\">\n<label for=\"RightSlide_TextBox_Text\">Text</label>\n<textarea class=\"form-control textValue\" id=\"RightSlide_TextBox_Text\" name=\"RightSlide.TextBox.Text\" rows=\"5\"></textarea>\n</div>\n</div>";
        rawHTML += "</div>";
        $('.extraSlides').append(rawHTML);
        copyFileName();
    });
});
