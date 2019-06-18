$(document).ready(function () {
    $('#convert').unbind().on('click', submitConvert);
});

var submitConvert = function () {
    var inputOutputmodel = {
        //Input: $('#input').val(),
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
        $(this).parent().find('input[type="text"].image').val(fileName);
    });
});
