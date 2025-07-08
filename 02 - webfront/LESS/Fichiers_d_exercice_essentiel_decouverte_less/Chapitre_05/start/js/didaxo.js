// JavaScript Document
$(document).ready(function(){
	//attach click event on hamburger button
	$('#hamburger').click(function(){
		//Toggle menu on and off
		$('#mainNav ul').stop(true, true).slideToggle(300);
		$('#mainNav #hamburger span').toggleClass('fa-bars fa-times');
	});
});