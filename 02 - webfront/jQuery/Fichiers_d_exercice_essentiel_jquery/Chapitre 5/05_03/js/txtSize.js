$(document).ready(function(){
    $('#txtSize button:not(.active)').on('click', changeTxtSize);
});

function changeTxtSize(){
    console.log('Bonjour de changeTxtSize()');
}
