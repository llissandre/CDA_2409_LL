$(document).ready(function(){
    let searchParams = new URLSearchParams(window.location.search);
    if(searchParams.has('id')){
        $.getJSON('/js/galleries.json', function(data){
            console.log(data);
        });
    } else {
        window.location.pathname = "galleries.html";
    }
});