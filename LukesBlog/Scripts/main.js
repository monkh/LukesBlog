$(document).ready(function() {

    $(window).scroll(function() {
        if ($(window).scrollTop() > 140) {
            $('#nav_bar').addClass('navbar-fixed');
        }
        if ($(window).scrollTop() < 141) {
            $('#nav_bar').removeClass('navbar-fixed');
        }
    });
});