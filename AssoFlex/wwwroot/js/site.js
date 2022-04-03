// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
jQuery(
    function($) {
        $(window).scroll(function() {
            if ($(document).scrollTop() >= 400) {
                // $('.navbar').removeClass('shadow');
                $('.navbar').addClass('bg-white'); 
            } else { 
                $('.navbar').removeClass('bg-white');
                $('.navbar').addClass('fixed-top shadow');
            }
    });

    function adjustNav() {
        var winWidth = $(window).width(),
            dropdown = $('.dropdown'),
            dropdownMenu = $('.dropdown-menu');

        if (winWidth >= 768) {
            dropdown.on('mouseenter', function() {
                $(this).addClass('show')
                    .children(dropdownMenu).addClass('show');
            });

            dropdown.on('mouseleave', function() {
                $(this).removeClass('show')
                    .children(dropdownMenu).removeClass('show');
            });
        } else {
            dropdown.off('mouseenter mouseleave');
        }
    }

    $(window).on('resize', adjustNav);

    adjustNav();
});