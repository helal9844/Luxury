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

let top_search_content_drop = document.querySelector("#toggle_menu");
let _menu = document.querySelector(".toggle_menu");

top_search_content_drop.addEventListener("click", function (event) {
    console.log("top_search_content");
    _menu.classList.toggle("show");
    event.stopPropagation();
});
_menu.addEventListener("click", function (event) {
    console.log("_menu");
    event.stopPropagation();
})
document.addEventListener('click', (event) => {
    _menu.classList.remove('show');
    console.log("body");
});