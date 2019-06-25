$(document).ready(function () {
    $('#generate').unbind().on('click', submitGenerateHTML);
    $('#refresh').unbind().on('click', submitRefreshPreview);
});

var submitGenerateHTML = function () {
    var filePath = $('#ContentCarousel_FilePath').val();
    var title = $('#ContentCarousel_ThumbnailSlidePair_TitleBox_Title').val();
    var caption = $('#ContentCarousel_ThumbnailSlidePair_TitleBox_Caption').val();
    var thumbnail = $('#ContentCarousel_ThumbnailSlidePair_Thumbnail').val();

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
    $('input[type="file"]').change(function (e) {
        var fileName = e.target.files[0].name;
        $(this).parent().find('input[type="text"]#LeftSlide_Image,\
                                input[type="text"]#RightSlide_Image,\
                                input[type="text"]#ContentCarousel_ThumbnailSlidePair_Thumbnail').val(fileName);
    });
});
