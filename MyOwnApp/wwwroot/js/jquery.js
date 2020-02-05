$(function () {
    let flickerContent = [{ text: "Shop to earn points", link: "#" }, { text: "Stack&Save", link: "#" }, { text: "Reward cash", link: "#" }, { text: "FREE SHOPPING", link: "#" }];
    let flickerInd = 0;
    let timer = setInterval(function () {
        if (flickerInd === flickerContent.length - 1) {
            flickerInd = 0;
        }
        $("#flicker").hide(400);
        setTimeout(function () {
            $("#flicker").attr("href", flickerContent[flickerInd].link);
            $("#flicker").text(flickerContent[flickerInd].text);

        }, 450);

        $("#flicker").show(400);
        flickerInd++;
    }, 4000);
    $(".dropdown-content").css("left", function () {
        return 0 - this.parentElement.getBoundingClientRect().left;
    });
    $("#toggleNavBtn").on("click",SizingNavElementsPhone);
    function SizingNavElementsPhone() {
        $(".dropdown-content").css("left", function () {
            return 0 - $("#toggleNavBtn")[0].getBoundingClientRect().left;
        });
    }
    
})