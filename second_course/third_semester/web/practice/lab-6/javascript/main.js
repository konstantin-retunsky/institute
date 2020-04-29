



if($(".terminal__text").text().length == 0) {
    $(".kostil").click();
}

$(".terminal__text").keypress(function (event) {
    if (event.keyCode === 13) {
        $(".kostil").click();
    }
});

$(function () {
    $('.terminal').draggable({
        start: function () {
            $('.terminal').css("opacity", "0.5");
        },
        stop: function () {
            $('.terminal').css("opacity", "0.8");
        }
    });
});

let searchInput = $('.terminal__text');
let strLength = searchInput.val().length * 2;
searchInput.focus();
searchInput[0].setSelectionRange(strLength, strLength);
