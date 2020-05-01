
function validate() {
    var name = document.getElementById('name');
    var email = document.getElementById('email');
    var phone = document.getElementById('phone');

    var valid = new form(name.value, email.value, phone.value);

    if (!valid.validernom()) {
        name.style.borderColor = "red";

    }
    else {
        name.style.borderColor = "black";
    }

    if (!valid.validertelephone()) {
        phone.style.borderColor = "red";

    }
    else {
        phone.style.borderColor = "black";
    }

    if (!valid.valideremail()) {
        email.style.borderColor = "red";

    }
    else {
        email.style.borderColor = "black";
    }

}

function form(name, email, phone) {
    this.name = name;
    this.email = email;
    this.phone = phone;

}

form.prototype.getNom = function () {
    return this.name;
}

form.prototype.setNom = function (name) {
    this.name = name;
}

form.prototype.getMail = function () {
    return this.email;
}

form.prototype.setMail = function (email) {
    this.email = email;

}


form.prototype.setTel = function (phone) {

    this.phone = phone;

}

form.prototype.getTel = function () {
    return this.phone;
}

form.prototype.validernom = function () {
    var status;

    for (var i = 0; i < this.name.length; i++) {
        if (((this.name.charCodeAt(i) >= "A".charCodeAt(0)) && (this.name.charCodeAt(i) <= "Z".charCodeAt(0))) ||
            ((this.name.charCodeAt(i) >= "a".charCodeAt(0)) && (this.name.charCodeAt(i) <= "z".charCodeAt(0)))) {
            status = true;

        }
        else {
            alert("Nom invalide");
            status = false;
        }
    }

    return status;


}


form.prototype.validertelephone = function () {

    var telRegEx = /^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$/im;
    if (telRegEx.test(this.phone)) {
        return true;  
    }
    else {
        alert("Numero de telephone invalide");

        return false;
    }


}

form.prototype.valideremail = function () {

    var emailRegEx = /[a-zA-Z0-9]+(\.|_|-)?[a-zA-Z0-9]+@gmail\.com/;
    if (emailRegEx.test(this.email)) {
        return true;  
    }
    else {
        alert("Email invalide");
        return false;

    }
}
