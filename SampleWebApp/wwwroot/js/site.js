// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

function validateEmail(mail) {
    var mailFormat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    if (mail.match(mailFormat))
        return true;
    else
        return false;
}

function validatePhone(phone) {
    debugger;
    var phoneFormat = /^(\(\d{3}\))|(\d{3}-)\d{3}-\d{4}$/;
    if (phone.match(phoneFormat))
        return true;
    else
        return false;
}

function isNumberWithDecimalKey(evt) {
    var charCode = (evt.which) ? evt.which : evt.keyCode;
    if (charCode != 45 && charCode > 31
        && (charCode < 48 || charCode > 57))
        return false;

    return true;
}