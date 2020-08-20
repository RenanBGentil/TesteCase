// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

    $("#form1").submit(function () {
        var jqxhr = $.post('api/values', $('#form1').serialize())
            .success(function () {
                var loc = jqxhr.getResponseHeader('Location');
                var a = $('<a />', {href: loc, text: loc });
                $('#message').html(a);
            })
            .error(function () {
        $('#message').html("Error posting the update.");
            });
        return false;
    });
