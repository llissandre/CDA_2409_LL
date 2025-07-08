$(document).ready(function(){
    $('#txtSize button:not(.active)').click(changeTxtSize);
});

function changeTxtSize(evt){
    let clicked = $(evt.target);
    let newSize = clicked.data('size');
    $('#pageContent').css('font-size', `${newSize}rem`);
    $('#txtSize button.active').removeClass('active').click(changeTxtSize);
    clicked.addClass('active').off('click');
}