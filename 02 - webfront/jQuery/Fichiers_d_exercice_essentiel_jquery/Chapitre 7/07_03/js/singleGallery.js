$(document).ready(function(){
    let searchParams = new URLSearchParams(window.location.search);
    if(searchParams.has('id')){
       
    } else {
        window.location.pathname = "galleries.html"
    }
});