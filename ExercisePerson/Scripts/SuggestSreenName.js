function permutate(form) {
    var firstlastname = form.firstname.value.toLowerCase().trim() + ' ' + form.lastname.value.toLowerCase().trim();
    var namesplit = firstlastname.split(" ");
    var firstname = namesplit[0];
    var lastname = namesplit[1];
    var domain = form..value.toLowerCase().trim();
    var sep = form.sep.value + ' ';
    //var sep = ", ";

    if (firstname == null || firstname == "") {
        document.getElementById("Email").innerHTML = "Please provide a first name e.g. Luke";
        return false;
    }
    else if (lastname == null || lastname == "") {
        document.getElementById("Email").innerHTML = "Please provide a last name e.g. Skywalker";
        return false;
    }
    else if (domain == null || domain == "") {
        document.getElementById("Email").innerHTML = "Please provide a domain e.g. yahoo.com";
        return false;
    }
    else { }

    //If no optional separator, defult to comma
    if (sep == null || sep == " ") {
        sep = ", ";
    }

    //bob@domain.com
    var p1 = firstname + "@" + domain + sep;

    //bobsmith@domain.com
    var p2 = firstname + lastname + "@" + domain + sep;

    //bob.smith@domain.com
    var p3 = firstname + "." + lastname + "@" + domain + sep;

    //smith@domain.com
    var p4 = lastname + "@" + domain + sep;

    //bsmith@domain.com
    var p5 = firstname.charAt(0) + lastname + "@" + domain + sep;

    //b.smith@domain.com
    var p6 = firstname.charAt(0) + "." + lastname + "@" + domain + sep;

    //bobs@domain.com
    var p7 = firstname + lastname.charAt(0) + "@" + domain + sep;

    //bob.s@domain.com
    var p8 = firstname + "." + lastname.charAt(0) + "@" + domain + sep;

    //bs@domain.com
    var p9 = firstname.charAt(0) + lastname.charAt(0) + "@" + domain;

    var addresses = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9;

    document.getElementById("Email").innerHTML = addresses;
}

function reset(Email) {
    document.getElementById("Email").innerHTML = "";
    document.getElementById("FirstName").value = "";
    document.getElementById("LastName").value = "";
    document.getElementById("DateOfBirth").value = "";
}