$(document).ready(function () {
    $('#generate').unbind().on('click', submitGenerate);
});

var submitGenerate = function () {

    var filePath = $('#ContentCarousel_FilePath').val();
    var title = $('#ContentCarousel_ThumbnailSlidePair_TitleBox_Title').val();
    var caption = $('#ContentCarousel_ThumbnailSlidePair_TitleBox_Caption').val();
    var thumbnail = $('#ContentCarousel_ThumbnailSlidePair_Thumbnail').val();

    var headers = [];
    var textValues = [];
    var images = [];

    $('.Header').each(function () {
        headers.push($(this).find('input[type="text"]').val());
    });
    $('.Text').each(function () {
        textValues.push($(this).find('textarea').val());
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


    console.log(filePath, title, caption, thumbnail, headers, textValues, images);

    var inputOutputmodel = {
        ContentCarousel: {
            FilePath: filePath,
            ThumbnailSlidePair: thumbnailSlidePair,
            Slides: {
                SlidePair: [{
                    LeftSlide: '',
                    RightSlide: ''
                },
                {
                    LeftSlide: '',
                    RightSlide: ''
                },
                {
                    LeftSlide: '',
                    RightSlide: ''
                }]
            }
        },
        Output: ''
    };

    // Call ajax fn
    convert(inputOutputmodel);
};

var convert = function (inputOutputModel) {
    $.ajax({
        type: "POST",
        url: "/Home/GenerateJSON",
        data: inputOutputModel,
        success: function (d) {
            $('#output').val(d.output);
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
                                input[type = "text"]#RightSlide_Image,\
                                input[type = "text"]#ContentCarousel_ThumbnailSlidePair_Thumbnail').val(fileName);
    });
});
