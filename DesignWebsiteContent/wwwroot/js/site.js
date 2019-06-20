$(document).ready(function () {
    $('#generate').unbind().on('click', submitGenerate);
});

var submitGenerate = function () {

    var title = $('.Title');
    var caption = $('.Caption');

    var header = $('.Header');
    var text = $('.Text');


    console.log(header);

    for (var i = 0; i < header.length; i++) {
        console.log(header[i]);
    }
    for (var j = 0; j < caption.length; j++) {
        console.log(caption[j]);
    }
    for (var k = 0; k < title.length; k++) {
        console.log(title[k]);
    }
    for (var l = 0; l < text.length; l++) {
        console.log(text[l]);
    }

    var inputOutputmodel = {
        ContentCarousel: {
            FilePath: '#filePath',
            ThumbnailSlidePair: '',
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
