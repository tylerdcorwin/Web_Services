/// <reference path="jquery-1.7.1.js" />
$(document).ready(
	function () {
	    $('#btnChangeToGreen').addClass('ChangeToGreen');



	    $('#btnChangeToGreen').click(function (e) {
	        $('#leftlabel').addClass('ChangeToGreen');
	        e.preventDefault();
	    });
	    $('#btnChangeToRed').click(function (e) {
	        $('.MainLabel').css('background-color', 'red');
	        $('.MainLabel').removeAttr('MainLabel');
	        $('.MainLabel').addClass('ChangeToRed');
	        e.preventDefault();

	    });

	    $('#btnMoveText').click(function (e) {
	        $('#txtBox2').val($('#txtBox1').val());
	    });

	    $('#btnAddToList').click(function (e) {
	        $('#ListOfStuff ul').append('<LI>' + $('#txtBox1').val() + '</LI>');
           
	    });

	});

	