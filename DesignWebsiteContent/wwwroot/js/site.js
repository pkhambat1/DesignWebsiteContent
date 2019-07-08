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

    var slides = [];

    $('.slide').each(function () {
        var inputs = [];
        $(this).find('.slideInput').each(function () {
            if ($(this).hasClass('image')) {
                inputs.push(
                    {
                        "Text": $(this).find('input[type=text]').val(),
                        "Type": "Image"
                    });
            } else if ($(this).hasClass('textBox')) {
                inputs.push(
                    {
                        "Text": $(this).find('textarea').val(),
                        "Type": "TextBox"
                    });
            }
        });

        slides.push({
            Inputs: inputs
        });
    });

    var inputOutputModel = {
        ContentCarousel: {
            FilePath: $('.filePath').val(),
            Thumbnail: $('input[type=text].thumbnail').val(),
            Title: $('.titleValue').val(),
            Caption: $('.caption').val(),
            Slides: slides
        },
        Output: ""
    };

    console.log("inputOutputModel", inputOutputModel);

    generateHTML(inputOutputModel);
};

var submitRefreshPreview = function () {
    $('.preview').html($('#output').val());
    loadCarousel();
    slideCarousel();
    //hideOwlNav();
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
        $(this).closest('.slideInput').find('input[type="text"].image, input[type="text"].thumbnail').val(fileName);
    });
};

var addSlidePair = function () {
    var rawHTML = "";
    var slide = "<div class=\"col-md-6 col-12\"><div class=\"slide slideBox\"><div class=\"form-group\"><div class=\"row slideInput image\"><div class=\"col-12\"><label for=\"Image\">Image</label></div><div class=\"col-md-5 col-12\"><input type=\"file\" class=\"form-control-file\"></div><div class=\"input-group mb-2 col-md-5 col-12\"><div class=\"input-group-prepend\"><div class=\"input-group-text\">/</div></div><input class=\"form-control image\" disabled=\"True\" id=\"Image\" name=\"Image\" type=\"text\" value=\"\"></div><div class=\"col-md-2 col-12 text-right\"><button class=\"btn btn-danger btn-sm deleteInput\"><i class=\"fas fa-trash\"></i></button></div></div><div class=\"row slideInput textBox\"><div class=\"col-12\"><label for=\"TextBox\">TextBox</label></div><div class=\"textBox col-md-10 col-12\"><textarea class=\"form-control textBox\" id=\"TextBox\" name=\"TextBox\" rows=\"3\"></textarea></div><div class=\"col-md-2 col-12 text-right\"><button class=\"btn btn-danger btn-sm deleteInput\"><i class=\"fas fa-trash\"></i></button></div></div></div><div class=\"row\"><div class=\"col-auto mr-auto\"><button class=\"btn btn-dark mr-1 addImage\">+ Image</button><button class=\"btn btn-dark addTextBox\">+ TextBox</button></div><div class=\"col-auto\"><button class=\"btn btn-danger btn-sm deleteSlide\">Delete Slide</button></div></div></div></div>";
    rawHTML += slide + slide;

    $('.slides').find('.row').first().append(rawHTML);

    bind();
};

var addImage = function () {
    var rawHTML = "";
    rawHTML += "<div class=\"row slideInput image\"><div class=\"col-12\"><label for=\"Image\">Image</label></div><div class=\"col-md-5 col-12\"><input type=\"file\" class=\"form-control-file\"></div><div class=\"input-group mb-2 col-md-5 col-12\"><div class=\"input-group-prepend\"><div class=\"input-group-text\">/</div></div><input class=\"form-control image\" disabled=\"True\" id=\"Image\" name=\"Image\" type=\"text\" value=\"\"></div><div class=\"col-md-2 col-12 text-right\"><button class=\"btn btn-danger btn-sm deleteInput\"><i class=\"fas fa-trash\"></i></button></div></div>";

    $(this).closest('.slide').find('.form-group').first().append(rawHTML);
    bind();
};

var addTextBox = function () {
    var rawHTML = "";
    rawHTML += "<div class=\"row slideInput textBox\"><div class=\"col-12\"><label for=\"TextBox\">TextBox</label></div><div class=\"col-md-10 col-12\"><textarea class=\"form-control textBox\" id=\"TextBox\" name=\"TextBox\" rows=\"3\"></textarea></div><div class=\"col-md-2 col-12 text-right\"><button class=\"btn btn-danger btn-sm deleteInput\"><i class=\"fas fa-trash\"></i></button></div></div>";

    $(this).closest('.slide').find('.form-group').first().append(rawHTML);
    bind();
};

var deleteSlide = function () {
    $(this).closest('.slide').parent('.col-12').remove();
};

var deleteInput = function () {
    $(this).closest('.row').remove();
};