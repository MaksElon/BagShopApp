let records_per_page = 3;
let current_page = 6;
let unString = '<a class="page-link" onclick="choosePage(this.innerHTML)" href="#">...</a>';
let isDots = 0, isSmall = false;
let pasteStr1 =
    '<div class="col-sm-' + Math.floor(12 / records_per_page) + '" >' +
    '<div class="card">' +
    '<img src="';
let pasteStr2='" />' +
    '<div class="card-body">' +
    '<h5 class="card-title">';
let pasteStr3 = '</h5>' +
    '<p class="card-text">Lorem ipsum</p>' +
    '</div>' +
    '</div>' +
    '</div >';    

var objJson = new Array();
for (let i = 1; i <= 90; i++) {
    objJson.push({ value: "value " + i, img: "images/" + Math.ceil(i / 3) + ".jfif" });
}
function prevPage() {
    current_page--;
    changePage(current_page);
}

function nextPage() {
    current_page++;
    changePage(current_page);
}
function choosePage(page) {
    current_page = page;
    changePage(current_page);
}
function changePage(page) {

    if (page < 1 || page > numPages()) return;
    if (page <= 6) page = 6;
    if (page >= numPages() - 5) page = numPages() - 5;
    if (!isSmall) {
        if (page > 6 && pagUl.getElementsByTagName("li")[4].innerHTML != unString) {
            let li = document.createElement("li");
            li.innerHTML = unString;
            li.classList.add("page-item", "disabled");
            pagUl.insertBefore(li, pagUl.children[4]);
            isDots = 1;
        }
        if (current_page <= 6 && pagUl.getElementsByTagName("li")[4].innerHTML == unString) {
            pagUl.removeChild(pagUl.children[4]);
            isDots = 0;
        }
        if (page < numPages() - 5 && pagUl.getElementsByTagName("li")[9 + isDots].innerHTML != unString) {
            let li = document.createElement("li");
            li.innerHTML = unString;
            li.classList.add("page-item", "disabled");
            pagUl.insertBefore(li, pagUl.children[10]);
        }
        if (current_page >= numPages() - 5 && pagUl.getElementsByTagName("li")[10].innerHTML == unString) {
            pagUl.removeChild(pagUl.children[10]);
        }
        pagUl.getElementsByTagName("li")[4 + isDots].innerHTML = '<a class="page-link" onclick="choosePage(this.innerHTML)" href="#">' + (+page - 2) + '</a>';
        pagUl.getElementsByTagName("li")[5 + isDots].innerHTML = '<a class="page-link" onclick="choosePage(this.innerHTML)" href="#">' + (+page - 1) + '</a>';
        pagUl.getElementsByTagName("li")[6 + isDots].innerHTML = '<a class="page-link" onclick="choosePage(this.innerHTML)" href="#">' + (+page) + '</a>';
        pagUl.getElementsByTagName("li")[7 + isDots].innerHTML = '<a class="page-link" onclick="choosePage(this.innerHTML)" href="#">' + (+page + 1) + '</a>';
        pagUl.getElementsByTagName("li")[8 + isDots].innerHTML = '<a class="page-link" onclick="choosePage(this.innerHTML)" href="#">' + (+page + 2) + '</a>';
    }
    content.innerHTML = "";

    for (let i = (current_page - 1) * records_per_page; i < (current_page * records_per_page); i++) {
        content.innerHTML += pasteStr1 + objJson[i].img + pasteStr2 + objJson[i].value + pasteStr3;
    }

    if (current_page <= 1) {
        pagUl.firstElementChild.classList.add("disabled");
    } else {
        pagUl.firstElementChild.classList.remove("disabled");
    }

    if (current_page >= numPages()) {
        pagUl.lastElementChild.classList.add("disabled");
    } else {
        pagUl.lastElementChild.classList.remove("disabled");
    }
    for (let item of pagUl.children) {
        item.classList.remove("active");
    }
    for (let item of pagUl.children) {
        if (item.innerHTML.includes(current_page)) {
            item.classList.add("active");
            console.log(item.value);
            break;
        }
    }
}
window.onload = function () {
    if (numPages() < 8) {
        for (let i = 12; i > numPages(); i--) {
            pagUl.removeChild(pagUl.children[i]);
        }
        isSmall = true;
    } else {
        let count = numPages();
        for (let i = 12; i > 9; i--) {
            pagUl.children[i].firstElementChild.textContent = count;
            count--;
        }
    }
};
function numPages() {
    return Math.ceil(objJson.length / records_per_page);
}
