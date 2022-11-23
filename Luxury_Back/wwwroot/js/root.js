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

let open_menu_drop = document.querySelectorAll(".open_toggle_menu");
let _menu = document.querySelectorAll(".toggle_menu");


[].forEach.call(open_menu_drop, function (el) {
    el.addEventListener("click", function (event) {
        let _menu_ = document.querySelector(`${el.dataset.menu}`);
        _menu_.classList.toggle("show");
        event.stopPropagation();
    });
});

[].forEach.call(_menu, function (el) {
    el.addEventListener("click", function (event) {
        console.log("_menu");
        event.stopPropagation();
    })
});

document.addEventListener('click', (event) => {
    [].forEach.call(_menu, function (el) {
        el.classList.remove("show");
    });
});

let personsSpan = document.querySelector(".persons span");
let roomsSpan = document.querySelector(".rooms span");

document.getElementById("persons").onchange = function () {
    personsSpan.innerText = this.value;
}
document.getElementById("rooms").onchange = function () {
    roomsSpan.innerText = this.value;
}

function currentDate(str) {
    var today = new Date();
    var dd = String(today.getDate()).padStart(2, '0');
    var mm = String(today.getMonth() + 1).padStart(2, '0'); //January is 0!
    var yyyy = today.getFullYear();

    today = mm + str + dd + str + yyyy;
}

mobiscroll.setOptions({
    locale: mobiscroll.localeAr,  // Specify language like: locale: mobiscroll.localePl or omit setting to use default
    theme: 'ios',                 // Specify theme like: theme: 'ios' or omit setting to use default
    themeVariant: 'light'         // More info about themeVariant: https://docs.mobiscroll.com/5-19-2/javascript/calendar#opt-themeVariant
});

mobiscroll.datepicker('#check_in_out_input', {
    display: 'inline',            // Specify display mode like: display: 'bottom' or omit setting to use default
    rangeSelectMode: 'wizard',
    select: 'range',              // More info about select: https://docs.mobiscroll.com/5-19-2/javascript/calendar#opt-select
    showRangeLabels: true,
    min: currentDate("-"),
    format: 'dd/mm/yyyy',
    rtl: true
});

let check_in_out_input = document.querySelector("#check_in_out_input");
let _searchForm = document.getElementById("search_form");
let check_in_out_label = document.getElementById("check_in_out_label");

check_in_out_input.onchange = function () {
    console.log(this.value);
    check_in_out_label.innerText = this.value;
};


_searchForm.addEventListener("submit", function (e) {
    /*e.preventDefault();*/
    let formData = new FormData(this);
    console.log(formData);
});

let whereGoing = document.querySelectorAll(".whereGoing .dropdown-item");
let whereGoingA = document.querySelector(".whereGoing .dropdown-toggle");
let whereGoingInput = document.querySelector("#cityIdInput");

[].forEach.call(whereGoing, function (el) {
    el.onclick = function () {
        console.log(this.dataset.name)
        console.log(this.dataset.city)
        whereGoingA.innerText = this.dataset.name;
        whereGoingInput.value = this.dataset.city;
    }
});
//close section
let closesection = document.querySelector(".closesection")
document.getElementById("iclose").onclick() = function () {
    closesection.ariaHidden=true;
};