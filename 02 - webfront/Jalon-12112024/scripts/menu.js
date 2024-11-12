



$(".menu").click(function(){

    console.log("menu");

    $(".menu").addClass("OK");

    console.log(".menu");

    var section = $(this).closest(".menu").data( "section" );

    var newsection = "#exo"+section;


    $(".exo").addClass("hidden");



    $("#menu"+section).addClass("selected");

    $(newsection).removeClass("hidden");



});
