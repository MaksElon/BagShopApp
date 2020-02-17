let errors = [false, false, false, false, false, false, false];
submBtn.disabled = true;
submBtn.style.opacity = "0.7";

function email_validate(email) {
    let regMail = /^([_a-zA-Z0-9-]+)(\.[_a-zA-Z0-9-]+)*@([a-zA-Z0-9-]+\.)+([a-zA-Z]{2,3})$/;
    if (regMail.test(email) == false) {
        messageE.innerHTML = "<span class='text-danger'>Email address is not valid yet.</span>";
        document.getElementById("email").style.border = "1px solid red";

        errors[2] = false;
        submBtn.disabled = true;
        submBtn.style.opacity = "0.7";

    }
    else {
        messageE.innerHTML = "<span class='text-success'>Thanks, you have entered a valid email!</span>";
        document.getElementById("email").style.border = "1px solid #ced4da";
        errors[2] = true;
        submBtn.disabled = false;
        submBtn.style.opacity = "1";

    }
}
function pass_validate(password) {
    let regex = new RegExp("^(((?=.*[a-z])(?=.*[A-Z]))|((?=.*[a-z])(?=.*[0-9]))|((?=.*[A-Z])(?=.*[0-9])))(?=.{6,})");;

    if (regex.test(password) == false) {
        messageP.innerHTML = "<span class='text-danger'>Password is not valid.</span>";
        document.getElementById("password").style.border = "1px solid red";
        errors[3] = false;
        submBtn.disabled = true;
        submBtn.style.opacity = "0.7";

    } else {
        messageP.innerHTML = "<span class='text-success'>Thanks, you have entered a valid password!</span>";
        document.getElementById("password").style.border = "1px solid #ced4da";
        errors[3] = true;
        submBtn.disabled = false;
        submBtn.style.opacity = "1";

    }
}
function passC_validate(password) {
    if (password != document.getElementById("password").value) {
        messagePC.innerHTML = "<span class='text-danger'>Password is not matched.</span>";
        document.getElementById("passwordC").style.border = "1px solid red";
        errors[4] = false;
        submBtn.disabled = true;
        submBtn.style.opacity = "0.7";

    } else {
        messagePC.innerHTML = "<span class='text-success'>Thanks, you confirm a password!</span>";
        document.getElementById("passwordC").style.border = "1px solid #ced4da";
        errors[4] = true;
        submBtn.disabled = false;
        submBtn.style.opacity = "1";

    }
}
function phone_validate(phone) {
    let regex = /^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$/im;

    if (regex.test(phone) == false) {
        messagePh.innerHTML = "<span class='text-danger'>Phone is not valid.</span>";
        document.getElementById("phone").style.border = "1px solid red";
        errors[6] = false;
        submBtn.disabled = true;
        submBtn.style.opacity = "0.7";

    } else {
        messagePh.innerHTML = "<span class='text-success'>Thanks, you have entered a valid phone!</span>";
        document.getElementById("phone").style.border = "1px solid #ced4da";
        errors[6]= true;
        submBtn.style.opacity = "1";
        submBtn.disabled = false;

    }
}
//function address_validate(address) {
//    if (address === "") {
//        messageA.innerHTML = "<span class='text-danger'>Input your address</span>";
//        document.getElementById("address").style.border = "1px solid red";
//        errors[5] = false;
//        submBtn.style.opacity = "0.7";
//        submBtn.disabled = true;
//    } else {
//        messageA.innerHTML = "<span class='text-success'>Thanks, you have entered a valid address!</span>";
//        document.getElementById("address").style.border = "1px solid #ced4da";
//        errors[5] = true;
//        submBtn.style.opacity = "1";
//        submBtn.disabled = false;

//    }
//}

function FN_validate(firstName) {
    if (firstName === "") {
        messageFN.innerHTML = "<span class='text-danger'>Input your name</span>";
        document.getElementById("firstName").style.border = "1px solid red";
        errors[0] = false;
        submBtn.style.opacity = "0.7";
        submBtn.disabled = true;
    } else {
        messageFN.innerHTML = "<span class='text-success'>Thanks, you have entered a valid first name!</span>";
        document.getElementById("firstName").style.border = "1px solid #ced4da";
        errors[0] = true;
        submBtn.style.opacity = "1";
        submBtn.disabled = false;

    }
}
function LN_validate(lastName) {
    if (lastName === "") {
        messageLN.innerHTML = "<span class='text-danger'>Input your second name</span>";
        document.getElementById("lastName").style.border = "1px solid red";
        errors[1] = false;
        submBtn.disabled = true;
        submBtn.style.opacity = "0.7";

    } else {
        messageLN.innerHTML = "<span class='text-success'>Thanks, you have entered a valid last name!</span>";
        document.getElementById("lastName").style.border = "1px solid #ced4da";
        errors[1] = true;
        submBtn.style.opacity = "1";
        submBtn.disabled = false;

    }
}
//function check_validate() {
//    if (gridCheck.checked === false) {
//        messageBtn.innerHTML = "<span class='text-danger'>Accept the terms</span>";
//        errors[7] = false;
//        submBtn.disabled = true;
//        submBtn.style.opacity = "0.7";

//    } else {
//        messageBtn.innerHTML = "";
//        errors[7] = true;
//        submBtn.style.opacity = "1";
//        submBtn.disabled = false;

//    }
//}
function form_validate(e) {
    if (e) e.preventDefault();

    for (let i = 0; i < errors.length; i++) {
        if (errors[i] == false) {
            return;
        }
    }
    let arr = new Array();
    for (let item of document.forms["form"].elements) {
        if (item.name !== "")
            arr.push({ [item.name]: item.value });
    }
    arr.push({ gender: check });
    let json = JSON.stringify(arr);
    console.log(json);
}
//function EyeClick(e) {
//    if (e) e.preventDefault();
//    if (password.type === "password") {
//        password.type = "text";
//    } else {
//        password.type = "password";
//    }
//}