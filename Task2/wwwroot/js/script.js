$(".item").hover(itemHover, itemHoverOut);

function itemHover() {
    $(this).animate(
        {
            backgroundColor: "#cacfd9"
        },
        200
    );
}

function itemHoverOut() {
    $(this).animate(
        {
            backgroundColor: "white"
        },
        200
    );
}