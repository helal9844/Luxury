// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(".lang-item").on("click", function () {
    let lang = $(this).data("lang");
    console.log(lang);
    $(".select_lang").val(lang);
    console.log($(".select_lang"));
    $(".lang-form").submit();
});

let fixedNav = document.getElementsByClassName("header-navbar fixed-top")[0];

window.onscroll = function () {

    if (this.scrollY) {
        fixedNav.classList.add("onScroll");
    } else {
        fixedNav.classList.remove("onScroll");
    }
}