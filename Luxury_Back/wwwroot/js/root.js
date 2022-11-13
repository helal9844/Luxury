// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
console.log("root");

$(".lang-item").on("click", function () {
    let lang = $(this).data("lang");
    console.log(lang);
    $(".select_lang").val(lang);
    console.log($(".select_lang"));
    $(".lang-form").submit();
});