$(function () 
{            
$('#username, #password').keypress(function (e) {          
if (e.which == 13) {   
$('#loginbutton').focus().click();                  
}             
});           
});
