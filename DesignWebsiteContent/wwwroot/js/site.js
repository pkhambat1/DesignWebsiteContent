
$(document).ready(function () {
    $('#generate').unbind().on('click', submitGenerateHTML);
    $('#refresh').unbind().on('click', submitRefreshPreview);
    $('#addSlidePair').unbind().on('click', addSlidePair);
    $('#copy').unbind().on('click', copy);

    bind();
});

var bind = function () {
    copyFileName();
    $('.addImage').unbind().on('click', addImage);
    $('.addTextBox').unbind().on('click', addTextBox);
    $('.deleteSlide').unbind().on('click', deleteSlide);
    $('.deleteInput').unbind().on('click', deleteInput);
};

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

    for (var i = 0; i < leftSlides.length; i++) {
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

var copy = function () {
    $('#output').focus();
    $('#output').select();
    document.execCommand('copy');
    $(".copied").text("Copied to clipboard").show().fadeOut(1200);
};

var copyFileName = function () {
    $('input[type="file"]').change(function (e) {
        var fileName = e.target.files[0].name;
        $(this).parent().find('input[type="text"]#LeftSlide_Image,\
                                input[type="text"]#RightSlide_Image,\
                                input[type="text"]#ContentCarousel_ThumbnailSlidePair_Thumbnail').val(fileName);
    });
};

var addSlidePair = function () {
    var rawHTML = "";
    var slide = "<div class=\"col-md-6 col-12\"><div class=\"slide\"><div class=\"form-group\"><div class=\"row\"><div class=\"col-12\"><label for=\"Image\">Image</label></div><div class=\"col-md-5 col-12\"><input type=\"file\" class=\"form-control-file\"></div><div class=\"input-group mb-2 col-md-5 col-12\"><div class=\"input-group-prepend\"><div class=\"input-group-text\">/</div></div><input class=\"form-control image\" disabled=\"True\" id=\"Image\" name=\"Image\" type=\"text\" value=\"\"></div><div class=\"col-md-2 col-12 text-right\"><button class=\"btn btn-danger btn-sm deleteInput\"><i class=\"fas fa-trash\"></i></button></div></div><div class=\"row\"><div class=\"col-12\"><label for=\"TextBox\">TextBox</label></div><div class=\"textBox col-md-10 col-12\"><textarea class=\"form-control textBox\" id=\"TextBox\" name=\"TextBox\" rows=\"3\"></textarea></div><div class=\"col-md-2 col-12 text-right\"><button class=\"btn btn-danger btn-sm deleteInput\"><i class=\"fas fa-trash\"></i></button></div></div><div class=\"extraInputs\"></div></div><div class=\"row\"><div class=\"col-auto mr-auto\"><button class=\"btn btn-dark mr-1 addImage\">+ Image</button><button class=\"btn btn-dark addTextBox\">+ TextBox</button></div><div class=\"col-auto\"><button class=\"btn btn-danger btn-sm deleteSlide\">Delete Slide</button></div></div></div></div>";
    rawHTML += slide + slide;

    $('.extraSlides').find('.row').first().append(rawHTML);

    bind();
};

var addImage = function () {
    var rawHTML = "";
    rawHTML += "<div class=\"row\"><div class=\"col-12\"><label for=\"Image\">Image</label></div><div class=\"col-md-5 col-12\"><input type=\"file\" class=\"form-control-file\"></div><div class=\"input-group mb-2 col-md-5 col-12\"><div class=\"input-group-prepend\"><div class=\"input-group-text\">/</div></div><input class=\"form-control image\" disabled=\"True\" id=\"Image\" name=\"Image\" type=\"text\" value=\"\"></div><div class=\"col-md-2 col-12 text-right\"><button class=\"btn btn-danger btn-sm deleteInput\"><i class=\"fas fa-trash\"></i></button></div></div>";

    $(this).closest('.slide').find('.extraInputs').append(rawHTML);
    bind();
};

var addTextBox = function () {
    var rawHTML = "";
    rawHTML += "<div class=\"row\"><div class=\"col-12\"><label for=\"TextBox\">TextBox</label></div><div class=\"col-md-10 col-12\"><textarea class=\"form-control textBox\" id=\"TextBox\" name=\"TextBox\" rows=\"3\"></textarea></div><div class=\"col-md-2 col-12 text-right\"><button class=\"btn btn-danger btn-sm deleteInput\"><i class=\"fas fa-trash\"></i></button></div></div>";

    $(this).closest('.slide').find('.extraInputs').append(rawHTML);
    bind();
};

var deleteSlide = function () {
    $(this).closest('.slide').parent('.col-12').remove();
};

var deleteInput = function () {
    $(this).closest('.row').remove();
};
